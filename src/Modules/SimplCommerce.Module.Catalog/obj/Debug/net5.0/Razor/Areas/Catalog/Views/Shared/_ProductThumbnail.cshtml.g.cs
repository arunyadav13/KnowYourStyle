#pragma checksum "D:\Project\KnowYourStyle\SimplCommerce-master\SimplCommerce-master\src\Modules\SimplCommerce.Module.Catalog\Areas\Catalog\Views\Shared\_ProductThumbnail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9f49a2868e019ebd665c1de91d0071c8a80d821"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Catalog_Views_Shared__ProductThumbnail), @"mvc.1.0.view", @"/Areas/Catalog/Views/Shared/_ProductThumbnail.cshtml")]
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
#line 1 "D:\Project\KnowYourStyle\SimplCommerce-master\SimplCommerce-master\src\Modules\SimplCommerce.Module.Catalog\Areas\Catalog\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Project\KnowYourStyle\SimplCommerce-master\SimplCommerce-master\src\Modules\SimplCommerce.Module.Catalog\Areas\Catalog\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Project\KnowYourStyle\SimplCommerce-master\SimplCommerce-master\src\Modules\SimplCommerce.Module.Catalog\Areas\Catalog\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9f49a2868e019ebd665c1de91d0071c8a80d821", @"/Areas/Catalog/Views/Shared/_ProductThumbnail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"538836bd7b7402d98e6a00e670f64f36420bffff", @"/Areas/Catalog/Views/_ViewImports.cshtml")]
    public class Areas_Catalog_Views_Shared__ProductThumbnail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SimplCommerce.Module.Catalog.Areas.Catalog.ViewModels.ProductThumbnail>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div class=\"card mb-4\">\n    <input type=\"hidden\" id=\"productId\"");
            BeginWriteAttribute("value", " value=\"", 142, "\"", 159, 1);
#nullable restore
#line 4 "D:\Project\KnowYourStyle\SimplCommerce-master\SimplCommerce-master\src\Modules\SimplCommerce.Module.Catalog\Areas\Catalog\Views\Shared\_ProductThumbnail.cshtml"
WriteAttributeValue("", 150, Model.Id, 150, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b9f49a2868e019ebd665c1de91d0071c8a80d8214317", async() => {
                WriteLiteral("\n        <img");
                BeginWriteAttribute("alt", " alt=\"", 205, "\"", 222, 1);
#nullable restore
#line 6 "D:\Project\KnowYourStyle\SimplCommerce-master\SimplCommerce-master\src\Modules\SimplCommerce.Module.Catalog\Areas\Catalog\Views\Shared\_ProductThumbnail.cshtml"
WriteAttributeValue("", 211, Model.Name, 211, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"card-img-top\"");
                BeginWriteAttribute("src", " src=\"", 244, "\"", 269, 1);
#nullable restore
#line 6 "D:\Project\KnowYourStyle\SimplCommerce-master\SimplCommerce-master\src\Modules\SimplCommerce.Module.Catalog\Areas\Catalog\Views\Shared\_ProductThumbnail.cshtml"
WriteAttributeValue("", 250, Model.ThumbnailUrl, 250, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n        <div class=\"card-body\">\n            <h5 class=\"card-title product-name\">");
#nullable restore
#line 8 "D:\Project\KnowYourStyle\SimplCommerce-master\SimplCommerce-master\src\Modules\SimplCommerce.Module.Catalog\Areas\Catalog\Views\Shared\_ProductThumbnail.cshtml"
                                           Write(Model.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\n            <p class=\"card-text product-price\">\n");
#nullable restore
#line 10 "D:\Project\KnowYourStyle\SimplCommerce-master\SimplCommerce-master\src\Modules\SimplCommerce.Module.Catalog\Areas\Catalog\Views\Shared\_ProductThumbnail.cshtml"
                 if (Model.IsCallForPricing)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Project\KnowYourStyle\SimplCommerce-master\SimplCommerce-master\src\Modules\SimplCommerce.Module.Catalog\Areas\Catalog\Views\Shared\_ProductThumbnail.cshtml"
               Write(Localizer["Call for pricing"]);

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Project\KnowYourStyle\SimplCommerce-master\SimplCommerce-master\src\Modules\SimplCommerce.Module.Catalog\Areas\Catalog\Views\Shared\_ProductThumbnail.cshtml"
                                                  
                }
                else
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\Project\KnowYourStyle\SimplCommerce-master\SimplCommerce-master\src\Modules\SimplCommerce.Module.Catalog\Areas\Catalog\Views\Shared\_ProductThumbnail.cshtml"
               Write(Model.CalculatedProductPrice.PriceString);

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\Project\KnowYourStyle\SimplCommerce-master\SimplCommerce-master\src\Modules\SimplCommerce.Module.Catalog\Areas\Catalog\Views\Shared\_ProductThumbnail.cshtml"
                                                             
                    if (Model.CalculatedProductPrice.PercentOfSaving > 0)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <span class=\"product-price-saving\">-");
