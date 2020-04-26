#pragma checksum "C:\Users\Marti\source\repos\MartinX122\Pandora-NET-CORE\Pandora-NET-CORE\Views\Pages\forms_extended.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9550fdc1b042764d4dffaa52494e1a294cb0c109"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pages_forms_extended), @"mvc.1.0.view", @"/Views/Pages/forms_extended.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9550fdc1b042764d4dffaa52494e1a294cb0c109", @"/Views/Pages/forms_extended.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4fd4ad6f872c55489aedbca76f05feb6323ca691", @"/Views/_ViewImports.cshtml")]
    public class Views_Pages_forms_extended : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""row border-bottom bd-lightGray m-3"">
    <div class=""cell-md-4 d-flex flex-align-center"">
        <h3 class=""dashboard-section-title text-center text-left-md w-100"">Forms
            <small>extended</small>
        </h3>
    </div>

    <div class=""cell-md-8 d-flex flex-justify-center flex-justify-end-md flex-align-center"">
        <ul class=""breadcrumbs bg-transparent"">
            <li class=""page-item""><a href=""#"" class=""page-link""><span class=""mif-meter""></span></a></li>
            <li class=""page-item""><a href=""#"" class=""page-link"">Forms</a></li>
            <li class=""page-item""><a href=""#"" class=""page-link"">Extended</a></li>
        </ul>
    </div>
</div>

