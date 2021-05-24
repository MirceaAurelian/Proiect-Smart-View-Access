import 'dart:io';

import 'package:cached_network_image/cached_network_image.dart';
import 'package:flutter/material.dart';
import 'package:intl/intl.dart';
import 'package:qr_flutter/qr_flutter.dart';
import 'package:smartphone/view_models/profile_viewModel.dart';
import 'package:stacked/stacked.dart';

class ProfileScreen extends StatefulWidget {
  @override
  ProfileScreenState createState() => ProfileScreenState();
}

class ProfileScreenState extends State<ProfileScreen> {
  String formattedDate;
  bool isPressed = false;
  File image;
  Widget build(BuildContext context) {
    return ViewModelBuilder<ProfileView>.reactive(
      viewModelBuilder: () => ProfileView(),
      builder: (context, model, child) => WillPopScope(
        onWillPop: () async => false,
        child: Scaffold(
          appBar: AppBar(
            automaticallyImplyLeading: false,
            leading: IconButton(
              icon: Icon(Icons.arrow_back),
              onPressed: () {
                Navigator.of(context).pop();
              },
            ),
            title: Text("PROFILE"),
          ),
          body: SingleChildScrollView(
            child: Column(
              mainAxisAlignment: MainAxisAlignment.start,
              children: [
                SizedBox(
                  height: 60,
                ),
                Row(
                  children: [
                    SizedBox(
                      width: 20,
                    ),
                    Container(
                      color: Colors.grey[300],
                      child: model.avatar == null
                          ? IconButton(
                              onPressed: () async {
                                showAlertDialogOwn(() async {
                                  image = await model.takeImageCamera();
                                  await model.uploadAvatar();
                                }, () async {
                                  image = await model.takeImageGallery();
                                  await model.uploadAvatar();
                                }, context);
                              },
                              icon: Icon(Icons.person),
                              iconSize: 100,
                              color: Colors.grey[500],
                            )
                          : InkWell(
                              onTap: () async {
                                showAlertDialogOwn(() async {
                                  image = await model.takeImageCamera();
                                  await model.uploadAvatar();
                                }, () async {
                                  image = await model.takeImageGallery();
                                  await model.uploadAvatar();
                                }, context);
                              },
                              child: model.avatar == null
                                  ? Image.file(
                                      model.imagePicked,
                                      width: 100,
                                      height: 100,
                                      fit: BoxFit.fill,
                                    )
                                  : CachedNetworkImage(
                                      imageUrl: model.avatar,
                                      width: 100,
                                      height: 100,
                                      fit: BoxFit.fill,
                                    )),
                    ),
                    SizedBox(
                      width: 20,
                    ),
                    Container(
                      padding: EdgeInsets.only(left: 150),
                      child: Image(
                        width: 100,
                        height: 100,
                        alignment: Alignment.bottomRight,
                        image: NetworkImage(
                            'https://cdn.discordapp.com/attachments/814426440308752449/814460660569735199/1.png'),
                      ),
                    )
                  ],
                ),
                SizedBox(
                  height: 20,
                ),
                isPressed == true
                    ? QrImage(
                        data: model.cnp.toString() + formattedDate,
                      )
                    : Column(children: [
                        Container(
                          padding: EdgeInsets.only(right: 310),
                          child: Text("Nume: " + model.nume),
                        ),
                        SizedBox(
                          height: 20,
                        ),
                        Container(
                          padding: EdgeInsets.only(right: 305),
                          child: Text("CNP: " + model.cnp.toString()),
                        ),
                        SizedBox(
                          height: 20,
                        ),
                        Container(
                          padding: EdgeInsets.only(right: 260),
                          child: Text("Nr. Masina: " + model.nr_inmatriculare),
                        ),
                        SizedBox(
                          height: 20,
                        ),
                        Container(
                          padding: EdgeInsets.only(right: 300),
                          child: Text("Departament: " + model.departament),
                        ),
                        SizedBox(
                          height: 20,
                        ),
                        Container(
                          padding: EdgeInsets.only(right: 170),
                          child: Text("Repartizare loc: " +
                              " Etaj " +
                              model.etaj.toString() +
                              ", " +
                              "Birou " +
                              model.birou.toString() +
                              ", " +
                              "Loc" +
                              model.loc.toString() +
                              " "),
                        ),
                        SizedBox(
                          height: 20,
                        ),
                        Padding(
                          padding: EdgeInsets.only(right: 200),
                          child: Container(
                            width: 200,
                            height: 30,
                            decoration: BoxDecoration(
                                color: Colors.grey[300],
                                borderRadius: BorderRadius.zero),
                            child: MaterialButton(
                              onPressed: () {
                                Navigator.pushNamed(context, "/changePassword");
                              },
                              child: Text("Schimbare parola"),
                            ),
                          ),
                        ),
                        SizedBox(
                          height: 100,
                        ),
                        Container(
                          width: 200,
                          height: 100,
                          decoration: BoxDecoration(
                              color: Colors.grey[300],
                              borderRadius: BorderRadius.zero),
                          child: MaterialButton(
                            onPressed: () {
                              setState(() {
                                isPressed = true;
                                var now = new DateTime.now();
                                var formatter =
                                    new DateFormat('yyyyMMddhhmmss');
                                formattedDate = formatter.format(now);
                                print(
                                    "DATAAA: ${model.cnp.toString()}$formattedDate");
                              });
                            },
                            child: Text(
                              "Generare cod QR",
                              style: TextStyle(
                                  fontWeight: FontWeight.bold, fontSize: 20),
                            ),
                          ),
                        ),
                      ]),
                SizedBox(
                  height: 20,
                ),
                isPressed == true
                    ? Container(
                        width: 300,
                        height: 50,
                        decoration: BoxDecoration(
                            color: Colors.grey[300],
                            borderRadius: BorderRadius.zero),
                        child: MaterialButton(
                          onPressed: () {
                            setState(() {
                              isPressed = false;
                              formattedDate = null;
                            });
                          },
                          child: Text(
                            "Inapoi",
                            style: TextStyle(
                                fontWeight: FontWeight.bold, fontSize: 20),
                          ),
                        ),
                      )
                    : SizedBox(
                        height: 1,
                      ),
              ],
            ),
          ),
        ),
      ),
    );
  }

