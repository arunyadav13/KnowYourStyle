#pragma checksum "D:\Project\KnowYourStyle\SimplCommerce-master\SimplCommerce-master\src\Modules\SimplCommerce.Module.Payments\Areas\Payments\Views\Checkout\Payment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b3c893543f8a476fa904c8f6f29e02127f57ddb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Payments_Views_Checkout_Payment), @"mvc.1.0.view", @"/Areas/Payments/Views/Checkout/Payment.cshtml")]
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
#line 1 "D:\Project\KnowYourStyle\SimplCommerce-master\SimplCommerce-master\src\Modules\SimplCommerce.Module.Payments\Areas\Payments\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Project\KnowYourStyle\SimplCommerce-master\SimplCommerce-master\src\Modules\SimplCommerce.Module.Payments\Areas\Payments\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b3c893543f8a476fa904c8f6f29e02127f57ddb", @"/Areas/Payments/Views/Checkout/Payment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dfe26aff0bbdcef08ea5c392043aec87db666b39", @"/Areas/Payments/Views/_ViewImports.cshtml")]
    public class Areas_Payments_Views_Checkout_Payment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SimplCommerce.Module.Payments.Areas.Payments.ViewModels.CheckoutPaymentForm>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Checkout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Cancel", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("logoutForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "D:\Project\KnowYourStyle\SimplCommerce-master\SimplCommerce-master\src\Modules\SimplCommerce.Module.Payments\Areas\Payments\Views\Checkout\Payment.cshtml"
  
    ViewBag.Title = "Payment Information";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"row\">\n    <div class=\"col-md-8\">\n");
#nullable restore
#line 9 "D:\Project\KnowYourStyle\SimplCommerce-master\SimplCommerce-master\src\Modules\SimplCommerce.Module.Payments\Areas\Payments\Views\Checkout\Payment.cshtml"
         if (TempData["Error"] != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"alert alert-danger\" role=\"alert\">");
#nullable restore
#line 11 "D:\Project\KnowYourStyle\SimplCommerce-master\SimplCommerce-master\src\Modules\SimplCommerce.Module.Payments\Areas\Payments\Views\Checkout\Payment.cshtml"
                                                    Write(TempData["Error"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n");
#nullable restore
#line 12 "D:\Project\KnowYourStyle\SimplCommerce-master\SimplCommerce-master\src\Modules\SimplCommerce.Module.Payments\Areas\Payments\Views\Checkout\Payment.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div id=\"paymentError\" class=\"alert alert-danger d-none\" role=\"alert\"></div>\n        <h3>");
#nullable restore
#line 14 "D:\Project\KnowYourStyle\SimplCommerce-master\SimplCommerce-master\src\Modules\SimplCommerce.Module.Payments\Areas\Payments\Views\Checkout\Payment.cshtml"
       Write(Localizer["Choose a payment methods"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n        <div class=\"row\">\n");
#nullable restore
#line 16 "D:\Project\KnowYourStyle\SimplCommerce-master\SimplCommerce-master\src\Modules\SimplCommerce.Module.Payments\Areas\Payments\Views\Checkout\Payment.cshtml"
             foreach (var paymentProvider in Model.PaymentProviders)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-sm-12 col-md-6\">\n                    <div");
            BeginWriteAttribute("class", " class=\"", 643, "\"", 701, 3);
            WriteAttributeValue("", 651, "payment-method", 651, 14, true);
            WriteAttributeValue(" ", 665, "paymentProvider-", 666, 17, true);
#nullable restore
#line 19 "D:\Project\KnowYourStyle\SimplCommerce-master\SimplCommerce-master\src\Modules\SimplCommerce.Module.Payments\Areas\Payments\Views\Checkout\Payment.cshtml"
WriteAttributeValue("", 682, paymentProvider.Id, 682, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n");
#nullable restore
#line 20 "D:\Project\KnowYourStyle\SimplCommerce-master\SimplCommerce-master\src\Modules\SimplCommerce.Module.Payments\Areas\Payments\Views\Checkout\Payment.cshtml"
                         if (!string.IsNullOrWhiteSpace(paymentProvider.LandingViewComponentName))
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "D:\Project\KnowYourStyle\SimplCommerce-master\SimplCommerce-master\src\Modules\SimplCommerce.Module.Payments\Areas\Payments\Views\Checkout\Payment.cshtml"
                       Write(await Component.InvokeAsync(paymentProvider.LandingViewComponentName));

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "D:\Project\KnowYourStyle\SimplCommerce-master\SimplCommerce-master\src\Modules\SimplCommerce.Module.Payments\Areas\Payments\Views\Checkout\Payment.cshtml"
                                                                                                  
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\n                </div>\n");
#nullable restore
#line 26 "D:\Project\KnowYourStyle\SimplCommerce-master\SimplCommerce-master\src\Modules\SimplCommerce.Module.Payments\Areas\Payments\Views\Checkout\Payment.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\n        <div class=\"text-right\">\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b3c893543f8a476fa904c8f6f29e02127f57ddb9887", async() => {
                WriteLiteral("\n                <button type=\"submit\" class=\"btn btn-secondary active\">");
#nullable restore
#line 30 "D:\Project\KnowYourStyle\SimplCommerce-master\SimplCommerce-master\src\Modules\SimplCommerce.Module.Payments\Areas\Payments\Views\Checkout\Payment.cshtml"
                                                                  Write(Localizer["Cancel Order"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</button>\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        </div>\n    </div>\n    <div class=\"col-md-4\">\n        ");
#nullable restore
#line 35 "D:\Project\KnowYourStyle\SimplCommerce-master\SimplCommerce-master\src\Modules\SimplCommerce.Module.Payments\Areas\Payments\Views\Checkout\Payment.cshtml"
   Write(await Component.InvokeAsync("OrderSummary"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SimplCommerce.Module.Payments.Areas.Payments.ViewModels.CheckoutPaymentForm> Html { get; private set; }
    }
}
#pragma warning restore 1591