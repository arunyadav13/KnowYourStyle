#pragma checksum "D:\Project\KnowYourStyle\SimplCommerce-master\SimplCommerce-master\src\Modules\SimplCommerce.Module.Cms\Areas\Cms\Views\Shared\Components\Menu\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eede8cdb9bd0c2bb275fb1e680dbe6b416f35e90"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Cms_Views_Shared_Components_Menu_Default), @"mvc.1.0.view", @"/Areas/Cms/Views/Shared/Components/Menu/Default.cshtml")]
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
#line 1 "D:\Project\KnowYourStyle\SimplCommerce-master\SimplCommerce-master\src\Modules\SimplCommerce.Module.Cms\Areas\Cms\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eede8cdb9bd0c2bb275fb1e680dbe6b416f35e90", @"/Areas/Cms/Views/Shared/Components/Menu/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6e487af9f599b2cd461681599ad34205d5bca37", @"/Areas/Cms/Views/_ViewImports.cshtml")]
    public class Areas_Cms_Views_Shared_Components_Menu_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SimplCommerce.Module.Cms.Areas.Cms.ViewModels.MenuItemVm>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<ul class=\"list-unstyled\">\n");
#nullable restore
#line 4 "D:\Project\KnowYourStyle\SimplCommerce-master\SimplCommerce-master\src\Modules\SimplCommerce.Module.Cms\Areas\Cms\Views\Shared\Components\Menu\Default.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>\n            <a");
            BeginWriteAttribute("href", " href=\"", 171, "\"", 188, 1);
#nullable restore
#line 7 "D:\Project\KnowYourStyle\SimplCommerce-master\SimplCommerce-master\src\Modules\SimplCommerce.Module.Cms\Areas\Cms\Views\Shared\Components\Menu\Default.cshtml"
WriteAttributeValue("", 178, item.Link, 178, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 7 "D:\Project\KnowYourStyle\SimplCommerce-master\SimplCommerce-master\src\Modules\SimplCommerce.Module.Cms\Areas\Cms\Views\Shared\Components\Menu\Default.cshtml"
                            Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n");
#nullable restore
#line 8 "D:\Project\KnowYourStyle\SimplCommerce-master\SimplCommerce-master\src\Modules\SimplCommerce.Module.Cms\Areas\Cms\Views\Shared\Components\Menu\Default.cshtml"
              if (item.ChildItems.Any())
             {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <ul>\n");
#nullable restore
#line 11 "D:\Project\KnowYourStyle\SimplCommerce-master\SimplCommerce-master\src\Modules\SimplCommerce.Module.Cms\Areas\Cms\Views\Shared\Components\Menu\Default.cshtml"
                     foreach (var childItem in item.ChildItems)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li><a");
            BeginWriteAttribute("href", " href=\"", 398, "\"", 420, 1);
#nullable restore
#line 13 "D:\Project\KnowYourStyle\SimplCommerce-master\SimplCommerce-master\src\Modules\SimplCommerce.Module.Cms\Areas\Cms\Views\Shared\Components\Menu\Default.cshtml"
WriteAttributeValue("", 405, childItem.Link, 405, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 13 "D:\Project\KnowYourStyle\SimplCommerce-master\SimplCommerce-master\src\Modules\SimplCommerce.Module.Cms\Areas\Cms\Views\Shared\Components\Menu\Default.cshtml"
                                                 Write(childItem.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\n");
#nullable restore
#line 14 "D:\Project\KnowYourStyle\SimplCommerce-master\SimplCommerce-master\src\Modules\SimplCommerce.Module.Cms\Areas\Cms\Views\Shared\Components\Menu\Default.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ul>\n");
#nullable restore
#line 16 "D:\Project\KnowYourStyle\SimplCommerce-master\SimplCommerce-master\src\Modules\SimplCommerce.Module.Cms\Areas\Cms\Views\Shared\Components\Menu\Default.cshtml"
             }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </li>\n");
#nullable restore
#line 18 "D:\Project\KnowYourStyle\SimplCommerce-master\SimplCommerce-master\src\Modules\SimplCommerce.Module.Cms\Areas\Cms\Views\Shared\Components\Menu\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SimplCommerce.Module.Cms.Areas.Cms.ViewModels.MenuItemVm>> Html { get; private set; }
    }
}
#pragma warning restore 1591
