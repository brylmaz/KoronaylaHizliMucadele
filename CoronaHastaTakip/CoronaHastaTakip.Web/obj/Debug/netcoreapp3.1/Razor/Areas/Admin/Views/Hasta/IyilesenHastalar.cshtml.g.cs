#pragma checksum "C:\Users\User\Documents\C#Projects\CoronaHastaTakip\CoronaHastaTakip.Web\Areas\Admin\Views\Hasta\IyilesenHastalar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "460329e27ac2aaa4655f918c4afba3f6d82d8e1b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Hasta_IyilesenHastalar), @"mvc.1.0.view", @"/Areas/Admin/Views/Hasta/IyilesenHastalar.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"460329e27ac2aaa4655f918c4afba3f6d82d8e1b", @"/Areas/Admin/Views/Hasta/IyilesenHastalar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85ed3fdc7109aacc0373e184fe1186cf8a44de98", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Hasta_IyilesenHastalar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<HastaListAllViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-light btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "EkipHasta", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detay", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-color:cornflowerblue"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("page-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "IyilesenHastalar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\User\Documents\C#Projects\CoronaHastaTakip\CoronaHastaTakip.Web\Areas\Admin\Views\Hasta\IyilesenHastalar.cshtml"
  
    ViewData["Title"] = "IyilesenHasta";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";
    int index = 0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\User\Documents\C#Projects\CoronaHastaTakip\CoronaHastaTakip.Web\Areas\Admin\Views\Hasta\IyilesenHastalar.cshtml"
 if (Model.Count > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"text-center text-danger font-weight-bold col-md-12 my-3\">\r\n            <h3>İyileştirilen Hastalar</h3>\r\n        </div>\r\n    </div>\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 15 "C:\Users\User\Documents\C#Projects\CoronaHastaTakip\CoronaHastaTakip.Web\Areas\Admin\Views\Hasta\IyilesenHastalar.cshtml"
         foreach (var hasta in Model)
        {
            index++;

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-4\">\r\n                <div class=\"card p-2 ml-2\">\r\n                    <div class=\"card-header text-white bg-success\">\r\n                        <h3 style=\"color:black\">Kimlik No: ");
#nullable restore
#line 21 "C:\Users\User\Documents\C#Projects\CoronaHastaTakip\CoronaHastaTakip.Web\Areas\Admin\Views\Hasta\IyilesenHastalar.cshtml"
                                                      Write(hasta.KimlikNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    </div>\r\n                    <div class=\"card-body\">\r\n                        <strong style=\"color:blue\">Ad Soyad: </strong> <small style=\"font-size:large;color:black\">");
#nullable restore
#line 24 "C:\Users\User\Documents\C#Projects\CoronaHastaTakip\CoronaHastaTakip.Web\Areas\Admin\Views\Hasta\IyilesenHastalar.cshtml"
                                                                                                             Write(hasta.AdSoyad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                        <br />\r\n                        <br />\r\n                        <strong style=\"color:blue\">Yaş: </strong> <small style=\"font-size:large;color:black\">");
#nullable restore
#line 27 "C:\Users\User\Documents\C#Projects\CoronaHastaTakip\CoronaHastaTakip.Web\Areas\Admin\Views\Hasta\IyilesenHastalar.cshtml"
                                                                                                        Write(hasta.Yas);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                        <br />\r\n                        <br />\r\n                        <p class=\"card-text\" style=\"color:black;font-size:large\">");
#nullable restore
#line 30 "C:\Users\User\Documents\C#Projects\CoronaHastaTakip\CoronaHastaTakip.Web\Areas\Admin\Views\Hasta\IyilesenHastalar.cshtml"
                                                                            Write(hasta.Aciklama);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p class=\"card-text\">\r\n                            <strong style=\"color:blue\">Aciliyet Durumu: </strong> <span class=\"badge badge-danger\" style=\"font-size:large\">");
#nullable restore
#line 32 "C:\Users\User\Documents\C#Projects\CoronaHastaTakip\CoronaHastaTakip.Web\Areas\Admin\Views\Hasta\IyilesenHastalar.cshtml"
                                                                                                                                      Write(hasta.Aciliyet.Tanim);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        </p>\r\n                        <strong style=\"color:blue\">Test Tarihi: </strong> <small style=\"font-size:large;color:black\">");
