#pragma checksum "C:\Users\Marti\source\repos\MartinX122\Pandora-NET-CORE\Pandora-NET-CORE\Views\Pages\calendar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68a5a1498114ef680357f03f89fd5efcf9063be2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pages_calendar), @"mvc.1.0.view", @"/Views/Pages/calendar.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68a5a1498114ef680357f03f89fd5efcf9063be2", @"/Views/Pages/calendar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4fd4ad6f872c55489aedbca76f05feb6323ca691", @"/Views/_ViewImports.cshtml")]
    public class Views_Pages_calendar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""row m-3"">
    <div class=""cell-md-4 text-center text-left-md"">
        <h3 class=""dashboard-section-title"">Calendar
            <small>ui elements</small>
        </h3>
    </div>

    <div class=""cell-md-8 d-flex flex-justify-center flex-justify-end-md"">
        <ul class=""breadcrumbs bg-transparent"">
            <li class=""page-item""><a href=""#"" class=""page-link""><span class=""mif-meter""></span></a></li>
            <li class=""page-item""><a href=""#"" class=""page-link"">UI Elements</a></li>
            <li class=""page-item""><a href=""#"" class=""page-link"">Calendar</a></li>
        </ul>
    </div>
</div>

<div class=""p-1 m-3"">
    <div class=""row bg-white"">
        <div class=""cell-lg-4 mt-2 mb-2"">
                <h5 class=""mt-0"">Default</h5>
                <div data-role=""calendar""></div>
        </div>
        <div class=""cell-lg-4 mt-2 mb-2"">
                <h5 class=""mt-0"">Start from monday</h5>
                <div data-role=""calendar"" data-week-start=""1""></div>
        </div>
        <div cla");
            WriteLiteral(@"ss=""cell-lg-4 mt-2 mb-2"">
                <h5 class=""mt-0"">i18n</h5>
                <div data-role=""calendar"" data-week-start=""1"" data-locale=""uk-UA""></div>
        </div>
    </div>
    <br>
    <div class=""row bg-white"">
        <div class=""cell-lg-4 mt-2 mb-2"">
                <h5 class=""mt-0"">Multi select</h5>
                <div data-role=""calendar""  data-multi-select=""true""></div>
        </div>
        <div class=""cell-lg-4 mt-2 mb-2"">
                <h5 class=""mt-0"">One day select</h5>
                <div data-role=""calendar""  data-multi-select=""false""></div>
        </div>
        <div class=""cell-lg-4 mt-2 mb-2"">
                <h5 class=""mt-0"">Picker</h5>
                <div data-role=""calendar"" data-picker-mode=""true""></div>
        </div>
    </div>
    <br>
    <div class=""row bg-white"">
        <div class=""cell-lg-4 mt-2 mb-2"">
                <h5 class=""mt-0"">Exclude days</h5>
                <div
                        data-role=""calendar""
                        data-input-format=""dd-");
            WriteLiteral(@"mm-yyyy""
                        data-show=""15-10-2017""
                        data-exclude=""
                            10-10-2017,
                            11-10-2017,
                            12-10-2017,
                            13-10-2017,
                            14-10-2017,
                            15-10-2017
                         ""
                ></div>
        </div>
        <div class=""cell-lg-4 mt-2 mb-2"">
                <h5 class=""mt-0"">Pre-select days</h5>
                <div
                        data-role=""calendar""
                        data-show=""2017/10/15""
                        data-preset=""
                            2017/10/10,
                            2017/10/11,
                            2017/10/12,
                            2017/10/13,
                            2017/10/14,
                            2017/10/15,
                            2017/10/16""
                ></div>
        </div>
        <div class=""cell-lg-4 mt-2 mb-2"">
                ");
            WriteLiteral(@"<h5 class=""mt-0"">Special days</h5>
                <div
                        data-role=""calendar""
                        data-show=""2017/10/15""
                        data-special=""
                            2017/10/10,
                            2017/10/11,
                            2017/10/12,
                            2017/10/13,
                            2017/10/14,
                            2017/10/15,
                            2017/10/16""
                ></div>
        </div>
    </div>

    <br>
    <div class=""row bg-white"">
        <div class=""cell-lg-4 mt-2 mb-2"">
            <h5 class=""mt-0"">min and max dates</h5>
            <div
                    data-role=""calendar""
                    data-show=""2017/10/15""
                    data-min-date=""2017/10/08""
                    data-max-date=""2017/10/25""
            ></div>
        </div>
        <div class=""cell-lg-4 mt-2 mb-2"">
            <h5 class=""mt-0"">Show specific date</h5>
            <div
                    data-role=");
            WriteLiteral(@"""calendar""
                    data-show=""1972/12/21""
            ></div>
        </div>
        <div class=""cell-lg-4 mt-2 mb-2"">
            <h5 class=""mt-0"">Customize</h5>
            <div
                 data-role=""calendar""
                 data-show=""2017/10/15""
                 data-exclude=""2017/10/01, 2017/10/02, 2017/10/03""
                 data-preset=""2017/10/15, 2017/10/16, 2017/10/17""
                 data-cls-selected=""bg-cyan fg-white""
                 data-cls-excluded=""bg-dark fg-white""
                 data-cls-today=""bg-pink fg-white""
                 data-cls-today-button=""success""
                 data-cls-clear-button=""alert""
                 data-cls-done-button=""primary""
                 data-cls-calendar-header=""bg-green""
                 data-cls-calendar-content=""bg-orange fg-white""
                 data-cls-calendar-footer=""bg-teal""
            ></div>
        </div>
    </div>

    <br>
    <div class=""row bg-white"">
        <div class=""cell-lg-6 mt-2 mb-2"">
            <h5 clas");
            WriteLiteral(@"s=""mt-0"">Wide mode</h5>
            <div data-role=""calendar"" data-wide=""true""></div>
            <h5>Compact wide mode</h5>
            <div class=""compact"" data-role=""calendar"" data-wide=""true""></div>
        </div>
        <div class=""cell-lg-6 mt-2 mb-2"">
            <h5 class=""mt-0"">Compact mode</h5>
            <div class=""compact"" data-role=""calendar""></div>
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
