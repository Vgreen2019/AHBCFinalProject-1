#pragma checksum "C:\Users\green\source\repos\AHBCFinalProject-1\AHBCFinalProject\Views\Manage\ManageLogins.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a93e2e9485bc5c0695d1fa3c5ff26c40a586084"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manage_ManageLogins), @"mvc.1.0.view", @"/Views/Manage/ManageLogins.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Manage/ManageLogins.cshtml", typeof(AspNetCore.Views_Manage_ManageLogins))]
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
#line 1 "C:\Users\green\source\repos\AHBCFinalProject-1\AHBCFinalProject\Views\_ViewImports.cshtml"
using AHBCFinalProject;

#line default
#line hidden
#line 2 "C:\Users\green\source\repos\AHBCFinalProject-1\AHBCFinalProject\Views\_ViewImports.cshtml"
using AHBCFinalProject.Models;

#line default
#line hidden
#line 2 "C:\Users\green\source\repos\AHBCFinalProject-1\AHBCFinalProject\Views\Manage\ManageLogins.cshtml"
using Microsoft.AspNetCore.Http.Authentication;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a93e2e9485bc5c0695d1fa3c5ff26c40a586084", @"/Views/Manage/ManageLogins.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4177622b0e9158860a444c60c25e185bc092aa9d", @"/Views/_ViewImports.cshtml")]
    public class Views_Manage_ManageLogins : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AHBCFinalProject.ManageViewModels.ManageLoginsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "LoginProvider", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "ProviderKey", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Manage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveLogin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "LinkLogin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\green\source\repos\AHBCFinalProject-1\AHBCFinalProject\Views\Manage\ManageLogins.cshtml"
  
    ViewData["Title"] = "Manage your external logins";

