#pragma checksum "C:\Users\Eagha\Desktop\CodeLessons\P201\ASP\Pustok\49. 20-12-2021\PustokP201\PustokP201\Views\Shared\_BookTabSlider.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "872c0f5e49098795b05b16e17ff0736dfae306b1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__BookTabSlider), @"mvc.1.0.view", @"/Views/Shared/_BookTabSlider.cshtml")]
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
#line 1 "C:\Users\Eagha\Desktop\CodeLessons\P201\ASP\Pustok\49. 20-12-2021\PustokP201\PustokP201\Views\_ViewImports.cshtml"
using PustokP201;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Eagha\Desktop\CodeLessons\P201\ASP\Pustok\49. 20-12-2021\PustokP201\PustokP201\Views\_ViewImports.cshtml"
using PustokP201.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Eagha\Desktop\CodeLessons\P201\ASP\Pustok\49. 20-12-2021\PustokP201\PustokP201\Views\_ViewImports.cshtml"
using PustokP201.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"872c0f5e49098795b05b16e17ff0736dfae306b1", @"/Views/Shared/_BookTabSlider.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5884438bbf247ea6d9f39676e18e38800fdc98e2", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__BookTabSlider : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Book>>
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
            WriteLiteral(@"
<div class=""product-slider multiple-row  slider-border-multiple-row  sb-slick-slider""
     data-slick-setting='{
                                        ""autoplay"": true,
                                        ""autoplaySpeed"": 8000,
                                        ""slidesToShow"": 5,
                                        ""rows"":1,
                                        ""dots"":true
                                    }' data-slick-responsive='[
                                        {""breakpoint"":1200, ""settings"": {""slidesToShow"": 3} },
                                        {""breakpoint"":768, ""settings"": {""slidesToShow"": 2} },
                                        {""breakpoint"":480, ""settings"": {""slidesToShow"": 1} },
                                        {""breakpoint"":320, ""settings"": {""slidesToShow"": 1} }
                                    ]'>
");
#nullable restore
#line 16 "C:\Users\Eagha\Desktop\CodeLessons\P201\ASP\Pustok\49. 20-12-2021\PustokP201\PustokP201\Views\Shared\_BookTabSlider.cshtml"
     foreach (Book item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"single-slide\">\r\n            <div class=\"product-card\">\r\n                <div class=\"product-header\">\r\n                    <a href=\"#\" class=\"author\">\r\n                        ");
#nullable restore
#line 22 "C:\Users\Eagha\Desktop\CodeLessons\P201\ASP\Pustok\49. 20-12-2021\PustokP201\PustokP201\Views\Shared\_BookTabSlider.cshtml"
                   Write(item.Author.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </a>\r\n                    <h3>\r\n                        <a href=\"product-details.html\">\r\n                            ");
#nullable restore
#line 26 "C:\Users\Eagha\Desktop\CodeLessons\P201\ASP\Pustok\49. 20-12-2021\PustokP201\PustokP201\Views\Shared\_BookTabSlider.cshtml"
                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </a>\r\n                    </h3>\r\n                </div>\r\n                <div class=\"product-card--body\">\r\n                    <div class=\"card-image\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "872c0f5e49098795b05b16e17ff0736dfae306b16151", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1530, "~/image/products/", 1530, 17, true);
#nullable restore
#line 32 "C:\Users\Eagha\Desktop\CodeLessons\P201\ASP\Pustok\49. 20-12-2021\PustokP201\PustokP201\Views\Shared\_BookTabSlider.cshtml"
AddHtmlAttributeValue("", 1547, item.BookImages.FirstOrDefault(x=>x.PosterStatus==true)?.Image, 1547, 63, false);

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
            WriteLiteral("\r\n                        <div class=\"hover-contents\">\r\n                            <a href=\"product-details.html\" class=\"hover-image\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "872c0f5e49098795b05b16e17ff0736dfae306b17995", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1798, "~/image/products/", 1798, 17, true);
#nullable restore
#line 35 "C:\Users\Eagha\Desktop\CodeLessons\P201\ASP\Pustok\49. 20-12-2021\PustokP201\PustokP201\Views\Shared\_BookTabSlider.cshtml"
AddHtmlAttributeValue("", 1815, item.BookImages.FirstOrDefault(x=>x.PosterStatus==false)?.Image, 1815, 64, false);

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
            WriteLiteral(@"
                            </a>
                            <div class=""hover-btns"">
                                <a href=""cart.html"" class=""single-btn"">
                                    <i class=""fas fa-shopping-basket""></i>
                                </a>
                                <a href=""wishlist.html"" class=""single-btn"">
                                    <i class=""fas fa-heart""></i>
                                </a>
                                <a href=""compare.html"" class=""single-btn"">
                                    <i class=""fas fa-random""></i>
                                </a>
                                <a href=""#"" data-toggle=""modal"" data-id=""");
#nullable restore
#line 47 "C:\Users\Eagha\Desktop\CodeLessons\P201\ASP\Pustok\49. 20-12-2021\PustokP201\PustokP201\Views\Shared\_BookTabSlider.cshtml"
                                                                    Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""" 
                                   class=""single-btn single-eye-btn"">
                                    <i class=""fas fa-eye""></i>
                                </a>
                            </div>
                        </div>
                    </div>
                    <div class=""price-block"">
");
#nullable restore
#line 55 "C:\Users\Eagha\Desktop\CodeLessons\P201\ASP\Pustok\49. 20-12-2021\PustokP201\PustokP201\Views\Shared\_BookTabSlider.cshtml"
                         if (item.DiscountPercent > 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"price\">£");
#nullable restore
#line 57 "C:\Users\Eagha\Desktop\CodeLessons\P201\ASP\Pustok\49. 20-12-2021\PustokP201\PustokP201\Views\Shared\_BookTabSlider.cshtml"
                                             Write((item.SalePrice*(100-item.DiscountPercent)/100).ToString("#.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            <del class=\"price-old\">£");
#nullable restore
#line 58 "C:\Users\Eagha\Desktop\CodeLessons\P201\ASP\Pustok\49. 20-12-2021\PustokP201\PustokP201\Views\Shared\_BookTabSlider.cshtml"
                                               Write(item.SalePrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</del>\r\n                            <span class=\"price-discount\">");
#nullable restore
#line 59 "C:\Users\Eagha\Desktop\CodeLessons\P201\ASP\Pustok\49. 20-12-2021\PustokP201\PustokP201\Views\Shared\_BookTabSlider.cshtml"
                                                    Write(item.DiscountPercent);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</span>\r\n");
#nullable restore
#line 60 "C:\Users\Eagha\Desktop\CodeLessons\P201\ASP\Pustok\49. 20-12-2021\PustokP201\PustokP201\Views\Shared\_BookTabSlider.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"price\">£");
#nullable restore
#line 63 "C:\Users\Eagha\Desktop\CodeLessons\P201\ASP\Pustok\49. 20-12-2021\PustokP201\PustokP201\Views\Shared\_BookTabSlider.cshtml"
                                            Write(item.SalePrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 64 "C:\Users\Eagha\Desktop\CodeLessons\P201\ASP\Pustok\49. 20-12-2021\PustokP201\PustokP201\Views\Shared\_BookTabSlider.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 70 "C:\Users\Eagha\Desktop\CodeLessons\P201\ASP\Pustok\49. 20-12-2021\PustokP201\PustokP201\Views\Shared\_BookTabSlider.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Book>> Html { get; private set; }
    }
}
#pragma warning restore 1591