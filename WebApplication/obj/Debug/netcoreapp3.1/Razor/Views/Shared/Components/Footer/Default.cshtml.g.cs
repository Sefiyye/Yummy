#pragma checksum "C:\Users\Ilhame\Desktop\WebApplication\WebApplication\Views\Shared\Components\Footer\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ddf5cfe795164e33c2c2d9b14641bdc9e3c5d42"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Footer_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Footer/Default.cshtml")]
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
#line 1 "C:\Users\Ilhame\Desktop\WebApplication\WebApplication\Views\_ViewImports.cshtml"
using WebApplication.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ilhame\Desktop\WebApplication\WebApplication\Views\_ViewImports.cshtml"
using WebApplication.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ddf5cfe795164e33c2c2d9b14641bdc9e3c5d42", @"/Views/Shared/Components/Footer/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32411760086fa85aafa7f1f3fbf38032bc10523c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_Footer_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVM>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<footer id=""footer"" class=""footer"">

    <div class=""container"">
      <div class=""row gy-3"">
        <div class=""col-lg-3 col-md-6 d-flex"">
          <i class=""bi bi-geo-alt icon""></i>
          <div>
            <h4>Address</h4>
            <p>
              A108 Adam Street <br>
              New York, NY 535022 - US<br>
            </p>
          </div>

        </div>

        <div class=""col-lg-3 col-md-6 footer-links d-flex"">
          <i class=""bi bi-telephone icon""></i>
          <div>
            <h4>Reservations</h4>
            <p>
              <strong>Phone:</strong> +1 5589 55488 55<br>
              <strong>Email:</strong> info@example.com<br>
            </p>
          </div>
        </div>

        <div class=""col-lg-3 col-md-6 footer-links d-flex"">
          <i class=""bi bi-clock icon""></i>
          <div>
            <h4>Opening Hours</h4>
            <p>
              <strong>Mon-Sat: 11AM</strong> - 23PM<br>
              Sunday: Closed
            </p>");
            WriteLiteral("\n          </div>\r\n        </div>\r\n\r\n        <div class=\"col-lg-3 col-md-6 footer-links\">\r\n          <h4>Follow Us</h4>\r\n          <div class=\"social-links d-flex\">\r\n");
#nullable restore
#line 43 "C:\Users\Ilhame\Desktop\WebApplication\WebApplication\Views\Shared\Components\Footer\Default.cshtml"
               foreach (var item in Model.SocialMedias)
             {

#line default
#line hidden
#nullable disable
            WriteLiteral("                  <a");
            BeginWriteAttribute("href", " href=\"", 1298, "\"", 1318, 1);
#nullable restore
#line 45 "C:\Users\Ilhame\Desktop\WebApplication\WebApplication\Views\Shared\Components\Footer\Default.cshtml"
WriteAttributeValue("", 1305, item.IconUrl, 1305, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"twitter\"><i");
            BeginWriteAttribute("class", " class=\"", 1338, "\"", 1356, 1);
#nullable restore
#line 45 "C:\Users\Ilhame\Desktop\WebApplication\WebApplication\Views\Shared\Components\Footer\Default.cshtml"
WriteAttributeValue("", 1346, item.Icon, 1346, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i></a>\n");
#nullable restore
#line 46 "C:\Users\Ilhame\Desktop\WebApplication\WebApplication\Views\Shared\Components\Footer\Default.cshtml"
             }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"          </div>
        </div>

      </div>
    </div>

    <div class=""container"">
      <div class=""copyright"">
        &copy; Copyright <strong><span>Yummy</span></strong>. All Rights Reserved
      </div>
      <div class=""credits"">
        <!-- All the links in the footer should remain intact. -->
        <!-- You can delete the links only if you purchased the pro version. -->
        <!-- Licensing information: https://bootstrapmade.com/license/ -->
        <!-- Purchase the pro version with working PHP/AJAX contact form: https://bootstrapmade.com/yummy-bootstrap-restaurant-website-template/ -->
        Designed by <a href=""https://bootstrapmade.com/"">BootstrapMade</a>
      </div>
    </div>

  </footer><!-- End Footer -->
  <!-- End Footer -->");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
