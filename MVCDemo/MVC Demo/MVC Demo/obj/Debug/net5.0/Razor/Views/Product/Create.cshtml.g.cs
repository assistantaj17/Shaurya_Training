#pragma checksum "D:\DotnetProject\ADODOTNET\Shaurya_Training\MVCDemo\MVC Demo\MVC Demo\Views\Product\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a9607f228cd881b12865003bec1f76b288c65114"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Create), @"mvc.1.0.view", @"/Views/Product/Create.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\DotnetProject\ADODOTNET\Shaurya_Training\MVCDemo\MVC Demo\MVC Demo\Views\_ViewImports.cshtml"
using MVC_Demo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DotnetProject\ADODOTNET\Shaurya_Training\MVCDemo\MVC Demo\MVC Demo\Views\_ViewImports.cshtml"
using MVC_Demo.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\DotnetProject\ADODOTNET\Shaurya_Training\MVCDemo\MVC Demo\MVC Demo\Views\_ViewImports.cshtml"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9607f228cd881b12865003bec1f76b288c65114", @"/Views/Product/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4313a5ccdc0503b1a2c5cca6af899839a6b5c4a8", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Product_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "D:\DotnetProject\ADODOTNET\Shaurya_Training\MVCDemo\MVC Demo\MVC Demo\Views\Product\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Create</h1>\r\n<!--<form>     </form> -->\r\n");
#nullable restore
#line 9 "D:\DotnetProject\ADODOTNET\Shaurya_Training\MVCDemo\MVC Demo\MVC Demo\Views\Product\Create.cshtml"
Write(Html.BeginForm());

#line default
#line hidden
#nullable disable
            WriteLiteral("{\r\n\r\n    <table>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 13 "D:\DotnetProject\ADODOTNET\Shaurya_Training\MVCDemo\MVC Demo\MVC Demo\Views\Product\Create.cshtml"
           Write(Html.Label("Enter Product Id"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                ");
#nullable restore
#line 15 "D:\DotnetProject\ADODOTNET\Shaurya_Training\MVCDemo\MVC Demo\MVC Demo\Views\Product\Create.cshtml"
           Write(Html.TextBox("Id"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </td>
        </tr>
        <tr>
            <td>
                <label>Enter Product Name</label>
            </td>
            <td>
                <input type=""text"" id=""pname"" name=""pname""/>
            </td>
        </tr>
        <tr>
            <td>
                <label>Enter Product Price</label>
            </td>
            <td>
                ");
#nullable restore
#line 31 "D:\DotnetProject\ADODOTNET\Shaurya_Training\MVCDemo\MVC Demo\MVC Demo\Views\Product\Create.cshtml"
           Write(Html.TextBox("price"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </td>
        </tr>
        <tr>
            <td>
                
            </td>
            <td>
                <input type=""submit"" value=""Add Product"" class=""btn-primary btn-primary""/>
            </td>
        </tr>
    </table>
}
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
