#pragma checksum "C:\Users\User\Documents\C#Projects\CoronaHastaTakip\CoronaHastaTakip.Web\Areas\Admin\Views\EkipHasta\Detay.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "554fe60555ecce05d2494b80ea2e8dc630319f6f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_EkipHasta_Detay), @"mvc.1.0.view", @"/Areas/Admin/Views/EkipHasta/Detay.cshtml")]
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
#line 3 "C:\Users\User\Documents\C#Projects\CoronaHastaTakip\CoronaHastaTakip.Web\Areas\Admin\Views\_ViewImports.cshtml"
using CoronaHastaTakipTaslak.Web.Areas.Admin.Models.AciliyetViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\Documents\C#Projects\CoronaHastaTakip\CoronaHastaTakip.Web\Areas\Admin\Views\_ViewImports.cshtml"
using CoronaHastaTakip.Web.Areas.Admin.Models.HastaViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\Documents\C#Projects\CoronaHastaTakip\CoronaHastaTakip.Web\Areas\Admin\Views\_ViewImports.cshtml"
using CoronaHastaTakip.Web.Areas.Admin.Models.IsEmriViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\User\Documents\C#Projects\CoronaHastaTakip\CoronaHastaTakip.Web\Areas\Admin\Views\_ViewImports.cshtml"
using CoronaHastaTakip.Web.Areas.Admin.Models.UserViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\User\Documents\C#Projects\CoronaHastaTakip\CoronaHastaTakip.Web\Areas\Admin\Views\_ViewImports.cshtml"
using CoronaHastaTakip.Web.Areas.Admin.Models.Bildirim;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\User\Documents\C#Projects\CoronaHastaTakip\CoronaHastaTakip.Web\Areas\Admin\Views\_ViewImports.cshtml"
using CoronaHastaTakip.Web.Areas.Admin.Models.RaporViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"554fe60555ecce05d2494b80ea2e8dc630319f6f", @"/Areas/Admin/Views/EkipHasta/Detay.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85ed3fdc7109aacc0373e184fe1186cf8a44de98", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_EkipHasta_Detay : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HastaListAllViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetirExcel", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("target", new global::Microsoft.AspNetCore.Html.HtmlString("_blank"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info mt-2 ml-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetirPdf", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\User\Documents\C#Projects\CoronaHastaTakip\CoronaHastaTakip.Web\Areas\Admin\Views\EkipHasta\Detay.cshtml"
  
    ViewData["Title"] = "Detay";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\User\Documents\C#Projects\CoronaHastaTakip\CoronaHastaTakip.Web\Areas\Admin\Views\EkipHasta\Detay.cshtml"
 if (Model.Raporlar.Count > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "554fe60555ecce05d2494b80ea2e8dc630319f6f6235", async() => {
                WriteLiteral("<i class=\"fas fa-file-excel mr-2\"></i>Excel İndir");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 9 "C:\Users\User\Documents\C#Projects\CoronaHastaTakip\CoronaHastaTakip.Web\Areas\Admin\Views\EkipHasta\Detay.cshtml"
                                 WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "554fe60555ecce05d2494b80ea2e8dc630319f6f8627", async() => {
                WriteLiteral("<i class=\"fas fa-file-pdf mr-2\"></i>Pdf İndir");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 10 "C:\Users\User\Documents\C#Projects\CoronaHastaTakip\CoronaHastaTakip.Web\Areas\Admin\Views\EkipHasta\Detay.cshtml"
                               WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral("    <table class=\"table table-bordered table-hover mt-3 text-center\">\r\n\r\n        <tr class=\"mt-2\">\r\n            <th><h5 style=\"color:orangered\"><b>Tanim</b></h5></th>\r\n            <th><h5 style=\"color:orangered\"><b>Detay</b></h5></th>\r\n        </tr>\r\n");
#nullable restore
#line 18 "C:\Users\User\Documents\C#Projects\CoronaHastaTakip\CoronaHastaTakip.Web\Areas\Admin\Views\EkipHasta\Detay.cshtml"
         foreach (var rapor in Model.Raporlar)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td><h6 style=\"color:black\">");
#nullable restore
#line 21 "C:\Users\User\Documents\C#Projects\CoronaHastaTakip\CoronaHastaTakip.Web\Areas\Admin\Views\EkipHasta\Detay.cshtml"
                                       Write(rapor.Tanim);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6></td>\r\n                <td><h6 style=\"color:black\">");
#nullable restore
#line 22 "C:\Users\User\Documents\C#Projects\CoronaHastaTakip\CoronaHastaTakip.Web\Areas\Admin\Views\EkipHasta\Detay.cshtml"
                                       Write(rapor.Detay);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6></td>\r\n            </tr>\r\n");
#nullable restore
#line 24 "C:\Users\User\Documents\C#Projects\CoronaHastaTakip\CoronaHastaTakip.Web\Areas\Admin\Views\EkipHasta\Detay.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n");
#nullable restore
#line 26 "C:\Users\User\Documents\C#Projects\CoronaHastaTakip\CoronaHastaTakip.Web\Areas\Admin\Views\EkipHasta\Detay.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"border border-dark mt-3 text-center\">\r\n        <h4 style=\"color:black\">");
#nullable restore
#line 30 "C:\Users\User\Documents\C#Projects\CoronaHastaTakip\CoronaHastaTakip.Web\Areas\Admin\Views\EkipHasta\Detay.cshtml"
                           Write(Model.AppUser.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ekibi tedaviye devam ediyor. Henüz bir rapor yazmamıştır.</h4>\r\n    </div>\r\n");
#nullable restore
#line 32 "C:\Users\User\Documents\C#Projects\CoronaHastaTakip\CoronaHastaTakip.Web\Areas\Admin\Views\EkipHasta\Detay.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HastaListAllViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
