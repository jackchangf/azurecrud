#pragma checksum "C:\Users\Chan\Desktop\SGUNITED FULL STACK DEV\GitTest\azurecrud\Grocery\Grocery\Grocery.WebApp\Areas\Manage\Views\Products\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c8fc57ce9f968cac8c59b35768fd239bec605d6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Grocery.WebApp.Pages.Products.Areas_Manage_Views_Products_Delete), @"mvc.1.0.view", @"/Areas/Manage/Views/Products/Delete.cshtml")]
namespace Grocery.WebApp.Pages.Products
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
#line 1 "C:\Users\Chan\Desktop\SGUNITED FULL STACK DEV\GitTest\azurecrud\Grocery\Grocery\Grocery.WebApp\Areas\Manage\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Chan\Desktop\SGUNITED FULL STACK DEV\GitTest\azurecrud\Grocery\Grocery\Grocery.WebApp\Areas\Manage\Views\_ViewImports.cshtml"
using Grocery.WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Chan\Desktop\SGUNITED FULL STACK DEV\GitTest\azurecrud\Grocery\Grocery\Grocery.WebApp\Areas\Manage\Views\_ViewImports.cshtml"
using Grocery.WebApp.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c8fc57ce9f968cac8c59b35768fd239bec605d6", @"/Areas/Manage/Views/Products/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a43b88138f5bd0af34b39bc0e7f34079426005d7", @"/Areas/Manage/Views/_ViewImports.cshtml")]
    public class Areas_Manage_Views_Products_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Grocery.WebApp.Models.Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Chan\Desktop\SGUNITED FULL STACK DEV\GitTest\azurecrud\Grocery\Grocery\Grocery.WebApp\Areas\Manage\Views\Products\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Product</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 16 "C:\Users\Chan\Desktop\SGUNITED FULL STACK DEV\GitTest\azurecrud\Grocery\Grocery\Grocery.WebApp\Areas\Manage\Views\Products\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ProductName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 19 "C:\Users\Chan\Desktop\SGUNITED FULL STACK DEV\GitTest\azurecrud\Grocery\Grocery\Grocery.WebApp\Areas\Manage\Views\Products\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ProductName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 22 "C:\Users\Chan\Desktop\SGUNITED FULL STACK DEV\GitTest\azurecrud\Grocery\Grocery\Grocery.WebApp\Areas\Manage\Views\Products\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 25 "C:\Users\Chan\Desktop\SGUNITED FULL STACK DEV\GitTest\azurecrud\Grocery\Grocery\Grocery.WebApp\Areas\Manage\Views\Products\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 28 "C:\Users\Chan\Desktop\SGUNITED FULL STACK DEV\GitTest\azurecrud\Grocery\Grocery\Grocery.WebApp\Areas\Manage\Views\Products\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.SellingPricePerUnit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 31 "C:\Users\Chan\Desktop\SGUNITED FULL STACK DEV\GitTest\azurecrud\Grocery\Grocery\Grocery.WebApp\Areas\Manage\Views\Products\Delete.cshtml"
       Write(Html.DisplayFor(model => model.SellingPricePerUnit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 34 "C:\Users\Chan\Desktop\SGUNITED FULL STACK DEV\GitTest\azurecrud\Grocery\Grocery\Grocery.WebApp\Areas\Manage\Views\Products\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Image));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 37 "C:\Users\Chan\Desktop\SGUNITED FULL STACK DEV\GitTest\azurecrud\Grocery\Grocery\Grocery.WebApp\Areas\Manage\Views\Products\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Image));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 40 "C:\Users\Chan\Desktop\SGUNITED FULL STACK DEV\GitTest\azurecrud\Grocery\Grocery\Grocery.WebApp\Areas\Manage\Views\Products\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.LastUpdatedOn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 43 "C:\Users\Chan\Desktop\SGUNITED FULL STACK DEV\GitTest\azurecrud\Grocery\Grocery\Grocery.WebApp\Areas\Manage\Views\Products\Delete.cshtml"
       Write(Html.DisplayFor(model => model.LastUpdatedOn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 46 "C:\Users\Chan\Desktop\SGUNITED FULL STACK DEV\GitTest\azurecrud\Grocery\Grocery\Grocery.WebApp\Areas\Manage\Views\Products\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CreatedByUser));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 49 "C:\Users\Chan\Desktop\SGUNITED FULL STACK DEV\GitTest\azurecrud\Grocery\Grocery\Grocery.WebApp\Areas\Manage\Views\Products\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CreatedByUser.DisplayName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd class>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 52 "C:\Users\Chan\Desktop\SGUNITED FULL STACK DEV\GitTest\azurecrud\Grocery\Grocery\Grocery.WebApp\Areas\Manage\Views\Products\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.UpdatedByUser));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 55 "C:\Users\Chan\Desktop\SGUNITED FULL STACK DEV\GitTest\azurecrud\Grocery\Grocery\Grocery.WebApp\Areas\Manage\Views\Products\Delete.cshtml"
       Write(Html.DisplayFor(model => model.UpdatedByUser.DisplayName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd class>\r\n    </dl>\r\n    \r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c8fc57ce9f968cac8c59b35768fd239bec605d610835", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3c8fc57ce9f968cac8c59b35768fd239bec605d611102", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 60 "C:\Users\Chan\Desktop\SGUNITED FULL STACK DEV\GitTest\azurecrud\Grocery\Grocery\Grocery.WebApp\Areas\Manage\Views\Products\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ProductID);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c8fc57ce9f968cac8c59b35768fd239bec605d612953", async() => {
                    WriteLiteral("Back to List");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Grocery.WebApp.Models.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591