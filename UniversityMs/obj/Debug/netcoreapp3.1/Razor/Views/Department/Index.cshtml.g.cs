#pragma checksum "C:\Users\simar\source\repos\UniversityMs\UniversityMs\Views\Department\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c95607bd4b97d86b009b4679b5052c536d787ea6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Department_Index), @"mvc.1.0.view", @"/Views/Department/Index.cshtml")]
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
#line 1 "C:\Users\simar\source\repos\UniversityMs\UniversityMs\Views\_ViewImports.cshtml"
using UniversityMs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\simar\source\repos\UniversityMs\UniversityMs\Views\_ViewImports.cshtml"
using UniversityMs.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c95607bd4b97d86b009b4679b5052c536d787ea6", @"/Views/Department/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95d1bc3bbc254e387390222101da229c3da7e82f", @"/Views/_ViewImports.cshtml")]
    public class Views_Department_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\simar\source\repos\UniversityMs\UniversityMs\Views\Department\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""pt-80 pb-130"">
    <div class=""container"">
        <div class=""row pt-120 pb-60"">
            <div class=""col-12 col-lg-8 offset-lg-2"">
                <h1 class=""m-0 pe-30"" style=""text-align: center;"">Kafedralar</h1>
            </div>
        </div>
        <!-- Isotope-->
        <div class=""isotope"">
            <div class=""row isotope-grid gy-30"" style=""position: relative; height: 1585.15px;"">
");
#nullable restore
#line 16 "C:\Users\simar\source\repos\UniversityMs\UniversityMs\Views\Department\Index.cshtml"
                 foreach (var item in Model.Department)
                {


#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class="" isotope-item col-12 col-md-6 col-lg-4"" data-filters=""company""
                         style=""position: absolute; left: 0px; top: 528.385px;"">
                        <!-- Blog-->
                        <div class=""card card-blog  card-vertical card-hover-zoom card-blog-bordered rounded-4 overflow-hidden bg-white"">
                            <a class=""card-img rounded-0"" href=""riyazianaliz-kafedra.html"" data-img-height=""""
                               style=""--img-height: 72%;"">
                                <img loading=""lazy""");
            BeginWriteAttribute("src", "\r\n                                     src=\"", 1124, "\"", 1190, 2);
            WriteAttributeValue("", 1168, "assets/img/", 1168, 11, true);
#nullable restore
#line 26 "C:\Users\simar\source\repos\UniversityMs\UniversityMs\Views\Department\Index.cshtml"
WriteAttributeValue("", 1179, item.Image, 1179, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1191, "\"", 1197, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            </a>\r\n                            <div class=\"card-body py-40 px-50 pb-50\">\r\n                                <a class=\"card-title h4\"\r\n                                   href=\"riyazianaliz-kafedra.html\">");
#nullable restore
#line 30 "C:\Users\simar\source\repos\UniversityMs\UniversityMs\Views\Department\Index.cshtml"
                                                               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                                <!-- Button--><a class=""btn btn-accent-1 btn-link btn-clean""
                                                 href=""riyazianaliz-kafedra.html"" target=""_self"">Learn more</a>
                            </div>
                        </div>
                    </div>
");
#nullable restore
#line 36 "C:\Users\simar\source\repos\UniversityMs\UniversityMs\Views\Department\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class="" isotope-item col-12 col-md-6 col-lg-4"" data-filters=""company""
                     style=""position: absolute; left: 0px; top: 528.385px;"">
                    <!-- Blog-->
                    <div class=""card card-blog  card-vertical card-hover-zoom card-blog-bordered rounded-4 overflow-hidden bg-white"">
                        <a class=""card-img rounded-0"" href=""diftenlik-kafedra.html"" data-img-height=""""
                           style=""--img-height: 72%;"">
                            <img loading=""lazy"" src=""assets/img/Dif_tenlik.jpg""");
            BeginWriteAttribute("alt", "\r\n                                 alt=\"", 2348, "\"", 2388, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </a>
                        <div class=""card-body py-40 px-50 pb-50"">
                            <a class=""card-title h4""
                               href=""diftenlik-kafedra.html"">Diferensial və inteqral tənliklər</a>
                            <p class=""card-text"">
                                Kafedra müdiri:R.ü.d., prof. Yaşar Topuş oğlu Mehrəliyev
                                Mirzəyev
                            </p>
                            <!-- Button--><a class=""btn btn-accent-1 btn-link btn-clean""
                                             href=""diftenlik-kafedra.html"" target=""_self"">
                                Learn
                                more
                            </a>
                        </div>
                    </div>
                </div>
                <div class="" isotope-item col-12 col-md-6 col-lg-4"" data-filters=""company""
                     style=""position: absolute; left: 0px; top: 528.385px;"">
      ");
            WriteLiteral(@"              <!-- Blog-->
                    <d iv
                       class=""card card-blog  card-vertical card-hover-zoom card-blog-bordered rounded-4 overflow-hidden bg-white"">
                        <a class=""card-img rounded-0"" href=""riyaziusullar-kafedrasi.html"" data-img-height=""""
                           style=""--img-height: 72%;"">
                            <img loading=""lazy"" src=""assets/img/idareetme.jpg""");
            BeginWriteAttribute("alt", "\r\n                                 alt=\"", 3845, "\"", 3885, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </a>
                        <div class=""card-body py-40 px-50 pb-50"">
                            <a class=""card-title h4""
                               href=""riyaziusullar-kafedrasi.html"">
                                İdarəetmə nəzəriyyəsinin riyazi
                                üsulları
                            </a>
                            <p class=""card-text"">
                                Kafedra müdiri:F.r.e.d.,prof Hamlet Fərman oğlu Quliyev
                                Mirzəyev
                            </p>
                            <!-- Button--><a class=""btn btn-accent-1 btn-link btn-clean""
                                             href=""riyaziusullar-kafedrasi.html"" target=""_self"">
                                Learn
                                more
                            </a>
                        </div>
                </div>
            </div>
        </div>
    </div>
</div>

");
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
