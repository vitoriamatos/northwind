#pragma checksum "C:\Users\JO20283394\Documents\Wipro\Treinamento\ProjetoNorthwind\ProjetoNorthwind\Views\Home\ProcedureRio.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e94d00f4fde97931be7c5638f5d12d055916642a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ProcedureRio), @"mvc.1.0.view", @"/Views/Home/ProcedureRio.cshtml")]
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
#line 1 "C:\Users\JO20283394\Documents\Wipro\Treinamento\ProjetoNorthwind\ProjetoNorthwind\Views\_ViewImports.cshtml"
using ProjetoNorthwind;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\JO20283394\Documents\Wipro\Treinamento\ProjetoNorthwind\ProjetoNorthwind\Views\_ViewImports.cshtml"
using ProjetoNorthwind.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e94d00f4fde97931be7c5638f5d12d055916642a", @"/Views/Home/ProcedureRio.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8b827f3a6cadb79a5a87de622f2b869dae3dab9", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_ProcedureRio : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProjetoNorthwind.Models.ProceRio>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<h2>Pedidos Indo pro Rio</h2>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 10 "C:\Users\JO20283394\Documents\Wipro\Treinamento\ProjetoNorthwind\ProjetoNorthwind\Views\Home\ProcedureRio.cshtml"
           Write(Html.DisplayNameFor(model => model.OrderID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 13 "C:\Users\JO20283394\Documents\Wipro\Treinamento\ProjetoNorthwind\ProjetoNorthwind\Views\Home\ProcedureRio.cshtml"
           Write(Html.DisplayNameFor(model => model.CustomerID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\JO20283394\Documents\Wipro\Treinamento\ProjetoNorthwind\ProjetoNorthwind\Views\Home\ProcedureRio.cshtml"
           Write(Html.DisplayNameFor(model => model.EmployeeID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\JO20283394\Documents\Wipro\Treinamento\ProjetoNorthwind\ProjetoNorthwind\Views\Home\ProcedureRio.cshtml"
           Write(Html.DisplayNameFor(model => model.OrderDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\JO20283394\Documents\Wipro\Treinamento\ProjetoNorthwind\ProjetoNorthwind\Views\Home\ProcedureRio.cshtml"
           Write(Html.DisplayNameFor(model => model.RequiredDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\JO20283394\Documents\Wipro\Treinamento\ProjetoNorthwind\ProjetoNorthwind\Views\Home\ProcedureRio.cshtml"
           Write(Html.DisplayNameFor(model => model.ShippedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\JO20283394\Documents\Wipro\Treinamento\ProjetoNorthwind\ProjetoNorthwind\Views\Home\ProcedureRio.cshtml"
           Write(Html.DisplayNameFor(model => model.ShipVia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "C:\Users\JO20283394\Documents\Wipro\Treinamento\ProjetoNorthwind\ProjetoNorthwind\Views\Home\ProcedureRio.cshtml"
           Write(Html.DisplayNameFor(model => model.Freight));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 34 "C:\Users\JO20283394\Documents\Wipro\Treinamento\ProjetoNorthwind\ProjetoNorthwind\Views\Home\ProcedureRio.cshtml"
           Write(Html.DisplayNameFor(model => model.ShipName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 37 "C:\Users\JO20283394\Documents\Wipro\Treinamento\ProjetoNorthwind\ProjetoNorthwind\Views\Home\ProcedureRio.cshtml"
           Write(Html.DisplayNameFor(model => model.ShipAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 40 "C:\Users\JO20283394\Documents\Wipro\Treinamento\ProjetoNorthwind\ProjetoNorthwind\Views\Home\ProcedureRio.cshtml"
           Write(Html.DisplayNameFor(model => model.Discontinued));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 43 "C:\Users\JO20283394\Documents\Wipro\Treinamento\ProjetoNorthwind\ProjetoNorthwind\Views\Home\ProcedureRio.cshtml"
           Write(Html.DisplayNameFor(model => model.ShipCity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 46 "C:\Users\JO20283394\Documents\Wipro\Treinamento\ProjetoNorthwind\ProjetoNorthwind\Views\Home\ProcedureRio.cshtml"
           Write(Html.DisplayNameFor(model => model.ShipRegion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 49 "C:\Users\JO20283394\Documents\Wipro\Treinamento\ProjetoNorthwind\ProjetoNorthwind\Views\Home\ProcedureRio.cshtml"
           Write(Html.DisplayNameFor(model => model.ShipPostalCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 52 "C:\Users\JO20283394\Documents\Wipro\Treinamento\ProjetoNorthwind\ProjetoNorthwind\Views\Home\ProcedureRio.cshtml"
           Write(Html.DisplayNameFor(model => model.ShipCountry));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 58 "C:\Users\JO20283394\Documents\Wipro\Treinamento\ProjetoNorthwind\ProjetoNorthwind\Views\Home\ProcedureRio.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 61 "C:\Users\JO20283394\Documents\Wipro\Treinamento\ProjetoNorthwind\ProjetoNorthwind\Views\Home\ProcedureRio.cshtml"
           Write(Html.DisplayFor(modelItem => item.OrderID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 64 "C:\Users\JO20283394\Documents\Wipro\Treinamento\ProjetoNorthwind\ProjetoNorthwind\Views\Home\ProcedureRio.cshtml"
           Write(Html.DisplayFor(modelItem => item.CustomerID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 67 "C:\Users\JO20283394\Documents\Wipro\Treinamento\ProjetoNorthwind\ProjetoNorthwind\Views\Home\ProcedureRio.cshtml"
           Write(Html.DisplayFor(modelItem => item.EmployeeID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 70 "C:\Users\JO20283394\Documents\Wipro\Treinamento\ProjetoNorthwind\ProjetoNorthwind\Views\Home\ProcedureRio.cshtml"
           Write(Html.DisplayFor(modelItem => item.OrderDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 73 "C:\Users\JO20283394\Documents\Wipro\Treinamento\ProjetoNorthwind\ProjetoNorthwind\Views\Home\ProcedureRio.cshtml"
           Write(Html.DisplayFor(modelItem => item.RequiredDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 76 "C:\Users\JO20283394\Documents\Wipro\Treinamento\ProjetoNorthwind\ProjetoNorthwind\Views\Home\ProcedureRio.cshtml"
           Write(Html.DisplayFor(modelItem => item.ShippedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 79 "C:\Users\JO20283394\Documents\Wipro\Treinamento\ProjetoNorthwind\ProjetoNorthwind\Views\Home\ProcedureRio.cshtml"
           Write(Html.DisplayFor(modelItem => item.ShipVia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 82 "C:\Users\JO20283394\Documents\Wipro\Treinamento\ProjetoNorthwind\ProjetoNorthwind\Views\Home\ProcedureRio.cshtml"
           Write(Html.DisplayFor(modelItem => item.Freight));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 85 "C:\Users\JO20283394\Documents\Wipro\Treinamento\ProjetoNorthwind\ProjetoNorthwind\Views\Home\ProcedureRio.cshtml"
           Write(Html.DisplayFor(modelItem => item.ShipName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 88 "C:\Users\JO20283394\Documents\Wipro\Treinamento\ProjetoNorthwind\ProjetoNorthwind\Views\Home\ProcedureRio.cshtml"
           Write(Html.DisplayFor(modelItem => item.ShipAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 91 "C:\Users\JO20283394\Documents\Wipro\Treinamento\ProjetoNorthwind\ProjetoNorthwind\Views\Home\ProcedureRio.cshtml"
           Write(Html.DisplayFor(modelItem => item.Discontinued));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 94 "C:\Users\JO20283394\Documents\Wipro\Treinamento\ProjetoNorthwind\ProjetoNorthwind\Views\Home\ProcedureRio.cshtml"
           Write(Html.DisplayFor(modelItem => item.ShipCity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 97 "C:\Users\JO20283394\Documents\Wipro\Treinamento\ProjetoNorthwind\ProjetoNorthwind\Views\Home\ProcedureRio.cshtml"
           Write(Html.DisplayFor(modelItem => item.ShipRegion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 100 "C:\Users\JO20283394\Documents\Wipro\Treinamento\ProjetoNorthwind\ProjetoNorthwind\Views\Home\ProcedureRio.cshtml"
           Write(Html.DisplayFor(modelItem => item.ShipPostalCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 103 "C:\Users\JO20283394\Documents\Wipro\Treinamento\ProjetoNorthwind\ProjetoNorthwind\Views\Home\ProcedureRio.cshtml"
           Write(Html.DisplayFor(modelItem => item.ShipCountry));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 106 "C:\Users\JO20283394\Documents\Wipro\Treinamento\ProjetoNorthwind\ProjetoNorthwind\Views\Home\ProcedureRio.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProjetoNorthwind.Models.ProceRio>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591