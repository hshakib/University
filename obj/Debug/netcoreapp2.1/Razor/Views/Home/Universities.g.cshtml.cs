#pragma checksum "C:\Users\haish\Desktop\Coding Dojo\ASP\University\Views\Home\Universities.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "64abd6069428bed704b55371dfdc84ebd4b82970"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Universities), @"mvc.1.0.view", @"/Views/Home/Universities.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Universities.cshtml", typeof(AspNetCore.Views_Home_Universities))]
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
#line 1 "C:\Users\haish\Desktop\Coding Dojo\ASP\University\Views\_ViewImports.cshtml"
using University;

#line default
#line hidden
#line 2 "C:\Users\haish\Desktop\Coding Dojo\ASP\University\Views\_ViewImports.cshtml"
using University.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64abd6069428bed704b55371dfdc84ebd4b82970", @"/Views/Home/Universities.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e04dcc244e1469154104359d31508023c653ccb7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Universities : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Universities>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/AddUniversity"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("well col-sm-12"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(21, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(25, 2870, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6263e89c10f247c49c063f48a43c45a2", async() => {
                BeginContext(92, 377, true);
                WriteLiteral(@"
    <div class=""col-sm-12"">
        <div class=""row"">
            <div class=""col-sm-12 well"">
                <div class=""col-sm-12"">
                    <div class=""form-group"">
                        <label>University Name:</label>
                        <input type=""text"" name=""Name"" placeholder=""University Name"" class=""form-control""/>
                        ");
                EndContext();
                BeginContext(469, 39, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed47bb7782a141c48b35ebcb49a28f2a", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 12 "C:\Users\haish\Desktop\Coding Dojo\ASP\University\Views\Home\Universities.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Name);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(508, 259, true);
                WriteLiteral(@"
                    </div>
                    <div class=""form-group"">
                        <label>Location:</label>
                        <input type=""text"" name=""Location"" placeholder=""Location..."" class=""form-control""/>
                        ");
                EndContext();
                BeginContext(767, 43, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "20a2cd80b5be48a889231f6872e936cb", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 17 "C:\Users\haish\Desktop\Coding Dojo\ASP\University\Views\Home\Universities.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Location);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(810, 429, true);
                WriteLiteral(@"
                    </div>  
                    <input type=""submit"" class=""btn btn-primary"" value=""Save"" />
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""well"">
                <table class=""table"">
                    <tr>
                        <th>University Name</th>
                        <th>University Location</th>
                    </tr>
");
                EndContext();
#line 30 "C:\Users\haish\Desktop\Coding Dojo\ASP\University\Views\Home\Universities.cshtml"
                     foreach (var un in ViewBag.Universities)
                    {

#line default
#line hidden
                BeginContext(1325, 66, true);
                WriteLiteral("                        <tr>\r\n                                <td>");
                EndContext();
                BeginContext(1392, 7, false);
#line 33 "C:\Users\haish\Desktop\Coding Dojo\ASP\University\Views\Home\Universities.cshtml"
                               Write(un.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1399, 43, true);
                WriteLiteral("</td>\r\n                                <td>");
                EndContext();
                BeginContext(1443, 11, false);
#line 34 "C:\Users\haish\Desktop\Coding Dojo\ASP\University\Views\Home\Universities.cshtml"
                               Write(un.Location);

#line default
#line hidden
                EndContext();
                BeginContext(1454, 113, true);
                WriteLiteral("</td>\r\n                                <td>\r\n                                    <a class=\"btn btn-danger btn-sm\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1567, "\"", 1608, 2);
                WriteAttributeValue("", 1574, "RemoverUniversity/", 1574, 18, true);
#line 36 "C:\Users\haish\Desktop\Coding Dojo\ASP\University\Views\Home\Universities.cshtml"
WriteAttributeValue("", 1592, un.UniversityId, 1592, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1609, 159, true);
                WriteLiteral(">Delete</a>\r\n                                </td>\r\n                                <td>\r\n                                    <a class=\"btn btn-primary btn-sm\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1768, "\"", 1797, 2);
                WriteAttributeValue("", 1775, "EditU/", 1775, 6, true);
#line 39 "C:\Users\haish\Desktop\Coding Dojo\ASP\University\Views\Home\Universities.cshtml"
WriteAttributeValue("", 1781, un.UniversityId, 1781, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1798, 157, true);
                WriteLiteral(">Edit</a>\r\n                                </td>\r\n                                <td>\r\n                                    <a class=\"btn btn-primary btn-sm\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1955, "\"", 1984, 2);
                WriteAttributeValue("", 1962, "EditU/", 1962, 6, true);
#line 42 "C:\Users\haish\Desktop\Coding Dojo\ASP\University\Views\Home\Universities.cshtml"
WriteAttributeValue("", 1968, un.UniversityId, 1968, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1985, 86, true);
                WriteLiteral(">Faculties</a>\r\n                                </td>\r\n                        </tr>\r\n");
                EndContext();
#line 45 "C:\Users\haish\Desktop\Coding Dojo\ASP\University\Views\Home\Universities.cshtml"
                    }

#line default
#line hidden
                BeginContext(2094, 173, true);
                WriteLiteral("                </table>\r\n            </div>\r\n        </div>\r\n        <!-- <div class=\"row\">\r\n            <div class=\"col-sm-12\">\r\n                <div class=\"form-group\">\r\n");
                EndContext();
#line 52 "C:\Users\haish\Desktop\Coding Dojo\ASP\University\Views\Home\Universities.cshtml"
                     foreach (var un in ViewBag.Universities)
                    {

#line default
#line hidden
                BeginContext(2353, 142, true);
                WriteLiteral("                    <div style=\"background-color: lightblue\" class=\"col-sm-12 well\">                            \r\n                        <h6>");
                EndContext();
                BeginContext(2496, 7, false);
#line 55 "C:\Users\haish\Desktop\Coding Dojo\ASP\University\Views\Home\Universities.cshtml"
                       Write(un.Name);

#line default
#line hidden
                EndContext();
                BeginContext(2503, 35, true);
                WriteLiteral("</h6>\r\n                        <h6>");
                EndContext();
                BeginContext(2539, 11, false);
#line 56 "C:\Users\haish\Desktop\Coding Dojo\ASP\University\Views\Home\Universities.cshtml"
                       Write(un.Location);

#line default
#line hidden
                EndContext();
                BeginContext(2550, 56, true);
                WriteLiteral("</h6>\r\n                        <a class=\"btn btn-danger\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2606, "\"", 2647, 2);
                WriteAttributeValue("", 2613, "RemoverUniversity/", 2613, 18, true);
#line 57 "C:\Users\haish\Desktop\Coding Dojo\ASP\University\Views\Home\Universities.cshtml"
WriteAttributeValue("", 2631, un.UniversityId, 2631, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2648, 63, true);
                WriteLiteral(">Delete</a>\r\n                        <a class=\"btn btn-primary\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2711, "\"", 2740, 2);
                WriteAttributeValue("", 2718, "EditU/", 2718, 6, true);
#line 58 "C:\Users\haish\Desktop\Coding Dojo\ASP\University\Views\Home\Universities.cshtml"
WriteAttributeValue("", 2724, un.UniversityId, 2724, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2741, 39, true);
                WriteLiteral(">Edit</a>\r\n                    </div>\r\n");
                EndContext();
#line 60 "C:\Users\haish\Desktop\Coding Dojo\ASP\University\Views\Home\Universities.cshtml"
                    }

#line default
#line hidden
                BeginContext(2803, 85, true);
                WriteLiteral("                </div>\r\n            </div>         \r\n        </div> -->\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2895, 7, true);
            WriteLiteral(" \r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Universities> Html { get; private set; }
    }
}
#pragma warning restore 1591
