#pragma checksum "C:\Users\JO20283394\Documents\Wipro\Treinamento\ProjetoNorthwind\ProjetoNorthwind\Views\Client\Client_Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6deb22322a483577960b7b36a5bde52db820648f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Client_Client_Detail), @"mvc.1.0.view", @"/Views/Client/Client_Detail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6deb22322a483577960b7b36a5bde52db820648f", @"/Views/Client/Client_Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8b827f3a6cadb79a5a87de622f2b869dae3dab9", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Client_Client_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjetoNorthwind.Models.CustomerList>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("Client_Update"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Client/Client_Delete"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6deb22322a483577960b7b36a5bde52db820648f4729", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6deb22322a483577960b7b36a5bde52db820648f5760", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6deb22322a483577960b7b36a5bde52db820648f6022", async() => {
                    WriteLiteral("\r\n        <row>\r\n            <div class=\"col-md-6\">\r\n                <input type=\"text\" name=\"id\"");
                    BeginWriteAttribute("value", " value=\"", 282, "\"", 307, 1);
#nullable restore
#line 10 "C:\Users\JO20283394\Documents\Wipro\Treinamento\ProjetoNorthwind\ProjetoNorthwind\Views\Client\Client_Detail.cshtml"
WriteAttributeValue("", 290, Model.CustomerID, 290, 17, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" readonly>\r\n                <label>Seu Nome</label>\r\n                <input type=\"text\" name=\"name\" class=\"form-control\" placeholder=\"Your Name\"");
                    BeginWriteAttribute("value", " value=\"", 452, "\"", 478, 1);
#nullable restore
#line 12 "C:\Users\JO20283394\Documents\Wipro\Treinamento\ProjetoNorthwind\ProjetoNorthwind\Views\Client\Client_Detail.cshtml"
WriteAttributeValue("", 460, Model.ContactName, 460, 18, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(">\r\n            </div>\r\n            <div class=\"col-md-6\">\r\n                <label>Your Address</label>\r\n                <input name=\"address\" class=\"form-control\" placeholder=\"Your Address\"");
                    BeginWriteAttribute("value", " value=\"", 668, "\"", 690, 1);
#nullable restore
#line 16 "C:\Users\JO20283394\Documents\Wipro\Treinamento\ProjetoNorthwind\ProjetoNorthwind\Views\Client\Client_Detail.cshtml"
WriteAttributeValue("", 676, Model.Address, 676, 14, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" readonly>\r\n            </div>\r\n            <div class=\"col-md-6\">\r\n                <label for=\"exampleInputPassword1\">Company Name</label>\r\n                <input type=\"text\" name=\"company\" class=\"form-control\" placeholder=\"Comapny Name\"");
                    BeginWriteAttribute("value", " value=\"", 929, "\"", 955, 1);
#nullable restore
#line 20 "C:\Users\JO20283394\Documents\Wipro\Treinamento\ProjetoNorthwind\ProjetoNorthwind\Views\Client\Client_Detail.cshtml"
WriteAttributeValue("", 937, Model.CompanyName, 937, 18, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(">\r\n            </div>\r\n            <div class=\"form-group col-md-6\">\r\n                <label for=\"exampleInputPassword1\">Citty</label>\r\n                <input type=\"text\" name=\"citty\" class=\"form-control\" placeholder=\"Citty\"");
                    BeginWriteAttribute("value", " value=\"", 1180, "\"", 1199, 1);
#nullable restore
#line 24 "C:\Users\JO20283394\Documents\Wipro\Treinamento\ProjetoNorthwind\ProjetoNorthwind\Views\Client\Client_Detail.cshtml"
WriteAttributeValue("", 1188, Model.City, 1188, 11, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(">\r\n            </div>\r\n            <div class=\"form-group col-md-6\">\r\n                <label for=\"exampleInputPassword1\">Region</label>\r\n                <input type=\"text\" name=\"region\" class=\"form-control\" placeholder=\"Region\"");
                    BeginWriteAttribute("value", " value=\"", 1427, "\"", 1448, 1);
#nullable restore
#line 28 "C:\Users\JO20283394\Documents\Wipro\Treinamento\ProjetoNorthwind\ProjetoNorthwind\Views\Client\Client_Detail.cshtml"
WriteAttributeValue("", 1435, Model.Region, 1435, 13, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(">\r\n            </div>\r\n            <div class=\"form-group col-md-6\">\r\n                <label for=\"exampleInputPassword1\">Postal Code</label>\r\n                <input type=\"text\" name=\"postal_code\" class=\"form-control\" placeholder=\"Postal Code\"");
                    BeginWriteAttribute("value", " value=\"", 1691, "\"", 1716, 1);
#nullable restore
#line 32 "C:\Users\JO20283394\Documents\Wipro\Treinamento\ProjetoNorthwind\ProjetoNorthwind\Views\Client\Client_Detail.cshtml"
WriteAttributeValue("", 1699, Model.PostalCode, 1699, 17, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(">\r\n            </div>\r\n            <div class=\"form-group col-md-6\">\r\n                <label for=\"exampleInputPassword1\">Country</label>\r\n                <input type=\"text\"");
                    BeginWriteAttribute("name", " name=\"", 1889, "\"", 1896, 0);
                    EndWriteAttribute();
                    WriteLiteral(" class=\"form-control\" placeholder=\"Country\"");
                    BeginWriteAttribute("value", " value=\"", 1940, "\"", 1962, 1);
#nullable restore
#line 36 "C:\Users\JO20283394\Documents\Wipro\Treinamento\ProjetoNorthwind\ProjetoNorthwind\Views\Client\Client_Detail.cshtml"
WriteAttributeValue("", 1948, Model.Country, 1948, 14, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(">\r\n            </div>\r\n            <div class=\"form-group col-md-6\">\r\n                <label for=\"exampleInputPassword1\">Phone</label>\r\n                <input type=\"text\" class=\"form-control\" placeholder=\"Phone\"");
                    BeginWriteAttribute("value", " value=\"", 2174, "\"", 2194, 1);
#nullable restore
#line 40 "C:\Users\JO20283394\Documents\Wipro\Treinamento\ProjetoNorthwind\ProjetoNorthwind\Views\Client\Client_Detail.cshtml"
WriteAttributeValue("", 2182, Model.Phone, 2182, 12, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@">
            </div>
            <div class=""form-check col-md-6"">
                <input type=""checkbox"" class=""form-check-input"" id=""exampleCheck1"">
                <label class=""form-check-label"" for=""exampleCheck1"">Check me out</label>
            </div>
            <button type=""submit"" class=""btn btn-primary"">Editar</button>
        </row>
    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6deb22322a483577960b7b36a5bde52db820648f13931", async() => {
                    WriteLiteral("\r\n        <input type=\"hidden\" name=\"id\"");
                    BeginWriteAttribute("value", " value=\"", 2659, "\"", 2684, 1);
#nullable restore
#line 50 "C:\Users\JO20283394\Documents\Wipro\Treinamento\ProjetoNorthwind\ProjetoNorthwind\Views\Client\Client_Detail.cshtml"
WriteAttributeValue("", 2667, Model.CustomerID, 2667, 17, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n        <button type=\"submit\">Deletar</button>   \r\n    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjetoNorthwind.Models.CustomerList> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
