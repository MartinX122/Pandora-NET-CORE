#pragma checksum "C:\Users\Marti\source\repos\MartinX122\Pandora-NET-CORE\Pandora-NET-CORE\Views\Pages\orders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b46d5b7d7a19e353a010ee708972ca616819226"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pages_orders), @"mvc.1.0.view", @"/Views/Pages/orders.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b46d5b7d7a19e353a010ee708972ca616819226", @"/Views/Pages/orders.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4fd4ad6f872c55489aedbca76f05feb6323ca691", @"/Views/_ViewImports.cshtml")]
    public class Views_Pages_orders : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""row border-bottom bd-lightGray m-3"">
    <div class=""cell-md-4 d-flex flex-align-center"">
        <h3 class=""dashboard-section-title text-center text-left-md w-100"">Orders <small>e-commerce</small></h3>
    </div>

    <div class=""cell-md-8 d-flex flex-justify-center flex-justify-end-md flex-align-center"">
        <ul class=""breadcrumbs bg-transparent"">
            <li class=""page-item""><a href=""#"" class=""page-link""><span class=""mif-meter""></span></a></li>
            <li class=""page-item""><a href=""#"" class=""page-link"">E-Commerce</a></li>
            <li class=""page-item""><a href=""#"" class=""page-link"">Orders</a></li>
        </ul>
    </div>
</div>

<div class=""p-1 mt-4-minus"">
    <div class=""bg-white p-4"">
        <script>
            function drawCell(td, value, index, head, item){
                if (head.name === 'payment') {
                    $(td).html(payments[value]);
                }
                if (head.name === 'status') {
                    var span = $(""<code>"").html(statuses");
            WriteLiteral(@"[value][0]).addClass(statuses[value][1]);
                    $(td).html(span);
                }
                if (head.name === 'total') {
                    var _value = parseInt(value.replace(/\$/g, """"));
                    var pb = Metro.makePlugin($(""<div>""), ""progress"", {
                        value: _value,
                        clsBar: _value < 10 ? ""bg-red"" : _value < 20 ? ""bg-orange"" : _value <= 50 ? ""bg-cyan"" : _value < 70 ? ""bg-cobalt"" : ""bg-green""
                    });
                    $(td).html("""").append(value).append(pb);
                }
            }

            function setFilter(flt, checked){
                var table = $('#t1').data('table');
                var data;

                if (checked) {
                    window[flt] = table.addFilter(function(row, heads){
                        var is_active_index = 0;
                        heads.forEach(function(el, i){
                            if (el.name === ""status"") {
                                is_active_in");
            WriteLiteral(@"dex = i;
                            }
                        });

                        data = parseInt(row[is_active_index]);

                        if (flt === 'filterDelivered') {
                            return data === 4;
                        }
                        if (flt === 'filterShipped') {
                            return data === 7;
                        }
                        if (flt === 'filterPreparing') {
                            return data === 5;
                        }
                        if (flt === 'filterAwaiting') {
                            return data === 6;
                        }
                        if (flt === 'filterError') {
                            return data === 3;
                        }
                        if (flt === 'filterPayed') {
                            return [2, 4, 7].indexOf(data) > 0;
                        }
                    }, true);
                } else {
                    table.removeFilter(window[flt],");
            WriteLiteral(@" true);
                }
            }
        </script>
        <div>
            <div class=""p-4 mb-3 border bd-default"">
                <input type=""checkbox"" data-role=""switch"" data-caption=""Preparing"" data-cls-caption=""fg-dark"" onclick=""setFilter('filterPreparing', this.checked)"">
                <input type=""checkbox"" data-role=""switch"" data-caption=""Awaiting"" data-cls-caption=""fg-cyan"" onclick=""setFilter('filterAwaiting', this.checked)"">
                <input type=""checkbox"" data-role=""switch"" data-caption=""Payed"" data-cls-caption=""fg-green"" onclick=""setFilter('filterPayed', this.checked)"">
                <input type=""checkbox"" data-role=""switch"" data-caption=""Shipped"" data-cls-caption=""fg-steel"" onclick=""setFilter('filterShipped', this.checked)"">
                <input type=""checkbox"" data-role=""switch"" data-caption=""Delivered"" data-cls-caption=""fg-teal"" onclick=""setFilter('filterDelivered', this.checked)"">
                <input type=""checkbox"" data-role=""switch"" data-caption=""Error"" data-cls-cap");
            WriteLiteral(@"tion=""fg-red"" onclick=""setFilter('filterError', this.checked)"">
            </div>
            <div class=""d-flex flex-wrap flex-nowrap-lg flex-align-center flex-justify-center flex-justify-start-lg mb-2"">
                <div class=""w-100 mb-2 mb-0-lg"" id=""t1_search""></div>
                <div class=""ml-2 mr-2"" id=""t1_rows""></div>
                <div");
            BeginWriteAttribute("class", " class=\"", 4451, "\"", 4459, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""t1_actions"">
                    <button class=""button square"" onclick=""$('#t1').data('table').toggleInspector()""><span class=""mif-cog""></span></button>
                </div>
            </div>
            <table id=""t1"" class=""table table-border cell-border""
                   data-role=""table""
                   data-source=""data/orders.json""
                   data-search-wrapper=""#t1_search""
                   data-rows-wrapper=""#t1_rows""
                   data-info-wrapper=""#t1_info""
                   data-pagination-wrapper=""#t1_pagination""
                   data-horizontal-scroll=""true""
                   data-on-draw-cell=""drawCell""
                   data-filters-operator=""or""
            >
            </table>
            <div class=""d-flex flex-column flex-justify-center"">
                <div id=""t1_info""></div>
                <div id=""t1_pagination""></div>
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
