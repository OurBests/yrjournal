#pragma checksum "/home/momtaheni/sources/yr/yrjournal/Views/Journal/JournalDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "649ec3e5c0481142dd728b4b7743616b4e548b68"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Journal_JournalDetails), @"mvc.1.0.view", @"/Views/Journal/JournalDetails.cshtml")]
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
#line 1 "/home/momtaheni/sources/yr/yrjournal/Views/_ViewImports.cshtml"
using yrjournal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/momtaheni/sources/yr/yrjournal/Views/_ViewImports.cshtml"
using yrjournal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"649ec3e5c0481142dd728b4b7743616b4e548b68", @"/Views/Journal/JournalDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab413565ebfeb8bd39756734796d8553f9128ef6", @"/Views/_ViewImports.cshtml")]
    public class Views_Journal_JournalDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<JournalModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/logo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/home/momtaheni/sources/yr/yrjournal/Views/Journal/JournalDetails.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("<style>\n    *{\n        text-align: center;\n    }\n</style>\n<div class=\"row\">\n    <div class=\"col-md-3\"></div>\n    <div class=\"col-md-6\">\n        <h1 class=\"rows-title\" style=\"border: 0;\">ژورنال معاملاتی</h2>\n    </div>\n    <div class=\"col-md-3\">\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "649ec3e5c0481142dd728b4b7743616b4e548b684198", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </div>\n</div>\n    <div class=\"row part-mt1\">\n        <h2 class=\"rows-title first-info-title\">اطلاعات اولیه</h2>\n    </div>\n    <div class=\"row\">\n        <div class=\"col-md-3\">\n            <dt>جفت ارز</dt>\n            <dd>");
#nullable restore
#line 25 "/home/momtaheni/sources/yr/yrjournal/Views/Journal/JournalDetails.cshtml"
           Write(Model.PairName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\n        </div>\n        <div class=\"col-md-3\">\n            <dt for=\"Quantity\">حجم معامله</dt>\n            <dd>");
#nullable restore
#line 29 "/home/momtaheni/sources/yr/yrjournal/Views/Journal/JournalDetails.cshtml"
           Write(Model.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\n        </div>\n        <div class=\"col-md-3\">\n            <dt for=\"Type\" class=\"eng-txt\">Long/Short</dt>\n            <dd>");
#nullable restore
#line 33 "/home/momtaheni/sources/yr/yrjournal/Views/Journal/JournalDetails.cshtml"
           Write(Model.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\n        </div>\n        <div class=\"col-md-3\">\n            <dt for=\"PL\">نتیجه: سود/ضرر (درصد)</dt>\n            <dd>");
#nullable restore
#line 37 "/home/momtaheni/sources/yr/yrjournal/Views/Journal/JournalDetails.cshtml"
           Write(Model.PL);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</dd>
        </div>
    </div>
    <div class=""row  part-mt1"">
        <div class=""col-md-6"">
            <div class=""row"">
                <h2 class=""rows-title eng-txt"">Signal</h2>
            </div>
            <div class=""row"">
                <div class=""col-md-4"">
                    <dt for=""SignalTimeFrame"" class=""eng-txt"">Time Frame</dt>
                    <dd>");
#nullable restore
#line 48 "/home/momtaheni/sources/yr/yrjournal/Views/Journal/JournalDetails.cshtml"
                   Write(Model.SignalTimeFrame);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\n                </div>\n                <div class=\"col-md-4\">\n                    <dt for=\"MainSignal\">سیگنال اصلی</dt>\n                    <dd>");
#nullable restore
#line 52 "/home/momtaheni/sources/yr/yrjournal/Views/Journal/JournalDetails.cshtml"
                   Write(Model.MainSignal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\n                </div>\n                <div class=\"col-md-4\">\n                    <dt for=\"ConfirmationSignal\">سیگنال فرعی</dt>\n                    <dd>");