#nullable restore
#line 34 "C:\Users\User\Documents\C#Projects\CoronaHastaTakip\CoronaHastaTakip.Web\Areas\Admin\Views\Hasta\IyilesenHastalar.cshtml"
                                                                                                                Write(hasta.TestTarihi.ToString("D"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                        <br />\r\n                        <br />\r\n                        <strong style=\"color:blue\">İyileştiren Ekip: </strong> <small class=\"badge badge-success\" style=\"font-size:large;color:black\">");
#nullable restore
#line 37 "C:\Users\User\Documents\C#Projects\CoronaHastaTakip\CoronaHastaTakip.Web\Areas\Admin\Views\Hasta\IyilesenHastalar.cshtml"
                                                                                                                                                 Write(hasta.AppUser.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                        <br />\r\n                        <br />\r\n                        <p class=\"text-right\">\r\n\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "460329e27ac2aaa4655f918c4afba3f6d82d8e1b11585", async() => {
                WriteLiteral("\r\n                                Raporlara Git\r\n                                <span class=\"badge badge-dark\" style=\"color:black;background-color:mediumpurple\">");
#nullable restore
#line 44 "C:\Users\User\Documents\C#Projects\CoronaHastaTakip\CoronaHastaTakip.Web\Areas\Admin\Views\Hasta\IyilesenHastalar.cshtml"
                                                                                                            Write(hasta.Raporlar.Count);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 42 "C:\Users\User\Documents\C#Projects\CoronaHastaTakip\CoronaHastaTakip.Web\Areas\Admin\Views\Hasta\IyilesenHastalar.cshtml"
                                                                                                            WriteLiteral(hasta.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 50 "C:\Users\User\Documents\C#Projects\CoronaHastaTakip\CoronaHastaTakip.Web\Areas\Admin\Views\Hasta\IyilesenHastalar.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    <nav aria-label=\"Page navigation example\" class=\"float-left mt-2\">\r\n        <ul class=\"pagination p-2\">\r\n");
#nullable restore
#line 54 "C:\Users\User\Documents\C#Projects\CoronaHastaTakip\CoronaHastaTakip.Web\Areas\Admin\Views\Hasta\IyilesenHastalar.cshtml"
             for (int i = 1; i <= ViewBag.ToplamSayfa; i++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li");
            BeginWriteAttribute("class", " class=\"", 2757, "\"", 2817, 2);
            WriteAttributeValue("", 2765, "page-item", 2765, 9, true);
#nullable restore
#line 56 "C:\Users\User\Documents\C#Projects\CoronaHastaTakip\CoronaHastaTakip.Web\Areas\Admin\Views\Hasta\IyilesenHastalar.cshtml"
WriteAttributeValue(" ", 2774, ViewBag.AktifSayfa == i ? "active" : "", 2775, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "460329e27ac2aaa4655f918c4afba3f6d82d8e1b16143", async() => {
#nullable restore
#line 57 "C:\Users\User\Documents\C#Projects\CoronaHastaTakip\CoronaHastaTakip.Web\Areas\Admin\Views\Hasta\IyilesenHastalar.cshtml"
                                                                                            Write(i);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-aktifSayfa", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 57 "C:\Users\User\Documents\C#Projects\CoronaHastaTakip\CoronaHastaTakip.Web\Areas\Admin\Views\Hasta\IyilesenHastalar.cshtml"
                                                                                 WriteLiteral(i);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["aktifSayfa"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-aktifSayfa", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["aktifSayfa"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </li>\r\n");
#nullable restore
#line 59 "C:\Users\User\Documents\C#Projects\CoronaHastaTakip\CoronaHastaTakip.Web\Areas\Admin\Views\Hasta\IyilesenHastalar.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\r\n    </nav>\r\n");
#nullable restore
#line 62 "C:\Users\User\Documents\C#Projects\CoronaHastaTakip\CoronaHastaTakip.Web\Areas\Admin\Views\Hasta\IyilesenHastalar.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"text-center lead mt-4\">\r\n        <p>\r\n            <h3 style=\"color:black\">İyileştirilen Hasta bulunamadı.</h3>\r\n        </p>\r\n    </div>\r\n");
#nullable restore
#line 70 "C:\Users\User\Documents\C#Projects\CoronaHastaTakip\CoronaHastaTakip.Web\Areas\Admin\Views\Hasta\IyilesenHastalar.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<HastaListAllViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
