#pragma checksum "C:\Users\hasic_000\Desktop\NoviProjekat - Copy\NoviProjekat.Web\Views\ServisStavke\Uradi.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7028bd25bc040fa301f364c04aa45f329cc69574"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ServisStavke_Uradi), @"mvc.1.0.view", @"/Views/ServisStavke/Uradi.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ServisStavke/Uradi.cshtml", typeof(AspNetCore.Views_ServisStavke_Uradi))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7028bd25bc040fa301f364c04aa45f329cc69574", @"/Views/ServisStavke/Uradi.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64bea66b5b10d5dcb2e9880e52115b00d6e674d4", @"/Views/_ViewImports.cshtml")]
    public class Views_ServisStavke_Uradi : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NoviProjekat.Web.ViewModels.ServisStavkeUradiVM>
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
#line 2 "C:\Users\hasic_000\Desktop\NoviProjekat - Copy\NoviProjekat.Web\Views\ServisStavke\Uradi.cshtml"
  
    ViewData["Title"] = "Dodaj";

#line default
#line hidden
            BeginContext(97, 60, true);
            WriteLiteral("\r\n<h2>Dodaj novi ili uredi postojeci rad na servisu</h2>\r\n\r\n");
            EndContext();
            BeginContext(157, 1008, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "09717b2d1c7d4e82929d629145efc5ec", async() => {
                BeginContext(176, 26, true);
                WriteLiteral("\r\n    <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 202, "\"", 225, 1);
#line 9 "C:\Users\hasic_000\Desktop\NoviProjekat - Copy\NoviProjekat.Web\Views\ServisStavke\Uradi.cshtml"
WriteAttributeValue("", 210, Model.ServisId, 210, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(226, 45, true);
                WriteLiteral(" name=\"ServisId\" />\r\n    <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 271, "\"", 288, 1);
#line 10 "C:\Users\hasic_000\Desktop\NoviProjekat - Copy\NoviProjekat.Web\Views\ServisStavke\Uradi.cshtml"
WriteAttributeValue("", 279, Model.Id, 279, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(289, 69, true);
                WriteLiteral(" name=\"Id\" />\r\n\r\n    <br />\r\n    <select name=\"ServiserId\">\r\n        ");
                EndContext();
                BeginContext(358, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b3bbadb1f9bb4ec586407a5e1276bdc0", async() => {
                    BeginContext(366, 21, true);
                    WriteLiteral("(Odaberite Servisera)");
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
                BeginContext(396, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 15 "C:\Users\hasic_000\Desktop\NoviProjekat - Copy\NoviProjekat.Web\Views\ServisStavke\Uradi.cshtml"
         foreach (SelectListItem x in Model.serviseri)
        {
            if (x.Value == Model.ServiserId.ToString())
            {

#line default
#line hidden
                BeginContext(537, 16, true);
                WriteLiteral("                ");
                EndContext();
                BeginContext(553, 50, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7aafb73f10544abfa332546781d1bc42", async() => {
                    BeginContext(588, 6, false);
#line 19 "C:\Users\hasic_000\Desktop\NoviProjekat - Copy\NoviProjekat.Web\Views\ServisStavke\Uradi.cshtml"
                                             Write(x.Text);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 19 "C:\Users\hasic_000\Desktop\NoviProjekat - Copy\NoviProjekat.Web\Views\ServisStavke\Uradi.cshtml"
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
                BeginContext(603, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 20 "C:\Users\hasic_000\Desktop\NoviProjekat - Copy\NoviProjekat.Web\Views\ServisStavke\Uradi.cshtml"
            }
            else
            {

#line default
#line hidden
                BeginContext(653, 16, true);
                WriteLiteral("                ");
                EndContext();
                BeginContext(669, 41, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eb2ef9bda60c456ebbcfae8eccbaa6c8", async() => {
                    BeginContext(695, 6, false);
#line 23 "C:\Users\hasic_000\Desktop\NoviProjekat - Copy\NoviProjekat.Web\Views\ServisStavke\Uradi.cshtml"
                                    Write(x.Text);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 23 "C:\Users\hasic_000\Desktop\NoviProjekat - Copy\NoviProjekat.Web\Views\ServisStavke\Uradi.cshtml"
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
                BeginContext(710, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 24 "C:\Users\hasic_000\Desktop\NoviProjekat - Copy\NoviProjekat.Web\Views\ServisStavke\Uradi.cshtml"
            }

        }

#line default
#line hidden
                BeginContext(740, 418, true);
                WriteLiteral(@"    </select>
    <br />
    <br />
    <label>Unesite opis rada: </label>
    <input type=""text"" name=""Opis"" />
    <br />
    <label>Unesite datum zavrsetka rada: </label>
    <input type=""datetime"" name=""DatumZavrsetkaPosla"" />
    <br />
    <label>Unesite cijenu: </label>
    <input type=""text"" name=""Cijena"" />


    <br />
    <br />
    <input id=""submitButton"" type=""submit"" value=""Snimi"" />
");
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
            BeginContext(1165, 31, true);
            WriteLiteral("\r\n\r\n<script>\r\n\r\n    rootUrl = \'");
            EndContext();
            BeginContext(1197, 16, false);
#line 47 "C:\Users\hasic_000\Desktop\NoviProjekat - Copy\NoviProjekat.Web\Views\ServisStavke\Uradi.cshtml"
          Write(Url.Content("~"));

#line default
#line hidden
            EndContext();
            BeginContext(1213, 374, true);
            WriteLiteral(@"'
    $(""#submitButton"").click(function (event) {

        var forma = $(""#formaId"");
        $.ajax({

            type: ""POST"",
            url: rootUrl + ""/ServisStavke/Snimi"",
            data: forma.serialize(),
            success: function (rezultat) {
                $(""#nekiId"").html(rezultat);
            }
        }
        );
    });

</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NoviProjekat.Web.ViewModels.ServisStavkeUradiVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
