#pragma checksum "C:\Users\Marti\source\repos\MartinX122\Pandora-NET-CORE\Pandora-NET-CORE\Views\Pages\toasts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "72ed4554f1a457f1a471d48d76c29ff19b98cdf4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pages_toasts), @"mvc.1.0.view", @"/Views/Pages/toasts.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72ed4554f1a457f1a471d48d76c29ff19b98cdf4", @"/Views/Pages/toasts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4fd4ad6f872c55489aedbca76f05feb6323ca691", @"/Views/_ViewImports.cshtml")]
    public class Views_Pages_toasts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""row m-3"">
    <div class=""cell-md-4 text-center text-left-md"">
        <h3 class=""dashboard-section-title"">Toasts
            <small>ui elements</small>
        </h3>
    </div>

    <div class=""cell-md-8 d-flex flex-justify-center flex-justify-end-md"">
        <ul class=""breadcrumbs bg-transparent"">
            <li class=""page-item""><a href=""#"" class=""page-link""><span class=""mif-meter""></span></a></li>
            <li class=""page-item""><a href=""#"" class=""page-link"">UI Elements</a></li>
            <li class=""page-item""><a href=""#"" class=""page-link"">Toasts</a></li>
        </ul>
    </div>
</div>

<div class=""m-3 p-6 bg-white"">
    <p class=""text-leader text-center"">
        Toasts are used for system messaging. They also display at the bottom of the screen, but may not be swiped off-screen. Metro 4 provides simple methods to create toasts.
    </p>
</div>

<div class=""p-1 m-3"">
    <div class=""bg-white p-4 text-center"">
        <h5 class=""mt-0"">General</h5>
        <button class=""button primary m");
            WriteLiteral(@"t-1"" onclick=""runToast()"">Default toast</button>
        <button class=""button secondary mt-1"" onclick=""runToast('callback')"">Toast with a callback</button>
        <button class=""button info mt-1"" onclick=""runToast('timeout')"">Toast timeout</button>
        <button class=""button success mt-1"" onclick=""runToast('class')"">Toast custom class</button>
        <button class=""button alert mt-1"" onclick=""runToast('options')"">Toast options</button>
    </div>
    <br>
    <div class=""bg-white p-4 text-center"">
        <h5 class=""mt-0"">Accent classes</h5>
        <button class=""button primary mt-1"" onclick=""toastClasses('primary')"">Primary</button>
        <button class=""button secondary mt-1"" onclick=""toastClasses('secondary')"">Secondary</button>
        <button class=""button success mt-1"" onclick=""toastClasses('success')"">Success</button>
        <button class=""button alert mt-1"" onclick=""toastClasses('alert')"">Alert</button>
        <button class=""button warning mt-1"" onclick=""toastClasses('warning')"">Warning</but");
            WriteLiteral(@"ton>
        <button class=""button yellow mt-1"" onclick=""toastClasses('yellow')"">Yellow</button>
        <button class=""button info mt-1"" onclick=""toastClasses('info')"">Info</button>
        <button class=""button light mt-1"" onclick=""toastClasses('light')"">Light</button>
    </div>
</div>

<script>
    function runToast(mode) {
        var toast = Metro.toast.create;
        switch (mode) {
            case 'callback': toast(""This is a toast with callback"", function(){alert('Toast callback executed!');}); break;
            case 'timeout': toast(""This is a toast with timeout 5s"", null, 5000); break;
            case 'class': toast(""This is a toast with custom class"", null, 5000, ""bg-green fg-white""); break;
            case 'options': toastOptions(); break;
            default: toast(""This is default toast"");
        }
    }

    function toastClasses(cls){
        var toast = Metro.toast.create;
        toast(""This is a toast with a predefined class ."" + cls, null, 5000, cls);
    }

    function toastOption");
            WriteLiteral("s(){\n        var options = {\n            showTop: true,\n            timeout: 3000,\n            distance: 64,\n            clsToast: \'alert\'\n        };\n        Metro.toast.create(\"Toast message\", null, null, null, options);\n    }\n</script>\n");
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