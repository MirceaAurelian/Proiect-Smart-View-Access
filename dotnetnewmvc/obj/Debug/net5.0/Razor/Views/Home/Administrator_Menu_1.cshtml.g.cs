#pragma checksum "E:\Faculta\IP\Proiect Smart View Access\Proiect-Smart-View-Access\dotnetnewmvc\Views\Home\Administrator_Menu_1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74d6a9c2d4596c99a5bd5aca2106aef3b43415ce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Administrator_Menu_1), @"mvc.1.0.view", @"/Views/Home/Administrator_Menu_1.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74d6a9c2d4596c99a5bd5aca2106aef3b43415ce", @"/Views/Home/Administrator_Menu_1.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed3f9eba2eba42d9cad24342d56cbb9b6a2015f9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Administrator_Menu_1 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\Faculta\IP\Proiect Smart View Access\Proiect-Smart-View-Access\dotnetnewmvc\Views\Home\Administrator_Menu_1.cshtml"
  
    ViewData["Title"] = "Administrator";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .hidden {
        display: none;
    }

    th {
        width: 25%;
    }

    td {
        width: 25%;
    }

    .error {
        background-color: #FF6347;
    }
</style>

<label for=""profile_pic_select""><img id=""profile_pic""");
            BeginWriteAttribute("src", " src=\"", 310, "\"", 330, 1);
#nullable restore
#line 23 "E:\Faculta\IP\Proiect Smart View Access\Proiect-Smart-View-Access\dotnetnewmvc\Views\Home\Administrator_Menu_1.cshtml"
WriteAttributeValue("", 316, ViewBag.Image, 316, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" style=""position: absolute; width: 15%; height: auto; top: 1%; left: 1%; cursor: pointer;"" /></label>
<input id=""profile_pic_select"" name=""profile_pic_select"" type=""file"" accept=""image/*"" style=""display: none;"" />

<div style=""position: absolute; top: 15%; width: 50%; margin-left: 25%; margin-right: 25%; height: 85%;"">
    <h1 style=""width: 100%; height: 25%; text-align: center; margin: 0;"">Statistica prezențelor în firmă a tuturor angajaților</h1>
    <div style=""position: relative; width: 100%; margin-bottom: 1%; height: 5%;  display: flex;"">
        <div id=""month_select"" style=""position: relative; cursor: pointer; user-select: none; width: 25%; margin-bottom: 1%; height: 100%; border: 1px solid grey; background-color: #E9ECEF;"">
            <p id=""current_month"" data-month=""");
#nullable restore
#line 30 "E:\Faculta\IP\Proiect Smart View Access\Proiect-Smart-View-Access\dotnetnewmvc\Views\Home\Administrator_Menu_1.cshtml"
                                         Write(ViewBag.CurrentMonth);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" style=\"margin: 0; width: 100%; height: 100%;\">");
#nullable restore
#line 30 "E:\Faculta\IP\Proiect Smart View Access\Proiect-Smart-View-Access\dotnetnewmvc\Views\Home\Administrator_Menu_1.cshtml"
                                                                                                              Write(ViewBag.Months[ViewBag.CurrentMonth - 1]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
            <i style=""position: absolute; color: grey; right: 5%; top: 20%;"" class=""fas fa-caret-down""></i>
        </div>
        <p style=""width: 25%; text-align: center;"">Cautare angajat:</p>
        <input id=""search_name"" style=""width: 25%"" />
        <p id=""total_hours"" style=""width: 25%;"">Numar total de ore: ");
#nullable restore
#line 35 "E:\Faculta\IP\Proiect Smart View Access\Proiect-Smart-View-Access\dotnetnewmvc\Views\Home\Administrator_Menu_1.cshtml"
                                                               Write(ViewBag.Total);

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>\r\n    </div>\r\n    <div id=\"months\" class=\"hidden\" style=\"top: 30%; position: absolute; width: 25%; background-color: white; border-left: 1px solid grey; border-bottom: 1px solid grey; border-right: 1px solid grey;\">\r\n");
#nullable restore
#line 38 "E:\Faculta\IP\Proiect Smart View Access\Proiect-Smart-View-Access\dotnetnewmvc\Views\Home\Administrator_Menu_1.cshtml"
         for (int i = 12; i >= 1; i--)
        {
            if (i > ViewBag.CurrentMonth)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p class=\"dropdown-element\" data-month=\"");
#nullable restore
#line 42 "E:\Faculta\IP\Proiect Smart View Access\Proiect-Smart-View-Access\dotnetnewmvc\Views\Home\Administrator_Menu_1.cshtml"
                                                   Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" style=\"margin: 0; display: none; cursor: pointer; width: 100%;\">");
