#pragma checksum "/home/momtaheni/sources/yr/yrjournal/Views/Journal/AllJournals.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6bea3540f8073fe68291e29defcd48b106c254b8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Journal_AllJournals), @"mvc.1.0.view", @"/Views/Journal/AllJournals.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bea3540f8073fe68291e29defcd48b106c254b8", @"/Views/Journal/AllJournals.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab413565ebfeb8bd39756734796d8553f9128ef6", @"/Views/_ViewImports.cshtml")]
    public class Views_Journal_AllJournals : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<System.Collections.Generic.List<yrjournal.Models.JournalModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/home/momtaheni/sources/yr/yrjournal/Views/Journal/AllJournals.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""row"">
    <div class=""table-responsive"">
    <table class=""table table-striped"">
        <thead>
            <tr>
             <th>معامله گر</th>
             <th>جفت ارز</th>
             <th>حجم</th>
             <th>Long/Short</th>
             <th>سود/ضرر</th>
             <th>تایم فریم سیگنال</th>
             <th>سیگنال اصلی</th>
             <th>سیگنال فرعی</th>
             <th>تایم فریم ورود</th>
             <th>E1 - E4</th>
             <th>توضیحات</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 24 "/home/momtaheni/sources/yr/yrjournal/Views/Journal/AllJournals.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                    <td>");
#nullable restore
#line 27 "/home/momtaheni/sources/yr/yrjournal/Views/Journal/AllJournals.cshtml"
                    Write(item.UserEmail.Split("@")[0]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 28 "/home/momtaheni/sources/yr/yrjournal/Views/Journal/AllJournals.cshtml"
                   Write(item.PairName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 29 "/home/momtaheni/sources/yr/yrjournal/Views/Journal/AllJournals.cshtml"
                   Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 30 "/home/momtaheni/sources/yr/yrjournal/Views/Journal/AllJournals.cshtml"
                   Write(item.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 31 "/home/momtaheni/sources/yr/yrjournal/Views/Journal/AllJournals.cshtml"
                   Write(item.PL);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 32 "/home/momtaheni/sources/yr/yrjournal/Views/Journal/AllJournals.cshtml"
                   Write(item.SignalTimeFrame);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 33 "/home/momtaheni/sources/yr/yrjournal/Views/Journal/AllJournals.cshtml"
                   Write(item.MainSignal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 34 "/home/momtaheni/sources/yr/yrjournal/Views/Journal/AllJournals.cshtml"
                   Write(item.ConfirmationSignal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 35 "/home/momtaheni/sources/yr/yrjournal/Views/Journal/AllJournals.cshtml"
                   Write(item.EntryTimeFrame);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 36 "/home/momtaheni/sources/yr/yrjournal/Views/Journal/AllJournals.cshtml"
                   Write(item.EntryPhase);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 1220, "\"", 1263, 2);
            WriteAttributeValue("", 1227, "/Journal/JournalDetailsById/", 1227, 28, true);
#nullable restore
#line 37 "/home/momtaheni/sources/yr/yrjournal/Views/Journal/AllJournals.cshtml"
WriteAttributeValue("", 1255, item.Id, 1255, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\">جزئیات</a></td>\n                </tr>\n");
#nullable restore
#line 39 "/home/momtaheni/sources/yr/yrjournal/Views/Journal/AllJournals.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\n    </table>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<System.Collections.Generic.List<yrjournal.Models.JournalModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
