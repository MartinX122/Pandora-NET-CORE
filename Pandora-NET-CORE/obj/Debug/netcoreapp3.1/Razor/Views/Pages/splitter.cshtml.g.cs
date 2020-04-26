#pragma checksum "C:\Users\Marti\source\repos\MartinX122\Pandora-NET-CORE\Pandora-NET-CORE\Views\Pages\splitter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1caabc24ac806851a3b27cb83fc91f0cc11f1b8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pages_splitter), @"mvc.1.0.view", @"/Views/Pages/splitter.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1caabc24ac806851a3b27cb83fc91f0cc11f1b8", @"/Views/Pages/splitter.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4fd4ad6f872c55489aedbca76f05feb6323ca691", @"/Views/_ViewImports.cshtml")]
    public class Views_Pages_splitter : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""row m-3"">
    <div class=""cell-md-4 text-center text-left-md"">
        <h3 class=""dashboard-section-title"">Splitter
            <small>ui elements</small>
        </h3>
    </div>

    <div class=""cell-md-8 d-flex flex-justify-center flex-justify-end-md"">
        <ul class=""breadcrumbs bg-transparent"">
            <li class=""page-item""><a href=""#"" class=""page-link""><span class=""mif-meter""></span></a></li>
            <li class=""page-item""><a href=""#"" class=""page-link"">UI Elements</a></li>
            <li class=""page-item""><a href=""#"" class=""page-link"">Splitter</a></li>
        </ul>
    </div>
</div>

<div class=""p-1 m-3"">
    <div class=""row"">
        <div class=""cell-lg-4"">
            <div class=""bg-white p-4"">
                <h5 class=""mt-0"">Split horizontal</h5>
                <div data-role=""splitter"" style=""height: 400px;"" class=""border bd-default"">
                    <div class=""d-flex flex-justify-center flex-align-center"">This is panel 1</div>
                    <div class=""d-flex fl");
            WriteLiteral(@"ex-justify-center flex-align-center"">This is panel 2</div>
                </div>
            </div>
        </div>
        <div class=""cell-lg-4"">
            <div class=""bg-white p-4"">
                <h5 class=""mt-0"">Split vertical</h5>
                <div data-role=""splitter"" data-split-mode=""vertical"" style=""height: 400px;"" class=""border bd-default"">
                    <div class=""d-flex flex-justify-center flex-align-center"">This is panel 1</div>
                    <div class=""d-flex flex-justify-center flex-align-center"">This is panel 2</div>
                </div>
            </div>
        </div>
        <div class=""cell-lg-4"">
            <div class=""bg-white p-4"">
                <h5 class=""mt-0"">Multi split</h5>
                <div data-role=""splitter"" style=""height: 400px;"" class=""border bd-default"">
                    <div class=""d-flex flex-justify-center flex-align-center"">This is panel 1</div>
                    <div data-role=""splitter"" data-split-mode=""vertical"">
                     ");
            WriteLiteral(@"   <div class=""d-flex flex-justify-center flex-align-center"">Panel 1</div>
                        <div class=""d-flex flex-justify-center flex-align-center"">Panel 2</div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <br>

    <div class=""row"">
        <div class=""cell-lg-4"">
            <div class=""bg-white p-4"">
                <h5 class=""mt-0"">Panels pre-sizes</h5>
                <div data-role=""splitter"" data-split-sizes=""70, 30"" style=""height: 400px;"" class=""border bd-default"">
                    <div class=""d-flex flex-justify-center flex-align-center"">This is panel 1</div>
                    <div class=""d-flex flex-justify-center flex-align-center"">This is panel 2</div>
                </div>
            </div>
        </div>
        <div class=""cell-lg-4"">
            <div class=""bg-white p-4"">
                <h5 class=""mt-0"">Panels min size</h5>
                <div data-role=""splitter"" data-min-sizes=""100"" style=""height: 400px;"" class=""border");
            WriteLiteral(@" bd-default"">
                    <div class=""d-flex flex-justify-center flex-align-center"">This is panel 1</div>
                    <div class=""d-flex flex-justify-center flex-align-center"">This is panel 2</div>
                </div>
            </div>
        </div>
        <div class=""cell-lg-4"">
            <div class=""bg-white p-4"">
                <h5 class=""mt-0"">Gutter size</h5>
                <div data-role=""splitter"" data-gutter-size=""10"" style=""height: 400px;"" class=""border bd-default"">
                    <div class=""d-flex flex-justify-center flex-align-center"">This is panel 1</div>
                    <div class=""d-flex flex-justify-center flex-align-center"">This is panel 2</div>
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
