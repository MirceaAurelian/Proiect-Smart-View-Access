#pragma checksum "/home/ubuntu/Proiect-Smart-View-Access/dotnetnewmvc/Views/Home/Index_Administrator.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c016ff4e3a3625bae472896c83fd721409e13a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index_Administrator), @"mvc.1.0.view", @"/Views/Home/Index_Administrator.cshtml")]
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
#line 1 "/home/ubuntu/Proiect-Smart-View-Access/dotnetnewmvc/Views/_ViewImports.cshtml"
using dotnetnewmvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/ubuntu/Proiect-Smart-View-Access/dotnetnewmvc/Views/_ViewImports.cshtml"
using dotnetnewmvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c016ff4e3a3625bae472896c83fd721409e13a4", @"/Views/Home/Index_Administrator.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed3f9eba2eba42d9cad24342d56cbb9b6a2015f9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index_Administrator : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/home/ubuntu/Proiect-Smart-View-Access/dotnetnewmvc/Views/Home/Index_Administrator.cshtml"
  
    ViewData["Title"] = "Administrator";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    h2 {
        cursor: pointer;
    }
</style>

<div style=""position: absolute; width: 75%; height: 75%; top: 25%; left: 12.5%; right: 12.5%"">
    <h1 style=""width: 100%; text-align: center;"">Meniu administrator</h1>
    <h2 id=""1"">1. Vizualizare statistici angajati</h2>
    <h2 id=""2"">2. Setarea locurilor de parcare si configurarea cladirii firmei</h2>
    <h2 id=""3"">3. Inserare date angajati</h2>
    <h2 id=""4"">4. Generare raport</h2>
</div>

<script>
    $('h2').on('click', function () {
        var form = document.createElement('form');
        form.setAttribute('method', 'POST');
        var input = document.createElement('input');
        input.setAttribute('type', 'hidden');
        input.name = ""administrator_menu_item"";
        input.value = $(this).attr('id');
        form.appendChild(input);
        document.querySelector('body').appendChild(form);
        form.submit();
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
