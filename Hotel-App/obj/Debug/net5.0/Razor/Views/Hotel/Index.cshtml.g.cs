#pragma checksum "C:\Users\HP\Desktop\Hotel-App\Hotel-App\Views\Hotel\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "24c9c5bb1178d72766d3fd48f25bce377e46e778"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Hotel_Index), @"mvc.1.0.view", @"/Views/Hotel/Index.cshtml")]
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
#line 1 "C:\Users\HP\Desktop\Hotel-App\Hotel-App\Views\_ViewImports.cshtml"
using Hotel_App;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Desktop\Hotel-App\Hotel-App\Views\_ViewImports.cshtml"
using Hotel_App.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HP\Desktop\Hotel-App\Hotel-App\Views\_ViewImports.cshtml"
using Hotel_App.Models.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HP\Desktop\Hotel-App\Hotel-App\Views\_ViewImports.cshtml"
using Hotel_App.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\HP\Desktop\Hotel-App\Hotel-App\Views\_ViewImports.cshtml"
using Hotel_App.Models.ViewModels.Hotel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24c9c5bb1178d72766d3fd48f25bce377e46e778", @"/Views/Hotel/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91c0919da7705681ff1011bc12c1c1670520f654", @"/Views/_ViewImports.cshtml")]
    public class Views_Hotel_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<HotelViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\HP\Desktop\Hotel-App\Hotel-App\Views\Hotel\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""hotel-banner-simple hotel-transition-bottom hotelrooms"">

    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">

                <div class=""hotel-center hotel-title-frame"">
                    <h1 class=""hotel-mb-20 hotel-h1-inner"">Hotel Seçin</h1>
                    <p class=""hotel-mb-30"">Lorem ipsum dolor sit amet, consectetur adipisicing elit. Esse, labore. Beatae sunt impedit accusamus eum.</p>
                    <ul class=""hotel-breadcrumbs"">
                        <li><a href=""index.html"">Ana Səhifə</a></li>
                        <li><span>Hotellər</span></li>
                    </ul>
                </div>

            </div>
        </div>
    </div>
</section>
<!-- banner end -->
<!-- rooms -->
<section class=""hotel-p-100-100"">
    <div class=""container"">

        <div class=""hotel-filter hotel-mb-60"">
            <a href=""#"" data-filter=""*"" class=""hotel-work-category hotel-current"">Bütün Hotellər</a>
            <");
            WriteLiteral(@"a href=""#"" data-filter="".deluxe"" class=""hotel-work-category"">A Hotel</a>
            <a href=""#"" data-filter="".standart"" class=""hotel-work-category"">B Hotel</a>
            <a href=""#"" data-filter="".economy"" class=""hotel-work-category"">C Hotel</a>


        </div>

        <div class=""hotel-masonry-grid hotel-3-col"">

            <div class=""hotel-grid-sizer""></div>
");
#nullable restore
#line 42 "C:\Users\HP\Desktop\Hotel-App\Hotel-App\Views\Hotel\Index.cshtml"
             foreach (var hotel in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""hotel-masonry-grid-item hotel-masonry-grid-item-33 deluxe"">

                    <!-- room card -->
                    <div class=""hotel-room-card"">
                        <div class=""hotel-cover-frame imgLoad"">
                            <a href=""menu.html""><img class=""lozad"" data-src=""img/HOTEL/");
#nullable restore
#line 49 "C:\Users\HP\Desktop\Hotel-App\Hotel-App\Views\Hotel\Index.cshtml"
                                                                                  Write(hotel.Image);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""" alt=""cover""></a>
                        </div>
                        <div class=""hotel-description-frame"">
                            <ul class=""hotel-stars"">
                                <li><i class=""fas fa-star""></i></li>
                                <li><i class=""fas fa-star""></i></li>
                                <li><i class=""fas fa-star""></i></li>
                                <li><i class=""fas fa-star""></i></li>
                                <li><i class=""fas fa-star""></i></li>
                            </ul>
                            <a href=""menu.html"">
                                <h3 class=""hotel-mb-20"">");
#nullable restore
#line 60 "C:\Users\HP\Desktop\Hotel-App\Hotel-App\Views\Hotel\Index.cshtml"
                                                   Write(hotel.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                            </a>\r\n                            <div class=\"hotel-text-light hotel-text-sm hotel-mb-20\">");
#nullable restore
#line 62 "C:\Users\HP\Desktop\Hotel-App\Hotel-App\Views\Hotel\Index.cshtml"
                                                                               Write(hotel.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                            <div class=""hotel-card-bottom imgLoad"">

                                <a href=""menu.html"" class=""hotel-btn""><img class=""lozad"" data-src=""img/icons/bookmark.svg"" alt=""icon"">Hotelə get</a>
                            </div>
                        </div>
                    </div>
                    <!-- room card end -->

                </div>
");
#nullable restore
#line 72 "C:\Users\HP\Desktop\Hotel-App\Hotel-App\Views\Hotel\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </div>\r\n\r\n    </div>\r\n</section>\r\n<!-- rooms end -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<HotelViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
