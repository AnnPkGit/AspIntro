#pragma checksum "C:\Users\96205\Desktop\Files\GIT\WordChecker\AspIntro\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec6d46871343ea1f6bbc87bc547fe982253f0deb"
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
#line 1 "C:\Users\96205\Desktop\Files\GIT\WordChecker\AspIntro\Views\_ViewImports.cshtml"
using Intro;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\96205\Desktop\Files\GIT\WordChecker\AspIntro\Views\_ViewImports.cshtml"
using Intro.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec6d46871343ea1f6bbc87bc547fe982253f0deb", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d8745bab99571aae92a33c863fdaee00502f2c9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\96205\Desktop\Files\GIT\WordChecker\AspIntro\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<p>\r\n    ");
#nullable restore
#line 6 "C:\Users\96205\Desktop\Files\GIT\WordChecker\AspIntro\Views\Home\Index.cshtml"
Write(ViewData["rnd"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("</p>\r\n\r\n<i>\r\n    ");
#nullable restore
#line 11 "C:\Users\96205\Desktop\Files\GIT\WordChecker\AspIntro\Views\Home\Index.cshtml"
Write(ViewBag.hash);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</i>\r\n\r\n<p>\r\n    ");
#nullable restore
#line 15 "C:\Users\96205\Desktop\Files\GIT\WordChecker\AspIntro\Views\Home\Index.cshtml"
Write(ViewBag.date);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n<p>\r\n    ");
#nullable restore
#line 18 "C:\Users\96205\Desktop\Files\GIT\WordChecker\AspIntro\Views\Home\Index.cshtml"
Write(ViewBag.time);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n<p>\r\n    Users Count : ");
#nullable restore
#line 21 "C:\Users\96205\Desktop\Files\GIT\WordChecker\AspIntro\Views\Home\Index.cshtml"
             Write(ViewData["UsersCount"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n\r\n<p>\r\n    ");
#nullable restore
#line 25 "C:\Users\96205\Desktop\Files\GIT\WordChecker\AspIntro\Views\Home\Index.cshtml"
Write(ViewData["fromAuthMiddleware"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n\r\n<p>\r\n    authUserName ");
#nullable restore
#line 29 "C:\Users\96205\Desktop\Files\GIT\WordChecker\AspIntro\Views\Home\Index.cshtml"
            Write(ViewData["authUserName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n\r\n<table>\r\n<tbody>\r\n");
#nullable restore
#line 34 "C:\Users\96205\Desktop\Files\GIT\WordChecker\AspIntro\Views\Home\Index.cshtml"
  foreach(var userName in @ViewBag.userNames)
  {

#line default
#line hidden
#nullable disable
            WriteLiteral("   <tr>\r\n      <td>");
#nullable restore
#line 37 "C:\Users\96205\Desktop\Files\GIT\WordChecker\AspIntro\Views\Home\Index.cshtml"
     Write(userName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n   </tr>\r\n");
#nullable restore
#line 39 "C:\Users\96205\Desktop\Files\GIT\WordChecker\AspIntro\Views\Home\Index.cshtml"
  }

#line default
#line hidden
#nullable disable
            WriteLiteral("</tbody>\r\n</table>\r\n\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
