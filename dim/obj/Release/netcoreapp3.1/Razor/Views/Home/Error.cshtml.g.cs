#pragma checksum "C:\Users\Marian\Source\Repos\RemontniResheniqRELEASE\dim\Views\Home\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7da74cfeded59526e2cea300ad4851b166695925"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Error), @"mvc.1.0.view", @"/Views/Home/Error.cshtml")]
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
#line 1 "C:\Users\Marian\Source\Repos\RemontniResheniqRELEASE\dim\Views\_ViewImports.cshtml"
using dim;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Marian\Source\Repos\RemontniResheniqRELEASE\dim\Views\_ViewImports.cshtml"
using dim.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7da74cfeded59526e2cea300ad4851b166695925", @"/Views/Home/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7459df878d98ea5592d58e433ee426e380a7b00e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Marian\Source\Repos\RemontniResheniqRELEASE\dim\Views\Home\Error.cshtml"
  
    ViewData["Title"] = "Error";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\" class=\"wide wow-animation\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7da74cfeded59526e2cea300ad4851b1666959253473", async() => {
                WriteLiteral(@"
    <title>Home</title>
    <meta name=""format-detection"" content=""telephone=no"">
    <meta name=""viewport"" content=""width=device-width, height=device-height, initial-scale=1.0, maximum-scale=1.0, user-scalable=0"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta charset=""utf-8"">
    <link rel=""stylesheet"" type=""text/css"" href=""css/css.css?family=Open+Sans:400,700,400italic,600italic,900"">
    <link rel=""stylesheet"" href=""css/style.css"">
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7da74cfeded59526e2cea300ad4851b1666959254930", async() => {
                WriteLiteral(@"
    <div class=""page section-single bg-venice-blue"">
        <header class=""page-head"">
            <section>
                <div class=""shell text-center"">
                    <div class=""brand-wrap""><a href=""index.html"" class=""brand""><img src=""images/logo-white-250x40.png""");
                BeginWriteAttribute("alt", " alt=\"", 878, "\"", 884, 0);
                EndWriteAttribute();
                WriteLiteral(@" width=""250"" height=""40"" /></a></div>
                </div>
            </section>
        </header>
        <main class=""page-content text-center"">
            <section>
                <div class=""shell"">
                    <div class=""range range-sm-center"">
                        <div class=""cell-md-10 cell-lg-8"">
                            <h1 class=""h5-variant-1""><strong>Грешка 404 страницате не е намерене!</strong></h1>
                            <div class=""text-extra-big"">404</div>
                            <div class=""offset-top-35 offset-sm-top-50"">
                                <div class=""group-xl""><a href=""index"" class=""btn btn-primary-variant-1 btn-mod-1"">Обратно към сайта</a><a href=""Contact"" class=""btn btn-white-outline btn-mod-2"">контакти</a></div>
                            </div>
                        </div>
                    </div>
                </div>
            </section>
        </main>
        <footer class=""page-foot"">
            <div class=""shel");
                WriteLiteral(@"l text-center"">
                <p class=""rights"">&#169;&nbsp;<span id=""copyright-year""></span>&nbsp;Всички права запазени&nbsp;</p>
            </div>
        </footer>
    </div>
    <div id=""form-output-global"" class=""snackbars""></div>
    <div tabindex=""-1"" role=""dialog"" aria-hidden=""true"" class=""pswp"">
        <div class=""pswp__bg""></div>
        <div class=""pswp__scroll-wrap"">
            <div class=""pswp__container"">
                <div class=""pswp__item""></div>
                <div class=""pswp__item""></div>
                <div class=""pswp__item""></div>
            </div>
            <div class=""pswp__ui pswp__ui--hidden"">
                <div class=""pswp__top-bar"">
                    <div class=""pswp__counter""></div>
                    <button title=""Close (Esc)"" class=""pswp__button pswp__button--close""></button>
                    <button title=""Share"" class=""pswp__button pswp__button--share""></button>
                    <button title=""Toggle fullscreen"" class=""pswp__button p");
                WriteLiteral(@"swp__button--fs""></button>
                    <button title=""Zoom in/out"" class=""pswp__button pswp__button--zoom""></button>
                    <div class=""pswp__preloader"">
                        <div class=""pswp__preloader__icn"">
                            <div class=""pswp__preloader__cut"">
                                <div class=""pswp__preloader__donut""></div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""pswp__share-modal pswp__share-modal--hidden pswp__single-tap"">
                    <div class=""pswp__share-tooltip""></div>
                </div>
                <button title=""Previous (arrow left)"" class=""pswp__button pswp__button--arrow--left""></button>
                <button title=""Next (arrow right)"" class=""pswp__button pswp__button--arrow--right""></button>
                <div class=""pswp__caption"">
                    <div class=""pswp__caption__cent""></div>
                </div");
                WriteLiteral(">\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <script src=\"js/core.min.js\"></script>\r\n    <script src=\"js/script.js\"></script>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n\r\n");
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
