#pragma checksum "C:\Users\Tees\source\repos\FoodServiceApi\BackOfficeFoodService\Views\Mesa\MesaConsumo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa3755968545f80af5d81a3db87d8143abfd11f5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Mesa_MesaConsumo), @"mvc.1.0.view", @"/Views/Mesa/MesaConsumo.cshtml")]
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
#line 1 "C:\Users\Tees\source\repos\FoodServiceApi\BackOfficeFoodService\Views\_ViewImports.cshtml"
using BackOfficeFoodService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Tees\source\repos\FoodServiceApi\BackOfficeFoodService\Views\_ViewImports.cshtml"
using BackOfficeFoodService.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Tees\source\repos\FoodServiceApi\BackOfficeFoodService\Views\_ViewImports.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa3755968545f80af5d81a3db87d8143abfd11f5", @"/Views/Mesa/MesaConsumo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2bb2ee245e2d1a76fd1b38cdb768655686e0836", @"/Views/_ViewImports.cshtml")]
    public class Views_Mesa_MesaConsumo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BackOfficeFoodService.Models.ConsumoModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Tees\source\repos\FoodServiceApi\BackOfficeFoodService\Views\Mesa\MesaConsumo.cshtml"
  
    ViewData["Title"] = "MesaConsumo";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Mesa ");
#nullable restore
#line 8 "C:\Users\Tees\source\repos\FoodServiceApi\BackOfficeFoodService\Views\Mesa\MesaConsumo.cshtml"
    Write(TempData["numeroMesa"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - Consumos</h1>\r\n<hr />\r\n<a href=\"#\"");
            BeginWriteAttribute("onclick", " onclick=\"", 223, "\"", 277, 3);
            WriteAttributeValue("", 233, "buscaCardapioPrincipal(", 233, 23, true);
#nullable restore
#line 10 "C:\Users\Tees\source\repos\FoodServiceApi\BackOfficeFoodService\Views\Mesa\MesaConsumo.cshtml"
WriteAttributeValue("", 256, TempData["codigo"], 256, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 275, ");", 275, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Adicionar Produtos</a>\r\n\r\n<div id=\"ListMenu\" class=\"col\">\r\n    <hr />\r\n    <div id=\"Menu\" class=\"row\">\r\n        ");
#nullable restore
#line 15 "C:\Users\Tees\source\repos\FoodServiceApi\BackOfficeFoodService\Views\Mesa\MesaConsumo.cshtml"
   Write(await Html.PartialAsync("../Shared/Spinner.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n<h3>Lista de produtos adicionado a Mesa ");
#nullable restore
#line 19 "C:\Users\Tees\source\repos\FoodServiceApi\BackOfficeFoodService\Views\Mesa\MesaConsumo.cshtml"
                                   Write(TempData["numeroMesa"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
<table class=""table table-striped table-bordered"">
    <thead>
        <tr>
            <th>
                Nome
            </th>
            <th>
                Descrição
            </th>
            <th>
                Preço  R$
            </th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 35 "C:\Users\Tees\source\repos\FoodServiceApi\BackOfficeFoodService\Views\Mesa\MesaConsumo.cshtml"
         if (Model != null)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\Tees\source\repos\FoodServiceApi\BackOfficeFoodService\Views\Mesa\MesaConsumo.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 41 "C:\Users\Tees\source\repos\FoodServiceApi\BackOfficeFoodService\Views\Mesa\MesaConsumo.cshtml"
           Write(Html.DisplayFor(modelItem => item.produto.nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 44 "C:\Users\Tees\source\repos\FoodServiceApi\BackOfficeFoodService\Views\Mesa\MesaConsumo.cshtml"
           Write(Html.DisplayFor(modelItem => item.produto.descricao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 47 "C:\Users\Tees\source\repos\FoodServiceApi\BackOfficeFoodService\Views\Mesa\MesaConsumo.cshtml"
           Write(Html.DisplayFor(modelItem => item.produto.valor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                |<a href=\"#\" ;");
            BeginWriteAttribute("onclick", " onclick=\"", 1343, "\"", 1406, 5);
            WriteAttributeValue("", 1353, "DeleteProdutoConsumoMesa(", 1353, 25, true);
#nullable restore
#line 50 "C:\Users\Tees\source\repos\FoodServiceApi\BackOfficeFoodService\Views\Mesa\MesaConsumo.cshtml"
WriteAttributeValue("", 1378, item.codigo, 1378, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1390, ",", 1390, 1, true);
#nullable restore
#line 50 "C:\Users\Tees\source\repos\FoodServiceApi\BackOfficeFoodService\Views\Mesa\MesaConsumo.cshtml"
WriteAttributeValue("", 1391, item.codMesa, 1391, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1404, ");", 1404, 2, true);
            EndWriteAttribute();
            WriteLiteral("> Excluir</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 53 "C:\Users\Tees\source\repos\FoodServiceApi\BackOfficeFoodService\Views\Mesa\MesaConsumo.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "C:\Users\Tees\source\repos\FoodServiceApi\BackOfficeFoodService\Views\Mesa\MesaConsumo.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 58 "C:\Users\Tees\source\repos\FoodServiceApi\BackOfficeFoodService\Views\Mesa\MesaConsumo.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<BackOfficeFoodService.Models.ConsumoModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
