#pragma checksum "C:\Users\emre5\Desktop\ikmm\GorevYoneticisi\GorevYoneticisi\Views\TableByDay\EditPlan.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dac2392b68de490419d3e99c92ba3b05a1a8ed6f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TableByDay_EditPlan), @"mvc.1.0.view", @"/Views/TableByDay/EditPlan.cshtml")]
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
#line 1 "C:\Users\emre5\Desktop\ikmm\GorevYoneticisi\GorevYoneticisi\Views\_ViewImports.cshtml"
using GorevYoneticisi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\emre5\Desktop\ikmm\GorevYoneticisi\GorevYoneticisi\Views\_ViewImports.cshtml"
using GorevYoneticisi.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\emre5\Desktop\ikmm\GorevYoneticisi\GorevYoneticisi\Views\TableByDay\EditPlan.cshtml"
using System.Security.Cryptography.X509Certificates;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dac2392b68de490419d3e99c92ba3b05a1a8ed6f", @"/Views/TableByDay/EditPlan.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9013dd2d6376a231cd41f52cbd9e37a688e693c1", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_TableByDay_EditPlan : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Plan>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\emre5\Desktop\ikmm\GorevYoneticisi\GorevYoneticisi\Views\TableByDay\EditPlan.cshtml"
  
    ViewData["Title"] = "EditPlan";
    Layout = "~/Views/Shared/UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"col-12 grid-margin stretch-card\">\r\n    <div class=\"card\">\r\n        <div class=\"card-body\">\r\n");
#nullable restore
#line 11 "C:\Users\emre5\Desktop\ikmm\GorevYoneticisi\GorevYoneticisi\Views\TableByDay\EditPlan.cshtml"
             using (Html.BeginForm("EditPlan", "TableByDay", FormMethod.Post))
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <h4>");
#nullable restore
#line 14 "C:\Users\emre5\Desktop\ikmm\GorevYoneticisi\GorevYoneticisi\Views\TableByDay\EditPlan.cshtml"
               Write(ViewBag.dayName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" günü Saat:");
#nullable restore
#line 14 "C:\Users\emre5\Desktop\ikmm\GorevYoneticisi\GorevYoneticisi\Views\TableByDay\EditPlan.cshtml"
                                          Write(ViewBag.dayTime);

#line default
#line hidden
#nullable disable
            WriteLiteral(" İçin Planı Düzenle</h4>\r\n");
            WriteLiteral("                <br />\r\n");
            WriteLiteral("                <div class=\"form-group\">\r\n                    <div class=\"form-group\">\r\n                        <label for=\"exampleInputName1\">Plan ID</label>\r\n                        ");
#nullable restore
#line 21 "C:\Users\emre5\Desktop\ikmm\GorevYoneticisi\GorevYoneticisi\Views\TableByDay\EditPlan.cshtml"
                   Write(Html.TextBoxFor(x => x.PlanID, new {@class = "form-control",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <label for=\"exampleInputName1\">Kullanıcı ID</label>\r\n                        ");
#nullable restore
#line 25 "C:\Users\emre5\Desktop\ikmm\GorevYoneticisi\GorevYoneticisi\Views\TableByDay\EditPlan.cshtml"
                   Write(Html.TextBoxFor(x => x.UserID, new {@class = "form-control",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n\r\n                    <label for=\"exampleInputName1\">Yeni Tarih ve Saat Belirle</label>\r\n                    ");
#nullable restore
#line 29 "C:\Users\emre5\Desktop\ikmm\GorevYoneticisi\GorevYoneticisi\Views\TableByDay\EditPlan.cshtml"
               Write(Html.TextBoxFor(x => x.PlanDay, new {@class = "form-control", @type = "datetime-local"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n                    <div class=\"form-group\">\r\n                        <label for=\"exampleInputName1\">Plan Başlığı</label>\r\n                        ");
#nullable restore
#line 34 "C:\Users\emre5\Desktop\ikmm\GorevYoneticisi\GorevYoneticisi\Views\TableByDay\EditPlan.cshtml"
                   Write(Html.TextBoxFor(x => x.PlanTitle, new {@class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <label for=\"exampleInputName1\">Plan İçeriği</label>\r\n                        ");
#nullable restore
#line 38 "C:\Users\emre5\Desktop\ikmm\GorevYoneticisi\GorevYoneticisi\Views\TableByDay\EditPlan.cshtml"
                   Write(Html.TextBoxFor(x => x.PlanContent, new {@class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n");
            WriteLiteral("                <button type=\"submit\" class=\"btn btn-gradient-primary mr-2\">Değiştir Ve Kaydet</button>\r\n                <button class=\"btn btn-light\">Cancel</button>\r\n");
#nullable restore
#line 44 "C:\Users\emre5\Desktop\ikmm\GorevYoneticisi\GorevYoneticisi\Views\TableByDay\EditPlan.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Plan> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591