#pragma checksum "D:\Project\KnowYourStyle\SimplCommerce-master\SimplCommerce-master\src\SimplCommerce.WebHost\Themes\CozaStore\Areas\Cms\Views\Shared\Components\CarouselWidget\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e6f04249ad72a368fef2bade89cf15affd8374ee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Themes_CozaStore_Areas_Cms_Views_Shared_Components_CarouselWidget_Default), @"mvc.1.0.view", @"/Themes/CozaStore/Areas/Cms/Views/Shared/Components/CarouselWidget/Default.cshtml")]
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
#line 1 "D:\Project\KnowYourStyle\SimplCommerce-master\SimplCommerce-master\src\SimplCommerce.WebHost\Themes\CozaStore\Areas\Cms\Views\_ViewImports.cshtml"
using SimplCommerce.Module.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Project\KnowYourStyle\SimplCommerce-master\SimplCommerce-master\src\SimplCommerce.WebHost\Themes\CozaStore\Areas\Cms\Views\_ViewImports.cshtml"
using SimplCommerce.Module.Core.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Project\KnowYourStyle\SimplCommerce-master\SimplCommerce-master\src\SimplCommerce.WebHost\Themes\CozaStore\Areas\Cms\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Project\KnowYourStyle\SimplCommerce-master\SimplCommerce-master\src\SimplCommerce.WebHost\Themes\CozaStore\Areas\Cms\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6f04249ad72a368fef2bade89cf15affd8374ee", @"/Themes/CozaStore/Areas/Cms/Views/Shared/Components/CarouselWidget/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba3df763d46145e8aecf63071a1b14a43e233cf1", @"/Themes/CozaStore/Areas/Cms/Views/_ViewImports.cshtml")]
    public class Themes_CozaStore_Areas_Cms_Views_Shared_Components_CarouselWidget_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SimplCommerce.Module.Cms.Areas.Cms.ViewModels.CarouselWidgetViewComponentVm>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "D:\Project\KnowYourStyle\SimplCommerce-master\SimplCommerce-master\src\SimplCommerce.WebHost\Themes\CozaStore\Areas\Cms\Views\Shared\Components\CarouselWidget\Default.cshtml"
  
    var effects = new string[] { "fadeInDown", "fadeInUp", "zoomIn", "rollIn", "lightSpeedIn", "slideInUp", "rotateInDownLeft", "rotateInUpRight", "rotateIn" };
    var numEffects = effects.Length - 1;
    var random = new Random();

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<section class=\"section-slide\">\n    <div class=\"wrap-slick1\">\n        <div class=\"slick1\">\n");
#nullable restore
#line 12 "D:\Project\KnowYourStyle\SimplCommerce-master\SimplCommerce-master\src\SimplCommerce.WebHost\Themes\CozaStore\Areas\Cms\Views\Shared\Components\CarouselWidget\Default.cshtml"
             foreach (var item in Model.Items)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"item-slick1\"");
            BeginWriteAttribute("style", " style=\"", 515, "\"", 558, 4);
            WriteAttributeValue("", 523, "background-image:", 523, 17, true);
            WriteAttributeValue(" ", 540, "url(", 541, 5, true);
#nullable restore
#line 14 "D:\Project\KnowYourStyle\SimplCommerce-master\SimplCommerce-master\src\SimplCommerce.WebHost\Themes\CozaStore\Areas\Cms\Views\Shared\Components\CarouselWidget\Default.cshtml"
WriteAttributeValue("", 545, item.Image, 545, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 556, ");", 556, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\n                    <div class=\"container h-full\">\n                        <div class=\"flex-col-l-m h-full p-t-100 p-b-30 respon5\">\n                            <div class=\"layer-slick1 animated visible-false\" data-appear=\"");
#nullable restore
#line 17 "D:\Project\KnowYourStyle\SimplCommerce-master\SimplCommerce-master\src\SimplCommerce.WebHost\Themes\CozaStore\Areas\Cms\Views\Shared\Components\CarouselWidget\Default.cshtml"
                                                                                     Write(effects[random.Next(0, numEffects)]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-delay=\"0\">\n                                <span class=\"ltext-101 cl2 respon2\">\n                                    ");
#nullable restore
#line 19 "D:\Project\KnowYourStyle\SimplCommerce-master\SimplCommerce-master\src\SimplCommerce.WebHost\Themes\CozaStore\Areas\Cms\Views\Shared\Components\CarouselWidget\Default.cshtml"
                               Write(item.SubCaption);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </span>\n                            </div>\n\n                            <div class=\"layer-slick1 animated visible-false\" data-appear=\"");
#nullable restore
#line 23 "D:\Project\KnowYourStyle\SimplCommerce-master\SimplCommerce-master\src\SimplCommerce.WebHost\Themes\CozaStore\Areas\Cms\Views\Shared\Components\CarouselWidget\Default.cshtml"
                                                                                     Write(effects[random.Next(0, numEffects)]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-delay=\"800\">\n                                <h2 class=\"ltext-201 cl2 p-t-19 p-b-43 respon1\">");
#nullable restore
#line 24 "D:\Project\KnowYourStyle\SimplCommerce-master\SimplCommerce-master\src\SimplCommerce.WebHost\Themes\CozaStore\Areas\Cms\Views\Shared\Components\CarouselWidget\Default.cshtml"
                                                                           Write(item.Caption);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n                            </div>\n\n                            <div class=\"layer-slick1 animated visible-false\" data-appear=\"");
#nullable restore
#line 27 "D:\Project\KnowYourStyle\SimplCommerce-master\SimplCommerce-master\src\SimplCommerce.WebHost\Themes\CozaStore\Areas\Cms\Views\Shared\Components\CarouselWidget\Default.cshtml"
                                                                                     Write(effects[random.Next(0, numEffects)]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-delay=\"1600\">\n                                <a");
            BeginWriteAttribute("href", " href=\"", 1497, "\"", 1519, 1);
#nullable restore
#line 28 "D:\Project\KnowYourStyle\SimplCommerce-master\SimplCommerce-master\src\SimplCommerce.WebHost\Themes\CozaStore\Areas\Cms\Views\Shared\Components\CarouselWidget\Default.cshtml"
WriteAttributeValue("", 1504, item.TargetUrl, 1504, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"flex-c-m stext-101 cl0 size-101 bg1 bor1 hov-btn1 p-lr-15 trans-04\">\n                                    ");
#nullable restore
#line 29 "D:\Project\KnowYourStyle\SimplCommerce-master\SimplCommerce-master\src\SimplCommerce.WebHost\Themes\CozaStore\Areas\Cms\Views\Shared\Components\CarouselWidget\Default.cshtml"
                               Write(item.LinkText);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </a>\n                            </div>\n                        </div>\n                    </div>\n                </div>\n");
#nullable restore
#line 35 "D:\Project\KnowYourStyle\SimplCommerce-master\SimplCommerce-master\src\SimplCommerce.WebHost\Themes\CozaStore\Areas\Cms\Views\Shared\Components\CarouselWidget\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\n    </div>\n</section>");
        }
        #pragma warning restore 1998
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SimplCommerce.Module.Cms.Areas.Cms.ViewModels.CarouselWidgetViewComponentVm> Html { get; private set; }
    }
}
#pragma warning restore 1591