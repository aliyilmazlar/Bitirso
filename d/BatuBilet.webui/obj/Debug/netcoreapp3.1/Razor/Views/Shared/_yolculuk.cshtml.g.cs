#pragma checksum "\\Mac\Home\Documents\GitHub\Bitirso\d\BatuBilet.webui\Views\Shared\_yolculuk.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5164b25e80fb12076561486a85b237c70a215811"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__yolculuk), @"mvc.1.0.view", @"/Views/Shared/_yolculuk.cshtml")]
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
#line 1 "\\Mac\Home\Documents\GitHub\Bitirso\d\BatuBilet.webui\Views\_ViewImports.cshtml"
using BatuBilet.webui;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "\\Mac\Home\Documents\GitHub\Bitirso\d\BatuBilet.webui\Views\_ViewImports.cshtml"
using batubilet.entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "\\Mac\Home\Documents\GitHub\Bitirso\d\BatuBilet.webui\Views\_ViewImports.cshtml"
using BatuBilet.webui.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5164b25e80fb12076561486a85b237c70a215811", @"/Views/Shared/_yolculuk.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb8e011a337a17a3ea0d9b1d995932761674ebbb", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__yolculuk : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Guzergah>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-title"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Yolculuk", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("text-decoration:none; font-size:24px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"card mb-4 mt-3 shadow\">\r\n    \r\n    <div class=\"card-body\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5164b25e80fb12076561486a85b237c70a2158115121", async() => {
#nullable restore
#line 6 "\\Mac\Home\Documents\GitHub\Bitirso\d\BatuBilet.webui\Views\Shared\_yolculuk.cshtml"
                                                                                                                                                       Write(Model.Baslangic);

#line default
#line hidden
#nullable disable
                WriteLiteral(" <i class=\"fas fa-long-arrow-alt-right\"></i> ");
#nullable restore
#line 6 "\\Mac\Home\Documents\GitHub\Bitirso\d\BatuBilet.webui\Views\Shared\_yolculuk.cshtml"
                                                                                                                                                                                                                    Write(Model.Bitis);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 6 "\\Mac\Home\Documents\GitHub\Bitirso\d\BatuBilet.webui\Views\Shared\_yolculuk.cshtml"
                                                                               WriteLiteral(Model.GuzergahId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        <p class=\"card-text\"><b style=\"font-size:19px;\">Güzergah:</b>  ");
#nullable restore
#line 7 "\\Mac\Home\Documents\GitHub\Bitirso\d\BatuBilet.webui\Views\Shared\_yolculuk.cshtml"
                                                                  Write(Model.Baslangic);

#line default
#line hidden
#nullable disable
            WriteLiteral(" > ");
#nullable restore
#line 7 "\\Mac\Home\Documents\GitHub\Bitirso\d\BatuBilet.webui\Views\Shared\_yolculuk.cshtml"
                                                                                     Write(Model.gz1);

#line default
#line hidden
#nullable disable
            WriteLiteral(" > ");
#nullable restore
#line 7 "\\Mac\Home\Documents\GitHub\Bitirso\d\BatuBilet.webui\Views\Shared\_yolculuk.cshtml"
                                                                                                  Write(Model.gz2);

#line default
#line hidden
#nullable disable
            WriteLiteral(" > ");
#nullable restore
#line 7 "\\Mac\Home\Documents\GitHub\Bitirso\d\BatuBilet.webui\Views\Shared\_yolculuk.cshtml"
                                                                                                               Write(Model.gz3);

#line default
#line hidden
#nullable disable
            WriteLiteral(" > ");
#nullable restore
#line 7 "\\Mac\Home\Documents\GitHub\Bitirso\d\BatuBilet.webui\Views\Shared\_yolculuk.cshtml"
                                                                                                                            Write(Model.Bitis);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p><br />\r\n\r\n        <p style=\" font-size:24px; text-align:center;\">\r\n            <b>");
#nullable restore
#line 10 "\\Mac\Home\Documents\GitHub\Bitirso\d\BatuBilet.webui\Views\Shared\_yolculuk.cshtml"
          Write(Model.Tarih);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </b>\r\n            - ");
#nullable restore
#line 11 "\\Mac\Home\Documents\GitHub\Bitirso\d\BatuBilet.webui\Views\Shared\_yolculuk.cshtml"
         Write(Model.Saat);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </p>\r\n\r\n        \r\n    </div>\r\n    <div class=\"card-footer text-center\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5164b25e80fb12076561486a85b237c70a21581110795", async() => {
                WriteLiteral("İncele");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 17 "\\Mac\Home\Documents\GitHub\Bitirso\d\BatuBilet.webui\Views\Shared\_yolculuk.cshtml"
                                                            WriteLiteral(Model.GuzergahId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        \r\n    </div>\r\n</div>   ");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Guzergah> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
