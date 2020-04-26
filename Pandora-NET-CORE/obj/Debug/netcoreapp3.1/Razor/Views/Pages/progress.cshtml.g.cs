#pragma checksum "C:\Users\Marti\source\repos\MartinX122\Pandora-NET-CORE\Pandora-NET-CORE\Views\Pages\progress.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83da23a03e6a6f90c1154773d8546854d6f81bc5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pages_progress), @"mvc.1.0.view", @"/Views/Pages/progress.cshtml")]
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
#line 1 "C:\Users\Marti\source\repos\MartinX122\Pandora-NET-CORE\Pandora-NET-CORE\Views\_ViewImports.cshtml"
using Pandora_NET_CORE;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Marti\source\repos\MartinX122\Pandora-NET-CORE\Pandora-NET-CORE\Views\_ViewImports.cshtml"
using Pandora_NET_CORE.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83da23a03e6a6f90c1154773d8546854d6f81bc5", @"/Views/Pages/progress.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4fd4ad6f872c55489aedbca76f05feb6323ca691", @"/Views/_ViewImports.cshtml")]
    public class Views_Pages_progress : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""row m-3"">
    <div class=""cell-md-4 text-center text-left-md"">
        <h3 class=""dashboard-section-title"">ListView
            <small>ui elements</small>
        </h3>
    </div>

    <div class=""cell-md-8 d-flex flex-justify-center flex-justify-end-md"">
        <ul class=""breadcrumbs bg-transparent"">
            <li class=""page-item""><a href=""#"" class=""page-link""><span class=""mif-meter""></span></a></li>
            <li class=""page-item""><a href=""#"" class=""page-link"">UI Elements</a></li>
            <li class=""page-item""><a href=""#"" class=""page-link"">ListView</a></li>
        </ul>
    </div>
</div>

<div class=""p-1 m-3"">

    <div class=""row"">
        <div class=""cell-lg-6"">
            <div class=""bg-white p-4 h-100"">
                <h2 class=""mt-0"">Progress</h2>
                <hr>
                <h5>Default</h5>
                <div>
                    <div data-role=""progress"" data-value=""35""></div>
                    <div class=""mt-1"" data-role=""progress"" data-value=""35"" data-small=""tr");
            WriteLiteral(@"ue""></div>
                </div>

                <h5>With buffer</h5>
                <div>
                    <div data-role=""progress"" data-type=""buffer"" data-value=""35"" data-buffer=""60""></div>
                    <div class=""mt-1"" data-role=""progress"" data-type=""buffer"" data-value=""35"" data-buffer=""60"" data-small=""true""></div>
                </div>

                <h5>With buffer and locator</h5>
                <div>
                    <div data-role=""progress"" data-type=""load"" data-value=""35"" data-buffer=""75""></div>
                    <div class=""mt-1"" data-role=""progress"" data-type=""load"" data-value=""35"" data-buffer=""75"" data-small=""true""></div>
                </div>

                <h5>Line</h5>
                <div>
                    <div data-role=""progress"" data-type=""line""></div>
                    <div class=""mt-1"" data-role=""progress"" data-type=""line"" data-small=""true""></div>
                </div>

                <h5>Custom colors</h5>
                <div data-role=""progress""
     ");
            WriteLiteral(@"                data-type=""buffer""
                     data-cls-back=""bg-yellow""
                     data-cls-bar=""bg-blue""
                     data-cls-buffer=""bg-pink""
                     data-value=""25"" data-buffer=""65""></div>
            </div>
        </div>

        <div class=""cell-lg-6"">
            <div class=""bg-white p-4 h-100"">
                <h2 class=""mt-0"">Activities</h2>
                <hr>
                <h5>Simple</h5>
                <div class=""row"">
                    <div class=""cell-md-4 bg-dark p-4"">
                        <div data-role=""activity"" data-type=""simple"" class=""mx-auto""></div>
                    </div>
                    <div class=""cell-md-4 p-4"">
                        <div data-role=""activity"" data-type=""simple"" data-style=""dark"" class=""mx-auto""></div>
                    </div>
                    <div class=""cell-md-4 p-4"">
                        <div data-role=""activity"" data-type=""simple"" data-style=""color"" class=""mx-auto""></div>
                    </d");
            WriteLiteral(@"iv>
                </div>

                <h5>Ring</h5>
                <div class=""row"">
                    <div class=""cell-md-4 bg-dark p-4"">
                        <div data-role=""activity"" data-type=""ring"" class=""mx-auto""></div>
                    </div>
                    <div class=""cell-md-4 p-4"">
                        <div data-role=""activity"" data-type=""ring"" data-style=""dark"" class=""mx-auto""></div>
                    </div>
                    <div class=""cell-md-4 p-4"">
                        <div data-role=""activity"" data-type=""ring"" data-style=""color"" class=""mx-auto""></div>
                    </div>
                </div>

                <h5>Metro</h5>
                <div class=""row"">
                    <div class=""cell-md-4 bg-dark p-4"">
                        <div data-role=""activity"" data-type=""metro"" class=""mx-auto""></div>
                    </div>
                    <div class=""cell-md-4 p-4"">
                        <div data-role=""activity"" data-type=""metro"" data-style=""d");
            WriteLiteral(@"ark"" class=""mx-auto""></div>
                    </div>
                    <div class=""cell-md-4 p-4"">
                        <div data-role=""activity"" data-type=""metro"" data-style=""color"" class=""mx-auto""></div>
                    </div>
                </div>

                <h5>Square</h5>
                <div class=""row"">
                    <div class=""cell-md-4 bg-dark p-4"">
                        <div data-role=""activity"" data-type=""square"" class=""mx-auto""></div>
                    </div>
                    <div class=""cell-md-4 p-4"">
                        <div data-role=""activity"" data-type=""square"" data-style=""dark"" class=""mx-auto""></div>
                    </div>
                    <div class=""cell-md-4 p-4"">
                        <div data-role=""activity"" data-type=""square"" data-style=""color"" class=""mx-auto""></div>
                    </div>
                </div>

                <h5>Cycle</h5>
                <div class=""row"">
                    <div class=""cell-md-4 bg-dark p-4"">
   ");
            WriteLiteral(@"                     <div data-role=""activity"" data-type=""cycle"" class=""mx-auto""></div>
                    </div>
                    <div class=""cell-md-4 p-4"">
                        <div data-role=""activity"" data-type=""cycle"" data-style=""dark"" class=""mx-auto""></div>
                    </div>
                    <div class=""cell-md-4 p-4"">
                        <div data-role=""activity"" data-type=""cycle"" data-style=""color"" class=""mx-auto""></div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>");
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
