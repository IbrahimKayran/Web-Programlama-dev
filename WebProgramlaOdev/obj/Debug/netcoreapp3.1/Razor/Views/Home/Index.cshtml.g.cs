#pragma checksum "C:\Users\Kayran\Desktop\Web Programlama Projeleri\WebProgramlaOdev\WebProgramlaOdev\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ac02ec25dfeb32e6a87e74a6fd0224ae3393d46"
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
#line 1 "C:\Users\Kayran\Desktop\Web Programlama Projeleri\WebProgramlaOdev\WebProgramlaOdev\Views\_ViewImports.cshtml"
using WebProgramlaOdev;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Kayran\Desktop\Web Programlama Projeleri\WebProgramlaOdev\WebProgramlaOdev\Views\_ViewImports.cshtml"
using WebProgramlaOdev.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ac02ec25dfeb32e6a87e74a6fd0224ae3393d46", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d150743a35bf4c8eee1bc95bfc94216ddf32f28", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Kayran\Desktop\Web Programlama Projeleri\WebProgramlaOdev\WebProgramlaOdev\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- Page Content -->
<div class=""container"">

    <div class=""row"">

        <div class=""col-lg-3"">

            <h2 class=""my-4"">Neler Var</h2>
            <div class=""list-group"">
                <a href=""#"" class=""list-group-item"">Köpekler</a>
                <a href=""#"" class=""list-group-item"">Kediler</a>
                <a href=""#"" class=""list-group-item"">Evcil Hayvan Ürünleri</a>
            </div>

        </div>
        <!-- /.col-lg-3 -->

        <div class=""col-lg-9"">

            <div id=""carouselExampleIndicators"" class=""carousel slide my-4"" data-ride=""carousel"">
                <ol class=""carousel-indicators"">
                    <li data-target=""#carouselExampleIndicators"" data-slide-to=""0"" class=""active""></li>
                    <li data-target=""#carouselExampleIndicators"" data-slide-to=""1""></li>
                    <li data-target=""#carouselExampleIndicators"" data-slide-to=""2""></li>
                </ol>
                <div class=""carousel-inner"" role=""listbox"">
 ");
            WriteLiteral(@"                   <div class=""carousel-item active"">
                        <img class=""d-block img-fluid"" src=""http://placehold.it/900x350"" alt=""First slide"">
                    </div>
                    <div class=""carousel-item"">
                        <img class=""d-block img-fluid"" src=""http://placehold.it/900x350"" alt=""Second slide"">
                    </div>
                    <div class=""carousel-item"">
                        <img class=""d-block img-fluid"" src=""http://placehold.it/900x350"" alt=""Third slide"">
                    </div>
                </div>
                <a class=""carousel-control-prev"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""prev"">
                    <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                    <span class=""sr-only"">Previous</span>
                </a>
                <a class=""carousel-control-next"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""next"">
                    <span class");
            WriteLiteral(@"=""carousel-control-next-icon"" aria-hidden=""true""></span>
                    <span class=""sr-only"">Next</span>
                </a>
            </div>

            <div class=""row"">

                <div class=""col-lg-4 col-md-6 mb-4"">
                    <div class=""card h-100"">
                        <a href=""#""><img class=""card-img-top"" src=""http://placehold.it/700x400""");
            BeginWriteAttribute("alt", " alt=\"", 2510, "\"", 2516, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a>
                        <div class=""card-body"">
                            <h4 class=""card-title"">
                                <a href=""#"">Item One</a>
                            </h4>
                            <h5>$24.99</h5>
                            <p class=""card-text"">Lorem ipsum dolor sit amet, consectetur adipisicing elit. Amet numquam aspernatur!</p>
                        </div>
                        <div class=""card-footer"">
                            <small class=""text-muted"">&#9733; &#9733; &#9733; &#9733; &#9734;</small>
                        </div>
                    </div>
                </div>

                <div class=""col-lg-4 col-md-6 mb-4"">
                    <div class=""card h-100"">
                        <a href=""#""><img class=""card-img-top"" src=""http://placehold.it/700x400""");
            BeginWriteAttribute("alt", " alt=\"", 3368, "\"", 3374, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a>
                        <div class=""card-body"">
                            <h4 class=""card-title"">
                                <a href=""#"">Item Two</a>
                            </h4>
                            <h5>$24.99</h5>
                            <p class=""card-text"">Lorem ipsum dolor sit amet, consectetur adipisicing elit. Amet numquam aspernatur! Lorem ipsum dolor sit amet.</p>
                        </div>
                        <div class=""card-footer"">
                            <small class=""text-muted"">&#9733; &#9733; &#9733; &#9733; &#9734;</small>
                        </div>
                    </div>
                </div>

                <div class=""col-lg-4 col-md-6 mb-4"">
                    <div class=""card h-100"">
                        <a href=""#""><img class=""card-img-top"" src=""http://placehold.it/700x400""");
            BeginWriteAttribute("alt", " alt=\"", 4254, "\"", 4260, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a>
                        <div class=""card-body"">
                            <h4 class=""card-title"">
                                <a href=""#"">Item Three</a>
                            </h4>
                            <h5>$24.99</h5>
                            <p class=""card-text"">Lorem ipsum dolor sit amet, consectetur adipisicing elit. Amet numquam aspernatur!</p>
                        </div>
                        <div class=""card-footer"">
                            <small class=""text-muted"">&#9733; &#9733; &#9733; &#9733; &#9734;</small>
                        </div>
                    </div>
                </div>

                <div class=""col-lg-4 col-md-6 mb-4"">
                    <div class=""card h-100"">
                        <a href=""#""><img class=""card-img-top"" src=""http://placehold.it/700x400""");
            BeginWriteAttribute("alt", " alt=\"", 5114, "\"", 5120, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a>
                        <div class=""card-body"">
                            <h4 class=""card-title"">
                                <a href=""#"">Item Four</a>
                            </h4>
                            <h5>$24.99</h5>
                            <p class=""card-text"">Lorem ipsum dolor sit amet, consectetur adipisicing elit. Amet numquam aspernatur!</p>
                        </div>
                        <div class=""card-footer"">
                            <small class=""text-muted"">&#9733; &#9733; &#9733; &#9733; &#9734;</small>
                        </div>
                    </div>
                </div>

                <div class=""col-lg-4 col-md-6 mb-4"">
                    <div class=""card h-100"">
                        <a href=""#""><img class=""card-img-top"" src=""http://placehold.it/700x400""");
            BeginWriteAttribute("alt", " alt=\"", 5973, "\"", 5979, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a>
                        <div class=""card-body"">
                            <h4 class=""card-title"">
                                <a href=""#"">Item Five</a>
                            </h4>
                            <h5>$24.99</h5>
                            <p class=""card-text"">Lorem ipsum dolor sit amet, consectetur adipisicing elit. Amet numquam aspernatur! Lorem ipsum dolor sit amet.</p>
                        </div>
                        <div class=""card-footer"">
                            <small class=""text-muted"">&#9733; &#9733; &#9733; &#9733; &#9734;</small>
                        </div>
                    </div>
                </div>

                <div class=""col-lg-4 col-md-6 mb-4"">
                    <div class=""card h-100"">
                        <a href=""#""><img class=""card-img-top"" src=""http://placehold.it/700x400""");
            BeginWriteAttribute("alt", " alt=\"", 6860, "\"", 6866, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a>
                        <div class=""card-body"">
                            <h4 class=""card-title"">
                                <a href=""#"">Item Six</a>
                            </h4>
                            <h5>$24.99</h5>
                            <p class=""card-text"">Lorem ipsum dolor sit amet, consectetur adipisicing elit. Amet numquam aspernatur!</p>
                        </div>
                        <div class=""card-footer"">
                            <small class=""text-muted"">&#9733; &#9733; &#9733; &#9733; &#9734;</small>
                        </div>
                    </div>
                </div>

            </div>
            <!-- /.row -->

        </div>
        <!-- /.col-lg-9 -->

    </div>
    <!-- /.row -->

</div>
<!-- /.container -->
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