#nullable restore
#line 42 "E:\Faculta\IP\Proiect Smart View Access\Proiect-Smart-View-Access\dotnetnewmvc\Views\Home\Administrator_Menu_1.cshtml"
                                                                                                                       Write(ViewBag.Months[i - 1]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 43 "E:\Faculta\IP\Proiect Smart View Access\Proiect-Smart-View-Access\dotnetnewmvc\Views\Home\Administrator_Menu_1.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p class=\"dropdown-element\" data-month=\"");
#nullable restore
#line 46 "E:\Faculta\IP\Proiect Smart View Access\Proiect-Smart-View-Access\dotnetnewmvc\Views\Home\Administrator_Menu_1.cshtml"
                                                   Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" style=\"margin: 0; cursor: pointer; width: 100%;\">");
#nullable restore
#line 46 "E:\Faculta\IP\Proiect Smart View Access\Proiect-Smart-View-Access\dotnetnewmvc\Views\Home\Administrator_Menu_1.cshtml"
                                                                                                        Write(ViewBag.Months[i - 1]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 47 "E:\Faculta\IP\Proiect Smart View Access\Proiect-Smart-View-Access\dotnetnewmvc\Views\Home\Administrator_Menu_1.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <i style=\"position: absolute; bottom: 2.5%; left: 5%;\" class=\"fas fa-edit\"></i>\r\n        <input class=\"dropdown-element\" id=\"year\" style=\"width: 100%; text-align: center; border: 0; outline:none;\" type=\"text\" data-current=\"");
