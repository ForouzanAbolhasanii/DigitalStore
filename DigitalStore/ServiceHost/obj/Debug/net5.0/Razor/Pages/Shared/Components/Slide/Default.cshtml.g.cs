#pragma checksum "C:\Users\HP\Desktop\DigitalStores\DigitalStore\ServiceHost\Pages\Shared\Components\Slide\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85a2ba304465001ddf2d4997bbb15f06a088550b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ServiceHost.Pages.Shared.Components.Slide.Pages_Shared_Components_Slide_Default), @"mvc.1.0.view", @"/Pages/Shared/Components/Slide/Default.cshtml")]
namespace ServiceHost.Pages.Shared.Components.Slide
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85a2ba304465001ddf2d4997bbb15f06a088550b", @"/Pages/Shared/Components/Slide/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d027006424b9e12b1709732f146fce9f1d78e6a1", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared_Components_Slide_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<_01_DigitalStoreQuery.Contract.Slide.SlideQueryModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""hero-slider-area section-space"">
    <div class=""container wide"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""hero-slider-wrapper"">
                    <div class=""ht-slick-slider"" data-slick-setting='{
                        ""slidesToShow"": 1,
                        ""slidesToScroll"": 1,
                        ""arrows"": true,
                        ""dots"": true,
                        ""autoplay"": true,
                        ""autoplaySpeed"": 5000,
                        ""speed"": 1000,
                        ""fade"": true,
                        ""infinite"": true,
                        ""prevArrow"": {""buttonClass"": ""slick-prev"", ""iconClass"": ""ion-chevron-left"" },
                        ""nextArrow"": {""buttonClass"": ""slick-next"", ""iconClass"": ""ion-chevron-right"" }
                    }' data-slick-responsive='[
                        {""breakpoint"":1501, ""settings"": {""slidesToShow"": 1} },
                        {""breakpoint""");
            WriteLiteral(@":1199, ""settings"": {""slidesToShow"": 1, ""arrows"": false} },
                        {""breakpoint"":991, ""settings"": {""slidesToShow"": 1, ""arrows"": false} },
                        {""breakpoint"":767, ""settings"": {""slidesToShow"": 1, ""arrows"": false} },
                        {""breakpoint"":575, ""settings"": {""slidesToShow"": 1, ""arrows"": false} },
                        {""breakpoint"":479, ""settings"": {""slidesToShow"": 1, ""arrows"": false} }
                    ]'>

");
#nullable restore
#line 29 "C:\Users\HP\Desktop\DigitalStores\DigitalStore\ServiceHost\Pages\Shared\Components\Slide\Default.cshtml"
                         foreach (var slide in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"single-slider-item\">\r\n                                <div class=\"hero-slider-item-wrapper\">\r\n                                    <div class=\"container\">\r\n                                        <img");
            BeginWriteAttribute("src", " src=\"", 1882, "\"", 1902, 1);
#nullable restore
#line 34 "C:\Users\HP\Desktop\DigitalStores\DigitalStore\ServiceHost\Pages\Shared\Components\Slide\Default.cshtml"
WriteAttributeValue("", 1888, slide.Picture, 1888, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1903, "\"", 1926, 1);
#nullable restore
#line 34 "C:\Users\HP\Desktop\DigitalStores\DigitalStore\ServiceHost\Pages\Shared\Components\Slide\Default.cshtml"
WriteAttributeValue("", 1909, slide.PictureAlt, 1909, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 1927, "\"", 1954, 1);
#nullable restore
#line 34 "C:\Users\HP\Desktop\DigitalStores\DigitalStore\ServiceHost\Pages\Shared\Components\Slide\Default.cshtml"
WriteAttributeValue("", 1935, slide.PictureTitle, 1935, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" style=""position:absolute ; top:0 ; left:0 ; height:100% ; width:100%;"" />
                                        <div class=""row"">
                                            <div class=""col-lg-12"">
                                                <div class=""hero-slider-content hero-slider-content--left-space"">
                                                    <p class=""slider-title slider-title--small "" style=""font:20px"">");
#nullable restore
#line 38 "C:\Users\HP\Desktop\DigitalStores\DigitalStore\ServiceHost\Pages\Shared\Components\Slide\Default.cshtml"
                                                                                                              Write(slide.Heading);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                                    <p class=\"slider-title slider-title--big-light \">");
#nullable restore
#line 39 "C:\Users\HP\Desktop\DigitalStores\DigitalStore\ServiceHost\Pages\Shared\Components\Slide\Default.cshtml"
                                                                                                Write(slide.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                                    <p class=\"slider-title slider-title--big-light \">\r\n                                                        ");
#nullable restore
#line 41 "C:\Users\HP\Desktop\DigitalStores\DigitalStore\ServiceHost\Pages\Shared\Components\Slide\Default.cshtml"
                                                   Write(slide.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </p>\r\n                                                    <a class=\"hero-slider-button\"");
            BeginWriteAttribute("href", " href=\"", 2839, "\"", 2857, 1);
#nullable restore
#line 43 "C:\Users\HP\Desktop\DigitalStores\DigitalStore\ServiceHost\Pages\Shared\Components\Slide\Default.cshtml"
WriteAttributeValue("", 2846, slide.Link, 2846, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"margin-top:15px\">\r\n                                                        ");
#nullable restore
#line 44 "C:\Users\HP\Desktop\DigitalStores\DigitalStore\ServiceHost\Pages\Shared\Components\Slide\Default.cshtml"
                                                   Write(slide.BtnText);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" <i class=""ion-ios-plus-empty""></i>
                                                    </a>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
");
#nullable restore
#line 52 "C:\Users\HP\Desktop\DigitalStores\DigitalStore\ServiceHost\Pages\Shared\Components\Slide\Default.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<_01_DigitalStoreQuery.Contract.Slide.SlideQueryModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
