#pragma checksum "C:\Users\Taghr\source\repos\Hospital\Hospital\Views\Physicians\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36c6d123162ad6452e736c7264340a91241de693"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Physicians_Details), @"mvc.1.0.view", @"/Views/Physicians/Details.cshtml")]
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
#line 1 "C:\Users\Taghr\source\repos\Hospital\Hospital\Views\_ViewImports.cshtml"
using Hospital;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Taghr\source\repos\Hospital\Hospital\Views\_ViewImports.cshtml"
using Hospital.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36c6d123162ad6452e736c7264340a91241de693", @"/Views/Physicians/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88caee22214edcd79e48d3dce45ad60c3b27aa44", @"/Views/_ViewImports.cshtml")]
    public class Views_Physicians_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Taghr\source\repos\Hospital\Hospital\Views\Physicians\Details.cshtml"
   
    var Physician = (PhysicianModel)ViewBag.Physicians;
    var url = (Physician.gender == 'F' ? "https://i.pinimg.com/originals/d3/f9/13/d3f913b8dd27fac04b26c2c9a903610d.png" : "https://i.pinimg.com/originals/e3/7e/14/e37e14e207070d62cfc4d0b050f3ad91.png");


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"card\" style=\"width: 18rem; margin-left:35%\">\r\n    <div class=\"card-header\">\r\n        <img");
            BeginWriteAttribute("src", " src=", 374, "", 383, 1);
#nullable restore
#line 9 "C:\Users\Taghr\source\repos\Hospital\Hospital\Views\Physicians\Details.cshtml"
WriteAttributeValue("", 379, url, 379, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\" alt=\"...\">\r\n    </div>\r\n    <div class=\"card-body\">\r\n        <h5 class=\"card-title text-info\"> ");
#nullable restore
#line 12 "C:\Users\Taghr\source\repos\Hospital\Hospital\Views\Physicians\Details.cshtml"
                                     Write(Physician.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral(" | ");
#nullable restore
#line 12 "C:\Users\Taghr\source\repos\Hospital\Hospital\Views\Physicians\Details.cshtml"
                                                           Write(Physician.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n        <p class=\"card-text alert-info\">Physician ID : ");
#nullable restore
#line 13 "C:\Users\Taghr\source\repos\Hospital\Hospital\Views\Physicians\Details.cshtml"
                                                  Write(Physician.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p class=\"card_text\"> Gender : ");
#nullable restore
#line 14 "C:\Users\Taghr\source\repos\Hospital\Hospital\Views\Physicians\Details.cshtml"
                                  Write(Physician.gender);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n        <a href=\"#\" class=\"btn btn-outline-danger\">Book an appointment</a>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
