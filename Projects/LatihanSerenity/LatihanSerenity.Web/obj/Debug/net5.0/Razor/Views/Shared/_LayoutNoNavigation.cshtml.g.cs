#pragma checksum "C:\Projects\LatihanSerenity\LatihanSerenity.Web\Views\Shared\_LayoutNoNavigation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f22be8b12e471b594fde6b5de2d844f7124f336"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__LayoutNoNavigation), @"mvc.1.0.view", @"/Views/Shared/_LayoutNoNavigation.cshtml")]
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
#line 1 "C:\Projects\LatihanSerenity\LatihanSerenity.Web\Views\_ViewImports.cshtml"
using Serenity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projects\LatihanSerenity\LatihanSerenity.Web\Views\_ViewImports.cshtml"
using Serenity.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Projects\LatihanSerenity\LatihanSerenity.Web\Views\_ViewImports.cshtml"
using LatihanSerenity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Projects\LatihanSerenity\LatihanSerenity.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f22be8b12e471b594fde6b5de2d844f7124f336", @"/Views/Shared/_LayoutNoNavigation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b20d2901909a5dbdccdfcb1b2d7d9d244d5dbc4", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__LayoutNoNavigation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n");
#nullable restore
#line 2 "C:\Projects\LatihanSerenity\LatihanSerenity.Web\Views\Shared\_LayoutNoNavigation.cshtml"
  
var rtl = System.Globalization.CultureInfo.CurrentUICulture.TextInfo.IsRightToLeft;

#line default
#line hidden
#nullable disable
            WriteLiteral("<html");
            BeginWriteAttribute("lang", " lang=\"", 114, "\"", 176, 1);
#nullable restore
#line 5 "C:\Projects\LatihanSerenity\LatihanSerenity.Web\Views\Shared\_LayoutNoNavigation.cshtml"
WriteAttributeValue("", 121, System.Globalization.CultureInfo.CurrentUICulture.Name, 121, 55, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
#nullable restore
#line 5 "C:\Projects\LatihanSerenity\LatihanSerenity.Web\Views\Shared\_LayoutNoNavigation.cshtml"
                                                               Write(Html.Raw(rtl ? " dir=\"rtl\"" : ""));

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9f22be8b12e471b594fde6b5de2d844f7124f3364762", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9f22be8b12e471b594fde6b5de2d844f7124f3365024", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 7 "C:\Projects\LatihanSerenity\LatihanSerenity.Web\Views\Shared\_LayoutNoNavigation.cshtml"
       WriteLiteral(MVC.Views.Shared._LayoutHead);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("name", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
#nullable restore
#line 8 "C:\Projects\LatihanSerenity\LatihanSerenity.Web\Views\Shared\_LayoutNoNavigation.cshtml"
Write(RenderSection("Head", false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <title>");
#nullable restore
#line 9 "C:\Projects\LatihanSerenity\LatihanSerenity.Web\Views\Shared\_LayoutNoNavigation.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9f22be8b12e471b594fde6b5de2d844f7124f3367884", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 12 "C:\Projects\LatihanSerenity\LatihanSerenity.Web\Views\Shared\_LayoutNoNavigation.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 371, "s-", 371, 2, true);
#nullable restore
#line 11 "C:\Projects\LatihanSerenity\LatihanSerenity.Web\Views\Shared\_LayoutNoNavigation.cshtml"
AddHtmlAttributeValue("", 373, ViewData["PageId"], 373, 21, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 394, "Page", 394, 4, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 11 "C:\Projects\LatihanSerenity\LatihanSerenity.Web\Views\Shared\_LayoutNoNavigation.cshtml"
AddHtmlAttributeValue("", 407, ViewData["BodyClass"], 407, 24, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue(" ", 431, "no-navigation", 432, 14, true);
#nullable restore
#line 11 "C:\Projects\LatihanSerenity\LatihanSerenity.Web\Views\Shared\_LayoutNoNavigation.cshtml"
AddHtmlAttributeValue("", 445, rtl ? " rtl" : "", 445, 20, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
