#pragma checksum "C:\Users\User\Documents\C#Projects\CoronaHastaTakip\CoronaHastaTakip.Web\Areas\Ekip\Views\Bildirim\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff55396604d2f948f3ee0df3a5263796bf2b4967"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Ekip_Views_Bildirim_Index), @"mvc.1.0.view", @"/Areas/Ekip/Views/Bildirim/Index.cshtml")]
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
#line 2 "C:\Users\User\Documents\C#Projects\CoronaHastaTakip\CoronaHastaTakip.Web\Areas\Ekip\Views\_ViewImports.cshtml"
using CoronaHastaTakip.Web.Areas.Ekip.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Documents\C#Projects\CoronaHastaTakip\CoronaHastaTakip.Web\Areas\Ekip\Views\_ViewImports.cshtml"
using CoronaHastaTakipTaslak.Web.Areas.Admin.Models.AciliyetViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\Documents\C#Projects\CoronaHastaTakip\CoronaHastaTakip.Web\Areas\Ekip\Views\_ViewImports.cshtml"
using CoronaHastaTakip.Web.Areas.Admin.Models.HastaViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\Documents\C#Projects\CoronaHastaTakip\CoronaHastaTakip.Web\Areas\Ekip\Views\_ViewImports.cshtml"
using CoronaHastaTakip.Web.Areas.Admin.Models.IsEmriViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\User\Documents\C#Projects\CoronaHastaTakip\CoronaHastaTakip.Web\Areas\Ekip\Views\_ViewImports.cshtml"
using CoronaHastaTakip.Web.Areas.Admin.Models.UserViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\User\Documents\C#Projects\CoronaHastaTakip\CoronaHastaTakip.Web\Areas\Ekip\Views\_ViewImports.cshtml"
using CoronaHastaTakip.Web.Areas.Admin.Models.Bildirim;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff55396604d2f948f3ee0df3a5263796bf2b4967", @"/Areas/Ekip/Views/Bildirim/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ee9da5398242cda91445f401ec03d7b1b2c0a12", @"/Areas/Ekip/Views/_ViewImports.cshtml")]
    public class Areas_Ekip_Views_Bildirim_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BildirimListViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "BildirimOkundu", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\User\Documents\C#Projects\CoronaHastaTakip\CoronaHastaTakip.Web\Areas\Ekip\Views\Bildirim\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Ekip/Views/Shared/_EkipLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"text-center text-danger font-weight-bold col-md-12\">\r\n        <h1 style=\"color:red\">Okunmamış Bildirimler</h1>\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 12 "C:\Users\User\Documents\C#Projects\CoronaHastaTakip\CoronaHastaTakip.Web\Areas\Ekip\Views\Bildirim\Index.cshtml"
 if (Model.Count > 0)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\User\Documents\C#Projects\CoronaHastaTakip\CoronaHastaTakip.Web\Areas\Ekip\Views\Bildirim\Index.cshtml"
     foreach (var bildirim in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-info mx-3 my-2\">\r\n\r\n\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff55396604d2f948f3ee0df3a5263796bf2b49676127", async() => {
                WriteLiteral("\r\n                <p class=\"lead\" style=\"color:black;font-size:larger\">\r\n\r\n                    ");
#nullable restore
#line 22 "C:\Users\User\Documents\C#Projects\CoronaHastaTakip\CoronaHastaTakip.Web\Areas\Ekip\Views\Bildirim\Index.cshtml"
               Write(bildirim.Mesaj);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <button type=\"submit\" class=\"btn btn-primary float-right\">Okundu</button>\r\n                </p>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 19 "C:\Users\User\Documents\C#Projects\CoronaHastaTakip\CoronaHastaTakip.Web\Areas\Ekip\Views\Bildirim\Index.cshtml"
                                                              WriteLiteral(bildirim.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 27 "C:\Users\User\Documents\C#Projects\CoronaHastaTakip\CoronaHastaTakip.Web\Areas\Ekip\Views\Bildirim\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\User\Documents\C#Projects\CoronaHastaTakip\CoronaHastaTakip.Web\Areas\Ekip\Views\Bildirim\Index.cshtml"
     
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p class=\"lead\">\r\n        <h4 class=\"text-center p-4\" style=\"color:black\">Okunmamış bildiriminiz bulunmamaktadır.</h4>\r\n    </p>\r\n");
#nullable restore
#line 34 "C:\Users\User\Documents\C#Projects\CoronaHastaTakip\CoronaHastaTakip.Web\Areas\Ekip\Views\Bildirim\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<BildirimListViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
