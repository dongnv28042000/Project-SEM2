#pragma checksum "G:\Project-SEM2\Project_SEM2_HNDShop\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d13c4f909874710de27148948b3add9ec6ddbf1a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "G:\Project-SEM2\Project_SEM2_HNDShop\Views\_ViewImports.cshtml"
using Project_SEM2_HNDShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\Project-SEM2\Project_SEM2_HNDShop\Views\_ViewImports.cshtml"
using Project_SEM2_HNDShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d13c4f909874710de27148948b3add9ec6ddbf1a", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bde3ebbaa628fe143384f9c49173c67dc0cfe14b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Project_SEM2_HNDShop.DTO.ProductDto>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<!-- <div class=\"row text-center\">\r\n");
#nullable restore
#line 4 "G:\Project-SEM2\Project_SEM2_HNDShop\Views\Home\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("         <div class=\"col-lg-3 col-md-6 mb-4\">\r\n        <div class=\"card h-100\">\r\n            <img class=\"card-img-top\" src=\".../100px180/\" alt=\"Card image cap\">\r\n            <div class=\"card-body\">\r\n                <p class=\"card-text\">");
#nullable restore
#line 10 "G:\Project-SEM2\Project_SEM2_HNDShop\Views\Home\Index.cshtml"
                                Write(item.subBrand.SubBrandName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <h5 class=\"card-title\">");
#nullable restore
#line 11 "G:\Project-SEM2\Project_SEM2_HNDShop\Views\Home\Index.cshtml"
                                  Write(item.product.ProName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <p class=\"card-text\">");
#nullable restore
#line 12 "G:\Project-SEM2\Project_SEM2_HNDShop\Views\Home\Index.cshtml"
                                Write(item.product.SellPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n");
            WriteLiteral("        </div>\r\n         </div>\r\n");
#nullable restore
#line 19 "G:\Project-SEM2\Project_SEM2_HNDShop\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>  -->

<!-- <div class=""col-s-6 col-m-4 col-l-6 no-gutters plp-column___3gy6t"">
        <div>
            <div class=""gl-product-card-container"">
                <div class=""gl-product-card glass-product-card___1PGiI"">
                    <div class=""gl-product-card__media""><a
                            href=""/us/top-ten-hi-star-wars-obi-wan-kenobi-shoes/FV8031.html""
                            data-auto-id=""glass-hockeycard-link""><img data-auto-id=""image""
                                class=""gl-product-card__image performance-item""
                                src=""https://assets.adidas.com/images/w_385,h_385,f_auto,q_auto:sensitive,fl_lossy/d4a6fabc1af54c4a8ec0aaee0124eb3b_9366/top-ten-hi-star-wars-obi-wan-kenobi-shoes.jpg""
                                alt=""Top Ten Hi Star Wars Obi-Wan Kenobi Shoes""
                                title=""Top Ten Hi Star Wars Obi-Wan Kenobi Shoes""><img data-auto-id=""image""
                                class=""gl-product-card__image-hover""
     ");
            WriteLiteral(@"                           src=""https://assets.adidas.com/images/w_385,h_385,f_auto,q_auto:sensitive,fl_lossy/6cf7d309850b4a1dac92aaef00f5e40c_9366/top-ten-hi-star-wars-obi-wan-kenobi-shoes.jpg""
                                alt=""Top Ten Hi Star Wars Obi-Wan Kenobi Shoes""
                                title=""Top Ten Hi Star Wars Obi-Wan Kenobi Shoes""></a>
                        
                        <div class=""gl-badge gl-badge--small gl-badge--semi-urgent"">New</div>
                    </div>
                    <div class=""gl-product-card__details""><a
                            href=""/us/top-ten-hi-star-wars-obi-wan-kenobi-shoes/FV8031.html"">
                            <div class=""gl-product-card__details-top"">
                                <div class=""gl-product-card__category"" title=""Originals"">Originals</div>
                                <div class=""gl-product-card__details-icons""></div>
                            </div>
                            <div class=""gl-product-card");
            WriteLiteral(@"__details-main"">
                                <div class=""gl-product-card__name gl-label gl-label--m""
                                    title=""Top Ten Hi Star Wars Obi-Wan Kenobi Shoes"">Top Ten Hi Star Wars Obi-Wan
                                    Kenobi Shoes</div>
                                <div class=""gl-price gl-price--s gl-price__inline___-VD1g""><span
                                        class=""gl-price__value"">$90</span></div>
                            </div>
                        </a></div>
                </div>
            </div>
        </div>
    </div> -->
<div class=""row"">
");
#nullable restore
#line 59 "G:\Project-SEM2\Project_SEM2_HNDShop\Views\Home\Index.cshtml"
  foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"         <div class=""col-lg-3 col-md-6 mb-4"">
        <div class=""card h-100"">
            <div class=""gl-product-card__media""><a
                            href=""/us/top-ten-hi-star-wars-obi-wan-kenobi-shoes/FV8031.html""
                            data-auto-id=""glass-hockeycard-link""><img data-auto-id=""image""
                                class=""gl-product-card__image performance-item""
                                src=""https://assets.adidas.com/images/w_385,h_385,f_auto,q_auto:sensitive,fl_lossy/d4a6fabc1af54c4a8ec0aaee0124eb3b_9366/top-ten-hi-star-wars-obi-wan-kenobi-shoes.jpg""
                                alt=""Top Ten Hi Star Wars Obi-Wan Kenobi Shoes""
                                title=""Top Ten Hi Star Wars Obi-Wan Kenobi Shoes"">
                                </a>
                        
                        <div class=""gl-badge gl-badge--small gl-badge--semi-urgent"">New</div>
                    </div>
            <div class=""card-body"">
               <div class=""gl-prod");
            WriteLiteral(@"uct-card__details""><a
                            href=""/us/top-ten-hi-star-wars-obi-wan-kenobi-shoes/FV8031.html"">
                            <div class=""gl-product-card__details-top"">
                                <div class=""gl-product-card__category"" >
                                    <p class=""card-text"">");
#nullable restore
#line 79 "G:\Project-SEM2\Project_SEM2_HNDShop\Views\Home\Index.cshtml"
                                                    Write(item.subBrand.SubBrandName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                </div>
                                <div class=""gl-product-card__details-icons""></div>
                            </div>
                            <div class=""gl-product-card__details-main"">
                                <div class=""gl-product-card__name gl-label gl-label--m"">
                                     <h5 class=""card-title"">");
#nullable restore
#line 85 "G:\Project-SEM2\Project_SEM2_HNDShop\Views\Home\Index.cshtml"
                                                       Write(item.product.ProName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                </div>\r\n                               \r\n                                <div class=\"gl-price gl-price--s gl-price__inline___-VD1g\"><span\r\n                                        class=\"gl-price__value\">");
#nullable restore
#line 89 "G:\Project-SEM2\Project_SEM2_HNDShop\Views\Home\Index.cshtml"
                                                           Write(item.product.SellPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></div>\r\n                            </div>\r\n                        </a></div>\r\n                </div>\r\n            </div>\r\n            \r\n        </div> \r\n");
#nullable restore
#line 96 "G:\Project-SEM2\Project_SEM2_HNDShop\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n     ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Project_SEM2_HNDShop.DTO.ProductDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
