#pragma checksum "C:\Users\Tees\source\repos\FoodServiceApi\BackOfficeFoodService\Views\Mesa\MesaConsumo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f3ddc7814323c7bbaa3fb24df18f17189fd736f4"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3ddc7814323c7bbaa3fb24df18f17189fd736f4", @"/Views/Mesa/MesaConsumo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70d193d557837f2b633dd17c79cdd56a162662ee", @"/Views/_ViewImports.cshtml")]
    public class Views_Mesa_MesaConsumo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BackOfficeFoodService.Models.MesaModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
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
            WriteLiteral(" - Consumos</h1>\r\n<hr />\r\n<a href=\"#\" onclick=\"buscaCardapioPrincipal();\" class=\"btn btn-success\">Buscar Produtos</a>\r\n\r\n<div id=\"ListMenu\" class=\"col\">\r\n    <h4 id=\"MenuCadapio\"></h4>\r\n    <div id=\"Menu\">\r\n        ");
#nullable restore
#line 15 "C:\Users\Tees\source\repos\FoodServiceApi\BackOfficeFoodService\Views\Mesa\MesaConsumo.cshtml"
   Write(await Html.PartialAsync("../Shared/Spinner.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<div>\r\n    ");
#nullable restore
#line 19 "C:\Users\Tees\source\repos\FoodServiceApi\BackOfficeFoodService\Views\Mesa\MesaConsumo.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { /* id = Model.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f3ddc7814323c7bbaa3fb24df18f17189fd736f44872", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 23 "C:\Users\Tees\source\repos\FoodServiceApi\BackOfficeFoodService\Views\Mesa\MesaConsumo.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BackOfficeFoodService.Models.MesaModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
