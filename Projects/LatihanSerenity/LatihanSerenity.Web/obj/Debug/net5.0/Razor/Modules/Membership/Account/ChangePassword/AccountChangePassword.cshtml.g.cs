#pragma checksum "C:\Projects\LatihanSerenity\LatihanSerenity.Web\Modules\Membership\Account\ChangePassword\AccountChangePassword.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc1ee2f8470eb870c3e0387f26f3be276e54de4d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Modules_Membership_Account_ChangePassword_AccountChangePassword), @"mvc.1.0.view", @"/Modules/Membership/Account/ChangePassword/AccountChangePassword.cshtml")]
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
#line 1 "C:\Projects\LatihanSerenity\LatihanSerenity.Web\Modules\_ViewImports.cshtml"
using Serenity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projects\LatihanSerenity\LatihanSerenity.Web\Modules\_ViewImports.cshtml"
using Serenity.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Projects\LatihanSerenity\LatihanSerenity.Web\Modules\_ViewImports.cshtml"
using LatihanSerenity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Projects\LatihanSerenity\LatihanSerenity.Web\Modules\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Projects\LatihanSerenity\LatihanSerenity.Web\Modules\_ViewImports.cshtml"
using System.Text;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc1ee2f8470eb870c3e0387f26f3be276e54de4d", @"/Modules/Membership/Account/ChangePassword/AccountChangePassword.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"def08078d1da0787400e886902d7ee22dbf964ac", @"/Modules/_ViewImports.cshtml")]
    public class Modules_Membership_Account_ChangePassword_AccountChangePassword : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Projects\LatihanSerenity\LatihanSerenity.Web\Modules\Membership\Account\ChangePassword\AccountChangePassword.cshtml"
  
    ViewData["Title"] = Texts.Forms.Membership.ChangePassword.FormTitle.ToString(Localizer);
    ViewData["PageId"] = "ChangePassword";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<script id=\"Template_Membership_ChangePasswordPanel\" type=\"text/template\">\r\n<div>\r\n    <h3 class=\"page-title\">");
#nullable restore
#line 9 "C:\Projects\LatihanSerenity\LatihanSerenity.Web\Modules\Membership\Account\ChangePassword\AccountChangePassword.cshtml"
                      Write(Texts.Forms.Membership.ChangePassword.FormTitle.ToString(Localizer));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
    <form id=""~_Form"" action="""">
        <div class=""s-Form"">
            <div class=""fieldset ui-widget ui-widget-content ui-corner-all"">
                <div id=""~_PropertyGrid""></div>
                <div class=""clear""></div>
            </div>
            <div class=""buttons"">
                <button id=""~_SubmitButton"" type=""submit"" class=""btn btn-primary"">
                    ");
#nullable restore
#line 18 "C:\Projects\LatihanSerenity\LatihanSerenity.Web\Modules\Membership\Account\ChangePassword\AccountChangePassword.cshtml"
               Write(Texts.Forms.Membership.ChangePassword.SubmitButton.ToString(Localizer));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </button>
            </div>
        </div>
    </form>
</div>
</script>

<div class=""page-content"">
    <div id=""ChangePasswordPanel"">
    </div>
</div>

<script type=""text/javascript"">
$(function() {
    new LatihanSerenity.Membership.ChangePasswordPanel($('#ChangePasswordPanel')).init();
});
</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Serenity.ITextLocalizer Localizer { get; private set; }
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