#nullable restore
#line 50 "E:\Faculta\IP\Proiect Smart View Access\Proiect-Smart-View-Access\dotnetnewmvc\Views\Home\Administrator_Menu_1.cshtml"
                                                                                                                                         Write(DateTime.Now.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
            BeginWriteAttribute("value", " value=\"", 2520, "\"", 2546, 1);
#nullable restore
#line 50 "E:\Faculta\IP\Proiect Smart View Access\Proiect-Smart-View-Access\dotnetnewmvc\Views\Home\Administrator_Menu_1.cshtml"
WriteAttributeValue("", 2528, DateTime.Now.Year, 2528, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
    </div>
    <table border=""1"" style=""width: 100%; max-height: 69%; border: 1px solid black; overflow-y: auto;"">
        <tr>
            <th style=""text-align: center;"">Nume angajat</th>
            <th style=""text-align: center;"">Intrare</th>
            <th style=""text-align: center;"">Ieșire</th>
            <th style=""text-align: center;"">Număr de ore</th>
        </tr>

");
#nullable restore
#line 60 "E:\Faculta\IP\Proiect Smart View Access\Proiect-Smart-View-Access\dotnetnewmvc\Views\Home\Administrator_Menu_1.cshtml"
         for (int i = 0; i < ViewBag.Count; i++)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n");
#nullable restore
#line 63 "E:\Faculta\IP\Proiect Smart View Access\Proiect-Smart-View-Access\dotnetnewmvc\Views\Home\Administrator_Menu_1.cshtml"
             if (i % 2 != 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td align=\"center\" style=\"background-color: #F5F5F5;\">\r\n                    ");
#nullable restore
#line 66 "E:\Faculta\IP\Proiect Smart View Access\Proiect-Smart-View-Access\dotnetnewmvc\Views\Home\Administrator_Menu_1.cshtml"
               Write(ViewBag.Angajat[i]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td align=\"center\" style=\"background-color: #F5F5F5;\">\r\n                    ");
#nullable restore
#line 69 "E:\Faculta\IP\Proiect Smart View Access\Proiect-Smart-View-Access\dotnetnewmvc\Views\Home\Administrator_Menu_1.cshtml"
               Write(ViewBag.Intrari[i].ToString("dd/MM/yyyy hh:mm:ss tt"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td align=\"center\" style=\"background-color: #F5F5F5;\">\r\n                    ");
#nullable restore
#line 72 "E:\Faculta\IP\Proiect Smart View Access\Proiect-Smart-View-Access\dotnetnewmvc\Views\Home\Administrator_Menu_1.cshtml"
               Write(ViewBag.Iesiri[i].ToString("dd/MM/yyyy hh:mm:ss tt"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td align=\"center\" style=\"background-color: #F5F5F5;\">\r\n                    ");
#nullable restore
#line 75 "E:\Faculta\IP\Proiect Smart View Access\Proiect-Smart-View-Access\dotnetnewmvc\Views\Home\Administrator_Menu_1.cshtml"
               Write(ViewBag.Ore[i]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n");
#nullable restore
#line 77 "E:\Faculta\IP\Proiect Smart View Access\Proiect-Smart-View-Access\dotnetnewmvc\Views\Home\Administrator_Menu_1.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td align=\"center\">\r\n                    ");
#nullable restore
#line 81 "E:\Faculta\IP\Proiect Smart View Access\Proiect-Smart-View-Access\dotnetnewmvc\Views\Home\Administrator_Menu_1.cshtml"
               Write(ViewBag.Angajat[i]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td align=\"center\">\r\n                    ");
#nullable restore
#line 84 "E:\Faculta\IP\Proiect Smart View Access\Proiect-Smart-View-Access\dotnetnewmvc\Views\Home\Administrator_Menu_1.cshtml"
               Write(ViewBag.Intrari[i].ToString("dd/MM/yyyy hh:mm:ss tt"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td align=\"center\">\r\n                    ");
#nullable restore
#line 87 "E:\Faculta\IP\Proiect Smart View Access\Proiect-Smart-View-Access\dotnetnewmvc\Views\Home\Administrator_Menu_1.cshtml"
               Write(ViewBag.Iesiri[i].ToString("dd/MM/yyyy hh:mm:ss tt"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td align=\"center\">\r\n                    ");
#nullable restore
#line 90 "E:\Faculta\IP\Proiect Smart View Access\Proiect-Smart-View-Access\dotnetnewmvc\Views\Home\Administrator_Menu_1.cshtml"
               Write(ViewBag.Ore[i]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n");
#nullable restore
#line 92 "E:\Faculta\IP\Proiect Smart View Access\Proiect-Smart-View-Access\dotnetnewmvc\Views\Home\Administrator_Menu_1.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tr>\r\n");
#nullable restore
#line 94 "E:\Faculta\IP\Proiect Smart View Access\Proiect-Smart-View-Access\dotnetnewmvc\Views\Home\Administrator_Menu_1.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </table>
</div>

<script>
    $('#month_select').on('click', function () {
        $('#months').toggleClass('hidden');
    });
    $("".dropdown-element"").mouseenter(function () {
        if (!$(this).hasClass('error'))
            $(this).css('background-color', '#4C8BF5');
    });
    $("".dropdown-element"").mouseleave(function () {
        if (!$(this).hasClass('error'))
            $(this).css('background-color', '');
    });
    $("".dropdown-element:not('input')"").on(""click"", function () {
        var month = $(this).data('month');
        var months = [""Ianuarie"", ""Februarie"", ""Martie"", ""Aprilie"", ""Mai"", ""Iunie"", ""Iulie"", ""August"", ""Septembrie"", ""Octombrie"", ""Noiembrie"", ""Decembrie""];
        $.ajax({
            url: ""/"",
            method: ""POST"",
            data: { ""change_month"": month, ""change_year"": $(""#year"").val()},
            success: function (data) {
                document.querySelector('table').innerHTML = ""<tr><th style = 'text-align: center;'>Nume angajat</th>");
            WriteLiteral(@"<th style = 'text-align: center;'>Intrare</th><th style='text-align: center;'>Ieșire</th><th style='text-align: center;'>Număr de ore</th></tr>""
                for (var i = 0; i < data[""iesiri""].length; i++) {
                    var date = data[""intrari""][i].substring(8, 10) + ""/"" + data[""intrari""][i].substring(5, 7) + ""/"" + data[""intrari""][i].substring(0, 4) + "" "";
                    if (+data[""intrari""][i].substring(11, 13) > 12) {
                        date += ""0"";
                        date += +data[""intrari""][i].substring(11, 13) - 12 + "":"" + data[""intrari""][i].substring(14, 16) + "":"" + data[""intrari""][i].substring(17, 19) + "" PM"";
                    }
                    else
                        date += data[""intrari""][i].substring(11, 13) + "":"" + data[""intrari""][i].substring(14, 16) + "":"" + data[""intrari""][i].substring(17, 19) + "" AM"";

                    var tr = document.createElement('tr');
                    var td = document.createElement('td');
                    td.ali");
            WriteLiteral(@"gn = ""center"";
                    td.innerText = data[""angajat""][i];
                    if (i % 2 != 0)
                        td.style.backgroundColor = ""#F5F5F5"";
                    tr.appendChild(td);
                    td = document.createElement('td');
                    td.align = ""center"";
                    td.innerText = date;
                    if (i % 2 != 0)
                        td.style.backgroundColor = ""#F5F5F5"";
                    tr.appendChild(td);
                    date = data[""iesiri""][i].substring(8, 10) + ""/"" + data[""iesiri""][i].substring(5, 7) + ""/"" + data[""iesiri""][i].substring(0, 4) + "" "";
                    if (+data[""iesiri""][i].substring(11, 13) > 12) {
                        date += ""0"";
                        date += +data[""iesiri""][i].substring(11, 13) - 12 + "":"" + data[""iesiri""][i].substring(14, 16) + "":"" + data[""iesiri""][i].substring(17, 19) + "" PM"";

                    }
                    else
                        date += data[""iesiri""");
            WriteLiteral(@"][i].substring(11, 13) + "":"" + data[""iesiri""][i].substring(14, 16) + "":"" + data[""iesiri""][i].substring(17, 19) + "" AM"";
                    td = document.createElement('td');
                    td.align = ""center"";
                    td.innerText = date;
                    if (i % 2 != 0)
                        td.style.backgroundColor = ""#F5F5F5"";
                    tr.appendChild(td);
                    td = document.createElement('td');
                    td.align = ""center"";
                    td.innerText = data[""ore""][i];
                    if (i % 2 != 0)
                        td.style.backgroundColor = ""#F5F5F5"";
                    tr.appendChild(td);
                    document.querySelector('table').appendChild(tr);
                }
                $('#current_month').text(months[+month - 1]);
                $('#total_hours').text(""Numar total de ore: ""+data[""total""]);
            }
        });
    });
    $('#search_name').on('input', function () {
        var ro");
            WriteLiteral(@"ws = $('table').find('tr');
        for (i = 1; i < rows.length; i++)
            if (!rows.eq(i).find('td').eq(0).text().toLowerCase().includes($(this).val().toLowerCase())) {
                rows.eq(i).css('display', 'none');
            }
            else {
                rows.eq(i).css('display', '');
            }
    });
    $('#year').on(""input"", function () {
        var nums = ""0123456789"";
        var text = $(this).val();
        if (text.length != 4) {
            $(this).css('background-color', '');
            $(this).addClass('error');
        }
        else if (!nums.includes(text[0]) || !nums.includes(text[1]) || !nums.includes(text[2]) || !nums.includes(text[3]))
        {
            $(this).css('background-color', '');
            $(this).addClass('error');
        }
        else if (+text > +$(this).data('current'))
        {
            $(this).css('background-color', '');
            $(this).addClass('error');
        }
        else {
            $(this).remo");
            WriteLiteral(@"veClass('error');
            if (+text < +$(this).data('current'))
                $(""p.dropdown-element"").css('display', '');
            else {
                i = 12;
                while (i != +$('#current_month').data('month')) {
                    $('.dropdown-element[data-month=""' + i + '""').css('display', 'none');
                    i--;
                }

            }

        }
    });
    $('#year').change(function () {
        if ($(this).hasClass(""error"")) {
            $(this).removeClass(""error"");
            $(this).val($(this).data('current'));
            i = 12;
            while (i != +$('#current_month').data('month')) {
                $('.dropdown-element[data-month=""' + i + '""').css('display', 'none');
                i--;
            }
        }
    });
    $(""#profile_pic_select"").change(function () {
        var input = this;
        if (input.files && input.files[0]) {
            var filesize = ((input.files[0].size / 1024) / 1024).toFixed(4); // M");
            WriteLiteral(@"B
            if (filesize > 5) {
                alert(""Eroare! Imaginile mai mari de 5MB nu sunt acceptate!"");
            }
            else {
                var reader = new FileReader();
                reader.onload = function (e) {
                    $(""#profile_pic"").attr(""src"", e.target.result);
                    $.ajax({
                        url: ""/"",
                        method: ""POST"",
                        data: { ""uid"": """);
#nullable restore
#line 235 "E:\Faculta\IP\Proiect Smart View Access\Proiect-Smart-View-Access\dotnetnewmvc\Views\Home\Administrator_Menu_1.cshtml"
                                   Write(ViewBag.uid);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""", ""change_profile_pic"": e.target.result }
                    });
                }
                reader.readAsDataURL(input.files[0]);
            }
        }
    });
    $('html').on(""click"", function (e) {
        if (e.target.id != ""months"" && e.target.id != ""month_select"" && e.target.parentElement.id != ""months"" && e.target.parentElement.id != ""month_select"")
        {
            $('#months').addClass('hidden');
        }
    });
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
