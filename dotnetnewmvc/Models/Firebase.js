﻿import * as firebase_app from 'firebase_app.js'
import * as firebase_firestore from 'firebase_firestore.js'


const firebaseConfig = {
  apiKey: "AIzaSyDeV9pbD-ZeNoxM6eJFl0xngHqG6UVhFM0",
  authDomain: "smartviewacces.firebaseapp.com",
  databaseURL: "https://smartviewacces-default-rtdb.europe-west1.firebasedatabase.app",
  projectId: "smartviewacces",
  storageBucket: "smartviewacces.appspot.com",
  messagingSenderId: "751235009352",
  appId: "1:751235009352:web:febf61f45aca0638f6017d",
  measurementId: "G-8G121FG9R3"
};

/*var firebase_app_script = document.createElement('script');
firebase_app_script.setAttribute('src', 'https://www.gstatic.com/firebasejs/8.3.1/firebase-app.js');
document.head.appendChild(firebase_app_script);

var firebase_analytics_script = document.createElement('script');
firebase_analytics_script.setAttribute('src', 'https://www.gstatic.com/firebasejs/8.3.1/firebase-analytics.js');
document.head.appendChild(firebase_analytics_script);

var firebase_firestore_script = document.createElement('script');
firebase_firestore_script.setAttribute('src', 'https://www.gstatic.com/firebasejs/8.3.1/firebase-firestore.js');
document.head.appendChild(firebase_firestore_script);*/



class Angajat {
    constructor(cnp, nume, prenume, numar_inmatriculare, etaj, birou, loc, avatar, email, email_firma, parola, departament) {
        this.cnp = cnp;
        this.nume = nume;
        this.prenume = prenume;
        this.numar_inmatriculare = numar_inmatriculare;
        this.etaj = etaj;
        this.birou = birou;
        this.loc = loc;
        this.avatar = avatar;
        this.email = email;
        this.email_firma = email_firma;
        this.parola = parola;
        this.departament = departament;
    }
    getDict() {
        return {
            "cnp": this.cnp,
            "nume": this.nume,
            "prenume": this.prenume,
            "numar_inmatriculare": this.numar_inmatriculare,
            "etaj": this.etaj,
            "birou": this.birou,
            "loc": this.loc,
            "avatar": this.avatar,
            "email": this.email,
            "email_firma": this.email_firma,
            "parola": this.parola,
            "departament": this.departament
        }
    }
}


    // Initialize Firebase
    firebase.initializeApp(firebaseConfig);
    //firebase.analytics();

    const myPost = firebase.firestore().collection('Angajat');

    myPost.doc().set((new Angajat("abcdefgh", "Mircea", "Dan", "HD56DMA", 1, 2, 3, "imagine", "email@email.com", "email2@email2.com", "123456789", "IT")).getDict());

    /*myPost.where("email", "==", Angajat2.email)
        .where("parola", "==", Angajat2.parola)
        .get()
        .then((querySnapshot) => {
            querySnapshot.forEach((doc) => {
                // doc.data() is never undefined for query doc snapshots

                //query = query + doc.id + " " + doc.data();
            });
        });*/

    /*const myPost = db.collection('Angajat');
    myPost.get().then(snapshot => {
        snapshot.docs.map(doc => {
            var data = doc.data();
            for (item in data)
                console.log(item, data[item])
        });
    });*/
    //myPost.update({ cnp: "1234567891011"});
// myPost.where("camp", "operator", "valoare");
//db.collection('Angajat').doc().set((new Angajat("1234567891231", "Mircea", "Dan", "HD56DMA", 1, 2, 3, "imagine", "email@email.com", "email2@email2.com", "123456789", "IT")).getDict());