#pragma checksum "C:\Users\laert\source\repos\githubproj\githubproj\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c98e9884fa30608f33d471d736af7331d381d1f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c98e9884fa30608f33d471d736af7331d381d1f", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8eb40f2aec50807f1ca17883ec4d10e3f23e401", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RepoViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-top:10px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/notfound.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(22, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\laert\source\repos\githubproj\githubproj\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Github Repositories Searcher";

#line default
#line hidden
            BeginContext(88, 33, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n\r\n    ");
            EndContext();
            BeginContext(121, 692, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "14bc4d6952af45ec9b3a7f7c71c9e06a", async() => {
                BeginContext(225, 581, true);
                WriteLiteral(@"
        <div class=""form-group mx-sm-3 mb-2"">
            <label for=""search"">Here you can search any repo on Github. Try it now!</label>
            <input type=""text"" name=""SearchString"" class=""form-control"" id=""search"" aria-describedby=""searchHelp"" placeholder=""Ex. python, javascript"">
        </div>
        <hidden id=""searchHidden"" value=""""></hidden>
        <button type=""submit"" value=""Filter"" class=""btn btn-primary mb-2"">Search in Github</button>
        <button type=""submit"" value=""own"" name=""own"" class=""btn btn-success mb-2"">Search in Own Repo</button>
    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(813, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 18 "C:\Users\laert\source\repos\githubproj\githubproj\Views\Home\Index.cshtml"
     if (TempData["Message"] != null)
    {

#line default
#line hidden
            BeginContext(861, 42, true);
            WriteLiteral("        <div class=\"center\">\r\n            ");
            EndContext();
            BeginContext(903, 35, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a8dacb17c76449749aaaedfd0eb7f0ca", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(938, 19, true);
            WriteLiteral("\r\n            <div>");
            EndContext();
            BeginContext(958, 19, false);
#line 22 "C:\Users\laert\source\repos\githubproj\githubproj\Views\Home\Index.cshtml"
            Write(TempData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(977, 24, true);
            WriteLiteral("</div>\r\n        </div>\r\n");
            EndContext();
#line 24 "C:\Users\laert\source\repos\githubproj\githubproj\Views\Home\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1008, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 27 "C:\Users\laert\source\repos\githubproj\githubproj\Views\Home\Index.cshtml"
     if (Model != null)
    {

#line default
#line hidden
            BeginContext(1044, 33, true);
            WriteLiteral("        <div class=\"card-deck\">\r\n");
            EndContext();
#line 30 "C:\Users\laert\source\repos\githubproj\githubproj\Views\Home\Index.cshtml"
             foreach (var item in Model.items)
            {


#line default
#line hidden
            BeginContext(1142, 196, true);
            WriteLiteral("                <div class=\"card card-block col-md-3\" style=\"margin:0px; margin-top:100px\">\r\n                    <img class=\"bd-placeholder-img card-img-top\"\r\n                         height=\"200\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1338, "\"", 1366, 1);
#line 35 "C:\Users\laert\source\repos\githubproj\githubproj\Views\Home\Index.cshtml"
WriteAttributeValue("", 1344, item.owner.avatar_url, 1344, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1367, 204, true);
            WriteLiteral(" />\r\n\r\n                    <div class=\"card-body\">\r\n                        <h5 class=\"card-title\"></h5>\r\n                        <p class=\"card-text\">\r\n                            <h5 class=\"card-title\">");
            EndContext();
            BeginContext(1572, 16, false);
#line 40 "C:\Users\laert\source\repos\githubproj\githubproj\Views\Home\Index.cshtml"
                                              Write(item.owner.login);

#line default
#line hidden
            EndContext();
            BeginContext(1588, 108, true);
            WriteLiteral("</h5>\r\n                        </p>\r\n                        <p class=\"card-text\"><small class=\"text-muted\">");
            EndContext();
            BeginContext(1697, 14, false);
#line 42 "C:\Users\laert\source\repos\githubproj\githubproj\Views\Home\Index.cshtml"
                                                                  Write(item.full_name);

#line default
#line hidden
            EndContext();
            BeginContext(1711, 38, true);
            WriteLiteral("</small></p>\r\n                        ");
            EndContext();
            BeginContext(1750, 102, false);
#line 43 "C:\Users\laert\source\repos\githubproj\githubproj\Views\Home\Index.cshtml"
                   Write(Html.ActionLink("Check and Save!", "Details", new { url = item.url }, new { @class = "btn btn-info" }));

#line default
#line hidden
            EndContext();
            BeginContext(1852, 54, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
#line 46 "C:\Users\laert\source\repos\githubproj\githubproj\Views\Home\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1921, 16, true);
            WriteLiteral("        </div>\r\n");
            EndContext();
#line 48 "C:\Users\laert\source\repos\githubproj\githubproj\Views\Home\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1944, 117, true);
            WriteLiteral("</div>\r\n\r\n<style>\r\n    .center {\r\n        margin: auto;\r\n        width: 50%;\r\n        padding: 50px;\r\n    }\r\n</style>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RepoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
