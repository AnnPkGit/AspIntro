#pragma checksum "C:\Users\96205\Desktop\Files\GIT\WordChecker\AspIntro\Views\Auth\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "337a4884d7ceca379f70c7ec02df26c3f0d1f727"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Auth_Register), @"mvc.1.0.view", @"/Views/Auth/Register.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"337a4884d7ceca379f70c7ec02df26c3f0d1f727", @"/Views/Auth/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d8745bab99571aae92a33c863fdaee00502f2c9", @"/Views/_ViewImports.cshtml")]
    public class Views_Auth_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Auth/RegUser"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>\r\n    Регистрация нового пользователя\r\n</h1>\r\n\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 10 "C:\Users\96205\Desktop\Files\GIT\WordChecker\AspIntro\Views\Auth\Register.cshtml"
  
    var err = (ViewData["err"] as String[]);
    var values = (ViewData["values"] as String[]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "337a4884d7ceca379f70c7ec02df26c3f0d1f7274616", async() => {
                WriteLiteral("   \r\n    Имя:    <input type=\"text\"  id=\"RealName\"   name=\"RealName\"");
                BeginWriteAttribute("value", " value=\"", 401, "\"", 420, 1);
#nullable restore
#line 20 "C:\Users\96205\Desktop\Files\GIT\WordChecker\AspIntro\Views\Auth\Register.cshtml"
WriteAttributeValue("", 409, values?[0], 409, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n");
#nullable restore
#line 21 "C:\Users\96205\Desktop\Files\GIT\WordChecker\AspIntro\Views\Auth\Register.cshtml"
     if (!String.IsNullOrEmpty(err?[1]))
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\96205\Desktop\Files\GIT\WordChecker\AspIntro\Views\Auth\Register.cshtml"
   Write(err[1]);

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\96205\Desktop\Files\GIT\WordChecker\AspIntro\Views\Auth\Register.cshtml"
               
       
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("    <br/>\r\n    Логин:  <input type=\"text\"     name=\"Login\"");
                BeginWriteAttribute("value", " value=\"", 565, "\"", 584, 1);
#nullable restore
#line 27 "C:\Users\96205\Desktop\Files\GIT\WordChecker\AspIntro\Views\Auth\Register.cshtml"
WriteAttributeValue("", 573, values?[1], 573, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n");
#nullable restore
#line 28 "C:\Users\96205\Desktop\Files\GIT\WordChecker\AspIntro\Views\Auth\Register.cshtml"
     if (!String.IsNullOrEmpty(err?[2]))
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\96205\Desktop\Files\GIT\WordChecker\AspIntro\Views\Auth\Register.cshtml"
   Write(err[2]);

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\96205\Desktop\Files\GIT\WordChecker\AspIntro\Views\Auth\Register.cshtml"
               
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("    <br/>\r\n    Пароль:   <input type=\"password\" name=\"Password1\" />\r\n");
#nullable restore
#line 34 "C:\Users\96205\Desktop\Files\GIT\WordChecker\AspIntro\Views\Auth\Register.cshtml"
     if (!String.IsNullOrEmpty(err?[3]))
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\96205\Desktop\Files\GIT\WordChecker\AspIntro\Views\Auth\Register.cshtml"
   Write(err[3]);

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\96205\Desktop\Files\GIT\WordChecker\AspIntro\Views\Auth\Register.cshtml"
               
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("    <br/>\r\n    Повтор:   <input type=\"password\" name=\"Password2\" />\r\n");
#nullable restore
#line 40 "C:\Users\96205\Desktop\Files\GIT\WordChecker\AspIntro\Views\Auth\Register.cshtml"
     if (!String.IsNullOrEmpty(err?[4]))
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\96205\Desktop\Files\GIT\WordChecker\AspIntro\Views\Auth\Register.cshtml"
   Write(err[4]);

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\96205\Desktop\Files\GIT\WordChecker\AspIntro\Views\Auth\Register.cshtml"
               
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("    <br/>\r\n    E-mail:   <input type=\"email\"    name=\"Email\"");
                BeginWriteAttribute("value", " value=\"", 1006, "\"", 1025, 1);
#nullable restore
#line 45 "C:\Users\96205\Desktop\Files\GIT\WordChecker\AspIntro\Views\Auth\Register.cshtml"
WriteAttributeValue("", 1014, values?[2], 1014, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n");
#nullable restore
#line 46 "C:\Users\96205\Desktop\Files\GIT\WordChecker\AspIntro\Views\Auth\Register.cshtml"
     if (!String.IsNullOrEmpty(err?[5]))
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Users\96205\Desktop\Files\GIT\WordChecker\AspIntro\Views\Auth\Register.cshtml"
   Write(err[5]);

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Users\96205\Desktop\Files\GIT\WordChecker\AspIntro\Views\Auth\Register.cshtml"
               
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("    <br/>\r\n    Аватарка: <input type=\"file\"     name=\"Avatar\"    />\r\n    <br/>\r\n    <button type=\"submit\">Зарегистрироваться</button>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 56 "C:\Users\96205\Desktop\Files\GIT\WordChecker\AspIntro\Views\Auth\Register.cshtml"
  
    var UserData = ViewData["UserData"] as RegUserModel; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "C:\Users\96205\Desktop\Files\GIT\WordChecker\AspIntro\Views\Auth\Register.cshtml"
 if(UserData?.Avatar != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <img");
            BeginWriteAttribute("src", " src=\"", 1357, "\"", 1393, 2);
            WriteAttributeValue("", 1363, "/img/", 1363, 5, true);
#nullable restore
#line 61 "C:\Users\96205\Desktop\Files\GIT\WordChecker\AspIntro\Views\Auth\Register.cshtml"
WriteAttributeValue("", 1368, UserData.Avatar.FileName, 1368, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 62 "C:\Users\96205\Desktop\Files\GIT\WordChecker\AspIntro\Views\Auth\Register.cshtml"
}

#line default
#line hidden
#nullable disable
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
