#pragma checksum "C:\Users\HP\Desktop\DigitalStores\DigitalStore\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "305122593fbcdd27ca5ad095f9735947471b1d9d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ServiceHost.Pages.Shared.Components.ProductCategoryWithProduct.Pages_Shared_Components_ProductCategoryWithProduct_Default), @"mvc.1.0.view", @"/Pages/Shared/Components/ProductCategoryWithProduct/Default.cshtml")]
namespace ServiceHost.Pages.Shared.Components.ProductCategoryWithProduct
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
#line 1 "C:\Users\HP\Desktop\DigitalStores\DigitalStore\ServiceHost\Pages\_ViewImports.cshtml"
using ServiceHost;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"305122593fbcdd27ca5ad095f9735947471b1d9d", @"/Pages/Shared/Components/ProductCategoryWithProduct/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d027006424b9e12b1709732f146fce9f1d78e6a1", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared_Components_ProductCategoryWithProduct_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<_01_DigitalStoreQuery.Contract.ProductCategory.ProductCategoryQueryModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
    <div class=""single-row-slider-tab-area section-space"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-12"">
                    <!--=======  section title  =======-->
                    <div class=""section-title-wrapper text-center section-space--half"">
                        <h2 class=""section-title"">محصولات ما</h2>
                        <p class=""section-subtitle"">
                            لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ و با استفاده از طراحان گرافیک است چاپگرها و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است
                        </p>
                    </div>
                    <!--=======  End of section title  =======-->
                </div>
            </div>
            <div class=""row"">
                <div class=""col-lg-12"">
                    <!--=======  tab slider wrapper  =======-->

                    <div class=""tab-slider-wrapper"">
                        <!--=======  ");
            WriteLiteral("tab product navigation  =======-->\r\n\r\n                        <div class=\"tab-product-navigation\">\r\n                            <div class=\"nav nav-tabs justify-content-center\" id=\"nav-tab2\" role=\"tablist\">\r\n");
