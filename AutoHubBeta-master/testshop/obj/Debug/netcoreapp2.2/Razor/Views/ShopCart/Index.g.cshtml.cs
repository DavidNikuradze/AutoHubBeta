#pragma checksum "C:\Users\acer\Desktop\AutoHubBeta-master\testshop\Views\ShopCart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae7f7c4c76a12d1c084214f09d187dd62f5d361e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ShopCart_Index), @"mvc.1.0.view", @"/Views/ShopCart/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ShopCart/Index.cshtml", typeof(AspNetCore.Views_ShopCart_Index))]
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
#line 2 "C:\Users\acer\Desktop\AutoHubBeta-master\testshop\Views\_ViewImports.cshtml"
using testshop.ViewModels;

#line default
#line hidden
#line 3 "C:\Users\acer\Desktop\AutoHubBeta-master\testshop\Views\_ViewImports.cshtml"
using testshop.data.models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae7f7c4c76a12d1c084214f09d187dd62f5d361e", @"/Views/ShopCart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34fd2a0abf55501296cf72c1d68157ffd44b448d", @"/Views/_ViewImports.cshtml")]
    public class Views_ShopCart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShopCartViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(25, 8, true);
            WriteLiteral("\n<div>\n\n");
            EndContext();
#line 5 "C:\Users\acer\Desktop\AutoHubBeta-master\testshop\Views\ShopCart\Index.cshtml"
     foreach (var el in Model.shopCart.listshopitems)
    {

#line default
#line hidden
            BeginContext(93, 78, true);
            WriteLiteral("        <div class=\"alert alert-warning mt-3\">\n\n            <b>ავტომობილი</b> ");
            EndContext();
            BeginContext(172, 11, false);
#line 9 "C:\Users\acer\Desktop\AutoHubBeta-master\testshop\Views\ShopCart\Index.cshtml"
                         Write(el.car.name);

#line default
#line hidden
            EndContext();
            BeginContext(183, 31, true);
            WriteLiteral(" <br/>\n            <b>ფასი</b> ");
            EndContext();
            BeginContext(215, 26, false);
#line 10 "C:\Users\acer\Desktop\AutoHubBeta-master\testshop\Views\ShopCart\Index.cshtml"
                   Write(el.car.price.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(241, 17, true);
            WriteLiteral("\n\n        </div>\n");
            EndContext();
#line 13 "C:\Users\acer\Desktop\AutoHubBeta-master\testshop\Views\ShopCart\Index.cshtml"

    }

#line default
#line hidden
            BeginContext(265, 89, true);
            WriteLiteral("    <hr/>\n    <div class=\"btn btn-danger\" asp-controller=\"order\">გადახდა</div>\n\n\n\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShopCartViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591