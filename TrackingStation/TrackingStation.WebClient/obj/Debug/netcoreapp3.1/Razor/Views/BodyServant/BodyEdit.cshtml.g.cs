#pragma checksum "E:\Education\8Sem\dotNet\TrackingStation\TrackingStation.WebClient\Views\BodyServant\BodyEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "464c842909c1826785fd55f14bd639b04e8fb4af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(TrackingStation.WebClient.Pages.BodyServant.Views_BodyServant_BodyEdit), @"mvc.1.0.view", @"/Views/BodyServant/BodyEdit.cshtml")]
namespace TrackingStation.WebClient.Pages.BodyServant
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
#line 1 "E:\Education\8Sem\dotNet\TrackingStation\TrackingStation.WebClient\Views\_ViewImports.cshtml"
using TrackingStation.WebClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Education\8Sem\dotNet\TrackingStation\TrackingStation.WebClient\Views\_ViewImports.cshtml"
using TrackingStation.WebClient.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"464c842909c1826785fd55f14bd639b04e8fb4af", @"/Views/BodyServant/BodyEdit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"855161d1fa41c47df891f2403e05a9ea9e000390", @"/Views/_ViewImports.cshtml")]
    public class Views_BodyServant_BodyEdit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BodyModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\Education\8Sem\dotNet\TrackingStation\TrackingStation.WebClient\Views\BodyServant\BodyEdit.cshtml"
  
    ViewData["Title"] = $"Edit {this.Model.BodyName}";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"centerDiv\">\r\n    <h1>Edit ");
#nullable restore
#line 7 "E:\Education\8Sem\dotNet\TrackingStation\TrackingStation.WebClient\Views\BodyServant\BodyEdit.cshtml"
        Write(this.Model.BodyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "464c842909c1826785fd55f14bd639b04e8fb4af4238", async() => {
                WriteLiteral("\r\n        <table style=\"text-align:left;\">\r\n            <tr class=\"trHoverable\">\r\n                <td>\r\n                    Radius (km):\r\n                </td>\r\n                <td>\r\n                    <input required type=\"number\" step=any name=\"radius\"");
                BeginWriteAttribute("value", " value=", 428, "", 453, 1);
#nullable restore
#line 15 "E:\Education\8Sem\dotNet\TrackingStation\TrackingStation.WebClient\Views\BodyServant\BodyEdit.cshtml"
WriteAttributeValue("", 435, this.Model.Radius, 435, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                </td>\r\n            </tr>\r\n\r\n            <tr class=\"trHoverable\">\r\n                <td>\r\n                    SMA (Mm):\r\n                </td>\r\n                <td>\r\n                    <input required type=\"number\" step=any name=\"sma\"");
                BeginWriteAttribute("value", " value=", 707, "", 729, 1);
#nullable restore
#line 24 "E:\Education\8Sem\dotNet\TrackingStation\TrackingStation.WebClient\Views\BodyServant\BodyEdit.cshtml"
WriteAttributeValue("", 714, this.Model.SMA, 714, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                </td>
            </tr>

            <tr class=""trHoverable"">
                <td>
                    Orbital speed (m/s):
                </td>
                <td>
                    <input required type=""number"" step=any name=""v1""");
                BeginWriteAttribute("value", " value=", 993, "", 1014, 1);
#nullable restore
#line 33 "E:\Education\8Sem\dotNet\TrackingStation\TrackingStation.WebClient\Views\BodyServant\BodyEdit.cshtml"
WriteAttributeValue("", 1000, this.Model.V1, 1000, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                </td>
            </tr>

            <tr class=""trHoverable"">
                <td>
                    Escape velocity (m/s):
                </td>
                <td>
                    <input required type=""number"" step=any name=""v2""");
                BeginWriteAttribute("value", " value=", 1280, "", 1301, 1);
#nullable restore
#line 42 "E:\Education\8Sem\dotNet\TrackingStation\TrackingStation.WebClient\Views\BodyServant\BodyEdit.cshtml"
WriteAttributeValue("", 1287, this.Model.V2, 1287, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                </td>\r\n            </tr>\r\n\r\n            <tr class=\"trHoverable\">\r\n                <td>\r\n                    Type:\r\n                </td>\r\n                <td>\r\n                    <input ");
#nullable restore
#line 51 "E:\Education\8Sem\dotNet\TrackingStation\TrackingStation.WebClient\Views\BodyServant\BodyEdit.cshtml"
                            if (this.Model.Type == 0) { 

#line default
#line hidden
#nullable disable
                WriteLiteral(" checked");
#nullable restore
#line 51 "E:\Education\8Sem\dotNet\TrackingStation\TrackingStation.WebClient\Views\BodyServant\BodyEdit.cshtml"
                                                                             }

#line default
#line hidden
#nullable disable
                WriteLiteral(" type=\"radio\" name=\"type\" value=\"0\" />Earth-like\r\n                    <input ");
#nullable restore
#line 52 "E:\Education\8Sem\dotNet\TrackingStation\TrackingStation.WebClient\Views\BodyServant\BodyEdit.cshtml"
                            if (this.Model.Type == 1) { 

#line default
#line hidden
#nullable disable
                WriteLiteral(" checked");
#nullable restore
#line 52 "E:\Education\8Sem\dotNet\TrackingStation\TrackingStation.WebClient\Views\BodyServant\BodyEdit.cshtml"
                                                                             }

#line default
#line hidden
#nullable disable
                WriteLiteral(" type=\"radio\" name=\"type\" value=\"1\" />Gas\r\n                    <input ");
#nullable restore
#line 53 "E:\Education\8Sem\dotNet\TrackingStation\TrackingStation.WebClient\Views\BodyServant\BodyEdit.cshtml"
                            if (this.Model.Type == 2) { 

#line default
#line hidden
#nullable disable
                WriteLiteral(" checked");
#nullable restore
#line 53 "E:\Education\8Sem\dotNet\TrackingStation\TrackingStation.WebClient\Views\BodyServant\BodyEdit.cshtml"
                                                                             }

#line default
#line hidden
#nullable disable
                WriteLiteral(" type=\"radio\" name=\"type\" value=\"2\" />Rocky\r\n                    <input ");
#nullable restore
#line 54 "E:\Education\8Sem\dotNet\TrackingStation\TrackingStation.WebClient\Views\BodyServant\BodyEdit.cshtml"
                            if (this.Model.Type == 3) { 

#line default
#line hidden
#nullable disable
                WriteLiteral(" checked");
#nullable restore
#line 54 "E:\Education\8Sem\dotNet\TrackingStation\TrackingStation.WebClient\Views\BodyServant\BodyEdit.cshtml"
                                                                             }

#line default
#line hidden
#nullable disable
                WriteLiteral(@" type=""radio"" name=""type"" value=""3"" />Star
                </td>
            </tr>

            <tr class=""trHoverable"">
                <td>
                    Color:
                </td>
                <td>
                    <input required type=""number"" step=1 name=""color""");
                BeginWriteAttribute("value", " value=", 2222, "", 2246, 1);
#nullable restore
#line 63 "E:\Education\8Sem\dotNet\TrackingStation\TrackingStation.WebClient\Views\BodyServant\BodyEdit.cshtml"
WriteAttributeValue("", 2229, this.Model.Color, 2229, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                </td>\r\n            </tr>\r\n        </table>\r\n\r\n        <input type=\"submit\" value=\"Submit\">\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BodyModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