#nullable restore
#line 26 "C:\Users\HP\Desktop\DigitalStores\DigitalStore\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
                                 foreach (var category in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <a");
            BeginWriteAttribute("class", " class=\"", 1458, "\"", 1528, 3);
            WriteAttributeValue("", 1466, "nav-item", 1466, 8, true);
            WriteAttributeValue(" ", 1474, "nav-link", 1475, 9, true);
#nullable restore
#line 28 "C:\Users\HP\Desktop\DigitalStores\DigitalStore\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
WriteAttributeValue(" ", 1483, Model.First() == category ? "active" : "", 1484, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 1529, "\"", 1558, 2);
            WriteAttributeValue("", 1534, "product-tab-", 1534, 12, true);
#nullable restore
#line 28 "C:\Users\HP\Desktop\DigitalStores\DigitalStore\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
WriteAttributeValue("", 1546, category.Id, 1546, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-toggle=\"tab\"");
            BeginWriteAttribute("href", "\r\n                                       href=\"", 1577, "\"", 1652, 2);
            WriteAttributeValue("", 1624, "#product-series-", 1624, 16, true);
#nullable restore
#line 29 "C:\Users\HP\Desktop\DigitalStores\DigitalStore\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
WriteAttributeValue("", 1640, category.Id, 1640, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"tab\" aria-selected=\"true\">");
#nullable restore
#line 29 "C:\Users\HP\Desktop\DigitalStores\DigitalStore\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
                                                                                                      Write(category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 30 "C:\Users\HP\Desktop\DigitalStores\DigitalStore\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </div>
                        </div>

                        <!--=======  End of tab product navigation  =======-->
                        <!--=======  tab product content  =======-->
                        <div class=""tab-content"">
");
#nullable restore
#line 38 "C:\Users\HP\Desktop\DigitalStores\DigitalStore\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
                             foreach (var category in Model)
                            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div");
            BeginWriteAttribute("class", " class=\"", 2145, "\"", 2216, 4);
            WriteAttributeValue("", 2153, "tab-pane", 2153, 8, true);
            WriteAttributeValue(" ", 2161, "fade", 2162, 5, true);
            WriteAttributeValue(" ", 2166, "show", 2167, 5, true);
#nullable restore
#line 41 "C:\Users\HP\Desktop\DigitalStores\DigitalStore\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
WriteAttributeValue(" ", 2171, Model.First() == category ? "active" : "", 2172, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 2217, "\"", 2249, 2);
            WriteAttributeValue("", 2222, "product-series-", 2222, 15, true);
#nullable restore
#line 41 "C:\Users\HP\Desktop\DigitalStores\DigitalStore\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
WriteAttributeValue("", 2237, category.Id, 2237, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"tabpanel\"");
            BeginWriteAttribute("aria-labelledby", "\r\n                                     aria-labelledby=\"", 2266, "\"", 2346, 2);
            WriteAttributeValue("", 2322, "product-tab-", 2322, 12, true);
#nullable restore
#line 42 "C:\Users\HP\Desktop\DigitalStores\DigitalStore\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
WriteAttributeValue("", 2334, category.Id, 2334, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                    <!--=======  single row slider wrapper  =======-->
                                    <div class=""single-row-slider-wrapper"">
                                        <div class=""ht-slick-slider"" data-slick-setting='{
                                    ""slidesToShow"": 4,
                                    ""slidesToScroll"": 1,
                                    ""arrows"": true,
                                    ""autoplay"": false,
                                    ""autoplaySpeed"": 5000,
                                    ""speed"": 1000,
                                    ""infinite"": true,
                                    ""rtl"": true,
                                    ""prevArrow"": {""buttonClass"": ""slick-prev"", ""iconClass"": ""ion-chevron-left"" },
                                    ""nextArrow"": {""buttonClass"": ""slick-next"", ""iconClass"": ""ion-chevron-right"" }
                                }' data-slick-responsive='[
                                 ");
            WriteLiteral(@"   {""breakpoint"":1501, ""settings"": {""slidesToShow"": 4} },
                                    {""breakpoint"":1199, ""settings"": {""slidesToShow"": 4, ""arrows"": false} },
                                    {""breakpoint"":991, ""settings"": {""slidesToShow"": 3, ""arrows"": false} },
                                    {""breakpoint"":767, ""settings"": {""slidesToShow"": 2, ""arrows"": false} },
                                    {""breakpoint"":575, ""settings"": {""slidesToShow"": 2, ""arrows"": false} },
                                    {""breakpoint"":479, ""settings"": {""slidesToShow"": 1, ""arrows"": false} }
                                ]'>


");
#nullable restore
#line 66 "C:\Users\HP\Desktop\DigitalStores\DigitalStore\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
                                             foreach (var product in category.Products)
                                            {



#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                     <div class=""col"">
                                                    <!--=======  single grid product  =======-->
                                                    <div class=""single-grid-product"">
                                                        <div class=""single-grid-product__image"">
");
#nullable restore
#line 74 "C:\Users\HP\Desktop\DigitalStores\DigitalStore\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
                                                             if (product.HasDiscount)
                                                             {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                <div class=\"single-grid-product__label\">\r\n                                                                    <span class=\"sale\">-");
#nullable restore
#line 77 "C:\Users\HP\Desktop\DigitalStores\DigitalStore\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
                                                                                   Write(product.DiscountRate);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</span>\r\n                                                                </div>\r\n");
#nullable restore
#line 79 "C:\Users\HP\Desktop\DigitalStores\DigitalStore\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
                                                             }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            <a href=\"single-product.html\">\r\n                                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "305122593fbcdd27ca5ad095f9735947471b1d9d13895", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5184, "~/ProductPicture/", 5184, 17, true);
#nullable restore
#line 81 "C:\Users\HP\Desktop\DigitalStores\DigitalStore\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
AddHtmlAttributeValue("", 5201, product.Picture, 5201, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "title", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 81 "C:\Users\HP\Desktop\DigitalStores\DigitalStore\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
AddHtmlAttributeValue("", 5226, product.PictureTitle, 5226, 21, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 82 "C:\Users\HP\Desktop\DigitalStores\DigitalStore\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
AddHtmlAttributeValue("", 5342, product.PictureAlt, 5342, 19, false);

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
            WriteLiteral("\r\n                                                            </a>\r\n\r\n");
            WriteLiteral(@"                                                        </div>
                                                        <div class=""single-grid-product__content"">
                                                            <div class=""single-grid-product__category-rating"">
                                                                <span class=""category"">
                                                                    <a href=""shop-left-sidebar.html"">");
#nullable restore
#line 100 "C:\Users\HP\Desktop\DigitalStores\DigitalStore\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
                                                                                                Write(product.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                                                                </span>
                                                                <span class=""rating"">
                                                                    <i class=""ion-android-star active""></i>
                                                                    <i class=""ion-android-star active""></i>
                                                                    <i class=""ion-android-star active""></i>
                                                                    <i class=""ion-android-star active""></i>
                                                                    <i class=""ion-android-star-outline""></i>
                                                                </span>
                                                            </div>

                                                            <h3 class=""single-grid-product__title"">
                                                                <a h");
            WriteLiteral("ref=\"single-product.html\">\r\n                                                                    ");
#nullable restore
#line 113 "C:\Users\HP\Desktop\DigitalStores\DigitalStore\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
                                                               Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                                </a>\r\n                                                            </h3>\r\n                                                            <p class=\"single-grid-product__price\">\r\n");
#nullable restore
#line 117 "C:\Users\HP\Desktop\DigitalStores\DigitalStore\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
                                                                 if (product.HasDiscount)
                                                                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                    <span class=\"main-price discounted\">");
#nullable restore
#line 120 "C:\Users\HP\Desktop\DigitalStores\DigitalStore\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
                                                                                                   Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" تومان</span>\r\n                                                                    <span class=\"discounted-price\">");
#nullable restore
#line 121 "C:\Users\HP\Desktop\DigitalStores\DigitalStore\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
                                                                                              Write(product.PriceWithDiscount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" تومان</span>\r\n");
#nullable restore
#line 122 "C:\Users\HP\Desktop\DigitalStores\DigitalStore\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"


                                                                }
                                                                else
                                                                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                    <span class=\"main-price\">");
#nullable restore
#line 128 "C:\Users\HP\Desktop\DigitalStores\DigitalStore\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
                                                                                        Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" تومان</span>\r\n");
#nullable restore
#line 129 "C:\Users\HP\Desktop\DigitalStores\DigitalStore\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"

                                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                            </p>

                                                            </div>
                                                    </div>
                                                    <!--=======  End of single grid product  =======-->
                                                </div>
");
#nullable restore
#line 137 "C:\Users\HP\Desktop\DigitalStores\DigitalStore\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                        </div>\r\n                                    </div>\r\n                                    <!--=======  End of single row slider wrapper  =======-->\r\n                                </div>\r\n");
#nullable restore
#line 144 "C:\Users\HP\Desktop\DigitalStores\DigitalStore\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"


                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </div>
                        <!--=======  End of tab product content  =======-->
                    </div>

                    <!--=======  End of tab slider wrapper  =======-->
                </div>
            </div>
        </div>
    </div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<_01_DigitalStoreQuery.Contract.ProductCategory.ProductCategoryQueryModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
