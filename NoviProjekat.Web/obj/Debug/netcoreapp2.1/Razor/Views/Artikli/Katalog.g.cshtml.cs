#pragma checksum "C:\Users\hasic_000\Desktop\NoviProjekat - Copy\NoviProjekat.Web\Views\Artikli\Katalog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c0b4fe3755ca59f1c3d1ff184285553423e8057"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Artikli_Katalog), @"mvc.1.0.view", @"/Views/Artikli/Katalog.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Artikli/Katalog.cshtml", typeof(AspNetCore.Views_Artikli_Katalog))]
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
#line 2 "C:\Users\hasic_000\Desktop\NoviProjekat - Copy\NoviProjekat.Web\Views\_ViewImports.cshtml"
using NoviProjekat.Web.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c0b4fe3755ca59f1c3d1ff184285553423e8057", @"/Views/Artikli/Katalog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64bea66b5b10d5dcb2e9880e52115b00d6e674d4", @"/Views/_ViewImports.cshtml")]
    public class Views_Artikli_Katalog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<NoviProjekat.Data.EntityModels.Artikal>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(60, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\hasic_000\Desktop\NoviProjekat - Copy\NoviProjekat.Web\Views\Artikli\Katalog.cshtml"
  
    ViewData["Title"] = "Katalog";

#line default
#line hidden
            BeginContext(105, 22, true);
            WriteLiteral("\r\n<h2>Katalog</h2>\r\n\r\n");
            EndContext();
#line 9 "C:\Users\hasic_000\Desktop\NoviProjekat - Copy\NoviProjekat.Web\Views\Artikli\Katalog.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
            BeginContext(160, 359, true);
            WriteLiteral(@"    <br />
    <div class=""mobitel-katalog"" style=""width:100%;height:170px;border-bottom:solid 2px grey;"">
        <div class=""slika-mob"" style=""display: flex; justify-content: center;float:left;height:150px;border:solid lightgrey 1px;width:20%"">
            <img style=""height:150px;border:solid lightgrey 0px;float:left"" class=""img-responsive full-width""");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 519, "\"", 583, 2);
            WriteAttributeValue("", 525, "data:image/jpeg;base64,", 525, 23, true);
#line 14 "C:\Users\hasic_000\Desktop\NoviProjekat - Copy\NoviProjekat.Web\Views\Artikli\Katalog.cshtml"
WriteAttributeValue("", 548, Convert.ToBase64String(item.Slika), 548, 35, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(584, 168, true);
            WriteLiteral(" />\r\n\r\n        </div>\r\n        <div class=\"naslov-mob\" style=\"float:left;height:150px;background:white;width:60%\">\r\n            <h3 style=\"margin:0 0 0 15px;\">Artikal: ");
            EndContext();
            BeginContext(753, 10, false);
#line 18 "C:\Users\hasic_000\Desktop\NoviProjekat - Copy\NoviProjekat.Web\Views\Artikli\Katalog.cshtml"
                                               Write(item.Naziv);

#line default
#line hidden
            EndContext();
            BeginContext(763, 71, true);
            WriteLiteral("</h3>\r\n            <h4 style=\"margin:0 0 0 15px;top:0px;\">Proizvodjac: ");
            EndContext();
            BeginContext(835, 28, false);
#line 19 "C:\Users\hasic_000\Desktop\NoviProjekat - Copy\NoviProjekat.Web\Views\Artikli\Katalog.cshtml"
                                                           Write(item.Model.Proizvodjac.Naziv);

#line default
#line hidden
            EndContext();
            BeginContext(863, 65, true);
            WriteLiteral("</h4>\r\n            <h4 style=\"margin:0 0 0 15px;top:0px;\">Model: ");
            EndContext();
            BeginContext(929, 16, false);
#line 20 "C:\Users\hasic_000\Desktop\NoviProjekat - Copy\NoviProjekat.Web\Views\Artikli\Katalog.cshtml"
                                                     Write(item.Model.Naziv);

#line default
#line hidden
            EndContext();
            BeginContext(945, 64, true);
            WriteLiteral("</h4>\r\n            <h4 style=\"margin:0 0 0 15px;top:0px;\">Boja: ");
            EndContext();
            BeginContext(1010, 9, false);
#line 21 "C:\Users\hasic_000\Desktop\NoviProjekat - Copy\NoviProjekat.Web\Views\Artikli\Katalog.cshtml"
                                                    Write(item.Boja);

#line default
#line hidden
            EndContext();
            BeginContext(1019, 136, true);
            WriteLiteral("</h4>\r\n\r\n            <img style=\"height:50px;border:solid lightgrey 0px;float:left;margin:0 0 0 15px;\" class=\"img-responsive full-width\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1155, "\"", 1237, 2);
            WriteAttributeValue("", 1161, "data:image/jpeg;base64,", 1161, 23, true);
#line 23 "C:\Users\hasic_000\Desktop\NoviProjekat - Copy\NoviProjekat.Web\Views\Artikli\Katalog.cshtml"
WriteAttributeValue("", 1184, Convert.ToBase64String(item.Model.Proizvodjac.Slika), 1184, 53, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1238, 7, true);
            WriteLiteral(" />\r\n\r\n");
            EndContext();
            BeginContext(1329, 188, true);
            WriteLiteral("        </div>\r\n        <div class=\"cijena-mob\" style=\"background:Gainsboro;float:left;height:150px;border:thin grey 1px;width:20%\">\r\n            <h2 style=\"margin:15px 0 0 15px;top:0px;\">");
            EndContext();
            BeginContext(1518, 11, false);
#line 28 "C:\Users\hasic_000\Desktop\NoviProjekat - Copy\NoviProjekat.Web\Views\Artikli\Katalog.cshtml"
                                                 Write(item.Cijena);

#line default
#line hidden
            EndContext();
            BeginContext(1529, 10, true);
            WriteLiteral(" KM</h2>\r\n");
            EndContext();
#line 29 "C:\Users\hasic_000\Desktop\NoviProjekat - Copy\NoviProjekat.Web\Views\Artikli\Katalog.cshtml"
             if (item.Novo == true)
            {

#line default
#line hidden
            BeginContext(1591, 125, true);
            WriteLiteral("                <p style=\"float:left;margin-top:20%;width:100%;font-size:25px;background:center green;color:white\">NOVO</p>\r\n");
            EndContext();
#line 32 "C:\Users\hasic_000\Desktop\NoviProjekat - Copy\NoviProjekat.Web\Views\Artikli\Katalog.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(1764, 127, true);
            WriteLiteral("                <p style=\"float:left;margin-top:20%;width:100%;font-size:25px;background:center grey;color:black\">POLOVNO</p>\r\n");
            EndContext();
#line 36 "C:\Users\hasic_000\Desktop\NoviProjekat - Copy\NoviProjekat.Web\Views\Artikli\Katalog.cshtml"


            }

#line default
#line hidden
            BeginContext(1910, 22, true);
            WriteLiteral("        </div>\r\n\r\n\r\n\r\n");
            EndContext();
            BeginContext(2902, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 62 "C:\Users\hasic_000\Desktop\NoviProjekat - Copy\NoviProjekat.Web\Views\Artikli\Katalog.cshtml"


}

#line default
#line hidden
            BeginContext(2923, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<NoviProjekat.Data.EntityModels.Artikal>> Html { get; private set; }
    }
}
#pragma warning restore 1591