<div class=""m-3"">
    <h4>Input</h4>
    <div class=""row"">
        <div class=""cell-lg-6"">
            <div class=""bg-white p-4 m-1"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9550fdc1b042764d4dffaa52494e1a294cb0c1094332", async() => {
                WriteLiteral(@"
                    <div class=""form-group"">
                        <label>Input[text] data-role=""input""</label>
                        <input type=""text"" data-role=""input"">
                        <p class=""text-small"">Input with clear button</p>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            </div>\n        </div>\n\n        <div class=\"cell-lg-6\">\n            <div class=\"bg-white p-4 m-1\">\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9550fdc1b042764d4dffaa52494e1a294cb0c1095997", async() => {
                WriteLiteral(@"
                    <div class=""form-group"">
                        <label>Input[password] data-role=""input""</label>
                        <input type=""password"" data-role=""input"">
                        <p class=""text-small"">Input with clear and reveal buttons</p>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            </div>\n        </div>\n\n    </div>\n    <div class=\"row\">\n\n        <div class=\"cell-lg-6\">\n            <div class=\"bg-white p-4 m-1\">\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9550fdc1b042764d4dffaa52494e1a294cb0c1097721", async() => {
                WriteLiteral(@"
                    <div class=""form-group"">
                        <label>Input[text] data-role=""input"" with search</label>
                        <input type=""text"" data-role=""input"" data-search-button=""true"">
                        <p class=""text-small"">Input with clear and search buttons</p>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            </div>\n        </div>\n\n        <div class=\"cell-lg-6\">\n            <div class=\"bg-white p-4 m-1\">\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9550fdc1b042764d4dffaa52494e1a294cb0c1099438", async() => {
                WriteLiteral(@"
                    <div class=""form-group"">
                        <label>Input[password] data-role=""input"" with history</label>
                        <input type=""password"" data-role=""input"" data-history=""true"">
                        <p class=""text-small"">Enter value and press <kbd>Enter</kbd>, repeat, then press <kbd>Up</kbd>
                            or <kbd>Down</kbd> arrows to access entered values.</p>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            </div>\n        </div>\n\n    </div>\n    <div class=\"row\">\n\n        <div class=\"cell-lg-6\">\n            <div class=\"bg-white p-4 m-1\">\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9550fdc1b042764d4dffaa52494e1a294cb0c10911314", async() => {
                WriteLiteral("\n                    <div class=\"form-group\">\n                        <label>Input[text] data-role=\"input\" with prepend</label>\n                        <input type=\"text\" data-role=\"input\" data-prepend=\"www.\">\n                    </div>\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            </div>\n        </div>\n\n        <div class=\"cell-lg-6\">\n            <div class=\"bg-white p-4 m-1\">\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9550fdc1b042764d4dffaa52494e1a294cb0c10912943", async() => {
                WriteLiteral(@"
                    <div class=""form-group"">
                        <label>Input[password] data-role=""input"" with append</label>
                        <input type=""password"" data-role=""input"" data-append="".00"">
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            </div>\n        </div>\n\n    </div>\n    <div class=\"row\">\n\n        <div class=\"cell-lg-6\">\n            <div class=\"bg-white p-4 m-1\">\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9550fdc1b042764d4dffaa52494e1a294cb0c10914612", async() => {
                WriteLiteral(@"
                    <div class=""form-group"">
                        <script>
                            var customButtons = [
                                {
                                    html: ""<span class='mif-user'></span>"",
                                    cls: ""alert"",
                                    onclick: ""alert('You press user button')""
                                },
                                {
                                    html: ""<span class='mif-cog'></span>"",
                                    cls: ""warning"",
                                    onclick: ""alert('You press cog button')""
                                }
                            ]
                        </script>
                        <label>Input[text] data-role=""input"" with custom buttons</label>
                        <input type=""text"" data-role=""input"" data-custom-buttons=""customButtons"">
                        <p class=""text-small"">Custom buttons must be defined before input</p>
     ");
                WriteLiteral("               </div>\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            </div>\n        </div>\n\n        <div class=\"cell-lg-6\">\n            <div class=\"bg-white p-4 m-1\">\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9550fdc1b042764d4dffaa52494e1a294cb0c10917096", async() => {
                WriteLiteral(@"
                    <div class=""form-group"">
                        <label>Input[text] data-role=""input"" with autocomplete</label>
                        <input type=""text"" data-role=""input""
                               data-autocomplete=""Ukraine, USA, Canada, Marokko, Singapur"">
                        <p class=""text-small"">Begin type one of Ukraine, USA, Canada, Marokko, Singapur</p>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
        </div>
    </div>

    <h4 class=""mt-3"">Date &amp; time</h4>
    <div class=""row"">
        <div class=""cell-lg-4"">
            <div class=""bg-white p-4 m-1"">
                <h5 class=""mt-0"">Calendar picker</h5>
                <input type=""text"" data-role=""calendarpicker"">
            </div>
        </div>
        <div class=""cell-lg-4"">
            <div class=""bg-white p-4 m-1"">
                <h5 class=""mt-0"">Date piker</h5>
                <input type=""text"" data-role=""datepicker"">
            </div>
        </div>
        <div class=""cell-lg-4"">
            <div class=""bg-white p-4 m-1"">
                <h5 class=""mt-0"">Time piker</h5>
                <input type=""text"" data-role=""timepicker"">
            </div>
        </div>
    </div>

    <h4 class=""mt-3"">Textarea</h4>
    <div class=""row"">
        <div class=""cell-lg-12"">
            <div class=""bg-white p-4 m-1"">
                <textarea data-role=""textarea"" data-prepend=""<span class='mif-leanpub'></span>""></textarea>
");
            WriteLiteral(@"            </div>
        </div>
    </div>

    <h4 class=""mt-3"">Select</h4>
    <div class=""row"">
        <div class=""cell-lg-6"">
            <div class=""bg-white p-4 m-1"">
                <h5>Single</h5>
                <select data-role=""select"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9550fdc1b042764d4dffaa52494e1a294cb0c10920155", async() => {
                WriteLiteral("Value 1");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9550fdc1b042764d4dffaa52494e1a294cb0c10921133", async() => {
                WriteLiteral("Value 2");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9550fdc1b042764d4dffaa52494e1a294cb0c10922111", async() => {
                WriteLiteral("Value 3");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9550fdc1b042764d4dffaa52494e1a294cb0c10923089", async() => {
                WriteLiteral("Value 4");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9550fdc1b042764d4dffaa52494e1a294cb0c10924067", async() => {
                WriteLiteral("Value 5");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                </select>\n            </div>\n        </div>\n        <div class=\"cell-lg-6\">\n            <div class=\"bg-white p-4 m-1\">\n                <h5>Multiple</h5>\n                <select data-role=\"select\" multiple>\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9550fdc1b042764d4dffaa52494e1a294cb0c10925280", async() => {
                WriteLiteral("Value 1");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9550fdc1b042764d4dffaa52494e1a294cb0c10926258", async() => {
                WriteLiteral("Value 2");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9550fdc1b042764d4dffaa52494e1a294cb0c10927236", async() => {
                WriteLiteral("Value 3");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9550fdc1b042764d4dffaa52494e1a294cb0c10928214", async() => {
                WriteLiteral("Value 4");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9550fdc1b042764d4dffaa52494e1a294cb0c10929192", async() => {
                WriteLiteral("Value 5");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </select>
            </div>
        </div>
    </div>

    <h4 class=""mt-3"">Keypad and Spinner</h4>
    <div class=""row"">
        <div class=""cell-lg-6"">
            <div class=""bg-white p-4 m-1"">
                <h5>Keypad</h5>
                <input  type=""text"" data-role=""keypad"">
            </div>
        </div>
        <div class=""cell-lg-6"">
            <div class=""bg-white p-4 m-1"">
                <h5>Spinner</h5>
                <input  type=""text"" data-role=""spinner"">
            </div>
        </div>
    </div>

    <h4 class=""mt-3"">Tag input</h4>
    <div class=""row"">
        <div class=""cell-lg-12"">
            <div class=""bg-white p-4 m-1"">
                <input  type=""text"" data-role=""taginput"" data-random-color=""true"" value=""Metro 4,the,best,css3,javascript,html5,framework"">
            </div>
        </div>
    </div>

    <h4 class=""mt-3"">Slider</h4>
    <div class=""row"">
        <div class=""cell-lg-6"">
            <div class=""bg-white p-4 m-1 h-100"">
                <h5>");
            WriteLiteral(@"Horizontal</h5>
                <input type=""text"" data-role=""slider"">
                <label>Accuracy</label>
                <input data-role=""slider"" data-accuracy=""10"">
                <label>With buffer</label>
                <input data-role=""slider"" data-buffer=""60"" data-value=""20"">
                <label>With hint</label>
                <input data-role=""slider"" data-hint=""true"" data-hint-always=""true"" data-value=""50"">
            </div>
        </div>
        <div class=""cell-lg-6"">
            <div class=""bg-white p-4 m-1 h-100 clear"">
                <h5>Vertical</h5>
                <input type=""text"" data-role=""slider"" data-vertical=""true"" data-size=""200"" data-cls-slider=""mx-auto"">
            </div>
        </div>
    </div>

    <h4 class=""mt-3"">Checkbox, Radio and Switch</h4>
    <div class=""row"">
        <div class=""cell-lg-4"">
            <div class=""bg-white p-4 m-1"">
                <h5>Checkboxes</h5>

                <input type=""checkbox"" data-role=""checkbox"">
                <input t");
            WriteLiteral(@"ype=""checkbox"" data-role=""checkbox"" checked >
                <input type=""checkbox"" data-role=""checkbox"" disabled >
                <input type=""checkbox"" data-role=""checkbox"" disabled checked>
                <input type=""checkbox"" data-role=""checkbox"" data-indeterminate=""true"">

                <hr>

                <input type=""checkbox"" data-role=""checkbox"" data-style=""2"">
                <input type=""checkbox"" data-role=""checkbox"" checked  data-style=""2"">
                <input type=""checkbox"" data-role=""checkbox"" disabled  data-style=""2"">
                <input type=""checkbox"" data-role=""checkbox"" disabled checked data-style=""2"">
                <input type=""checkbox"" data-role=""checkbox"" data-indeterminate=""true"" data-style=""2"">
            </div>
        </div>
        <div class=""cell-lg-4"">
            <div class=""bg-white p-4 m-1"">
                <h5>Radio</h5>
                <input name=""r1"" type=""radio"" data-role=""radio"">
                <input name=""r1"" type=""radio"" data-role=""radio"" checked ");
            WriteLiteral(@">
                <input name=""r1"" type=""radio"" data-role=""radio"" disabled >
                <input name=""r2"" type=""radio"" data-role=""radio"" disabled checked>

                <hr>

                <input name=""r3"" type=""radio"" data-role=""radio"" data-style=""2"">
                <input name=""r3"" type=""radio"" data-role=""radio"" checked  data-style=""2"">
                <input name=""r3"" type=""radio"" data-role=""radio"" disabled  data-style=""2"">
                <input name=""r4"" type=""radio"" data-role=""radio"" disabled checked data-style=""2"">
            </div>
        </div>
        <div class=""cell-lg-4"">
            <div class=""bg-white p-4 m-1"">
                <h5>Switch</h5>
                <input type=""checkbox"" data-role=""switch"">
                <input type=""checkbox"" data-role=""switch"" disabled >
                <input type=""checkbox"" data-role=""switch"" disabled checked>

                <hr>

                <input type=""checkbox"" data-role=""switch"" data-material=""true"">
                <input type=""checkbox""");
            WriteLiteral(@" data-role=""switch"" disabled data-material=""true"">
                <input type=""checkbox"" data-role=""switch"" disabled checked data-material=""true"">
            </div>
        </div>
    </div>

    <h4 class=""mt-3"">Rating</h4>
    <div class=""row"">
        <div class=""cell-lg-6"">
            <div class=""bg-white p-4 m-1"">
                <h5>Rating</h5>
                <input data-role=""rating"" class=""d-block"">
                <input data-role=""rating"" data-star-color=""red"" data-stared-color=""green"" data-value=""3"">
            </div>
        </div>
        <div class=""cell-lg-6"">
            <div class=""bg-white p-4 m-1"">
                <h5>Rating static</h5>
                <input data-role=""rating"" data-value=""3"" data-message=""(avg 3 from 3856)"" data-static=""true"" class=""d-block"">
                <input data-role=""rating"" data-value=""3.5"" data-message=""(avg 3.5 from 3856)"" data-static=""true"" class=""d-block"" data-stared-color=""cyan"">
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
