#pragma checksum "C:\Users\ASUS\Desktop\StartBootStrap\StartBootStrap-backend\StartBootstrap\StartBootstrap\Views\Shared\_PortfolioPartialViewModal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0978c17bba39e4e340d5b5bfc0aa37b7219f39b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__PortfolioPartialViewModal), @"mvc.1.0.view", @"/Views/Shared/_PortfolioPartialViewModal.cshtml")]
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
#line 1 "C:\Users\ASUS\Desktop\StartBootStrap\StartBootStrap-backend\StartBootstrap\StartBootstrap\Views\_ViewImports.cshtml"
using StartBootstrap;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ASUS\Desktop\StartBootStrap\StartBootStrap-backend\StartBootstrap\StartBootstrap\Views\_ViewImports.cshtml"
using StartBootstrap.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ASUS\Desktop\StartBootStrap\StartBootStrap-backend\StartBootstrap\StartBootstrap\Views\_ViewImports.cshtml"
using StartBootstrap.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0978c17bba39e4e340d5b5bfc0aa37b7219f39b", @"/Views/Shared/_PortfolioPartialViewModal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dfc1b7d4d2afeba770da5a7117f4bab6e559caff", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__PortfolioPartialViewModal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Portfolio>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<div class=\"modal-body text-center\">\r\n    <h5 class=\"modal-title\">");
#nullable restore
#line 4 "C:\Users\ASUS\Desktop\StartBootStrap\StartBootStrap-backend\StartBootstrap\StartBootstrap\Views\Shared\_PortfolioPartialViewModal.cshtml"
                       Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
    <div class=""delete-btn"" style=""position:absolute; left:863px; top:20px; font-size:64px; cursor:pointer"">
        <i class=""fas fa-times""></i>
    </div>
    <div class=""star-logo"">
        <i class=""fas fa-star""></i>
    </div>
    <div class=""pc-box"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e0978c17bba39e4e340d5b5bfc0aa37b7219f39b4544", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 387, "~/uploads/portfolios/", 387, 21, true);
#nullable restore
#line 12 "C:\Users\ASUS\Desktop\StartBootStrap\StartBootStrap-backend\StartBootstrap\StartBootstrap\Views\Shared\_PortfolioPartialViewModal.cshtml"
AddHtmlAttributeValue("", 408, Model.Image, 408, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n    <div class=\"desc\">\r\n        <p>\r\n           ");
#nullable restore
#line 16 "C:\Users\ASUS\Desktop\StartBootStrap\StartBootStrap-backend\StartBootstrap\StartBootstrap\Views\Shared\_PortfolioPartialViewModal.cshtml"
      Write(Model.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </p>\r\n    </div>\r\n</div>\r\n<div class=\"modal-footer\">\r\n    <button type=\"button\" style=\"cursor:pointer\" class=\"btn btn-secondary close-btn\" data-dismiss=\"modal\"><i class=\"fas fa-times\"></i>Close Window</button>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Portfolio> Html { get; private set; }
    }
}
#pragma warning restore 1591