#nullable restore
#line 56 "/home/momtaheni/sources/yr/yrjournal/Views/Journal/JournalDetails.cshtml"
                   Write(Model.ConfirmationSignal);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</dd>
                </div>
            </div>
        </div>
        <div class=""col-md-6"">
            <div class=""row"">
                <h2 class=""rows-title eng-txt"">Entry</h2>
            </div>
            <div class=""row"">
                <div class=""col-md-6"">
                    <dt for=""EntryTimeFrame"" class=""eng-txt"">Time Frame</dt>
                    <dd>");
#nullable restore
#line 67 "/home/momtaheni/sources/yr/yrjournal/Views/Journal/JournalDetails.cshtml"
                   Write(Model.EntryTimeFrame);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\n                </div>\n                <div class=\"col-md-6\" style=\"text-align: center;\">\n                    <dt for=\"E1\">E1</dt>\n                    <dd>");
#nullable restore
#line 71 "/home/momtaheni/sources/yr/yrjournal/Views/Journal/JournalDetails.cshtml"
                   Write(Model.EntryPhase);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</dd>
                </div>
                
            </div>
        </div>
    </div>
    <div class=""row  part-mt1"">
        <div class=""col-md-6"">
            <div class=""row"">
                <h2 class=""rows-title eng-txt"">Money Management</h2>
            </div>
            <div class=""row"">
                <div class=""col-md-6"">
                    <dt for=""RR"" class=""eng-txt"">R:R</dt>
                    <dd>");
#nullable restore
#line 85 "/home/momtaheni/sources/yr/yrjournal/Views/Journal/JournalDetails.cshtml"
                   Write(Model.RR);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\n                </div>\n                <div class=\"col-md-6\">\n                    <dt for=\"MoneyPercent\">درصد سرمایه</dt>\n                    <dd>");
#nullable restore
#line 89 "/home/momtaheni/sources/yr/yrjournal/Views/Journal/JournalDetails.cshtml"
                   Write(Model.MoneyPercent);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</dd>
                </div>
            </div>
        </div>
        <div class=""col-md-6"">
            <div class=""row"">
                <h2 class=""rows-title eng-txt"">Trade Management</h2>
            </div>
            <div class=""row"">
                <div class=""col-md-6"">
                    <dt for=""RiskFree"" class=""eng-txt"">RiskFree</dt>
                    <dd>");
#nullable restore
#line 100 "/home/momtaheni/sources/yr/yrjournal/Views/Journal/JournalDetails.cshtml"
                   Write(Model.RiskFree);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\n                </div>\n                <div class=\"col-md-6\">\n                    <dt for=\"TrendFollowing\" class=\"eng-txt\">TrendFollowing</dt>\n                    <dd>");
#nullable restore
#line 104 "/home/momtaheni/sources/yr/yrjournal/Views/Journal/JournalDetails.cshtml"
                   Write(Model.TrendFollowing);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\n                </div>\n            </div>\n        </div>\n    </div>\n    <div class=\"row  part-mt1\">\n        <div class=\"col-md-6\">\n            <img");
            BeginWriteAttribute("src", " src=\"", 3651, "\"", 3691, 2);
            WriteAttributeValue("", 3657, "data:image/png;base64,", 3657, 22, true);
#nullable restore
#line 111 "/home/momtaheni/sources/yr/yrjournal/Views/Journal/JournalDetails.cshtml"
WriteAttributeValue(" ", 3679, Model.File, 3680, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width: 100%;\">\n        </div>\n        <div class=\"col-md-6\">\n            <dt for=\"Description\">توضیحات بیشتر</dt>\n            <dd>");
#nullable restore
#line 115 "/home/momtaheni/sources/yr/yrjournal/Views/Journal/JournalDetails.cshtml"
           Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\n        </div>\n    </div>\n    <div class=\"row part-mt1\">\n        <div class=\"col-md-12\">\n            <a href=\"javascript: window.print();\" type=\"submit\" class=\"btn btn-success\" style=\"float: left;\">چاپ</a>\n        </div>\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<JournalModel> Html { get; private set; }
    }
}
#pragma warning restore 1591