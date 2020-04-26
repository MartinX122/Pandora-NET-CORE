#pragma checksum "C:\Users\Marti\source\repos\MartinX122\Pandora-NET-CORE\Pandora-NET-CORE\Views\Pages\video.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63ce073b2bfad6cb7d26015eab5aa5ca135fb862"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pages_video), @"mvc.1.0.view", @"/Views/Pages/video.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63ce073b2bfad6cb7d26015eab5aa5ca135fb862", @"/Views/Pages/video.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4fd4ad6f872c55489aedbca76f05feb6323ca691", @"/Views/_ViewImports.cshtml")]
    public class Views_Pages_video : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""row m-3"">
    <div class=""cell-md-4 text-center text-left-md"">
        <h3 class=""dashboard-section-title"">Video player
            <small>media</small>
        </h3>
    </div>

    <div class=""cell-md-8 d-flex flex-justify-center flex-justify-end-md"">
        <ul class=""breadcrumbs bg-transparent"">
            <li class=""page-item""><a href=""#"" class=""page-link""><span class=""mif-meter""></span></a></li>
            <li class=""page-item""><a href=""#"" class=""page-link"">Media</a></li>
            <li class=""page-item""><a href=""#"" class=""page-link"">Video player</a></li>
        </ul>
    </div>
</div>

<div class=""p-1 m-3"">
    <div class=""bg-white p-10"">
        <div class=""text-leader text-center"">Create cool styled view player in one command with Metro 4 video role.</div>
    </div>
    <br>
    <div class=""row"">
        <div class=""cell-lg-3""></div>
        <div class=""cell-lg-6"">
            <div class=""bg-white p-4 win-shadow"">
                <video
                        data-role=""video"" data");
            WriteLiteral(@"-src=""https://metroui.org.ua/res/oceans.mp4""
                        data-poster=""https://metroui.org.ua/res/poster-oceans.jpg""
                        data-logo=""images/p-120x120.png"" data-logo-height=""64""
                ></video>
            </div>
        </div>
        <div class=""cell-lg-3""></div>
    </div>

    <br>

    <h4>Any aspect ration</h4>
    <div class=""row"">
        <div class=""cell-lg-4"">
            <div class=""bg-white p-4"">
                <h5 class=""mt-0"">HD</h5>
                <video data-role=""video"" data-aspect-ratio=""hd"" data-src=""https://metroui.org.ua/res/oceans.mp4"" data-logo=""images/p-120x120.png"" data-logo-height=""64""></video>
            </div>
        </div>
        <div class=""cell-lg-4"">
            <div class=""bg-white p-4"">
                <h5 class=""mt-0"">SD</h5>
                <video data-role=""video"" data-aspect-ratio=""sd"" data-src=""https://metroui.org.ua/res/oceans.mp4"" data-logo=""images/p-120x120.png"" data-logo-height=""64""></video>
            </div>
        </div");
            WriteLiteral(@">
        <div class=""cell-lg-4"">
            <div class=""bg-white p-4"">
                <h5 class=""mt-0"">CINEMA</h5>
                <video data-role=""video"" data-aspect-ratio=""cinema"" data-src=""https://metroui.org.ua/res/oceans.mp4"" data-logo=""images/p-120x120.png"" data-logo-height=""64""></video>
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
