#pragma checksum "C:\Users\Filip\Desktop\C# workspace\Vjezba_6_7\src\Vjezba\Vjezba.Web\Views\Breakdowns\_BreakdownsTable.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4eee155038fa7889d92f7c258361e05c57e43fa1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Breakdowns__BreakdownsTable), @"mvc.1.0.view", @"/Views/Breakdowns/_BreakdownsTable.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Breakdowns/_BreakdownsTable.cshtml", typeof(AspNetCore.Views_Breakdowns__BreakdownsTable))]
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
#line 1 "C:\Users\Filip\Desktop\C# workspace\Vjezba_6_7\src\Vjezba\Vjezba.Web\Views\_ViewImports.cshtml"
using Vjezba.Web;

#line default
#line hidden
#line 2 "C:\Users\Filip\Desktop\C# workspace\Vjezba_6_7\src\Vjezba\Vjezba.Web\Views\_ViewImports.cshtml"
using Vjezba.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4eee155038fa7889d92f7c258361e05c57e43fa1", @"/Views/Breakdowns/_BreakdownsTable.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8738026d099901467e0be0027a96cd971753c195", @"/Views/_ViewImports.cshtml")]
    public class Views_Breakdowns__BreakdownsTable : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Radionica.Model.Breakdown>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Breakdowns", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Clients", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Employees", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(120, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(164, 208, true);
            WriteLiteral("\r\n<table class=\"col-md-12 table table-hover\">\r\n    <tr>\r\n        <th>ID</th>\r\n        <th>Breakdown</th>\r\n        <th>Client</th>\r\n        <th>Fixing time</th>\r\n        <th>Assigned employee</th>\r\n    </tr>\r\n");
            EndContext();
#line 15 "C:\Users\Filip\Desktop\C# workspace\Vjezba_6_7\src\Vjezba\Vjezba.Web\Views\Breakdowns\_BreakdownsTable.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(413, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(444, 7, false);
#line 18 "C:\Users\Filip\Desktop\C# workspace\Vjezba_6_7\src\Vjezba\Vjezba.Web\Views\Breakdowns\_BreakdownsTable.cshtml"
           Write(item.ID);

#line default
#line hidden
            EndContext();
            BeginContext(451, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(474, 90, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e4f8e17eead457b9de8b525858ba9d1", async() => {
                BeginContext(551, 9, false);
#line 19 "C:\Users\Filip\Desktop\C# workspace\Vjezba_6_7\src\Vjezba\Vjezba.Web\Views\Breakdowns\_BreakdownsTable.cshtml"
                                                                                       Write(item.Name);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 19 "C:\Users\Filip\Desktop\C# workspace\Vjezba_6_7\src\Vjezba\Vjezba.Web\Views\Breakdowns\_BreakdownsTable.cshtml"
                                                 WriteLiteral(item.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(564, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(587, 127, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ae706e9604384ae58e5ca7e33a100045", async() => {
                BeginContext(667, 21, false);
#line 20 "C:\Users\Filip\Desktop\C# workspace\Vjezba_6_7\src\Vjezba\Vjezba.Web\Views\Breakdowns\_BreakdownsTable.cshtml"
                                                                                          Write(item.Client.FirstName);

#line default
#line hidden
                EndContext();
                BeginContext(688, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(690, 20, false);
#line 20 "C:\Users\Filip\Desktop\C# workspace\Vjezba_6_7\src\Vjezba\Vjezba.Web\Views\Breakdowns\_BreakdownsTable.cshtml"
                                                                                                                 Write(item.Client.LastName);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 20 "C:\Users\Filip\Desktop\C# workspace\Vjezba_6_7\src\Vjezba\Vjezba.Web\Views\Breakdowns\_BreakdownsTable.cshtml"
                                              WriteLiteral(item.ClientID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(714, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(738, 15, false);
#line 21 "C:\Users\Filip\Desktop\C# workspace\Vjezba_6_7\src\Vjezba\Vjezba.Web\Views\Breakdowns\_BreakdownsTable.cshtml"
           Write(item.FixingTime);

#line default
#line hidden
            EndContext();
            BeginContext(753, 25, true);
            WriteLiteral(" h</td>\r\n            <td>");
            EndContext();
            BeginContext(778, 135, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9200cb0775f440f8ad01066a56105632", async() => {
                BeginContext(862, 23, false);
#line 22 "C:\Users\Filip\Desktop\C# workspace\Vjezba_6_7\src\Vjezba\Vjezba.Web\Views\Breakdowns\_BreakdownsTable.cshtml"
                                                                                              Write(item.Employee.FirstName);

#line default
#line hidden
                EndContext();
                BeginContext(885, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(887, 22, false);
#line 22 "C:\Users\Filip\Desktop\C# workspace\Vjezba_6_7\src\Vjezba\Vjezba.Web\Views\Breakdowns\_BreakdownsTable.cshtml"
                                                                                                                       Write(item.Employee.LastName);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 22 "C:\Users\Filip\Desktop\C# workspace\Vjezba_6_7\src\Vjezba\Vjezba.Web\Views\Breakdowns\_BreakdownsTable.cshtml"
                                                WriteLiteral(item.EmployeeID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(913, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 24 "C:\Users\Filip\Desktop\C# workspace\Vjezba_6_7\src\Vjezba\Vjezba.Web\Views\Breakdowns\_BreakdownsTable.cshtml"
    }

#line default
#line hidden
            BeginContext(942, 10, true);
            WriteLiteral("\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Radionica.Model.Breakdown>> Html { get; private set; }
    }
}
#pragma warning restore 1591