#pragma checksum "D:\ITI\Final Final\Final_Project\Final Magdy\Final_Project\Final_Project\Final_Project\Views\Products\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4402df4e94d082f48a390b7d463e8b137261bb8d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Index), @"mvc.1.0.view", @"/Views/Products/Index.cshtml")]
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
#line 1 "D:\ITI\Final Final\Final_Project\Final Magdy\Final_Project\Final_Project\Final_Project\Views\_ViewImports.cshtml"
using Final_Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ITI\Final Final\Final_Project\Final Magdy\Final_Project\Final_Project\Final_Project\Views\_ViewImports.cshtml"
using Final_Project.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\ITI\Final Final\Final_Project\Final Magdy\Final_Project\Final_Project\Final_Project\Views\Products\Index.cshtml"
using static Project.Controllers.ProductsController;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4402df4e94d082f48a390b7d463e8b137261bb8d", @"/Views/Products/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4fb7ef317ae05155a488c52b2e91b7ab94cdc5a", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Home/Index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EachProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\ITI\Final Final\Final_Project\Final Magdy\Final_Project\Final_Project\Final_Project\Views\Products\Index.cshtml"
  
    ViewData["Title"] = "Proudect";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>

    .smallData {
        display: flex;
        justify-content: space-between;
        align-items: center;
    }

    .card {
        border-radius: 20px;
        background: #fff;
        box-shadow: 0 6px 10px rgba(0,0,0,.08), 0 0 6px rgba(0,0,0,.05);
        transition: .3s transform cubic-bezier(.155,1.105,.295,1.12),.3s box-shadow,.3s -webkit-transform cubic-bezier(.155,1.105,.295,1.12);
        padding: 14px 80px 18px 36px;
        cursor: pointer;
        position: relative;
        border-color: white;
    }

        .card:hover {
            transform: scale(1.05);
            box-shadow: 0 10px 20px rgba(0,0,0,.12), 0 4px 8px rgba(0,0,0,.06);
        }

        .card img {
            height: 200px;
            width: 200px
        }

    .x {
        position: absolute;
        bottom: 95%;
        left: 95%;
        width: 30px;
        height: 30px;
        cursor: pointer;
        background-color: red;
        display: flex;
        justify-con");
            WriteLiteral(@"tent: center;
        align-items: center;
        padding: 10px;
        border-radius: 50%;
        color: white;
    }

    .addCard {
        display: flex;
        justify-content: center;
        align-items: center;
        font-size: 80px;
        background-color: antiquewhite;
        color: black;
        font-weight: bolder;
    }

    a, a:hover {
        text-decoration: none;
        color: black;
    }
</style>

<div class=""header bg-primary pb-6"">
    <div class=""container-fluid"">
        <div class=""header-body"">
            <div class=""row align-items-center py-4"">
                <div class=""col-lg-6 col-7"">
                    <h6 class=""h2 text-white d-inline-block mb-0"">All Product</h6>
                    <nav aria-label=""breadcrumb"" class=""d-none d-md-inline-block ml-md-4"">
                        <ol class=""breadcrumb breadcrumb-links breadcrumb-dark"">
                            <li class=""breadcrumb-item"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4402df4e94d082f48a390b7d463e8b137261bb8d7180", async() => {
                WriteLiteral("Dashboard");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</li>
                            <li class=""breadcrumb-item active"" aria-current=""page"">All Product</li>
                        </ol>
                    </nav>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Page content -->
<div class=""container-fluid mt--6"">

");
#nullable restore
#line 89 "D:\ITI\Final Final\Final_Project\Final Magdy\Final_Project\Final_Project\Final_Project\Views\Products\Index.cshtml"
     if (TempData["Added"] != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-success p-3\">New Product Added Successfully</div>\r\n");
#nullable restore
#line 92 "D:\ITI\Final Final\Final_Project\Final Magdy\Final_Project\Final_Project\Final_Project\Views\Products\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"row mt-3\">\r\n\r\n");
#nullable restore
#line 96 "D:\ITI\Final Final\Final_Project\Final Magdy\Final_Project\Final_Project\Final_Project\Views\Products\Index.cshtml"
         foreach (var item in Model)
        {
            if (item.Stock > 0)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-4 pb-2\">\r\n\r\n                    <div class=\"card\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4402df4e94d082f48a390b7d463e8b137261bb8d9649", async() => {
                WriteLiteral("\r\n                            <img");
                BeginWriteAttribute("src", " src=\"", 2931, "\"", 2948, 1);
#nullable restore
#line 105 "D:\ITI\Final Final\Final_Project\Final Magdy\Final_Project\Final_Project\Final_Project\Views\Products\Index.cshtml"
WriteAttributeValue("", 2937, item.Image, 2937, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"card-img-top img-fluid\" alt=\"Product Image\">\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 104 "D:\ITI\Final Final\Final_Project\Final Magdy\Final_Project\Final_Project\Final_Project\Views\Products\Index.cshtml"
                                                      WriteLiteral(item.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        <div class=\"card-body\">\r\n                            <h5 class=\"card-title\">");
#nullable restore
#line 108 "D:\ITI\Final Final\Final_Project\Final Magdy\Final_Project\Final_Project\Final_Project\Views\Products\Index.cshtml"
                                              Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            <p class=\"card-text\">");
#nullable restore
#line 109 "D:\ITI\Final Final\Final_Project\Final Magdy\Final_Project\Final_Project\Final_Project\Views\Products\Index.cshtml"
                                            Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                            <div class=\"smallData\">\r\n                                <p>Price: <b>");
#nullable restore
#line 112 "D:\ITI\Final Final\Final_Project\Final Magdy\Final_Project\Final_Project\Final_Project\Views\Products\Index.cshtml"
                                        Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></p>\r\n");
            WriteLiteral("                                <p>Stock: <b>");
#nullable restore
#line 114 "D:\ITI\Final Final\Final_Project\Final Magdy\Final_Project\Final_Project\Final_Project\Views\Products\Index.cshtml"
                                        Write(item.Stock);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></p>\r\n                            </div>\r\n\r\n                            <div class=\"smallData\">\r\n                                <p>Created Date: <b>");
#nullable restore
#line 118 "D:\ITI\Final Final\Final_Project\Final Magdy\Final_Project\Final_Project\Final_Project\Views\Products\Index.cshtml"
                                               Write(item.Create_Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></p>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"x\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4402df4e94d082f48a390b7d463e8b137261bb8d14527", async() => {
                WriteLiteral("X");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 122 "D:\ITI\Final Final\Final_Project\Final Magdy\Final_Project\Final_Project\Final_Project\Views\Products\Index.cshtml"
                                                     WriteLiteral(item.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n\r\n                </div>\r\n");
#nullable restore
#line 127 "D:\ITI\Final Final\Final_Project\Final Magdy\Final_Project\Final_Project\Final_Project\Views\Products\Index.cshtml"

            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-4\">\r\n\r\n            <div class=\"card\">\r\n\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4402df4e94d082f48a390b7d463e8b137261bb8d17172", async() => {
                WriteLiteral("\r\n\r\n                    <div class=\"card-body addCard\">\r\n                        +\r\n                    </div>\r\n\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n            </div>\r\n\r\n        </div>\r\n\r\n    </div>\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
