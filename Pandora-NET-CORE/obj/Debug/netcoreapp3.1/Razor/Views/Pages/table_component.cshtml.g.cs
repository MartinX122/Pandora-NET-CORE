#pragma checksum "C:\Users\Marti\source\repos\MartinX122\Pandora-NET-CORE\Pandora-NET-CORE\Views\Pages\table_component.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3981c42e9b023ce59424eb75130d6340502f5d41"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pages_table_component), @"mvc.1.0.view", @"/Views/Pages/table_component.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3981c42e9b023ce59424eb75130d6340502f5d41", @"/Views/Pages/table_component.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4fd4ad6f872c55489aedbca76f05feb6323ca691", @"/Views/_ViewImports.cshtml")]
    public class Views_Pages_table_component : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""row border-bottom bd-lightGray m-3"">
    <div class=""cell-md-4 d-flex flex-align-center"">
        <h3 class=""dashboard-section-title text-center text-left-md w-100"">Table
            <small>component</small>
        </h3>
    </div>

    <div class=""cell-md-8 d-flex flex-justify-center flex-justify-end-md flex-align-center"">
        <ul class=""breadcrumbs bg-transparent"">
            <li class=""page-item""><a href=""#"" class=""page-link""><span class=""mif-meter""></span></a></li>
            <li class=""page-item""><a href=""#"" class=""page-link"">Table</a></li>
            <li class=""page-item""><a href=""#"" class=""page-link"">Component</a></li>
        </ul>
    </div>
</div>