  Future<Widget> showQR(String cnp) async {
    return Container(
      width: 200,
      height: 200,
      decoration: BoxDecoration(
          color: Colors.grey[300], borderRadius: BorderRadius.zero),
      child: QrImage(
        data: cnp,
      ),
    );
  }

  Future<void> showAlertDialogOwn(
      Function cameraImage, Function galleryImage, BuildContext context) {
    return showModalBottomSheet(
        context: context,
        builder: (context) {
          return Container(
            decoration: BoxDecoration(
              borderRadius: BorderRadius.only(
                  topLeft: Radius.circular(10), topRight: Radius.circular(10)),
            ),
            height: 150,
            width: 150,
            child: Column(
              mainAxisAlignment: MainAxisAlignment.start,
              crossAxisAlignment: CrossAxisAlignment.start,
              children: [
                SizedBox(
                  height: 20,
                ),
                Container(
                  width: 300,
                  height: 50,
                  child: InkWell(
                    child: Row(
                      crossAxisAlignment: CrossAxisAlignment.start,
                      children: [
                        Icon(Icons.camera),
                        SizedBox(
                          width: 20,
                        ),
                        Text("Poza cu camera"),
                      ],
                    ),
                    onTap: () async {
                      await cameraImage();
                    },
                  ),
                ),
                SizedBox(
                  height: 20,
                ),
                Container(
                  width: 300,
                  height: 50,
                  child: InkWell(
                    child: Row(
                      crossAxisAlignment: CrossAxisAlignment.start,
                      children: [
                        Icon(Icons.image),
                        SizedBox(
                          width: 20,
                        ),
                        Text("Poza din galerie"),
                      ],
                    ),
                    onTap: () async {
                      await galleryImage();
                    },
                  ),
                )
              ],
            ),
          );
        });
  }
}