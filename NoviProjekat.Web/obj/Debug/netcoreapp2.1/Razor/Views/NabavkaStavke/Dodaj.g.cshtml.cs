#pragma checksum "C:\Users\hasic_000\Desktop\NoviProjekat - Copy\NoviProjekat.Web\Views\NabavkaStavke\Dodaj.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ec76182125bfa1f1f6c2f3d41919136b4491bd2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_NabavkaStavke_Dodaj), @"mvc.1.0.view", @"/Views/NabavkaStavke/Dodaj.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/NabavkaStavke/Dodaj.cshtml", typeof(AspNetCore.Views_NabavkaStavke_Dodaj))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ec76182125bfa1f1f6c2f3d41919136b4491bd2", @"/Views/NabavkaStavke/Dodaj.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64bea66b5b10d5dcb2e9880e52115b00d6e674d4", @"/Views/_ViewImports.cshtml")]
    public class Views_NabavkaStavke_Dodaj : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NoviProjekat.Web.ViewModels.NabavkaStavkeDodajVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formaId"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\hasic_000\Desktop\NoviProjekat - Copy\NoviProjekat.Web\Views\NabavkaStavke\Dodaj.cshtml"
  
    ViewData["Title"] = "Dodaj";

#line default
#line hidden
            BeginContext(98, 53, true);
            WriteLiteral("\r\n<h2>Dodaj novi ili uredi postojeci artikal</h2>\r\n\r\n");
            EndContext();
            BeginContext(151, 813, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "759c0e3c80d14c579703b5e722202d65", async() => {
                BeginContext(170, 26, true);
                WriteLiteral("\r\n    <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 196, "\"", 220, 1);
#line 9 "C:\Users\hasic_000\Desktop\NoviProjekat - Copy\NoviProjekat.Web\Views\NabavkaStavke\Dodaj.cshtml"
WriteAttributeValue("", 204, Model.NabavkaId, 204, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(221, 46, true);
                WriteLiteral(" name=\"NabavkaId\" />\r\n    <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 267, "\"", 284, 1);
#line 10 "C:\Users\hasic_000\Desktop\NoviProjekat - Copy\NoviProjekat.Web\Views\NabavkaStavke\Dodaj.cshtml"
WriteAttributeValue("", 275, Model.Id, 275, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(285, 98, true);
                WriteLiteral(" name=\"Id\" />\r\n\r\n    <br />\r\n    <label>Artikal: </label>\r\n    <select name=\"ArtikalId\">\r\n        ");
                EndContext();
                BeginContext(383, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "82db346524934ea7bf4583a4d9e3cad3", async() => {
                    BeginContext(391, 19, true);
                    WriteLiteral("(Odaberite artikal)");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(419, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 16 "C:\Users\hasic_000\Desktop\NoviProjekat - Copy\NoviProjekat.Web\Views\NabavkaStavke\Dodaj.cshtml"
         foreach (SelectListItem x in Model.artikli)
        {
            if (x.Value == Model.ArtikalId.ToString())
            {

#line default
#line hidden
                BeginContext(557, 16, true);
                WriteLiteral("                ");
                EndContext();
                BeginContext(573, 50, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b5aa76ff2bbc4f879f470e7923c6c578", async() => {
                    BeginContext(608, 6, false);
#line 20 "C:\Users\hasic_000\Desktop\NoviProjekat - Copy\NoviProjekat.Web\Views\NabavkaStavke\Dodaj.cshtml"
                                             Write(x.Text);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 20 "C:\Users\hasic_000\Desktop\NoviProjekat - Copy\NoviProjekat.Web\Views\NabavkaStavke\Dodaj.cshtml"
                   WriteLiteral(x.Value);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(623, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 21 "C:\Users\hasic_000\Desktop\NoviProjekat - Copy\NoviProjekat.Web\Views\NabavkaStavke\Dodaj.cshtml"
            }
            else
            {

#line default
#line hidden
                BeginContext(673, 16, true);
                WriteLiteral("                ");
                EndContext();
                BeginContext(689, 41, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f3cbf64535b243abb0f261a2261f3914", async() => {
                    BeginContext(715, 6, false);
#line 24 "C:\Users\hasic_000\Desktop\NoviProjekat - Copy\NoviProjekat.Web\Views\NabavkaStavke\Dodaj.cshtml"
                                    Write(x.Text);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 24 "C:\Users\hasic_000\Desktop\NoviProjekat - Copy\NoviProjekat.Web\Views\NabavkaStavke\Dodaj.cshtml"
                   WriteLiteral(x.Value);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(730, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 25 "C:\Users\hasic_000\Desktop\NoviProjekat - Copy\NoviProjekat.Web\Views\NabavkaStavke\Dodaj.cshtml"
            }

        }

#line default
#line hidden
                BeginContext(760, 197, true);
                WriteLiteral("\r\n    </select>\r\n    <div>\r\n        <label>Kolicina: </label><input type=\"text\" name=\"Kolicina\" />\r\n    </div>\r\n    <br />\r\n    <br />\r\n    <input id=\"submitButton\" type=\"submit\" value=\"Snimi\" />\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(964, 384, true);
            WriteLiteral(@"

<script>

    $(""#submitButton"").click(function (event) {

        var forma = $(""#formaId"");
        $.ajax({

            type: ""POST"",
            url: ""/NabavkaStavke/Snimi"",
            data: forma.serialize(),
            success: function (rezultat) {
                $(""#neki"").html(rezultat);
            }
        }
        );
    });

</script>



");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NoviProjekat.Web.ViewModels.NabavkaStavkeDodajVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
