#pragma checksum "C:\Users\Marti\source\repos\MartinX122\Pandora-NET-CORE\Pandora-NET-CORE\Views\Pages\notifies.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "686d3fa7ef3407749a8ee83866f850abf7e0abed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pages_notifies), @"mvc.1.0.view", @"/Views/Pages/notifies.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"686d3fa7ef3407749a8ee83866f850abf7e0abed", @"/Views/Pages/notifies.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4fd4ad6f872c55489aedbca76f05feb6323ca691", @"/Views/_ViewImports.cshtml")]
    public class Views_Pages_notifies : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""row m-3"">
    <div class=""cell-md-4 text-center text-left-md"">
        <h3 class=""dashboard-section-title"">Notifies
            <small>ui elements</small>
        </h3>
    </div>

    <div class=""cell-md-8 d-flex flex-justify-center flex-justify-end-md"">
        <ul class=""breadcrumbs bg-transparent"">
            <li class=""page-item""><a href=""#"" class=""page-link""><span class=""mif-meter""></span></a></li>
            <li class=""page-item""><a href=""#"" class=""page-link"">UI Elements</a></li>
            <li class=""page-item""><a href=""#"" class=""page-link"">Notifies</a></li>
        </ul>
    </div>
</div>

<div class=""m-3 p-6 bg-white"">
    <p class=""text-leader text-center"">
        The system of notifications is intended for informing users about the processes occurring on the site or in the application.
    </p>
</div>

<div class=""bg-white p-4 text-center"">
    <h5 class=""mt-0"">General</h5>
    <button class=""button primary mt-1"" onclick=""simpleNotify()"">Create notify</button>
    <button class=""bu");
            WriteLiteral(@"tton secondary mt-1"" onclick=""setupNotify()"">Setup notify</button>
    <button class=""button info mt-1"" onclick=""keepNotify()"">Keep open</button>
    <button class=""button success mt-1"" onclick=""callbackNotify()"">Callback</button>
    <button class=""button alert mt-1"" onclick=""classNotify()"">Additional classe</button>
</div>

<script>
    function simpleNotify(){
        return Metro.notify.create('This is a notify', 'Title', {});
    }

    function setupNotify(){
        var notify = Metro.notify;
        notify.setup({
            width: 300,
            duration: 1000,
            animation: 'easeOutBounce'
        });
        notify.create(""This is a notify"", """", {});
        notify.reset();
    }

    function classNotify(){
        var notify = Metro.notify;
        notify.create(""This is a notify with additional class."", null, {
            cls: ""alert""
        });
    }

    function keepNotify(){
        var notify = Metro.notify;
        notify.create(""This is a notify. Click me to close."", null, {");
            WriteLiteral(@"
            keepOpen: true
        });
    }

    function callbackNotify(){
        var notify = Metro.notify;
        notify.create(""This is a notify."", null, {
            onClose: function(){
                alert('Hi from notification callback');
            }
        });
    }

</script>");
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
