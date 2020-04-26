#pragma checksum "C:\Users\Marti\source\repos\MartinX122\Pandora-NET-CORE\Pandora-NET-CORE\Views\Pages\dialogs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "452476e3b576e4d9cf3d0fabcbc93ebe1a8f9dc4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pages_dialogs), @"mvc.1.0.view", @"/Views/Pages/dialogs.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"452476e3b576e4d9cf3d0fabcbc93ebe1a8f9dc4", @"/Views/Pages/dialogs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4fd4ad6f872c55489aedbca76f05feb6323ca691", @"/Views/_ViewImports.cshtml")]
    public class Views_Pages_dialogs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""row m-3"">
    <div class=""cell-md-4 text-center text-left-md"">
        <h3 class=""dashboard-section-title"">Dialog
            <small>information</small>
        </h3>
    </div>

    <div class=""cell-md-8 d-flex flex-justify-center flex-justify-end-md"">
        <ul class=""breadcrumbs bg-transparent"">
            <li class=""page-item""><a href=""#"" class=""page-link""><span class=""mif-meter""></span></a></li>
            <li class=""page-item""><a href=""#"" class=""page-link"">Information</a></li>
            <li class=""page-item""><a href=""#"" class=""page-link"">Dialog</a></li>
        </ul>
    </div>
</div>

<div id=""demoDialog1"" class=""dialog"" data-role=""dialog"">
    <div class=""dialog-title"">Use Windows location service?</div>
    <div class=""dialog-content"">
        Bassus abactors ducunt ad triticum.
        A fraternal form of manifestation is the bliss.
    </div>
    <div class=""dialog-actions"">
        <button class=""button js-dialog-close"">Disagree</button>
        <button class=""button primary js-d");
            WriteLiteral(@"ialog-close"">Agree</button>
    </div>
</div>

<div class=""p-1 m-3"">
    <div class=""bg-white p-4 text-center"">
        <button class=""button"" onclick=""Metro.dialog.open('#demoDialog1')"">Open pre-defined dialog</button>
        <button class=""button alert"" onclick=""
        Metro.dialog.create({
            title: 'Use Windows location service?',
            content: '<div>Bassus abactors ducunt ad triticum...</div>',
            clsDialog: 'alert'
        });
        "">Open runtime dialog</button>
    </div>
    <br>
    <div class=""row"">
        <div class=""cell-md-6 cell-lg-4 mt-2"">
            <div class=""dialog pos-relative win-shadow"">
                <div class=""dialog-title"">Use Windows location service?</div>
                <div class=""dialog-content"">
                    Bassus abactors ducunt ad triticum.
                    A fraternal form of manifestation is the bliss.
                </div>
                <div class=""dialog-actions"">
                    <button class=""button"">Disagree</button");
            WriteLiteral(@">
                    <button class=""button primary"">Agree</button>
                </div>
            </div>
        </div>
        <div class=""cell-md-6 cell-lg-4 mt-2"">
            <div class=""dialog primary pos-relative win-shadow"">
                <div class=""dialog-title"">Use Windows location service?</div>
                <div class=""dialog-content"">
                    Bassus abactors ducunt ad triticum.
                    A fraternal form of manifestation is the bliss.
                </div>
                <div class=""dialog-actions"">
                    <button class=""button"">Disagree</button>
                    <button class=""button primary"">Agree</button>
                </div>
            </div>
        </div>
        <div class=""cell-md-6 cell-lg-4 mt-2"">
            <div class=""dialog secondary pos-relative win-shadow"">
                <div class=""dialog-title"">Use Windows location service?</div>
                <div class=""dialog-content"">
                    Bassus abactors ducunt ad triti");
            WriteLiteral(@"cum.
                    A fraternal form of manifestation is the bliss.
                </div>
                <div class=""dialog-actions"">
                    <button class=""button"">Disagree</button>
                    <button class=""button primary"">Agree</button>
                </div>
            </div>
        </div>
        <div class=""cell-md-6 cell-lg-4 mt-2"">
            <div class=""dialog light pos-relative win-shadow"">
                <div class=""dialog-title"">Use Windows location service?</div>
                <div class=""dialog-content"">
                    Bassus abactors ducunt ad triticum.
                    A fraternal form of manifestation is the bliss.
                </div>
                <div class=""dialog-actions"">
                    <button class=""button"">Disagree</button>
                    <button class=""button primary"">Agree</button>
                </div>
            </div>
        </div>
        <div class=""cell-md-6 cell-lg-4 mt-2"">
            <div class=""dialog dark pos-rel");
            WriteLiteral(@"ative win-shadow"">
                <div class=""dialog-title"">Use Windows location service?</div>
                <div class=""dialog-content"">
                    Bassus abactors ducunt ad triticum.
                    A fraternal form of manifestation is the bliss.
                </div>
                <div class=""dialog-actions"">
                    <button class=""button"">Disagree</button>
                    <button class=""button primary"">Agree</button>
                </div>
            </div>
        </div>
        <div class=""cell-md-6 cell-lg-4 mt-2"">
            <div class=""dialog alert pos-relative win-shadow"">
                <div class=""dialog-title"">Use Windows location service?</div>
                <div class=""dialog-content"">
                    Bassus abactors ducunt ad triticum.
                    A fraternal form of manifestation is the bliss.
                </div>
                <div class=""dialog-actions"">
                    <button class=""button"">Disagree</button>
                    ");
            WriteLiteral(@"<button class=""button primary"">Agree</button>
                </div>
            </div>
        </div>
        <div class=""cell-md-6 cell-lg-4 mt-2"">
            <div class=""dialog warning pos-relative win-shadow"">
                <div class=""dialog-title"">Use Windows location service?</div>
                <div class=""dialog-content"">
                    Bassus abactors ducunt ad triticum.
                    A fraternal form of manifestation is the bliss.
                </div>
                <div class=""dialog-actions"">
                    <button class=""button"">Disagree</button>
                    <button class=""button primary"">Agree</button>
                </div>
            </div>
        </div>
        <div class=""cell-md-6 cell-lg-4 mt-2"">
            <div class=""dialog success pos-relative win-shadow"">
                <div class=""dialog-title"">Use Windows location service?</div>
                <div class=""dialog-content"">
                    Bassus abactors ducunt ad triticum.
                   ");
            WriteLiteral(@" A fraternal form of manifestation is the bliss.
                </div>
                <div class=""dialog-actions"">
                    <button class=""button"">Disagree</button>
                    <button class=""button primary"">Agree</button>
                </div>
            </div>
        </div>
        <div class=""cell-md-6 cell-lg-4 mt-2"">
            <div class=""dialog info pos-relative win-shadow"">
                <div class=""dialog-title"">Use Windows location service?</div>
                <div class=""dialog-content"">
                    Bassus abactors ducunt ad triticum.
                    A fraternal form of manifestation is the bliss.
                </div>
                <div class=""dialog-actions"">
                    <button class=""button"">Disagree</button>
                    <button class=""button primary"">Agree</button>
                </div>
            </div>
        </div>
    </div>

    <br>

    <div class=""p-6 text-center"">
        Read more about dialogs in the <a href=""https://met");
            WriteLiteral("roui.org.ua/dialog.html\">official docs</a>.\n    </div>\n</div>\n");
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
