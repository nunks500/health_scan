import 'dart:convert';
import 'dart:io';

import 'package:flutter/material.dart';
import 'package:barcode_scan/barcode_scan.dart';
import 'package:flutter/services.dart';

void main() => runApp(MyApp());

class MyApp extends StatelessWidget {
  // This widget is the root of your application.

  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      title: 'Flutter Demo',
      theme: ThemeData(
        // This is the theme of your application.
        //
        // Try running your application with "flutter run". You'll see the
        // application has a blue toolbar. Then, without quitting the app, try
        // changing the primarySwatch below to Colors.green and then invoke
        // "hot reload" (press "r" in the console where you ran "flutter run",
        // or simply save your changes to "hot reload" in a Flutter IDE).
        // Notice that the counter didn't reset back to zero; the application
        // is not restarted.
        primarySwatch: Colors.blue,
      ),
      home: MyHomePage(title: 'Flutter Demo Home Page'),
    );
  }
}

class MyHomePage extends StatefulWidget {
  MyHomePage({Key key, this.title}) : super(key: key);

  // This widget is the home page of your application. It is stateful, meaning
  // that it has a State object (defined below) that contains fields that affect
  // how it looks.

  // This class is the configuration for the state. It holds the values (in this
  // case the title) provided by the parent (in this case the App widget) and
  // used by the build method of the State. Fields in a Widget subclass are
  // always marked "final".

  final String title;

  @override
  _MyHomePageState createState() => _MyHomePageState();
}

class _MyHomePageState extends State<MyHomePage> {
  String result = "Hey there !";

  Future _scanQR() async{
    try{
      String qrResult = await BarcodeScanner.scan();
      var request = await HttpClient().getUrl(Uri.parse("https://jsonplaceholder.typicode.com/todos/1"));

      var response = await request.close();
      var x;

      await for(var contents in response.transform(Utf8Decoder()))
        {
          x =contents;
        }
      setState(() {
        result = x;
      });
      /*return new MaterialApp();
      setState(() {
        result = qrResult;
      });*/
    }on PlatformException catch(ex){
      if(ex.code == BarcodeScanner.CameraAccessDenied) {
        setState(() {
          result = "Camera permission denied";
        });
      }
      else{
        setState(() {
          result = "Unknown error $ex";
        });
      }
    } on FormatException{
      setState(() {
        result = "You pressed the back button";
      });
    } catch(ex) {
      setState(() {
        result = "Unknown error $ex";
      });
    }
  }
  @override
  Widget build(BuildContext context) {
    // This method is rerun every time setState is called, for instance as done
    // by the _incrementCounter method above.
    //
    // The Flutter framework has been optimized to make rerunning build methods
    // fast, so that you can just rebuild anything that needs updating rather
    // than having to individually change instances of widgets.
    return Scaffold(
      appBar: AppBar(
          title: Text("QR Scanner")
      ),
      body: Center(
          child: Text(result)
      ),
      floatingActionButton: FloatingActionButton.extended(
        icon: Icon(Icons.camera_alt),
        label: Text("Scan"),
        onPressed: _scanQR,
      ),
      floatingActionButtonLocation: FloatingActionButtonLocation.centerFloat,
    );
  }
}
