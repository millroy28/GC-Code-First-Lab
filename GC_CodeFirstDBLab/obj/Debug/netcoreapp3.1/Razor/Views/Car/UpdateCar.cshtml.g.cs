#pragma checksum "C:\Users\millr\source\repos\GC_CodeFirstDBLab\GC_CodeFirstDBLab\Views\Car\UpdateCar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47c8b1b36d2079155412f556a039b4c8a399e6d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Car_UpdateCar), @"mvc.1.0.view", @"/Views/Car/UpdateCar.cshtml")]
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
#line 1 "C:\Users\millr\source\repos\GC_CodeFirstDBLab\GC_CodeFirstDBLab\Views\_ViewImports.cshtml"
using GC_CodeFirstDBLab;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\millr\source\repos\GC_CodeFirstDBLab\GC_CodeFirstDBLab\Views\_ViewImports.cshtml"
using GC_CodeFirstDBLab.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\millr\source\repos\GC_CodeFirstDBLab\GC_CodeFirstDBLab\Views\Car\UpdateCar.cshtml"
using GC_CodeFirstDBLab.Context;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47c8b1b36d2079155412f556a039b4c8a399e6d0", @"/Views/Car/UpdateCar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e231da45d4e6dc4daf6cd945844877c34eaf9fe", @"/Views/_ViewImports.cshtml")]
    public class Views_Car_UpdateCar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Car>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Car/UpdateCar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\millr\source\repos\GC_CodeFirstDBLab\GC_CodeFirstDBLab\Views\Car\UpdateCar.cshtml"
  
    ViewData["Title"] = "UpdateCar";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Update Car</h1>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "47c8b1b36d2079155412f556a039b4c8a399e6d04392", async() => {
                WriteLiteral("\r\n    <input type=\"hidden\" name=\"Id\"");
                BeginWriteAttribute("value", " value=\"", 196, "\"", 213, 1);
#nullable restore
#line 10 "C:\Users\millr\source\repos\GC_CodeFirstDBLab\GC_CodeFirstDBLab\Views\Car\UpdateCar.cshtml"
WriteAttributeValue("", 204, Model.Id, 204, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <input type=\"text\" name=\"Make\"");
                BeginWriteAttribute("value", " value=\"", 253, "\"", 272, 1);
#nullable restore
#line 11 "C:\Users\millr\source\repos\GC_CodeFirstDBLab\GC_CodeFirstDBLab\Views\Car\UpdateCar.cshtml"
WriteAttributeValue("", 261, Model.Make, 261, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <input type=\"text\" name=\"Model\"");
                BeginWriteAttribute("value", " value=\"", 313, "\"", 333, 1);
#nullable restore
#line 12 "C:\Users\millr\source\repos\GC_CodeFirstDBLab\GC_CodeFirstDBLab\Views\Car\UpdateCar.cshtml"
WriteAttributeValue("", 321, Model.Model, 321, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <input type=\"number\" name=\"Year\"");
                BeginWriteAttribute("value", " value=\"", 375, "\"", 394, 1);
#nullable restore
#line 13 "C:\Users\millr\source\repos\GC_CodeFirstDBLab\GC_CodeFirstDBLab\Views\Car\UpdateCar.cshtml"
WriteAttributeValue("", 383, Model.Year, 383, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <input type=\"text\" name=\"Type\"");
                BeginWriteAttribute("value", " value=\"", 434, "\"", 453, 1);
#nullable restore
#line 14 "C:\Users\millr\source\repos\GC_CodeFirstDBLab\GC_CodeFirstDBLab\Views\Car\UpdateCar.cshtml"
WriteAttributeValue("", 442, Model.Type, 442, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
#nullable restore
#line 15 "C:\Users\millr\source\repos\GC_CodeFirstDBLab\GC_CodeFirstDBLab\Views\Car\UpdateCar.cshtml"
     if (Model.Transmission)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <p>Change to Automatic Transmission</p><input type=\"checkbox\" name=\"Transmission\" value=\"false\" />\r\n");
#nullable restore
#line 18 "C:\Users\millr\source\repos\GC_CodeFirstDBLab\GC_CodeFirstDBLab\Views\Car\UpdateCar.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <p>Change to Manual Transmission</p><input type=\"checkbox\" name=\"Transmission\" value=\"true\" />\r\n");
#nullable restore
#line 22 "C:\Users\millr\source\repos\GC_CodeFirstDBLab\GC_CodeFirstDBLab\Views\Car\UpdateCar.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("    <input type=\"submit\" value=\"Save Changes\" />\r\n\r\n\r\n");
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
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Car> Html { get; private set; }
    }
}
#pragma warning restore 1591