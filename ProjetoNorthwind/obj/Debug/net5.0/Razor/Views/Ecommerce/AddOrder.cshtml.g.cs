#pragma checksum "C:\Users\JO20283394\Documents\Wipro\Treinamento\ProjetoNorthwind\ProjetoNorthwind\Views\Ecommerce\AddOrder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe10c161e0f417136efefe3f8e91a548b16557c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ecommerce_AddOrder), @"mvc.1.0.view", @"/Views/Ecommerce/AddOrder.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe10c161e0f417136efefe3f8e91a548b16557c2", @"/Views/Ecommerce/AddOrder.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8b827f3a6cadb79a5a87de622f2b869dae3dab9", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Ecommerce_AddOrder : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjetoNorthwind.Models.EcommerceDetails>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h2>Detalhe da compra</h2>\r\n   \r\n<div class=\"form-group\">\r\n    <h2>Compra Realizada!</h2>\r\n    <h4>Produto comprado: ");
#nullable restore
#line 7 "C:\Users\JO20283394\Documents\Wipro\Treinamento\ProjetoNorthwind\ProjetoNorthwind\Views\Ecommerce\AddOrder.cshtml"
                     Write(Model.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n</div>\r\n\r\n<div class=\"form-group\">\r\n    <h2>\r\n       Vendedor:\r\n    </h2>\r\n    <h4>");
#nullable restore
#line 14 "C:\Users\JO20283394\Documents\Wipro\Treinamento\ProjetoNorthwind\ProjetoNorthwind\Views\Ecommerce\AddOrder.cshtml"
   Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    <h2>\r\n        Cliente:\r\n    </h2>\r\n    <h4>\r\n       ");
#nullable restore
#line 19 "C:\Users\JO20283394\Documents\Wipro\Treinamento\ProjetoNorthwind\ProjetoNorthwind\Views\Ecommerce\AddOrder.cshtml"
  Write(Model.CompanyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </h4>\r\n</div>\r\n    \r\n\r\n   \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjetoNorthwind.Models.EcommerceDetails> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
