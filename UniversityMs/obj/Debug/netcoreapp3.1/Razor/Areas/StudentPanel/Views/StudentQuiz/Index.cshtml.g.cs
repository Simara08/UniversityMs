#pragma checksum "C:\Users\simar\source\repos\UniversityMs\UniversityMs\Areas\StudentPanel\Views\StudentQuiz\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eda8df63bd08206fb26cacd2863896e9cd0384f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_StudentPanel_Views_StudentQuiz_Index), @"mvc.1.0.view", @"/Areas/StudentPanel/Views/StudentQuiz/Index.cshtml")]
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
#line 1 "C:\Users\simar\source\repos\UniversityMs\UniversityMs\Areas\StudentPanel\Views\_ViewImports.cshtml"
using UniversityMs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\simar\source\repos\UniversityMs\UniversityMs\Areas\StudentPanel\Views\_ViewImports.cshtml"
using UniversityMs.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\simar\source\repos\UniversityMs\UniversityMs\Areas\StudentPanel\Views\StudentQuiz\Index.cshtml"
using UniversityMs.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eda8df63bd08206fb26cacd2863896e9cd0384f4", @"/Areas/StudentPanel/Views/StudentQuiz/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95d1bc3bbc254e387390222101da229c3da7e82f", @"/Areas/StudentPanel/Views/_ViewImports.cshtml")]
    public class Areas_StudentPanel_Views_StudentQuiz_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CourseVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-bottom:10px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\simar\source\repos\UniversityMs\UniversityMs\Areas\StudentPanel\Views\StudentQuiz\Index.cshtml"
  
    ViewData["Title"] = "Index";
    int count = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"box-body\" style=\"margin:80px;\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eda8df63bd08206fb26cacd2863896e9cd0384f45126", async() => {
                WriteLiteral("+Add Seminar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    <div class=""table-responsive mb-0"">
        <table class=""table no-border"" style=""color: rgb(165, 63, 255);"">
            <thead>
                <tr class=""text-uppercase bg-lightest"">
                    <th style=""min-width: 50px"">
                        #
                    </th>
                    <th style=""min-width: 50px"">
                        Student
                    </th>
                    <th style=""min-width: 170px"">
                        <span>Quiz </span>
                    </th>
                    <th style=""min-width: 170px"">
                        <span>Exam </span>
                    </th>
                    <th style=""min-width: 170px"">
                        <span>Research Project</span>
                    </th>
                    <th style=""min-width: 170px"">
                        <span>Research Topic</span>
                    </th>
                    <th style=""min-width: 120px""></th>
                </tr>
            </thead>
     ");
            WriteLiteral("       <tbody>\r\n");
#nullable restore
#line 36 "C:\Users\simar\source\repos\UniversityMs\UniversityMs\Areas\StudentPanel\Views\StudentQuiz\Index.cshtml"
                 foreach (var course in Model.Course)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 40 "C:\Users\simar\source\repos\UniversityMs\UniversityMs\Areas\StudentPanel\Views\StudentQuiz\Index.cshtml"
                   Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n");
#nullable restore
#line 43 "C:\Users\simar\source\repos\UniversityMs\UniversityMs\Areas\StudentPanel\Views\StudentQuiz\Index.cshtml"
                         foreach (var item in course.CourseSturucture.SectionCourseStruc)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Users\simar\source\repos\UniversityMs\UniversityMs\Areas\StudentPanel\Views\StudentQuiz\Index.cshtml"
                             foreach (var temp in item.UserSectionCourseStruc)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span class=\"text-dark fw-600 d-block fs-16\">\r\n                                    ");
#nullable restore
#line 48 "C:\Users\simar\source\repos\UniversityMs\UniversityMs\Areas\StudentPanel\Views\StudentQuiz\Index.cshtml"
                               Write(temp.User.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("+");
#nullable restore
#line 48 "C:\Users\simar\source\repos\UniversityMs\UniversityMs\Areas\StudentPanel\Views\StudentQuiz\Index.cshtml"
                                                    Write(temp.User.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </span>\r\n");
#nullable restore
#line 50 "C:\Users\simar\source\repos\UniversityMs\UniversityMs\Areas\StudentPanel\Views\StudentQuiz\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Users\simar\source\repos\UniversityMs\UniversityMs\Areas\StudentPanel\Views\StudentQuiz\Index.cshtml"
                                 
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n                    <td>\r\n");
#nullable restore
#line 54 "C:\Users\simar\source\repos\UniversityMs\UniversityMs\Areas\StudentPanel\Views\StudentQuiz\Index.cshtml"
                         foreach (var item in course.CourseSturucture.SectionCourseStruc)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "C:\Users\simar\source\repos\UniversityMs\UniversityMs\Areas\StudentPanel\Views\StudentQuiz\Index.cshtml"
                             foreach (var temp in item.CourseQuiz)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span class=\"text-dark fw-600 d-block fs-16\">\r\n                                    ");
#nullable restore
#line 59 "C:\Users\simar\source\repos\UniversityMs\UniversityMs\Areas\StudentPanel\Views\StudentQuiz\Index.cshtml"
                               Write(temp.Quiz.Mark);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </span>\r\n");
#nullable restore
#line 61 "C:\Users\simar\source\repos\UniversityMs\UniversityMs\Areas\StudentPanel\Views\StudentQuiz\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "C:\Users\simar\source\repos\UniversityMs\UniversityMs\Areas\StudentPanel\Views\StudentQuiz\Index.cshtml"
                             

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                    <td>\r\n");
#nullable restore
#line 66 "C:\Users\simar\source\repos\UniversityMs\UniversityMs\Areas\StudentPanel\Views\StudentQuiz\Index.cshtml"
                         foreach (var item in course.CourseSturucture.SectionCourseStruc)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 68 "C:\Users\simar\source\repos\UniversityMs\UniversityMs\Areas\StudentPanel\Views\StudentQuiz\Index.cshtml"
                             foreach (var temp in item.ExamCourseStruc)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span class=\"text-dark fw-600 d-block fs-16\">\r\n                                    ");
#nullable restore
#line 71 "C:\Users\simar\source\repos\UniversityMs\UniversityMs\Areas\StudentPanel\Views\StudentQuiz\Index.cshtml"
                               Write(temp.Exam.Mark);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </span>\r\n");
#nullable restore
#line 73 "C:\Users\simar\source\repos\UniversityMs\UniversityMs\Areas\StudentPanel\Views\StudentQuiz\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 73 "C:\Users\simar\source\repos\UniversityMs\UniversityMs\Areas\StudentPanel\Views\StudentQuiz\Index.cshtml"
                             
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </td>
                    <td>

                        <span class=""text-dark fw-600 d-block fs-16"">

                        </span>
                    </td>
                    <td>
                        <span class=""text-dark fw-600 d-block fs-16"">

                        </span>
                    </td>
                </tr>
");
#nullable restore
#line 88 "C:\Users\simar\source\repos\UniversityMs\UniversityMs\Areas\StudentPanel\Views\StudentQuiz\Index.cshtml"
                    count++;
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CourseVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