<div class=""m-3"">
<div");
            BeginWriteAttribute("class", " class=\"", 709, "\"", 717, 0);
            EndWriteAttribute();
            WriteLiteral(@">
    <div class=""bg-white p-6 text-center text-leader"">
        Metro 4 InMemory table
        <p class=""text-leader2"">
            Turn your table interactive  with search, sorting, filtering, rows counting, pagination and table inspector features with a single attribute <code>data-role=""table""</code>
        </p>
    </div>
    <br>
    <div class=""bg-white p-4"">
        <div class=""d-flex flex-wrap flex-nowrap-lg flex-align-center flex-justify-center flex-justify-start-lg mb-2"">
            <div class=""w-100 mb-2 mb-0-lg"" id=""t1_search""></div>
            <div class=""ml-2 mr-2"" id=""t1_rows""></div>
            <div");
            BeginWriteAttribute("class", " class=\"", 1343, "\"", 1351, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""t1_actions"">
                <button class=""button square"" onclick=""$('#t1').data('table').toggleInspector()""><span class=""mif-cog""></span></button>
            </div>
        </div>
        <table id=""t1"" class=""table table-border cell-border""
               data-role=""table""
               data-source=""data/table.json""
               data-search-wrapper=""#t1_search""
               data-rows-wrapper=""#t1_rows""
               data-info-wrapper=""#t1_info""
               data-pagination-wrapper=""#t1_pagination""
               data-horizontal-scroll=""true"">
        </table>
        <div class=""d-flex flex-column flex-justify-center"">
            <div id=""t1_info""></div>
            <div id=""t1_pagination""></div>
        </div>
    </div>
</div>

<br>

<div class=""p-1"">
    <div class=""row"">
        <div class=""cell-lg-6"">
            <script>
                function skillTableDrawCell(td, value, index, head, item){
                    if (head.name === 'skill') {
                        var p = $(""<div dat");
            WriteLiteral(@"a-role='progress'>"")
                            .attr('data-value', value)
                            .attr('data-cls-back', 'bg-red');
                        $(td).html(p);
                    }
                }
            </script>
            <div class=""bg-white p-4"">
                <div class=""text-leader2 text-center mb-2"">
                    Use event <code>onDrawCell</code> to create your own table cell data.
                </div>
                <div class=""d-flex flex-wrap flex-nowrap-lg flex-align-center flex-justify-center flex-justify-start-lg mb-2"">
                    <div class=""w-100 mb-2 mb-0-lg"" id=""t2_search""></div>
                    <div class=""ml-2"" id=""t2_rows""></div>
                </div>
                <table id=""t2"" class=""table table-border cell-border""
                       data-role=""table""
                       data-source=""data/skill.json""
                       data-on-draw-cell=""skillTableDrawCell""
                       data-search-wrapper=""#t2_search""
         ");
            WriteLiteral(@"              data-rows-wrapper=""#t2_rows""
                       data-info-wrapper=""#t2_info""
                       data-pagination-wrapper=""#t2_pagination""
                       data-horizontal-scroll=""true"">
                </table>
                <div class=""d-flex flex-column flex-justify-center"">
                    <div id=""t2_info""></div>
                    <div id=""t2_pagination""></div>
                </div>
            </div>
        </div>
        <div class=""cell-lg-6"">
            <div class=""bg-white p-4"">
                <div class=""text-leader2 text-center mb-2"">
                    Export your table data to <code>CSV file</code>
                </div>
                <div class=""d-flex flex-wrap flex-nowrap-lg flex-align-center flex-justify-center flex-justify-start-lg mb-2"">
                    <div class=""w-100 mb-2 mb-0-lg"" id=""t3_search""></div>
                    <div class=""ml-2 mr-2"" id=""t3_rows""></div>
                    <div");
            BeginWriteAttribute("class", " class=\"", 4370, "\"", 4378, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""t3_actions"">
                        <button class=""button alert"" onclick=""$('#t3').data('table').export('CSV')""><span class=""mif-file-excel""></span> Export</button>
                    </div>
                </div>
                <table id=""t3"" class=""table table-border cell-border""
                       data-role=""table""
                       data-source=""data/table.json""
                       data-search-wrapper=""#t3_search""
                       data-rows-wrapper=""#t3_rows""
                       data-info-wrapper=""#t3_info""
                       data-pagination-wrapper=""#t3_pagination""
                       data-horizontal-scroll=""true"">
                </table>
                <div class=""d-flex flex-column flex-justify-center"">
                    <div id=""t3_info""></div>
                    <div id=""t3_pagination""></div>
                </div>
            </div>
        </div>
    </div>
</div>

<br>
<div class=""p-1"">
    <div class=""row"">
        <div class=""cell-lg-6"">
            <div c");
            WriteLiteral(@"lass=""bg-white p-4"">
                <div class=""text-leader2 text-center mb-2"">
                    Built in check boxes to select rows!
                </div>
                <div class=""d-flex flex-wrap flex-nowrap-lg flex-align-center flex-justify-center flex-justify-start-lg mb-2"">
                    <div class=""w-100 mb-2 mb-0-lg"" id=""t4_search""></div>
                    <div class=""ml-2"" id=""t4_rows""></div>
                </div>
                <table id=""t4"" class=""table table-border cell-border""
                       data-role=""table""
                       data-source=""data/skill.json""
                       data-check=""true""
                       data-check-type=""checkbox""
                       data-search-wrapper=""#t4_search""
                       data-rows-wrapper=""#t4_rows""
                       data-info-wrapper=""#t4_info""
                       data-pagination-wrapper=""#t4_pagination""
                       data-horizontal-scroll=""true"">
                </table>
                <div cl");
            WriteLiteral(@"ass=""d-flex flex-column flex-justify-center"">
                    <div id=""t4_info""></div>
                    <div id=""t4_pagination""></div>
                </div>
            </div>
        </div>
        <div class=""cell-lg-6"">
            <div class=""bg-white p-4"">
                <div class=""text-leader2 text-center mb-2"">
                    Built in radio boxes to select one row!
                </div>
                <div class=""d-flex flex-wrap flex-nowrap-lg flex-align-center flex-justify-center flex-justify-start-lg mb-2"">
                    <div class=""w-100 mb-2 mb-0-lg"" id=""t5_search""></div>
                    <div class=""ml-2"" id=""t5_rows""></div>
                </div>
                <table id=""t5"" class=""table table-border cell-border""
                       data-role=""table""
                       data-source=""data/table.json""
                       data-check=""true""
                       data-check-type=""radio""
                       data-search-wrapper=""#t5_search""
                     ");
            WriteLiteral(@"  data-rows-wrapper=""#t5_rows""
                       data-info-wrapper=""#t5_info""
                       data-pagination-wrapper=""#t5_pagination""
                       data-horizontal-scroll=""true"">
                </table>
                <div class=""d-flex flex-column flex-justify-center"">
                    <div id=""t5_info""></div>
                    <div id=""t5_pagination""></div>
                </div>
            </div>
        </div>
    </div>
</div>

<br>

<div class=""bg-white p-6 text-center"">
    And more, more other features... Read the docs for Metro 4 <a href=""https://metroui.org.ua/table.html"">table component</a>.
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
