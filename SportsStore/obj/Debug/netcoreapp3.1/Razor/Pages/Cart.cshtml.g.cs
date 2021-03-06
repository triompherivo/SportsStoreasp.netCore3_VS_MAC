#pragma checksum "/Users/triompheramandalahy/SportsSln/SportsStore/Pages/Cart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f87f2f56c7133a369137e3308dda9693d7e7618"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SportsStore.Pages.Pages_Cart), @"mvc.1.0.razor-page", @"/Pages/Cart.cshtml")]
namespace SportsStore.Pages
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
#line 2 "/Users/triompheramandalahy/SportsSln/SportsStore/Pages/_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.RazorPages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/triompheramandalahy/SportsSln/SportsStore/Pages/_ViewImports.cshtml"
using SportsStore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/triompheramandalahy/SportsSln/SportsStore/Pages/_ViewImports.cshtml"
using SportsStore.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/triompheramandalahy/SportsSln/SportsStore/Pages/Cart.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f87f2f56c7133a369137e3308dda9693d7e7618", @"/Pages/Cart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c065e169b12813b7dcf60612fc7f261b652eda50", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Cart : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "Remove", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Checkout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<h2>Your cart</h2>\n<table class=\"table table-bordered table-striped\">\n    <thead> <tr>\n        <th>Quantity</th>\n        <th>Item</th>\n        <th class=\"text-right\">Price</th> <th class=\"text-right\">Subtotal</th>\n    </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 14 "/Users/triompheramandalahy/SportsSln/SportsStore/Pages/Cart.cshtml"
     foreach (var line in Model.Cart.Lines) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td class=\"text-center\">");
#nullable restore
#line 16 "/Users/triompheramandalahy/SportsSln/SportsStore/Pages/Cart.cshtml"
                               Write(line.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td class=\"text-left\">");
#nullable restore
#line 17 "/Users/triompheramandalahy/SportsSln/SportsStore/Pages/Cart.cshtml"
                             Write(line.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td class=\"text-right\">");
#nullable restore
#line 18 "/Users/triompheramandalahy/SportsSln/SportsStore/Pages/Cart.cshtml"
                              Write(line.Product.Price.ToString("C",new CultureInfo("fr-FR")));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td> <td class=\"text-right\">\n                ");
#nullable restore
#line 19 "/Users/triompheramandalahy/SportsSln/SportsStore/Pages/Cart.cshtml"
            Write((line.Quantity * line.Product.Price).ToString("C",new CultureInfo("fr-FR")));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\n            <td class=\"text-center\">\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f87f2f56c7133a369137e3308dda9693d7e76186903", async() => {
                WriteLiteral("\n            <input type=\"hidden\" name=\"ProductID\"");
                BeginWriteAttribute("value", " value=\"", 843, "\"", 874, 1);
#nullable restore
#line 22 "/Users/triompheramandalahy/SportsSln/SportsStore/Pages/Cart.cshtml"
WriteAttributeValue("", 851, line.Product.ProductID, 851, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n            <input type=\"hidden\" name=\"returnUrl\"");
                BeginWriteAttribute("value", " value=\"", 928, "\"", 952, 1);
#nullable restore
#line 23 "/Users/triompheramandalahy/SportsSln/SportsStore/Pages/Cart.cshtml"
WriteAttributeValue("", 936, Model.ReturnUrl, 936, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n            <button type=\"submit\" class=\"btn btn-sm btn-danger\"> Remove\n                                    </button>\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.PageHandler = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            </td>\n        </tr> ");
#nullable restore
#line 28 "/Users/triompheramandalahy/SportsSln/SportsStore/Pages/Cart.cshtml"
              }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n    <tfoot>\n    <tr>\n        <td colspan=\"3\" class=\"text-right\">Total:</td> <td class=\"text-right\">\n            ");
#nullable restore
#line 33 "/Users/triompheramandalahy/SportsSln/SportsStore/Pages/Cart.cshtml"
       Write(Model.Cart.ComputeTotalValue().ToString("C",new CultureInfo("fr-FR")));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\n    </tr>\n    </tfoot>\n</table>\n<div class=\"text-center\">\n    <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 1439, "\"", 1462, 1);
#nullable restore
#line 38 "/Users/triompheramandalahy/SportsSln/SportsStore/Pages/Cart.cshtml"
WriteAttributeValue("", 1446, Model.ReturnUrl, 1446, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Continue shopping</a>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f87f2f56c7133a369137e3308dda9693d7e761810591", async() => {
                WriteLiteral("\n            Checkout\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CartModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CartModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CartModel>)PageContext?.ViewData;
        public CartModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
