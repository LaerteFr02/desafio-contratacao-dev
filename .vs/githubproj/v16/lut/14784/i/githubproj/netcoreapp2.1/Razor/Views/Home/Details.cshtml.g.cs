#pragma checksum "C:\Users\laert\source\repos\githubproj\githubproj\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae854b2075a3be27b1761e2d9409788c19d9a590"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Details.cshtml", typeof(AspNetCore.Views_Home_Details))]
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
#line 1 "C:\Users\laert\source\repos\githubproj\githubproj\Views\_ViewImports.cshtml"
using githubproj;

#line default
#line hidden
#line 2 "C:\Users\laert\source\repos\githubproj\githubproj\Views\_ViewImports.cshtml"
using githubproj.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae854b2075a3be27b1761e2d9409788c19d9a590", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8eb40f2aec50807f1ca17883ec4d10e3f23e401", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<githubproj.Models.DetailsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(43, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\laert\source\repos\githubproj\githubproj\Views\Home\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(88, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(95, 15, false);
#line 7 "C:\Users\laert\source\repos\githubproj\githubproj\Views\Home\Details.cshtml"
Write(Model.full_name);

#line default
#line hidden
            EndContext();
            BeginContext(110, 24, true);
            WriteLiteral("</h2>\r\n\r\n<div>\r\n    <h4>");
            EndContext();
            BeginContext(135, 17, false);
#line 10 "C:\Users\laert\source\repos\githubproj\githubproj\Views\Home\Details.cshtml"
   Write(Model.owner.login);

#line default
#line hidden
            EndContext();
            BeginContext(152, 98, true);
            WriteLiteral("</h4>\r\n    <hr />\r\n    <div class=\"card\" style=\"width: 18rem;\">\r\n        <img class=\"card-img-top\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 250, "\"", 279, 1);
#line 13 "C:\Users\laert\source\repos\githubproj\githubproj\Views\Home\Details.cshtml"
WriteAttributeValue("", 256, Model.owner.avatar_url, 256, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(280, 69, true);
            WriteLiteral(">\r\n        <div class=\"card-body\">\r\n            <p class=\"card-text\">");
            EndContext();
            BeginContext(350, 17, false);
#line 15 "C:\Users\laert\source\repos\githubproj\githubproj\Views\Home\Details.cshtml"
                            Write(Model.description);

#line default
#line hidden
            EndContext();
            BeginContext(367, 96, true);
            WriteLiteral("</p>\r\n        </div>\r\n\r\n    </div>\r\n\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(464, 38, false);
#line 22 "C:\Users\laert\source\repos\githubproj\githubproj\Views\Home\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.id));

#line default
#line hidden
            EndContext();
            BeginContext(502, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(546, 34, false);
#line 25 "C:\Users\laert\source\repos\githubproj\githubproj\Views\Home\Details.cshtml"
       Write(Html.DisplayFor(model => model.id));

#line default
#line hidden
            EndContext();
            BeginContext(580, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(624, 40, false);
#line 28 "C:\Users\laert\source\repos\githubproj\githubproj\Views\Home\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.name));

#line default
#line hidden
            EndContext();
            BeginContext(664, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(708, 36, false);
#line 31 "C:\Users\laert\source\repos\githubproj\githubproj\Views\Home\Details.cshtml"
       Write(Html.DisplayFor(model => model.name));

#line default
#line hidden
            EndContext();
            BeginContext(744, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(788, 45, false);
#line 34 "C:\Users\laert\source\repos\githubproj\githubproj\Views\Home\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.full_name));

#line default
#line hidden
            EndContext();
            BeginContext(833, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(877, 41, false);
#line 37 "C:\Users\laert\source\repos\githubproj\githubproj\Views\Home\Details.cshtml"
       Write(Html.DisplayFor(model => model.full_name));

#line default
#line hidden
            EndContext();
            BeginContext(918, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(962, 47, false);
#line 40 "C:\Users\laert\source\repos\githubproj\githubproj\Views\Home\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.description));

#line default
#line hidden
            EndContext();
            BeginContext(1009, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1053, 43, false);
#line 43 "C:\Users\laert\source\repos\githubproj\githubproj\Views\Home\Details.cshtml"
       Write(Html.DisplayFor(model => model.description));

#line default
#line hidden
            EndContext();
            BeginContext(1096, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1140, 46, false);
#line 46 "C:\Users\laert\source\repos\githubproj\githubproj\Views\Home\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.created_at));

#line default
#line hidden
            EndContext();
            BeginContext(1186, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1230, 42, false);
#line 49 "C:\Users\laert\source\repos\githubproj\githubproj\Views\Home\Details.cshtml"
       Write(Html.DisplayFor(model => model.created_at));

#line default
#line hidden
            EndContext();
            BeginContext(1272, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1316, 43, false);
#line 52 "C:\Users\laert\source\repos\githubproj\githubproj\Views\Home\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.git_url));

#line default
#line hidden
            EndContext();
            BeginContext(1359, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1403, 39, false);
#line 55 "C:\Users\laert\source\repos\githubproj\githubproj\Views\Home\Details.cshtml"
       Write(Html.DisplayFor(model => model.git_url));

#line default
#line hidden
            EndContext();
            BeginContext(1442, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1486, 39, false);
#line 58 "C:\Users\laert\source\repos\githubproj\githubproj\Views\Home\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.url));

#line default
#line hidden
            EndContext();
            BeginContext(1525, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1569, 35, false);
#line 61 "C:\Users\laert\source\repos\githubproj\githubproj\Views\Home\Details.cshtml"
       Write(Html.DisplayFor(model => model.url));

#line default
#line hidden
            EndContext();
            BeginContext(1604, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1652, 85, false);
#line 66 "C:\Users\laert\source\repos\githubproj\githubproj\Views\Home\Details.cshtml"
Write(Html.ActionLink("Back to Home", "Index", null, null, new { @class = "btn btn-link" }));

#line default
#line hidden
            EndContext();
            BeginContext(1737, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<githubproj.Models.DetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591