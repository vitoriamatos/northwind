#pragma checksum "C:\Users\JO20283394\Documents\Wipro\Treinamento\ProjetoNorthwind\ProjetoNorthwind\Views\Ecommerce\ExibirOrder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "858cc9797bb44338e13336bca7d2fbce73bca804"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ecommerce_ExibirOrder), @"mvc.1.0.view", @"/Views/Ecommerce/ExibirOrder.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"858cc9797bb44338e13336bca7d2fbce73bca804", @"/Views/Ecommerce/ExibirOrder.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8b827f3a6cadb79a5a87de622f2b869dae3dab9", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Ecommerce_ExibirOrder : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjetoNorthwind.Models.OrderViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Orders</h1>\r\n\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 10 "C:\Users\JO20283394\Documents\Wipro\Treinamento\ProjetoNorthwind\ProjetoNorthwind\Views\Ecommerce\ExibirOrder.cshtml"
           Write(Html.DisplayNameFor(model => model.order.OrderID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 13 "C:\Users\JO20283394\Documents\Wipro\Treinamento\ProjetoNorthwind\ProjetoNorthwind\Views\Ecommerce\ExibirOrder.cshtml"
           Write(Html.DisplayNameFor(model => model.order.CustomerID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\JO20283394\Documents\Wipro\Treinamento\ProjetoNorthwind\ProjetoNorthwind\Views\Ecommerce\ExibirOrder.cshtml"
           Write(Html.DisplayNameFor(model => model.order.EmployeeID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\JO20283394\Documents\Wipro\Treinamento\ProjetoNorthwind\ProjetoNorthwind\Views\Ecommerce\ExibirOrder.cshtml"
           Write(Html.DisplayNameFor(model => model.order.ShipName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\JO20283394\Documents\Wipro\Treinamento\ProjetoNorthwind\ProjetoNorthwind\Views\Ecommerce\ExibirOrder.cshtml"
           Write(Html.DisplayNameFor(model => model.order.ShipAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\JO20283394\Documents\Wipro\Treinamento\ProjetoNorthwind\ProjetoNorthwind\Views\Ecommerce\ExibirOrder.cshtml"
           Write(Html.DisplayNameFor(model => model.order.ShipCity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 31 "C:\Users\JO20283394\Documents\Wipro\Treinamento\ProjetoNorthwind\ProjetoNorthwind\Views\Ecommerce\ExibirOrder.cshtml"
 foreach (var item in Model.orderlist) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 34 "C:\Users\JO20283394\Documents\Wipro\Treinamento\ProjetoNorthwind\ProjetoNorthwind\Views\Ecommerce\ExibirOrder.cshtml"
           Write(Html.DisplayFor(modelItem => item.OrderID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "C:\Users\JO20283394\Documents\Wipro\Treinamento\ProjetoNorthwind\ProjetoNorthwind\Views\Ecommerce\ExibirOrder.cshtml"
           Write(Html.DisplayFor(modelItem => item.CustomerID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "C:\Users\JO20283394\Documents\Wipro\Treinamento\ProjetoNorthwind\ProjetoNorthwind\Views\Ecommerce\ExibirOrder.cshtml"
           Write(Html.DisplayFor(modelItem => item.EmployeeID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "C:\Users\JO20283394\Documents\Wipro\Treinamento\ProjetoNorthwind\ProjetoNorthwind\Views\Ecommerce\ExibirOrder.cshtml"
           Write(Html.DisplayFor(modelItem => item.ShipName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 46 "C:\Users\JO20283394\Documents\Wipro\Treinamento\ProjetoNorthwind\ProjetoNorthwind\Views\Ecommerce\ExibirOrder.cshtml"
           Write(Html.DisplayFor(modelItem => item.ShipAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 49 "C:\Users\JO20283394\Documents\Wipro\Treinamento\ProjetoNorthwind\ProjetoNorthwind\Views\Ecommerce\ExibirOrder.cshtml"
           Write(Html.DisplayFor(modelItem => item.ShipCity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 52 "C:\Users\JO20283394\Documents\Wipro\Treinamento\ProjetoNorthwind\ProjetoNorthwind\Views\Ecommerce\ExibirOrder.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjetoNorthwind.Models.OrderViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591