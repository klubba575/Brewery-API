#pragma checksum "C:\Users\Andy Wilder\Desktop\Grand Circus Detroit\API'S\Day31 - BreweryAPIs\Day31 - BreweryAPIs\Views\Brewery\DisplayByState.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eeed757057d86db1ce56a0265d05b8f0db7315bc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Brewery_DisplayByState), @"mvc.1.0.view", @"/Views/Brewery/DisplayByState.cshtml")]
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
#line 1 "C:\Users\Andy Wilder\Desktop\Grand Circus Detroit\API'S\Day31 - BreweryAPIs\Day31 - BreweryAPIs\Views\_ViewImports.cshtml"
using Day31___BreweryAPIs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Andy Wilder\Desktop\Grand Circus Detroit\API'S\Day31 - BreweryAPIs\Day31 - BreweryAPIs\Views\_ViewImports.cshtml"
using Day31___BreweryAPIs.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eeed757057d86db1ce56a0265d05b8f0db7315bc", @"/Views/Brewery/DisplayByState.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f91608a4be8d20253f8e87d590ffd1058c578adf", @"/Views/_ViewImports.cshtml")]
    public class Views_Brewery_DisplayByState : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Brew>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Andy Wilder\Desktop\Grand Circus Detroit\API'S\Day31 - BreweryAPIs\Day31 - BreweryAPIs\Views\Brewery\DisplayByState.cshtml"
  
    ViewData["Title"] = "DisplayByState";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h1>DisplayByState</h1>\r\n\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>name</th>\r\n        <th>brewery_type</th>\r\n        <th>state</th>\r\n\r\n    </tr>\r\n\r\n");
#nullable restore
#line 18 "C:\Users\Andy Wilder\Desktop\Grand Circus Detroit\API'S\Day31 - BreweryAPIs\Day31 - BreweryAPIs\Views\Brewery\DisplayByState.cshtml"
 for (int i = 0; i < @Model.Count; i++)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n    <td> ");
#nullable restore
#line 21 "C:\Users\Andy Wilder\Desktop\Grand Circus Detroit\API'S\Day31 - BreweryAPIs\Day31 - BreweryAPIs\Views\Brewery\DisplayByState.cshtml"
    Write(Model[i].name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td> ");
#nullable restore
#line 22 "C:\Users\Andy Wilder\Desktop\Grand Circus Detroit\API'S\Day31 - BreweryAPIs\Day31 - BreweryAPIs\Views\Brewery\DisplayByState.cshtml"
    Write(Model[i].brewery_type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td> ");
#nullable restore
#line 23 "C:\Users\Andy Wilder\Desktop\Grand Circus Detroit\API'S\Day31 - BreweryAPIs\Day31 - BreweryAPIs\Views\Brewery\DisplayByState.cshtml"
    Write(Model[i].state);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n</tr>\r\n");
#nullable restore
#line 25 "C:\Users\Andy Wilder\Desktop\Grand Circus Detroit\API'S\Day31 - BreweryAPIs\Day31 - BreweryAPIs\Views\Brewery\DisplayByState.cshtml"
  
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Brew>> Html { get; private set; }
    }
}
#pragma warning restore 1591
