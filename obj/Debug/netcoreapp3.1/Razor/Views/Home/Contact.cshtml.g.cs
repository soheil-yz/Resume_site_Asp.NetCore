#pragma checksum "C:\Users\sohei\OneDrive\Desktop\ایمان تقوا وعمل صالح\csharp\MYProtfolio2\MYProtfolio2\Views\Home\Contact.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "f0778eafa435217da6b9e1c15bc81d09ae228a976a6aaf825c0588fac87e1320"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contact), @"mvc.1.0.view", @"/Views/Home/Contact.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"f0778eafa435217da6b9e1c15bc81d09ae228a976a6aaf825c0588fac87e1320", @"/Views/Home/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"32fd15e6ae47bc245ef5115d802fda472192e9910f242125fcdcd75e86314c10", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Contact>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\sohei\OneDrive\Desktop\ایمان تقوا وعمل صالح\csharp\MYProtfolio2\MYProtfolio2\Views\Home\Contact.cshtml"
  
    ViewData["Title"] = "Contact";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("SEO", async() => {
                WriteLiteral("\r\n    <meta name=\"keywords\" content=\"project, my project, my personal project\" />\r\n    <meta name=\"description\" content=\"index description\" />\r\n");
            }
            );
            WriteLiteral(@"
<section id=""one"">
    <header class=""major"">
        <h2>
            تماس با من
        </h2>
    </header>
</section>

<section id=""two"">
    <div class=""row"">
        <table>
            <tr>
                <td>Email:</td>
                <td>");
#nullable restore
#line 26 "C:\Users\sohei\OneDrive\Desktop\ایمان تقوا وعمل صالح\csharp\MYProtfolio2\MYProtfolio2\Views\Home\Contact.cshtml"
               Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td>Mobile:</td>\r\n                <td>");
#nullable restore
#line 30 "C:\Users\sohei\OneDrive\Desktop\ایمان تقوا وعمل صالح\csharp\MYProtfolio2\MYProtfolio2\Views\Home\Contact.cshtml"
               Write(Model.Mobile);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td>Github:</td>\r\n                <td>");
#nullable restore
#line 34 "C:\Users\sohei\OneDrive\Desktop\ایمان تقوا وعمل صالح\csharp\MYProtfolio2\MYProtfolio2\Views\Home\Contact.cshtml"
               Write(Model.Github);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n        </table>\r\n    </div>\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Contact> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
