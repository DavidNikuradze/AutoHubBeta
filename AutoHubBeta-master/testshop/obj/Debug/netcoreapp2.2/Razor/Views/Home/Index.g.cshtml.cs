#pragma checksum "C:\Users\acer\Desktop\AutoHubBeta-master\testshop\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "27d379addc209f970d272c623ea88b977c1256cc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27d379addc209f970d272c623ea88b977c1256cc", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34fd2a0abf55501296cf72c1d68157ffd44b448d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 28, true);
            WriteLiteral("<!--სათაური ავტომობილები-->\n");
            EndContext();
            BeginContext(49, 95, true);
            WriteLiteral("<p2>ავტომობილები</p2>\n\n<!--დამატებული მანქნების ჩვენება მეინზე -->\n<div class=\"row mt-5 mb-2\">\n");
            EndContext();
#line 7 "C:\Users\acer\Desktop\AutoHubBeta-master\testshop\Views\Home\Index.cshtml"
      foreach (Car car in Model.FavCars)
      {
            

#line default
#line hidden
            BeginContext(206, 28, false);
#line 9 "C:\Users\acer\Desktop\AutoHubBeta-master\testshop\Views\Home\Index.cshtml"
       Write(Html.Partial("AllCars", car));

#line default
#line hidden
            EndContext();
#line 9 "C:\Users\acer\Desktop\AutoHubBeta-master\testshop\Views\Home\Index.cshtml"
                                         
      }
    

#line default
#line hidden
            BeginContext(249, 6, true);
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591