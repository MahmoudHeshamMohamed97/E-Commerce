#pragma checksum "D:\ITI\Final Final\Final_Project\Final Magdy\Final_Project\Final_Project\Final_Project\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f3d0f4b362c014ffaa83e9bec5c1a6acbccab4e0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3d0f4b362c014ffaa83e9bec5c1a6acbccab4e0", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4fb7ef317ae05155a488c52b2e91b7ab94cdc5a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Final_Project.Controllers.HomeController>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "a", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "w", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "m", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "y", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\ITI\Final Final\Final_Project\Final Magdy\Final_Project\Final_Project\Final_Project\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f3d0f4b362c014ffaa83e9bec5c1a6acbccab4e04876", async() => {
                WriteLiteral(@"

    <script type=""text/javascript"" src=""https://www.gstatic.com/charts/loader.js""></script>
    <script type=""text/javascript"">
      google.charts.load('current', {'packages':['corechart']});
      google.charts.setOnLoadCallback(drawChart);

      function drawChart() {
        var data = google.visualization.arrayToDataTable([
            ['Month', 'Order'],
          ['Now',   ");
#nullable restore
#line 16 "D:\ITI\Final Final\Final_Project\Final Magdy\Final_Project\Final_Project\Final_Project\Views\Home\Index.cshtml"
               Write(Model.getNumberOfOrdersChart(0));

#line default
#line hidden
#nullable disable
                WriteLiteral("],\r\n          [\'4\',  ");
#nullable restore
#line 17 "D:\ITI\Final Final\Final_Project\Final Magdy\Final_Project\Final_Project\Final_Project\Views\Home\Index.cshtml"
            Write(Model.getNumberOfOrdersChart(1));

#line default
#line hidden
#nullable disable
                WriteLiteral("],\r\n          [\'3\',  ");
#nullable restore
#line 18 "D:\ITI\Final Final\Final_Project\Final Magdy\Final_Project\Final_Project\Final_Project\Views\Home\Index.cshtml"
            Write(Model.getNumberOfOrdersChart(2));

#line default
#line hidden
#nullable disable
                WriteLiteral("],\r\n          [\'2\',  ");
#nullable restore
#line 19 "D:\ITI\Final Final\Final_Project\Final Magdy\Final_Project\Final_Project\Final_Project\Views\Home\Index.cshtml"
            Write(Model.getNumberOfOrdersChart(3));

#line default
#line hidden
#nullable disable
                WriteLiteral("],\r\n          [\'1\',  ");
#nullable restore
#line 20 "D:\ITI\Final Final\Final_Project\Final Magdy\Final_Project\Final_Project\Final_Project\Views\Home\Index.cshtml"
            Write(Model.getNumberOfOrdersChart(4));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"]
        ]);

        var options = {
            title: 'Orders in last 5 Month',
          curveType: 'function',
            legend: { position: 'bottom' },
            color: 'red'
        };

        var chart = new google.visualization.LineChart(document.getElementById('curve_chart'));

        chart.draw(data, options);
      }
    google.charts.load('current', { 'packages': ['bar'] });
        google.charts.setOnLoadCallback(drawStuff);

    function drawStuff() {
    var data = new google.visualization.arrayToDataTable([
    ['Month', 'Users'],
    ['1', ");
#nullable restore
#line 40 "D:\ITI\Final Final\Final_Project\Final Magdy\Final_Project\Final_Project\Final_Project\Views\Home\Index.cshtml"
     Write(Model.getNumberOfUsersJoinedChart(4));

#line default
#line hidden
#nullable disable
                WriteLiteral("],\r\n    [\'2\', ");
#nullable restore
#line 41 "D:\ITI\Final Final\Final_Project\Final Magdy\Final_Project\Final_Project\Final_Project\Views\Home\Index.cshtml"
     Write(Model.getNumberOfUsersJoinedChart(3));

#line default
#line hidden
#nullable disable
                WriteLiteral("],\r\n    [\'3\', ");
#nullable restore
#line 42 "D:\ITI\Final Final\Final_Project\Final Magdy\Final_Project\Final_Project\Final_Project\Views\Home\Index.cshtml"
     Write(Model.getNumberOfUsersJoinedChart(2));

#line default
#line hidden
#nullable disable
                WriteLiteral("],\r\n    [\'4\', ");
#nullable restore
#line 43 "D:\ITI\Final Final\Final_Project\Final Magdy\Final_Project\Final_Project\Final_Project\Views\Home\Index.cshtml"
     Write(Model.getNumberOfUsersJoinedChart(1));

#line default
#line hidden
#nullable disable
                WriteLiteral("],\r\n    [\'Now\', ");
#nullable restore
#line 44 "D:\ITI\Final Final\Final_Project\Final Magdy\Final_Project\Final_Project\Final_Project\Views\Home\Index.cshtml"
       Write(Model.getNumberOfUsersJoinedChart(0));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"]
    ]);
    var options = {
    legend: { position: 'none' },
    chart: {
    title: 'Number of user in last 5 Month'
    },
    bar: { groupWidth: ""40%"" }
    };

    var chart = new google.charts.Bar(document.getElementById('top_x_div'));
    // Convert the Classic options to Material options.
    chart.draw(data, google.charts.Bar.convertOptions(options));
    };
    </script>
");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f3d0f4b362c014ffaa83e9bec5c1a6acbccab4e010206", async() => {
                WriteLiteral(@"
    <div class=""header bg-primary pb-6"">
        <div class=""container-fluid"">
            <div class=""header-body"">
                <div class=""row align-items-center py-4"">
                    <div class=""col-lg-6 col-7"">
                        <h6 class=""h2 text-white d-inline-block mb-0"">Home</h6>
                        <nav aria-label=""breadcrumb"" class=""d-none d-md-inline-block ml-md-4"">
                            <ol class=""breadcrumb breadcrumb-links breadcrumb-dark"">
                                <li class=""breadcrumb-item""><a href=""#"">Dashboard</a></li>
                                <li class=""breadcrumb-item active"" aria-current=""page"">Home</li>
                            </ol>
                        </nav>
                    </div>
                    <div class=""col-lg-6 col-5 d-flex justify-content-lg-start"">
                        <a href=""#"" class=""btn btn-sm btn-neutral"">Filters</a>
                        <select style=""width:100px;"" id=""Select1"" class=""form-contr");
                WriteLiteral("ol float-right\">\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f3d0f4b362c014ffaa83e9bec5c1a6acbccab4e011607", async() => {
                    WriteLiteral("All");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f3d0f4b362c014ffaa83e9bec5c1a6acbccab4e012856", async() => {
                    WriteLiteral("Weak");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f3d0f4b362c014ffaa83e9bec5c1a6acbccab4e014106", async() => {
                    WriteLiteral("Month");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f3d0f4b362c014ffaa83e9bec5c1a6acbccab4e015357", async() => {
                    WriteLiteral("Year");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                        </select>
                    </div>
                </div>
                <div class=""row"">
                    <div class=""col-xl-3 col-md-6"">
                        <div class=""card card-stats"">
                            <!-- Card body -->
                            <div class=""card-body"">
                                <div class=""row"">
                                    <div class=""col"">
                                        <h5 class=""card-title text-uppercase text-muted mb-0"">New users</h5>
                                        <span class=""h2 font-weight-bold mb-0"" id=""User"">");
#nullable restore
#line 92 "D:\ITI\Final Final\Final_Project\Final Magdy\Final_Project\Final_Project\Final_Project\Views\Home\Index.cshtml"
                                                                                    Write(Model.getNumberOfUsersJoined('a'));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span>
                                    </div>
                                    <div class=""col-auto"">
                                        <div class=""icon icon-shape bg-gradient-orange text-white rounded-circle shadow"">
                                            <i class=""ni ni-chart-pie-35""></i>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""col-xl-3 col-md-6"">
                        <div class=""card card-stats"">
                            <!-- Card body -->
                            <div class=""card-body"">
                                <div class=""row"">
                                    <div class=""col"">
                                        <h5 class=""card-title text-uppercase text-muted mb-0"">Orders</h5>
                                        <span class=""h2 fo");
                WriteLiteral("nt-weight-bold mb-0\" id=\"Order\">");
#nullable restore
#line 110 "D:\ITI\Final Final\Final_Project\Final Magdy\Final_Project\Final_Project\Final_Project\Views\Home\Index.cshtml"
                                                                                     Write(Model.getNumberOfOrders('a'));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span>
                                    </div>
                                    <div class=""col-auto"">
                                        <div class=""icon icon-shape bg-gradient-green text-white rounded-circle shadow"">
                                            <i class=""bi bi-bag-check text-white""></i>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""col-xl-3 col-md-6"">
                        <div class=""card card-stats"">
                            <!-- Card body -->
                            <div class=""card-body"">
                                <div class=""row"">
                                    <div class=""col"">
                                        <h5 class=""card-title text-uppercase text-muted mb-0"">Product</h5>
                                        <span clas");
                WriteLiteral("s=\"h2 font-weight-bold mb-0\" id=\"Proudect\">");
#nullable restore
#line 128 "D:\ITI\Final Final\Final_Project\Final Magdy\Final_Project\Final_Project\Final_Project\Views\Home\Index.cshtml"
                                                                                        Write(Model.getMostProductSaled('a'));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span>
                                    </div>
                                    <div class=""col-auto"">
                                        <div class=""icon icon-shape bg-gradient-info text-white rounded-circle shadow"">
                                            <i class=""bi bi-box text-white text-center""></i>
                                        </div>
                                    </div>
                                </div>

                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""container-fluid mt--6"">
        <div class=""row"">
            <div class=""col-xl-8"">
                <div class=""card bg-default"">
                    <div class=""card-header bg-transparent"">
                        <div class=""row align-items-center"">
                            <div class=""col"">
                                <h6 class=""text-light text-uppercase ls-");
                WriteLiteral(@"1 mb-1"">Overview</h6>
                                <h5 class=""h3 text-white mb-0"">User</h5>
                            </div>
                        </div>
                    </div>
                    <div class=""card-body"">
                        <!-- Chart -->
                        <div class=""chart"">
                            <!-- Chart wrapper -->
                            <canvas id=""top_x_div"" class=""chart-canvas""></canvas>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-xl-4"">
                <div class=""card"">
                    <div class=""card-header bg-transparent"">
                        <div class=""row align-items-center"">
                            <div class=""col"">
                                <h6 class=""text-uppercase text-muted ls-1 mb-1"">Performance</h6>
                                <h5 class=""h3 mb-0"">Total orders</h5>
                            </div>
              ");
                WriteLiteral(@"          </div>
                    </div>
                    <div class=""card-body"">
                        <!-- Chart -->
                        <div class=""chart"">
                            <canvas id=""curve_chart"" class=""chart-canvas""></canvas>
                        </div>
                    </div>
                </div>
            </div>
        </div>
");
                WriteLiteral("    </div>\r\n    <script>\r\n            document.getElementById(\"Select1\").onchange = () => {\r\n                if (document.getElementById(\"Select1\").value == \"a\") {\r\n                    document.getElementById(\"User\").innerHTML =  ");
#nullable restore
#line 203 "D:\ITI\Final Final\Final_Project\Final Magdy\Final_Project\Final_Project\Final_Project\Views\Home\Index.cshtml"
                                                            Write(Model.getNumberOfUsersJoined('a'));

#line default
#line hidden
#nullable disable
                WriteLiteral(";\r\n                    document.getElementById(\"Order\").innerHTML =  ");
#nullable restore
#line 204 "D:\ITI\Final Final\Final_Project\Final Magdy\Final_Project\Final_Project\Final_Project\Views\Home\Index.cshtml"
                                                             Write(Model.getNumberOfOrders('a'));

#line default
#line hidden
#nullable disable
                WriteLiteral(";\r\n                    document.getElementById(\"Proudect\").innerHTML =  \"");
#nullable restore
#line 205 "D:\ITI\Final Final\Final_Project\Final Magdy\Final_Project\Final_Project\Final_Project\Views\Home\Index.cshtml"
                                                                 Write(Model.getMostProductSaled('a'));

#line default
#line hidden
#nullable disable
                WriteLiteral("\";\r\n                    console.log(\"all\");\r\n                }\r\n                else if (document.getElementById(\"Select1\").value == \"w\") {\r\n                    document.getElementById(\"User\").innerHTML =  ");
#nullable restore
#line 209 "D:\ITI\Final Final\Final_Project\Final Magdy\Final_Project\Final_Project\Final_Project\Views\Home\Index.cshtml"
                                                            Write(Model.getNumberOfUsersJoined('w'));

#line default
#line hidden
#nullable disable
                WriteLiteral(";\r\n                    document.getElementById(\"Order\").innerHTML =  ");
#nullable restore
#line 210 "D:\ITI\Final Final\Final_Project\Final Magdy\Final_Project\Final_Project\Final_Project\Views\Home\Index.cshtml"
                                                             Write(Model.getNumberOfOrders('w'));

#line default
#line hidden
#nullable disable
                WriteLiteral(";\r\n                    document.getElementById(\"Proudect\").innerHTML = \"");
#nullable restore
#line 211 "D:\ITI\Final Final\Final_Project\Final Magdy\Final_Project\Final_Project\Final_Project\Views\Home\Index.cshtml"
                                                                Write(Model.getMostProductSaled('w'));

#line default
#line hidden
#nullable disable
                WriteLiteral("\";\r\n                }\r\n                else if (document.getElementById(\"Select1\").value == \"m\") {\r\n                    document.getElementById(\"User\").innerHTML =  ");
#nullable restore
#line 214 "D:\ITI\Final Final\Final_Project\Final Magdy\Final_Project\Final_Project\Final_Project\Views\Home\Index.cshtml"
                                                            Write(Model.getNumberOfUsersJoined('m'));

#line default
#line hidden
#nullable disable
                WriteLiteral(";\r\n                    document.getElementById(\"Order\").innerHTML = ");
#nullable restore
#line 215 "D:\ITI\Final Final\Final_Project\Final Magdy\Final_Project\Final_Project\Final_Project\Views\Home\Index.cshtml"
                                                            Write(Model.getNumberOfOrders('m'));

#line default
#line hidden
#nullable disable
                WriteLiteral(";\r\n                    document.getElementById(\"Proudect\").innerHTML =  \"");
#nullable restore
#line 216 "D:\ITI\Final Final\Final_Project\Final Magdy\Final_Project\Final_Project\Final_Project\Views\Home\Index.cshtml"
                                                                 Write(Model.getMostProductSaled('m'));

#line default
#line hidden
#nullable disable
                WriteLiteral("\";\r\n                }\r\n                else {\r\n                    document.getElementById(\"User\").innerHTML =  ");
#nullable restore
#line 219 "D:\ITI\Final Final\Final_Project\Final Magdy\Final_Project\Final_Project\Final_Project\Views\Home\Index.cshtml"
                                                            Write(Model.getNumberOfUsersJoined('y'));

#line default
#line hidden
#nullable disable
                WriteLiteral(";\r\n                    document.getElementById(\"Order\").innerHTML =  ");
#nullable restore
#line 220 "D:\ITI\Final Final\Final_Project\Final Magdy\Final_Project\Final_Project\Final_Project\Views\Home\Index.cshtml"
                                                             Write(Model.getNumberOfOrders('y'));

#line default
#line hidden
#nullable disable
                WriteLiteral(";\r\n                    document.getElementById(\"Proudect\").innerHTML = \" ");
#nullable restore
#line 221 "D:\ITI\Final Final\Final_Project\Final Magdy\Final_Project\Final_Project\Final_Project\Views\Home\Index.cshtml"
                                                                 Write(Model.getMostProductSaled('y'));

#line default
#line hidden
#nullable disable
                WriteLiteral("\";\r\n                }\r\n     };\r\n    </script>\r\n");
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
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Final_Project.Controllers.HomeController> Html { get; private set; }
    }
}
#pragma warning restore 1591
