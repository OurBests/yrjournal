#pragma checksum "/home/momtaheni/sources/yr/yrjournal/Views/Journal/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a8580fbc035d32afca0ce62defbf35534f97729"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Journal_Index), @"mvc.1.0.view", @"/Views/Journal/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a8580fbc035d32afca0ce62defbf35534f97729", @"/Views/Journal/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab413565ebfeb8bd39756734796d8553f9128ef6", @"/Views/_ViewImports.cshtml")]
    public class Views_Journal_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/logo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Journal/JournalDetails"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/home/momtaheni/sources/yr/yrjournal/Views/Journal/Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\">\n    <div class=\"col-md-3\"></div>\n    <div class=\"col-md-6\">\n        <h1 class=\"rows-title\" style=\"border: 0;\">ژورنال معاملاتی</h2>\n    </div>\n    <div class=\"col-md-3\">\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1a8580fbc035d32afca0ce62defbf35534f977295373", async() => {
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
            WriteLiteral("\n    </div>\n</div>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a8580fbc035d32afca0ce62defbf35534f977296489", async() => {
                WriteLiteral(@"
    <div class=""row part-mt1"">
        <h2 class=""rows-title"">اطلاعات اولیه</h2>
    </div>
    <div class=""row"">
        <div class=""col-md-3"">
            <label for=""PairName"">جفت ارز</label>
            <input type=""text"" class=""form-control"" id=""PairName"" name=""PairName"">
        </div>
        <div class=""col-md-3"">
            <label for=""Quantity"">حجم معامله</label>
            <input type=""text"" class=""form-control"" id=""Quantity"" name=""Quantity"">
        </div>
        <div class=""col-md-3"">
            <label for=""Type"" class=""eng-txt"">Long/Short</label>
            <input type=""text"" class=""form-control"" id=""Type"" name=""Type"">
        </div>
        <div class=""col-md-3"">
            <label for=""PL"">نتیجه: سود/ضرر (درصد)</label>
            <input type=""text"" class=""form-control"" id=""PL"" name=""PL"">
        </div>
    </div>
    <div class=""row  part-mt1"">
        <div class=""col-md-6"">
            <div class=""row"">
                <h2 class=""rows-title eng-txt"">Signal</h2>
            </div>
     ");
                WriteLiteral(@"       <div class=""row"">
                <div class=""col-md-4"">
                    <label for=""SignalTimeFrame"" class=""eng-txt"">Time Frame</label>
                    <input type=""text"" class=""form-control"" id=""SignalTimeFrame"" name=""SignalTimeFrame"">
                </div>
                <div class=""col-md-4"">
                    <label for=""MainSignal"">سیگنال اصلی</label>
                    <input type=""text"" class=""form-control"" id=""MainSignal"" name=""MainSignal"">
                </div>
                <div class=""col-md-4"">
                    <label for=""ConfirmationSignal"">سیگنال فرعی</label>
                    <input type=""text"" class=""form-control"" id=""ConfirmationSignal"" name=""ConfirmationSignal"">
                </div>
            </div>
        </div>
        <div class=""col-md-6"">
            <div class=""row"">
                <h2 class=""rows-title eng-txt"">Entry</h2>
            </div>
            <div class=""row"">
                <div class=""col-md-4"">
                    <label for=""EntryTime");
                WriteLiteral(@"Frame"" class=""eng-txt"">Time Frame</label>
                    <input type=""text"" class=""form-control"" id=""EntryTimeFrame"" name=""EntryTimeFrame"">
                </div>
                <div class=""col-md-2"" style=""text-align: center;"">
                    <label for=""E1"">E1</label>
                    <input type=""radio"" value=""E1"" id=""E1"" class=""form-control"" name=""EntryPhase""> 
                </div>
                <div class=""col-md-2"" style=""text-align: center;"">
                    <label for=""E2"">E2</label>
                    <input type=""radio"" value=""E2"" id=""E2"" class=""form-control"" name=""EntryPhase"">
                </div>
                <div class=""col-md-2"" style=""text-align: center;"">
                    <label for=""E3"">E3</label>
                    <input type=""radio"" value=""E3"" id=""E3"" class=""form-control"" name=""EntryPhase"">
                </div>
                <div class=""col-md-2"" style=""text-align: center;"">
                    <label for=""E4"">E4</label>
                    <input type=""");
                WriteLiteral(@"radio"" value=""E4"" id=""E4"" class=""form-control"" name=""EntryPhase"">
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
                    <label for=""RR"" class=""eng-txt"">R:R</label>
                    <input type=""text"" class=""form-control"" id=""RR"" name=""RR"">
                </div>
                <div class=""col-md-6"">
                    <label for=""MoneyPercent"">درصد سرمایه</label>
                    <input type=""text"" class=""form-control"" id=""MoneyPercent"" name=""MoneyPercent"">
                </div>
            </div>
        </div>
        <div class=""col-md-6"">
            <div class=""row"">
                <h2 class=""rows-title eng-txt"">Trade Management</h2>
            </div>
            <div class=""row"">
                <div class=""col-md");
                WriteLiteral(@"-6"">
                    <label for=""RiskFree"" class=""eng-txt"">RiskFree</label>
                    <input type=""text"" class=""form-control"" id=""RiskFree"" name=""RiskFree"">
                </div>
                <div class=""col-md-6"">
                    <label for=""TrendFollowing"" class=""eng-txt"">TrendFollowing</label>
                    <input type=""text"" class=""form-control"" id=""TrendFollowing"" name=""TrendFollowing"">
                </div>
            </div>
        </div>
    </div>
    <div class=""row  part-mt1"">
         <div class=""col-md-4"">
            <label for=""pics"">تصاویر</label>
            <input type=""file"" name=""pics"" id=""pics"">
        </div>
        <div class=""col-md-8"">
            <label for=""Description"">توضیحات بیشتر</label>
            <textarea name=""Description"" class=""form-control"" id=""Description""></textarea>
        </div>
    </div>
    <div class=""row part-mt1"">
        <div class=""col-md-12"">
            <button type=""submit"" class=""btn btn-primary"" style=""float: left;"">ثبت و ");
                WriteLiteral("دریافت</button>\n        </div>\n    </div>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
