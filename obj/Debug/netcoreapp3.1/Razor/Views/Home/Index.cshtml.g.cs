#pragma checksum "C:\Users\sohei\OneDrive\Desktop\ایمان تقوا وعمل صالح\csharp\MYProtfolio2\MYProtfolio2\Views\Home\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9916466d4a2377cd78821651ebbfe711910ba7c0456a4c5ee7ca489f8ba1db76"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\sohei\OneDrive\Desktop\ایمان تقوا وعمل صالح\csharp\MYProtfolio2\MYProtfolio2\Views\_ViewImports.cshtml"
using MYProfilo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sohei\OneDrive\Desktop\ایمان تقوا وعمل صالح\csharp\MYProtfolio2\MYProtfolio2\Views\_ViewImports.cshtml"
using MYProfilo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"9916466d4a2377cd78821651ebbfe711910ba7c0456a4c5ee7ca489f8ba1db76", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"32fd15e6ae47bc245ef5115d802fda472192e9910f242125fcdcd75e86314c10", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\sohei\OneDrive\Desktop\ایمان تقوا وعمل صالح\csharp\MYProtfolio2\MYProtfolio2\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("SEO", async() => {
                WriteLiteral("\r\n    <meta name=\"keywords\" content=\"project, my project, my personal project\" />\r\n    <meta name=\"description\" content=\"index description\" />\r\n");
            }
            );
            WriteLiteral("\r\n<section id=\"one\">\r\n    <header class=\"major\">\r\n        <h2>\r\n            ");
#nullable restore
#line 15 "C:\Users\sohei\OneDrive\Desktop\ایمان تقوا وعمل صالح\csharp\MYProtfolio2\MYProtfolio2\Views\Home\Index.cshtml"
       Write(ViewData["headingTitle"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </h2>\r\n    </header>\r\n    <p>\r\n        ");
#nullable restore
#line 19 "C:\Users\sohei\OneDrive\Desktop\ایمان تقوا وعمل صالح\csharp\MYProtfolio2\MYProtfolio2\Views\Home\Index.cshtml"
   Write(ViewBag.headingText);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </p>\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
