#pragma checksum "/Users/stoicaandrei/Faculty/An3/Sem2/II/II_Proiect/CakeStyles/CakeStyles/Views/Users/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a075e69e247135fb72a45f405ab321595511fe48"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Index), @"mvc.1.0.view", @"/Views/Users/Index.cshtml")]
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
#line 1 "/Users/stoicaandrei/Faculty/An3/Sem2/II/II_Proiect/CakeStyles/CakeStyles/Views/_ViewImports.cshtml"
using CakeStyles;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/stoicaandrei/Faculty/An3/Sem2/II/II_Proiect/CakeStyles/CakeStyles/Views/_ViewImports.cshtml"
using CakeStyles.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a075e69e247135fb72a45f405ab321595511fe48", @"/Views/Users/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0036f227f02b08e64ebc2729caa82c06e6ab4413", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CakeStyles.Models.User>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "/Users/stoicaandrei/Faculty/An3/Sem2/II/II_Proiect/CakeStyles/CakeStyles/Views/Users/Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "_Layout_Welcome";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Welcome ");
#nullable restore
#line 8 "/Users/stoicaandrei/Faculty/An3/Sem2/II/II_Proiect/CakeStyles/CakeStyles/Views/Users/Index.cshtml"
       Write(ViewData["Email"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CakeStyles.Models.User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
