#pragma checksum "D:\myProjects\vs_studio\MobileStore\MobileStore\Areas\User\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91e62fe71b76816fb0b5ab3a22606b2b52506e9e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_User_Views_User_Index), @"mvc.1.0.view", @"/Areas/User/Views/User/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91e62fe71b76816fb0b5ab3a22606b2b52506e9e", @"/Areas/User/Views/User/Index.cshtml")]
    public class Areas_User_Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\myProjects\vs_studio\MobileStore\MobileStore\Areas\User\Views\User\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row mt-5"">
    <div class=""col text-center"">
        <h3 class=""font-weight-bold"">Manage All Phones</h3>
    </div>
</div>
<!-- Create and search row section -->
<div class=""row mt-5"">
    <div class=""col"">
        <a href=""#"" class=""btn btn-primary btn-material"">Create New</a>
        <form action=""#"" class=""form-inline float-right"">
            <input type=""search"" class=""form-control input-material"" placeholder=""Search by Name"" size=""30"">
            <button type=""submit"" class=""btn btn-link""><i class=""fa fa-lg fa-search""></i></button>
        </form>
    </div>
</div><!-- End create and search row section -->
<!-- Table for all phone management section -->
<Table class=""table mt-3"">
    <thead>
        <tr>
            <th>No.</th>
            <th class=""w-3""></th>
            <th>Model</th>
            <th>Brand</th>
            <th>UnitPrice</th>
            <th>Options</th>
            <th>Quantity</th>
            <th>Created Date</th>
            <th class=""w-");
            WriteLiteral(@"3""></th>
            <th class=""w-3""></th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td>1</td>
            <td>
                <img src=""assets/products/636863648672228468_ss-galaxy-s10-plus-trang-1_1.jpg""
                     class=""img-manage"">
            </td>
            <td class=""font-weight-bold"">Samsung Galaxy S10 Plus</td>
            <td>Samsung</td>
            <td>$999.9</td>
            <td>
                <small>2GB Ram - 128GB Rom - Blue</small><br>
                <small>3GB Ram - 256GB Rom - Red</small><br>
                <small>6GB Ram - 512GB Rom - Red</small><br>
            </td>
            <td class=""text-center"">
                <small>5</small><br>
                <small>15</small><br>
                <small>1</small>
            </td>
            <td>20-10-2019</td>
            <td>
                <a href=""#"" class=""text-secondary""><i class=""fas fa-times""></i></a>
            </td>
            <td>
                <a href=""#"" c");
            WriteLiteral(@"lass=""text-secondary""><i class=""fas fa-cog""></i></a>
            </td>
        </tr>
        <tr>
            <td>2</td>
            <td>
                <img src=""assets/products/636863648672228468_ss-galaxy-s10-plus-trang-1_1.jpg""
                     class=""img-manage"">
            </td>
            <td class=""font-weight-bold"">Samsung Galaxy S10 Plus</td>
            <td>Samsung</td>
            <td>$999.9</td>
            <td>
                <small>2GB Ram - 128GB Rom - Blue</small><br>
                <small>3GB Ram - 256GB Rom - Red</small><br>
                <small>6GB Ram - 512GB Rom - Red</small><br>
            </td>
            <td class=""text-center"">
                <small>5</small><br>
                <small>15</small><br>
                <small>1</small>
            </td>
            <td>20-10-2019</td>
            <td>
                <a href=""#"" class=""text-secondary""><i class=""fas fa-times""></i></a>
            </td>
            <td>
                <a href=""#"" ");
            WriteLiteral("class=\"text-secondary\"><i class=\"fas fa-cog\"></i></a>\r\n            </td>\r\n        </tr>\r\n    </tbody>\r\n</Table><!-- End table for all phone management section -->\r\n");
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
