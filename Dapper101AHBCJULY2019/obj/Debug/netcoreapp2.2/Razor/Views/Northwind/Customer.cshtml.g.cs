#pragma checksum "C:\Development\GRAND CIRCUS\AHBC_2019_JULY\Dapper101AHBCJULY2019\Views\Northwind\Customer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8aa2c32ec13c5a30a4d638c1fca8bb740e010b6e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Northwind_Customer), @"mvc.1.0.view", @"/Views/Northwind/Customer.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Northwind/Customer.cshtml", typeof(AspNetCore.Views_Northwind_Customer))]
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
#line 1 "C:\Development\GRAND CIRCUS\AHBC_2019_JULY\Dapper101AHBCJULY2019\Views\_ViewImports.cshtml"
using Dapper101AHBCJULY2019;

#line default
#line hidden
#line 2 "C:\Development\GRAND CIRCUS\AHBC_2019_JULY\Dapper101AHBCJULY2019\Views\_ViewImports.cshtml"
using Dapper101AHBCJULY2019.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8aa2c32ec13c5a30a4d638c1fca8bb740e010b6e", @"/Views/Northwind/Customer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cecba75b6eb96057c673566fb7e94b8c48c3ab52", @"/Views/_ViewImports.cshtml")]
    public class Views_Northwind_Customer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Dapper101AHBCJULY2019.Models.CustomerViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(55, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Development\GRAND CIRCUS\AHBC_2019_JULY\Dapper101AHBCJULY2019\Views\Northwind\Customer.cshtml"
  
    ViewData["Title"] = "CustomerViewModel";

#line default
#line hidden
            BeginContext(110, 150, true);
            WriteLiteral("\r\n<h1>CustomerViewModel</h1>\r\n\r\n<div>\r\n    <h4>CustomerViewModel</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(261, 38, false);
#line 14 "C:\Development\GRAND CIRCUS\AHBC_2019_JULY\Dapper101AHBCJULY2019\Views\Northwind\Customer.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(299, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(363, 34, false);
#line 17 "C:\Development\GRAND CIRCUS\AHBC_2019_JULY\Dapper101AHBCJULY2019\Views\Northwind\Customer.cshtml"
       Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(397, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(460, 47, false);
#line 20 "C:\Development\GRAND CIRCUS\AHBC_2019_JULY\Dapper101AHBCJULY2019\Views\Northwind\Customer.cshtml"
       Write(Html.DisplayNameFor(model => model.CompanyName));

#line default
#line hidden
            EndContext();
            BeginContext(507, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(571, 43, false);
#line 23 "C:\Development\GRAND CIRCUS\AHBC_2019_JULY\Dapper101AHBCJULY2019\Views\Northwind\Customer.cshtml"
       Write(Html.DisplayFor(model => model.CompanyName));

#line default
#line hidden
            EndContext();
            BeginContext(614, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(677, 43, false);
#line 26 "C:\Development\GRAND CIRCUS\AHBC_2019_JULY\Dapper101AHBCJULY2019\Views\Northwind\Customer.cshtml"
       Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(720, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(784, 39, false);
#line 29 "C:\Development\GRAND CIRCUS\AHBC_2019_JULY\Dapper101AHBCJULY2019\Views\Northwind\Customer.cshtml"
       Write(Html.DisplayFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(823, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(886, 40, false);
#line 32 "C:\Development\GRAND CIRCUS\AHBC_2019_JULY\Dapper101AHBCJULY2019\Views\Northwind\Customer.cshtml"
       Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
            EndContext();
            BeginContext(926, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(990, 36, false);
#line 35 "C:\Development\GRAND CIRCUS\AHBC_2019_JULY\Dapper101AHBCJULY2019\Views\Northwind\Customer.cshtml"
       Write(Html.DisplayFor(model => model.City));

#line default
#line hidden
            EndContext();
            BeginContext(1026, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1089, 42, false);
#line 38 "C:\Development\GRAND CIRCUS\AHBC_2019_JULY\Dapper101AHBCJULY2019\Views\Northwind\Customer.cshtml"
       Write(Html.DisplayNameFor(model => model.Region));

#line default
#line hidden
            EndContext();
            BeginContext(1131, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1195, 38, false);
#line 41 "C:\Development\GRAND CIRCUS\AHBC_2019_JULY\Dapper101AHBCJULY2019\Views\Northwind\Customer.cshtml"
       Write(Html.DisplayFor(model => model.Region));

#line default
#line hidden
            EndContext();
            BeginContext(1233, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1296, 46, false);
#line 44 "C:\Development\GRAND CIRCUS\AHBC_2019_JULY\Dapper101AHBCJULY2019\Views\Northwind\Customer.cshtml"
       Write(Html.DisplayNameFor(model => model.PostalCode));

#line default
#line hidden
            EndContext();
            BeginContext(1342, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1406, 42, false);
#line 47 "C:\Development\GRAND CIRCUS\AHBC_2019_JULY\Dapper101AHBCJULY2019\Views\Northwind\Customer.cshtml"
       Write(Html.DisplayFor(model => model.PostalCode));

#line default
#line hidden
            EndContext();
            BeginContext(1448, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1511, 43, false);
#line 50 "C:\Development\GRAND CIRCUS\AHBC_2019_JULY\Dapper101AHBCJULY2019\Views\Northwind\Customer.cshtml"
       Write(Html.DisplayNameFor(model => model.Country));

#line default
#line hidden
            EndContext();
            BeginContext(1554, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1618, 39, false);
#line 53 "C:\Development\GRAND CIRCUS\AHBC_2019_JULY\Dapper101AHBCJULY2019\Views\Northwind\Customer.cshtml"
       Write(Html.DisplayFor(model => model.Country));

#line default
#line hidden
            EndContext();
            BeginContext(1657, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1720, 41, false);
#line 56 "C:\Development\GRAND CIRCUS\AHBC_2019_JULY\Dapper101AHBCJULY2019\Views\Northwind\Customer.cshtml"
       Write(Html.DisplayNameFor(model => model.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(1761, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1825, 37, false);
#line 59 "C:\Development\GRAND CIRCUS\AHBC_2019_JULY\Dapper101AHBCJULY2019\Views\Northwind\Customer.cshtml"
       Write(Html.DisplayFor(model => model.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(1862, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1910, 68, false);
#line 64 "C:\Development\GRAND CIRCUS\AHBC_2019_JULY\Dapper101AHBCJULY2019\Views\Northwind\Customer.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { /* id = Model.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1978, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1986, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8aa2c32ec13c5a30a4d638c1fca8bb740e010b6e11489", async() => {
                BeginContext(2008, 12, true);
                WriteLiteral("Back to List");
                EndContext();
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
            EndContext();
            BeginContext(2024, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Dapper101AHBCJULY2019.Models.CustomerViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591