import 'package:flutter/material.dart';
import 'package:location/location.dart';

import '../utils/get_location.dart';
import '../utils/listen_location.dart';
import '../utils/permission_status.dart';
import '../utils/service_enabled.dart';

class Home extends StatefulWidget {
  Home({Key key, this.title}) : super(key: key);
  final String title;

  @override
  _MyHomePageState createState() => _MyHomePageState();
}

class _MyHomePageState extends State<Home> {
  final Location location = new Location();
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text(widget.title),
      ),
      body: Container(
        padding: EdgeInsets.all(32),
        child: Column(
          children: <Widget>[
            PermissionStatusWidget(),
            Divider(
              height: 32,
            ),
            ServiceEnabledWidget(),
            Divider(
              height: 32,
            ),
            GetLocationWidget(),
            Divider(
              height: 32,
            ),
            ListenLocationWidget()
          ],
        ),
      ),
    );
  }
}
