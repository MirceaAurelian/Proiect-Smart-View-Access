#pragma checksum "E:\Faculta\IP\Proiect Smart View Access\Proiect-Smart-View-Access\dotnetnewmvc\Views\Home\Firebase.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5095ed903e39c93075f0b95116faa82796b4d11"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Firebase), @"mvc.1.0.view", @"/Views/Home/Firebase.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "E:\Faculta\IP\Proiect Smart View Access\Proiect-Smart-View-Access\dotnetnewmvc\Views\_ViewImports.cshtml"
using dotnetnewmvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Faculta\IP\Proiect Smart View Access\Proiect-Smart-View-Access\dotnetnewmvc\Views\_ViewImports.cshtml"
using dotnetnewmvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5095ed903e39c93075f0b95116faa82796b4d11", @"/Views/Home/Firebase.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed3f9eba2eba42d9cad24342d56cbb9b6a2015f9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Firebase : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<script src=""https://www.gstatic.com/firebasejs/8.3.1/firebase-app.js""></script>

<!-- TODO: Add SDKs for Firebase products that you want to use
   https://firebase.google.com/docs/web/setup#available-libraries -->
<script src=""https://www.gstatic.com/firebasejs/8.3.1/firebase-analytics.js""></script>
<script src=""https://www.gstatic.com/firebasejs/8.3.1/firebase-firestore.js""></script>


<script>

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
      ");
            WriteLiteral(@"  getDict() {
            return {
                ""cnp"": this.cnp,
                ""nume"": this.nume,
                ""prenume"": this.prenume,
                ""numar_inmatriculare"": this.numar_inmatriculare,
                ""etaj"": this.etaj,
                ""birou"": this.birou,
                ""loc"": this.loc,
                ""avatar"": this.avatar,
                ""email"": this.email,
                ""email_firma"": this.email_firma,
                ""parola"": this.parola,
                ""departament"": this.departament
            }
        }
    }

    window.addEventListener(""load"", function () {
        var firebaseConfig = {
            apiKey: ""AIzaSyDeV9pbD-ZeNoxM6eJFl0xngHqG6UVhFM0"",
            authDomain: ""smartviewacces.firebaseapp.com"",
            databaseURL: ""https://smartviewacces-default-rtdb.europe-west1.firebasedatabase.app"",
            projectId: ""smartviewacces"",
            storageBucket: ""smartviewacces.appspot.com"",
            messagingSenderId: ""751235009352");
            WriteLiteral(@""",
            appId: ""1:751235009352:web:febf61f45aca0638f6017d"",
            measurementId: ""G-8G121FG9R3""
        };
        // Initialize Firebase
        firebase.initializeApp(firebaseConfig);
        firebase.analytics();
        db = firebase.firestore();
        var Angajat = db.collection('Angajat');
        var Administrator = db.collection('Administrator')
        /*Administrator.get().then(snapshot => {
            snapshot.docs.map(doc => {
                var data = doc.data();
                for (item in data)
                    console.log(item, data[item])
            });
        });*/
        var form = document.createElement('form');
        form.setAttribute(""method"", ""POST"");

        var finished_admin_check = false;
        var finished_user_check = false;

        var input;
        var alldata = """";


        Angajat.where(""email"", ""=="", """")
            .where(""parola"", ""=="", """")
            .get()
            .then((querySnapshot) => {
              ");
            WriteLiteral(@"  querySnapshot.forEach((ang) => {
                    // doc.data() is never undefined for query doc snapshots

                    input = document.createElement('input');
                    var dataset = ang.data();
                    input.setAttribute('type', 'hidden');
                    input.name = ""User"";
                    //console.log(ang.id);
                    //console.log(Administrator.where(""id"", ""=="", ""a7UNRVlmYa7ZS6KjYChe"").get());


                    alldata += ""id: "" + ang.id;
                    for (var i in dataset) {
                        alldata += ""\n"" + i + "": "" + dataset[i];
                    }

                    Administrator.doc(ang.id).get().then((adm) => {
                        if (adm.exists) {
                            var input_admin = document.createElement('input');
                            input_admin.setAttribute('type', 'hidden');
                            input_admin.name = ""is_Administrator"";
                            inpu");
            WriteLiteral(@"t_admin.value = ""true"";
                            form.appendChild(input_admin);
                        }
                    }).then(function () {
                        finished_admin_check = true;

                    });




                    //console.log(doc.id, "" => "", doc.data());
                });
            })
            .catch((error) => {
                console.log(""Error getting documents: "", error);
            }).then(function () {
                finished_user_check = true;
                if (alldata == """")
                    finished_admin_check = true;
            });

            function Refresh() {
                if (finished_admin_check == false || finished_user_check == false) {
                    window.setTimeout(Refresh, 100);
                }
                else {
                    if (alldata != """")
                    {
                        input.value = alldata;

                        form.appendChild(input);

             ");
            WriteLiteral(@"       }


                    document.querySelector('body').appendChild(form);
                    form.submit();
                }
        }
        Refresh();



    });









    //myPost.update({ cnp: ""1234567891011""});
    // myPost.where(""camp"", ""operator"", ""valoare"");
    //db.collection('Angajat').doc().set((new Angajat(""Html234567891231"", ""Mircea"", ""Dan"", ""HD56DMA"", 1, 2, 3, ""imagine"", ""email@email.com"", ""email2@email2.com"", ""123456789"", ""IT"")).getDict());
</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
