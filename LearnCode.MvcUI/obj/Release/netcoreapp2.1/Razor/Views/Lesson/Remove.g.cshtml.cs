#pragma checksum "C:\Users\CODER\source\repos\LearnCode\LearnCode.MvcUI\Views\Lesson\Remove.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c99097e97d66bb40fbaae89a2f40f2b75a91fe5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Lesson_Remove), @"mvc.1.0.view", @"/Views/Lesson/Remove.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Lesson/Remove.cshtml", typeof(AspNetCore.Views_Lesson_Remove))]
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
#line 1 "C:\Users\CODER\source\repos\LearnCode\LearnCode.MvcUI\Views\_ViewImports.cshtml"
using LearnCode.MvcUI;

#line default
#line hidden
#line 2 "C:\Users\CODER\source\repos\LearnCode\LearnCode.MvcUI\Views\_ViewImports.cshtml"
using LearnCode.MvcUI.Models;

#line default
#line hidden
#line 3 "C:\Users\CODER\source\repos\LearnCode\LearnCode.MvcUI\Views\_ViewImports.cshtml"
using LearnCode.Entities;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c99097e97d66bb40fbaae89a2f40f2b75a91fe5", @"/Views/Lesson/Remove.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3913d721defe5cad5f51091e290b82346c5402b", @"/Views/_ViewImports.cshtml")]
    public class Views_Lesson_Remove : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LearnCode.MvcUI.Models.ListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-group"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-comfirm", new global::Microsoft.AspNetCore.Html.HtmlString("Are you Sure Delete Lesson"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-method", new global::Microsoft.AspNetCore.Html.HtmlString("post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-complete", new global::Microsoft.AspNetCore.Html.HtmlString("completed"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\CODER\source\repos\LearnCode\LearnCode.MvcUI\Views\Lesson\Remove.cshtml"
  
    ViewData["Title"] = "Remove";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(134, 732, true);
            WriteLiteral(@"

<div class=""container-fluid"">

    <div class=""form-group form-inline"">

        <input class=""form-control"" type=""text"" placeholder=""Search lesson..."" name=""search"" />
        <button class=""btn btn-success""><span class=""glyphicon glyphicon-search""></span>  Lesson Search</button>

    </div>

</div>

<div class=""container"" style=""margin-top:10px"">


    <table class=""table table-bordered"">
        <thead>
            <tr>
                <td>
                    Lesson Name
                </td>
                <td>
                    Creat Date
                </td>
                <td>
                    Action
                </td>
            </tr>
        </thead>
        <tbody>

");
            EndContext();
#line 38 "C:\Users\CODER\source\repos\LearnCode\LearnCode.MvcUI\Views\Lesson\Remove.cshtml"
             foreach (var item in Model.Lessons)
            {

#line default
#line hidden
            BeginContext(931, 19, true);
            WriteLiteral("                <tr");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 950, "\"", 963, 1);
#line 40 "C:\Users\CODER\source\repos\LearnCode\LearnCode.MvcUI\Views\Lesson\Remove.cshtml"
WriteAttributeValue("", 955, item.id, 955, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(964, 27, true);
            WriteLiteral(">\r\n                    <td>");
            EndContext();
            BeginContext(992, 15, false);
#line 41 "C:\Users\CODER\source\repos\LearnCode\LearnCode.MvcUI\Views\Lesson\Remove.cshtml"
                   Write(item.LessonName);

#line default
#line hidden
            EndContext();
            BeginContext(1007, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1039, 14, false);
#line 42 "C:\Users\CODER\source\repos\LearnCode\LearnCode.MvcUI\Views\Lesson\Remove.cshtml"
                   Write(item.CreatTime);

#line default
#line hidden
            EndContext();
            BeginContext(1053, 176, true);
            WriteLiteral("</td>\r\n                    <td>\r\n                        <div class=\"form-inline\" style=\"color:white!important;\">\r\n                           \r\n                                ");
            EndContext();
            BeginContext(1229, 474, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ea2c6af11ecf457fa734d6db1e6a7b7d", async() => {
                BeginContext(1389, 83, true);
                WriteLiteral("\r\n                                    <input class=\"hidden\" type=\"hidden\" name=\"id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1472, "\"", 1488, 1);
#line 47 "C:\Users\CODER\source\repos\LearnCode\LearnCode.MvcUI\Views\Lesson\Remove.cshtml"
WriteAttributeValue("", 1480, item.id, 1480, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1489, 207, true);
                WriteLiteral(" />\r\n                                    <button class=\"btn btn-danger\"><span class=\"glyphicon glyphicon-trash\"></span> Delete\r\n                                    </button>\r\n                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1703, 238, true);
            WriteLiteral("\r\n                             \r\n                            <button class=\"btn btn-info\"><span class=\"glyphicon glyphicon-edit\"></span> Update</button>\r\n                        </div>\r\n\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 57 "C:\Users\CODER\source\repos\LearnCode\LearnCode.MvcUI\Views\Lesson\Remove.cshtml"
            }

#line default
#line hidden
            BeginContext(1956, 67, true);
            WriteLiteral("\r\n        </tbody>\r\n        <tfoot>\r\n            <tr>Total Count : ");
            EndContext();
            BeginContext(2024, 19, false);
#line 61 "C:\Users\CODER\source\repos\LearnCode\LearnCode.MvcUI\Views\Lesson\Remove.cshtml"
                         Write(Model.Lessons.Count);

#line default
#line hidden
            EndContext();
            BeginContext(2043, 212, true);
            WriteLiteral("</tr>\r\n        </tfoot>\r\n\r\n    </table>\r\n\r\n</div>\r\n\r\n\r\n<script>\r\n\r\n  \r\n\r\n \r\n    function completed(xhr, status) {\r\n               \r\n        document.getElementById(xhr.responseText).remove()\r\n    }\r\n\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LearnCode.MvcUI.Models.ListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
