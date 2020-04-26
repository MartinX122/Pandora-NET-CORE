#pragma checksum "C:\Users\Marti\source\repos\MartinX122\Pandora-NET-CORE\Pandora-NET-CORE\Views\Pages\countdown.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e5bba23bc42786c574fa8ade8fd5acd81110b61"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pages_countdown), @"mvc.1.0.view", @"/Views/Pages/countdown.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e5bba23bc42786c574fa8ade8fd5acd81110b61", @"/Views/Pages/countdown.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4fd4ad6f872c55489aedbca76f05feb6323ca691", @"/Views/_ViewImports.cshtml")]
    public class Views_Pages_countdown : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""row m-3"">
    <div class=""cell-md-4 text-center text-left-md"">
        <h3 class=""dashboard-section-title"">Countdown
            <small>ui elements</small>
        </h3>
    </div>

    <div class=""cell-md-8 d-flex flex-justify-center flex-justify-end-md"">
        <ul class=""breadcrumbs bg-transparent"">
            <li class=""page-item""><a href=""#"" class=""page-link""><span class=""mif-meter""></span></a></li>
            <li class=""page-item""><a href=""#"" class=""page-link"">UI Elements</a></li>
            <li class=""page-item""><a href=""#"" class=""page-link"">Countdown</a></li>
        </ul>
    </div>
</div>

<div class=""p-1 m-3"">
    <div class=""row"">
        <div class=""cell-lg-6"">
            <div class=""bg-white p-4"">
                <h5 class=""mt-0"">Default</h5>
                <div data-role=""countdown"" data-days=""30"" style=""font-size: 64px;""></div>
            </div>
        </div>
        <div class=""cell-lg-6"">
            <div class=""bg-white p-4"">
                <h5 class=""mt-0"">Effect slide");
            WriteLiteral(@"</h5>
                <div data-role=""countdown"" data-days=""30"" data-animate=""slide"" style=""font-size: 64px;""></div>
            </div>
        </div>
    </div>
    <br>
    <div class=""row"">
        <div class=""cell-lg-6"">
            <div class=""bg-white p-4"">
                <h5 class=""mt-0"">Effect fade</h5>
                <div data-role=""countdown"" data-days=""30"" data-animate=""fade"" style=""font-size: 64px;""></div>
            </div>
        </div>
        <div class=""cell-lg-6"">
            <div class=""bg-white p-4"">
                <h5 class=""mt-0"">Effect Zoom</h5>
                <div data-role=""countdown"" data-days=""30"" data-animate=""zoom"" style=""font-size: 64px;""></div>
            </div>
        </div>
    </div>
    <br>
    <div class=""row"">
        <div class=""cell-lg-12"">
            <div class=""bg-white p-4"">
                <h5 class=""mt-0"">i18n</h5>
                <div class=""d-flex flex-justify-center mb-4"">
                    <button class=""button m-1"" onclick=""changeLocale($(this).text(");
            WriteLiteral(@"))"">en-US</button>
                    <button class=""button m-1"" onclick=""changeLocale($(this).text())"">de-DE</button>
                    <button class=""button m-1"" onclick=""changeLocale($(this).text())"">hu-HU</button>
                    <button class=""button m-1"" onclick=""changeLocale($(this).text())"">uk-UA</button>
                    <button class=""button m-1"" onclick=""changeLocale($(this).text())"">ru-RU</button>
                </div>

                <div id=""countdown_locale"" data-role=""countdown"" data-days=""30"" style=""font-size: 64px""></div>

                <script>
                    function changeLocale(locale){
                        $('#countdown_locale').attr('data-locale', locale);
                    }
                </script>
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
