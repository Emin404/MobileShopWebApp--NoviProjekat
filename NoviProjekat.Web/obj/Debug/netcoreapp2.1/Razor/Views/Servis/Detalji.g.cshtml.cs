#pragma checksum "C:\Users\hasic_000\Desktop\NoviProjekat - Copy\NoviProjekat.Web\Views\Servis\Detalji.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f46dd3dad27bbbb382ee502c4e76c27b37eb17f6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Servis_Detalji), @"mvc.1.0.view", @"/Views/Servis/Detalji.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Servis/Detalji.cshtml", typeof(AspNetCore.Views_Servis_Detalji))]
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
#line 1 "C:\Users\hasic_000\Desktop\NoviProjekat - Copy\NoviProjekat.Web\Views\_ViewImports.cshtml"
using NoviProjekat.Web;

#line default
#line hidden
#line 2 "C:\Users\hasic_000\Desktop\NoviProjekat - Copy\NoviProjekat.Web\Views\Servis\Detalji.cshtml"
using NoviProjekat.Web.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f46dd3dad27bbbb382ee502c4e76c27b37eb17f6", @"/Views/Servis/Detalji.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64bea66b5b10d5dcb2e9880e52115b00d6e674d4", @"/Views/_ViewImports.cshtml")]
    public class Views_Servis_Detalji : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ServisDetaljiVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(38, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "C:\Users\hasic_000\Desktop\NoviProjekat - Copy\NoviProjekat.Web\Views\Servis\Detalji.cshtml"
  
    ViewData["Title"] = "Detalji";




#line default
#line hidden
            BeginContext(113, 175, true);
            WriteLiteral("\r\n<h2>Detalji</h2>\r\n\r\n<div>\r\n    <div class=\"form-group\">\r\n        <label>Datum primanja: </label>\r\n        <div>\r\n            <input type=\"text\" class=\"form-control\" readonly");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 288, "\"", 316, 1);
#line 18 "C:\Users\hasic_000\Desktop\NoviProjekat - Copy\NoviProjekat.Web\Views\Servis\Detalji.cshtml"
WriteAttributeValue("", 296, Model.DatumPrimanja, 296, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(317, 171, true);
            WriteLiteral(" />\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        <label>Opis: </label>\r\n        <div>\r\n            <input type=\"text\" class=\"form-control\" readonly");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 488, "\"", 507, 1);
#line 25 "C:\Users\hasic_000\Desktop\NoviProjekat - Copy\NoviProjekat.Web\Views\Servis\Detalji.cshtml"
WriteAttributeValue("", 496, Model.Opis, 496, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(508, 175, true);
            WriteLiteral(" />\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        <label>Klijent : </label>\r\n        <div>\r\n            <input type=\"text\" class=\"form-control\" readonly");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 683, "\"", 705, 1);
#line 32 "C:\Users\hasic_000\Desktop\NoviProjekat - Copy\NoviProjekat.Web\Views\Servis\Detalji.cshtml"
WriteAttributeValue("", 691, Model.Klijent, 691, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(706, 173, true);
            WriteLiteral(" />\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label>Artikal : </label>\r\n        <div>\r\n            <input type=\"text\" class=\"form-control\" readonly");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 879, "\"", 901, 1);
#line 38 "C:\Users\hasic_000\Desktop\NoviProjekat - Copy\NoviProjekat.Web\Views\Servis\Detalji.cshtml"
WriteAttributeValue("", 887, Model.Artikal, 887, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(902, 178, true);
            WriteLiteral(" />\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label>Ukupna cijena: </label>\r\n        <div>\r\n            <input type=\"text\" class=\"form-control\" readonly");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1080, "\"", 1107, 1);
#line 44 "C:\Users\hasic_000\Desktop\NoviProjekat - Copy\NoviProjekat.Web\Views\Servis\Detalji.cshtml"
WriteAttributeValue("", 1088, Model.UkupnaCijena, 1088, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1108, 186, true);
            WriteLiteral(" />\r\n        </div>\r\n    </div>\r\n\r\n\r\n    <div class=\"form-group\">\r\n        <label>Datum slanja : </label>\r\n        <div>\r\n            <input type=\"datetime\" class=\"form-control\" readonly");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1294, "\"", 1320, 1);
#line 52 "C:\Users\hasic_000\Desktop\NoviProjekat - Copy\NoviProjekat.Web\Views\Servis\Detalji.cshtml"
WriteAttributeValue("", 1302, Model.DatumSlanja, 1302, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1321, 206, true);
            WriteLiteral(" />\r\n        </div>\r\n    </div>\r\n\r\n\r\n</div>\r\n\r\n<div id=\"nekiId\" style=\"border: 2px black solid\"></div>\r\n\r\n<script>\r\n    $(document).ready(function(parameters) {\r\n        $.get(\"/ServisStavke/Index?ServisId=");
            EndContext();
            BeginContext(1528, 8, false);
#line 63 "C:\Users\hasic_000\Desktop\NoviProjekat - Copy\NoviProjekat.Web\Views\Servis\Detalji.cshtml"
                                       Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1536, 135, true);
            WriteLiteral("\",\r\n            function(rezultat, status) {\r\n                $(\"#nekiId\").html(rezultat);\r\n\r\n            });\r\n    });\r\n\r\n</script>\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ServisDetaljiVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