#line default
#line hidden
            BeginContext(176, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(183, 17, false);
#line 7 "C:\Users\green\source\repos\AHBCFinalProject-1\AHBCFinalProject\Views\Manage\ManageLogins.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(200, 34, true);
            WriteLiteral(".</h2>\r\n\r\n<p class=\"text-success\">");
            EndContext();
            BeginContext(235, 25, false);
#line 9 "C:\Users\green\source\repos\AHBCFinalProject-1\AHBCFinalProject\Views\Manage\ManageLogins.cshtml"
                   Write(ViewData["StatusMessage"]);

#line default
#line hidden
            EndContext();
            BeginContext(260, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 10 "C:\Users\green\source\repos\AHBCFinalProject-1\AHBCFinalProject\Views\Manage\ManageLogins.cshtml"
 if (Model.CurrentLogins.Count > 0)
{

#line default
#line hidden
            BeginContext(306, 76, true);
            WriteLiteral("    <h4>Registered Logins</h4>\r\n    <table class=\"table\">\r\n        <tbody>\r\n");
            EndContext();
#line 15 "C:\Users\green\source\repos\AHBCFinalProject-1\AHBCFinalProject\Views\Manage\ManageLogins.cshtml"
             for (var index = 0; index < Model.CurrentLogins.Count; index++)
            {

#line default
#line hidden
            BeginContext(475, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(522, 40, false);
#line 18 "C:\Users\green\source\repos\AHBCFinalProject-1\AHBCFinalProject\Views\Manage\ManageLogins.cshtml"
                   Write(Model.CurrentLogins[index].LoginProvider);

#line default
#line hidden
            EndContext();
            BeginContext(562, 33, true);
            WriteLiteral("</td>\r\n                    <td>\r\n");
            EndContext();
#line 20 "C:\Users\green\source\repos\AHBCFinalProject-1\AHBCFinalProject\Views\Manage\ManageLogins.cshtml"
                         if ((bool)ViewData["ShowRemoveButton"])
                        {

#line default
#line hidden
            BeginContext(688, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(716, 659, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6a93e2e9485bc5c0695d1fa3c5ff26c40a5860848723", async() => {
                BeginContext(809, 77, true);
                WriteLiteral("\r\n                                <div>\r\n                                    ");
                EndContext();
                BeginContext(886, 96, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6a93e2e9485bc5c0695d1fa3c5ff26c40a5860849182", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 24 "C:\Users\green\source\repos\AHBCFinalProject-1\AHBCFinalProject\Views\Manage\ManageLogins.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.CurrentLogins[index].LoginProvider);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(982, 38, true);
                WriteLiteral("\r\n                                    ");
                EndContext();
                BeginContext(1020, 92, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6a93e2e9485bc5c0695d1fa3c5ff26c40a58608411287", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 25 "C:\Users\green\source\repos\AHBCFinalProject-1\AHBCFinalProject\Views\Manage\ManageLogins.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.CurrentLogins[index].ProviderKey);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1112, 97, true);
                WriteLiteral("\r\n                                    <input type=\"submit\" class=\"btn btn-default\" value=\"Remove\"");
                EndContext();
                BeginWriteAttribute("title", " title=\"", 1209, "\"", 1294, 7);
                WriteAttributeValue("", 1217, "Remove", 1217, 6, true);
                WriteAttributeValue(" ", 1223, "this", 1224, 5, true);
#line 26 "C:\Users\green\source\repos\AHBCFinalProject-1\AHBCFinalProject\Views\Manage\ManageLogins.cshtml"
WriteAttributeValue(" ", 1228, Model.CurrentLogins[index].LoginProvider, 1229, 41, false);

#line default
#line hidden
                WriteAttributeValue(" ", 1270, "login", 1271, 6, true);
                WriteAttributeValue(" ", 1276, "from", 1277, 5, true);
                WriteAttributeValue(" ", 1281, "your", 1282, 5, true);
                WriteAttributeValue(" ", 1286, "account", 1287, 8, true);
                EndWriteAttribute();
                BeginContext(1295, 73, true);
                WriteLiteral(" />\r\n                                </div>\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1375, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 29 "C:\Users\green\source\repos\AHBCFinalProject-1\AHBCFinalProject\Views\Manage\ManageLogins.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(1461, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(1491, 9, true);
            WriteLiteral(" &nbsp;\r\n");
            EndContext();
#line 33 "C:\Users\green\source\repos\AHBCFinalProject-1\AHBCFinalProject\Views\Manage\ManageLogins.cshtml"
                        }

#line default
#line hidden
            BeginContext(1527, 50, true);
            WriteLiteral("                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 36 "C:\Users\green\source\repos\AHBCFinalProject-1\AHBCFinalProject\Views\Manage\ManageLogins.cshtml"
            }

#line default
#line hidden
            BeginContext(1592, 32, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
            EndContext();
#line 39 "C:\Users\green\source\repos\AHBCFinalProject-1\AHBCFinalProject\Views\Manage\ManageLogins.cshtml"
}

#line default
#line hidden
#line 40 "C:\Users\green\source\repos\AHBCFinalProject-1\AHBCFinalProject\Views\Manage\ManageLogins.cshtml"
 if (Model.OtherLogins.Count > 0)
{

#line default
#line hidden
            BeginContext(1665, 61, true);
            WriteLiteral("    <h4>Add another service to log in.</h4>\r\n    <hr />\r\n    ");
            EndContext();
            BeginContext(1726, 477, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6a93e2e9485bc5c0695d1fa3c5ff26c40a58608417753", async() => {
                BeginContext(1817, 55, true);
                WriteLiteral("\r\n        <div id=\"socialLoginList\">\r\n            <p>\r\n");
                EndContext();
#line 47 "C:\Users\green\source\repos\AHBCFinalProject-1\AHBCFinalProject\Views\Manage\ManageLogins.cshtml"
                 foreach (var provider in Model.OtherLogins)
                {

#line default
#line hidden
                BeginContext(1953, 81, true);
                WriteLiteral("                    <button type=\"submit\" class=\"btn btn-default\" name=\"provider\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2034, "\"", 2056, 1);
#line 49 "C:\Users\green\source\repos\AHBCFinalProject-1\AHBCFinalProject\Views\Manage\ManageLogins.cshtml"
WriteAttributeValue("", 2042, provider.Name, 2042, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("title", " title=\"", 2057, "\"", 2112, 6);
                WriteAttributeValue("", 2065, "Log", 2065, 3, true);
                WriteAttributeValue(" ", 2068, "in", 2069, 3, true);
                WriteAttributeValue(" ", 2071, "using", 2072, 6, true);
                WriteAttributeValue(" ", 2077, "your", 2078, 5, true);
#line 49 "C:\Users\green\source\repos\AHBCFinalProject-1\AHBCFinalProject\Views\Manage\ManageLogins.cshtml"
WriteAttributeValue(" ", 2082, provider.DisplayName, 2083, 21, false);

#line default
#line hidden
                WriteAttributeValue(" ", 2104, "account", 2105, 8, true);
                EndWriteAttribute();
                BeginContext(2113, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(2115, 13, false);
#line 49 "C:\Users\green\source\repos\AHBCFinalProject-1\AHBCFinalProject\Views\Manage\ManageLogins.cshtml"
                                                                                                                                                            Write(provider.Name);

#line default
#line hidden
                EndContext();
                BeginContext(2128, 11, true);
                WriteLiteral("</button>\r\n");
                EndContext();
#line 50 "C:\Users\green\source\repos\AHBCFinalProject-1\AHBCFinalProject\Views\Manage\ManageLogins.cshtml"
                }

#line default
#line hidden
                BeginContext(2158, 38, true);
                WriteLiteral("            </p>\r\n        </div>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2203, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 54 "C:\Users\green\source\repos\AHBCFinalProject-1\AHBCFinalProject\Views\Manage\ManageLogins.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AHBCFinalProject.ManageViewModels.ManageLoginsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591