#nullable restore
#line 19 "D:\Project\KnowYourStyle\SimplCommerce-master\SimplCommerce-master\src\Modules\SimplCommerce.Module.Catalog\Areas\Catalog\Views\Shared\_ProductThumbnail.cshtml"
                                                        Write(Model.CalculatedProductPrice.PercentOfSaving);

#line default
#line hidden
#nullable disable
                WriteLiteral("%</span>\n                        <br />\n                        <span class=\"product-price-regular\">");
#nullable restore
#line 21 "D:\Project\KnowYourStyle\SimplCommerce-master\SimplCommerce-master\src\Modules\SimplCommerce.Module.Catalog\Areas\Catalog\Views\Shared\_ProductThumbnail.cshtml"
                                                       Write(Model.CalculatedProductPrice.OldPriceString);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\n");
#nullable restore
#line 22 "D:\Project\KnowYourStyle\SimplCommerce-master\SimplCommerce-master\src\Modules\SimplCommerce.Module.Catalog\Areas\Catalog\Views\Shared\_ProductThumbnail.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </p>\n            <ul class=\"list-inline product-ratings\">\n                <li><input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 1155, "\"", 1183, 1);
#nullable restore
#line 26 "D:\Project\KnowYourStyle\SimplCommerce-master\SimplCommerce-master\src\Modules\SimplCommerce.Module.Catalog\Areas\Catalog\Views\Shared\_ProductThumbnail.cshtml"
WriteAttributeValue("", 1163, Model.RatingAverage, 1163, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" readonly=\"readonly\" class=\"rating-loading\" step=\"1\" data-size=\"xs\" data-show-clear=\"false\" data-show-caption=\"false\" /></li>\n");
#nullable restore
#line 27 "D:\Project\KnowYourStyle\SimplCommerce-master\SimplCommerce-master\src\Modules\SimplCommerce.Module.Catalog\Areas\Catalog\Views\Shared\_ProductThumbnail.cshtml"
                 if (Model.ReviewsCount > 0)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <li class=\"product-review-list\">\n                        <span>(");
#nullable restore
#line 30 "D:\Project\KnowYourStyle\SimplCommerce-master\SimplCommerce-master\src\Modules\SimplCommerce.Module.Catalog\Areas\Catalog\Views\Shared\_ProductThumbnail.cshtml"
                          Write(Model.ReviewsCount);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 30 "D:\Project\KnowYourStyle\SimplCommerce-master\SimplCommerce-master\src\Modules\SimplCommerce.Module.Catalog\Areas\Catalog\Views\Shared\_ProductThumbnail.cshtml"
                                              Write(Localizer["reviews"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(")</span>\n                    </li>\n");
#nullable restore
#line 32 "D:\Project\KnowYourStyle\SimplCommerce-master\SimplCommerce-master\src\Modules\SimplCommerce.Module.Catalog\Areas\Catalog\Views\Shared\_ProductThumbnail.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </ul>\n\n        </div>\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 177, "~/", 177, 2, true);
#nullable restore
#line 5 "D:\Project\KnowYourStyle\SimplCommerce-master\SimplCommerce-master\src\Modules\SimplCommerce.Module.Catalog\Areas\Catalog\Views\Shared\_ProductThumbnail.cshtml"
AddHtmlAttributeValue("", 179, Model.Slug, 179, 11, false);

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
            WriteLiteral("\n</div>\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IConfiguration AppSetting { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer Localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SimplCommerce.Module.Catalog.Areas.Catalog.ViewModels.ProductThumbnail> Html { get; private set; }
    }
}
#pragma warning restore 1591
