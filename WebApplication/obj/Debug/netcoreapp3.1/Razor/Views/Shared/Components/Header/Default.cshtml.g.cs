#pragma checksum "C:\Users\Ilhame\Desktop\WebApplication\WebApplication\Views\Shared\Components\Header\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7dc68c50952057cbc44e97fb3b56aa58d50e5011"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Header_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Header/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7dc68c50952057cbc44e97fb3b56aa58d50e5011", @"/Views/Shared/Components/Header/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32411760086fa85aafa7f1f3fbf38032bc10523c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_Header_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVM>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/hero-img.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-aos", new global::Microsoft.AspNetCore.Html.HtmlString("zoom-out"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-aos-delay", new global::Microsoft.AspNetCore.Html.HtmlString("300"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<!-- ======= Header ======= -->
  <header id=""header"" class=""header fixed-top d-flex align-items-center"">
    <div class=""container d-flex align-items-center justify-content-between"">

      <a href=""index.html"" class=""logo d-flex align-items-center me-auto me-lg-0"">
        <!-- Uncomment the line below if you also wish to use an image logo -->
        <!-- <img src=""~/assets/img/logo.png"" alt=""""> -->
        <h1>");
#nullable restore
#line 9 "C:\Users\Ilhame\Desktop\WebApplication\WebApplication\Views\Shared\Components\Header\Default.cshtml"
       Write(Model.Settings.HeaderLogo);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<span>.</span></h1>
      </a>

      <nav id=""navbar"" class=""navbar"">
        <ul>
          <li><a href=""#hero"">Home</a></li>
          <li><a href=""#about"">About</a></li>
          <li><a href=""#menu"">Menu</a></li>
          <li><a href=""#events"">Events</a></li>
          <li><a href=""#chefs"">Chefs</a></li>
          <li><a href=""#gallery"">Gallery</a></li>
          <li class=""dropdown""><a href=""#""><span>Drop Down</span> <i class=""bi bi-chevron-down dropdown-indicator""></i></a>
            <ul>
              <li><a href=""#"">Drop Down 1</a></li>
              <li class=""dropdown""><a href=""#""><span>Deep Drop Down</span> <i class=""bi bi-chevron-down dropdown-indicator""></i></a>
                <ul>
                  <li><a href=""#"">Deep Drop Down 1</a></li>
                  <li><a href=""#"">Deep Drop Down 2</a></li>
                  <li><a href=""#"">Deep Drop Down 3</a></li>
                  <li><a href=""#"">Deep Drop Down 4</a></li>
                  <li><a href=""#"">Deep Drop Down 5</a></");
            WriteLiteral(@"li>
                </ul>
              </li>
              <li><a href=""#"">Drop Down 2</a></li>
              <li><a href=""#"">Drop Down 3</a></li>
              <li><a href=""#"">Drop Down 4</a></li>
            </ul>
          </li>
          <li><a href=""#contact"">Contact</a></li>
        </ul>
      </nav><!-- .navbar -->

      <a class=""btn-book-a-table"" href=""#book-a-table"">Book a Table</a>
      <i class=""mobile-nav-toggle mobile-nav-show bi bi-list""></i>
      <i class=""mobile-nav-toggle mobile-nav-hide d-none bi bi-x""></i>

    </div>
  </header><!-- End Header -->
  <!-- ======= Hero Section ======= -->
  <section id=""hero"" class=""hero d-flex align-items-center section-bg"">
    <div class=""container"">
      <div class=""row justify-content-between gy-5"">
        <div class=""col-lg-5 order-2 order-lg-1 d-flex flex-column justify-content-center align-items-center align-items-lg-start text-center text-lg-start"">
          <h2 data-aos=""fade-up"">Enjoy Your Healthy<br>Delicious Food<");
            WriteLiteral(@"/h2>
          <p data-aos=""fade-up"" data-aos-delay=""100"">Sed autem laudantium dolores. Voluptatem itaque ea consequatur eveniet. Eum quas beatae cumque eum quaerat.</p>
          <div class=""d-flex"" data-aos=""fade-up"" data-aos-delay=""200"">
            <a href=""#book-a-table"" class=""btn-book-a-table"">Book a Table</a>
            <a href=""https://www.youtube.com/watch?v=LXb3EKWsInQ"" class=""glightbox btn-watch-video d-flex align-items-center""><i class=""bi bi-play-circle""></i><span>Watch Video</span></a>
          </div>
        </div>
        <div class=""col-lg-5 order-1 order-lg-2 text-center text-lg-start"">
          ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7dc68c50952057cbc44e97fb3b56aa58d50e50118539", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n      </div>\r\n    </div>\r\n  </section><!-- End Hero Section -->");
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