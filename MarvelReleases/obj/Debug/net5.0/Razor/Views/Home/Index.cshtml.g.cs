#pragma checksum "/home/rafaelg/Estudos/C#/MarvelReleases/MarvelReleases/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d467e41b0b9637228d4ecc0e9d3a96d8168c225"
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
#line 1 "/home/rafaelg/Estudos/C#/MarvelReleases/MarvelReleases/Views/_ViewImports.cshtml"
using MarvelReleases;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/rafaelg/Estudos/C#/MarvelReleases/MarvelReleases/Views/_ViewImports.cshtml"
using MarvelReleases.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d467e41b0b9637228d4ecc0e9d3a96d8168c225", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe9b0906195760e53db3c09c82ddc9d1749626c3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Movie>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "/home/rafaelg/Estudos/C#/MarvelReleases/MarvelReleases/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Página Inicial";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container-sm\">\r\n    <div class=\"row justify-content-center\">\r\n        <div class=\"col-8\">\r\n            <div class=\"album\">\r\n");
#nullable restore
#line 10 "/home/rafaelg/Estudos/C#/MarvelReleases/MarvelReleases/Views/Home/Index.cshtml"
                 foreach (var movie in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"card shadow mb-4\">\r\n                        <div class=\"card-body\">\r\n                            <h1 class=\"card-title\">");
#nullable restore
#line 14 "/home/rafaelg/Estudos/C#/MarvelReleases/MarvelReleases/Views/Home/Index.cshtml"
                                              Write(movie.MovieName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n");
#nullable restore
#line 17 "/home/rafaelg/Estudos/C#/MarvelReleases/MarvelReleases/Views/Home/Index.cshtml"
                             if(movie.ReleaseDate != null)
                            {   

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <p class=\"card-text\"><strong>Lançamento:</strong> ");
#nullable restore
#line 19 "/home/rafaelg/Estudos/C#/MarvelReleases/MarvelReleases/Views/Home/Index.cshtml"
                                                                             Write(movie.ReleaseDate.Value.ToString("M"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" de ");
#nullable restore
#line 19 "/home/rafaelg/Estudos/C#/MarvelReleases/MarvelReleases/Views/Home/Index.cshtml"
                                                                                                                       Write(movie.ReleaseDate.Value.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 20 "/home/rafaelg/Estudos/C#/MarvelReleases/MarvelReleases/Views/Home/Index.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <p class=\"card-text\"><strong>Lançamento:</strong> Sem data definida</p>\r\n");
#nullable restore
#line 24 "/home/rafaelg/Estudos/C#/MarvelReleases/MarvelReleases/Views/Home/Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p><strong>O que é:</strong> ");
#nullable restore
#line 25 "/home/rafaelg/Estudos/C#/MarvelReleases/MarvelReleases/Views/Home/Index.cshtml"
                                                    Write(movie.Genre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                        <img class=\"card-img-bottom img-fluid\"");
            BeginWriteAttribute("src", " src=\"", 1169, "\"", 1185, 1);
#nullable restore
#line 27 "/home/rafaelg/Estudos/C#/MarvelReleases/MarvelReleases/Views/Home/Index.cshtml"
WriteAttributeValue("", 1175, movie.Img, 1175, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1186, "\"", 1208, 1);
#nullable restore
#line 27 "/home/rafaelg/Estudos/C#/MarvelReleases/MarvelReleases/Views/Home/Index.cshtml"
WriteAttributeValue("", 1192, movie.MovieName, 1192, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"300\">\r\n                    </div>\r\n");
#nullable restore
#line 29 "/home/rafaelg/Estudos/C#/MarvelReleases/MarvelReleases/Views/Home/Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Movie>> Html { get; private set; }
    }
}
#pragma warning restore 1591
