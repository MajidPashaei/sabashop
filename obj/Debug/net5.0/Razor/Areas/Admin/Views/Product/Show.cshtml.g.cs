#pragma checksum "E:\sabashop\Areas\Admin\Views\Product\Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "624fbfb69f1d923b3a8ab3c4ec6cc2c212f991f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Product_Show), @"mvc.1.0.view", @"/Areas/Admin/Views/Product/Show.cshtml")]
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
#line 1 "E:\sabashop\Areas\Admin\Views\_ViewImports.cshtml"
using sabashop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\sabashop\Areas\Admin\Views\_ViewImports.cshtml"
using sabashop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"624fbfb69f1d923b3a8ab3c4ec6cc2c212f991f4", @"/Areas/Admin/Views/Product/Show.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bec31618b1c9538a5b46fabeceacc7caabcdc81f", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Product_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<table>\r\n  <tr>\r\n    <th>number</th>\r\n    <th>name</th>\r\n    <th>Count</th>\r\n    <th>catId</th>\r\n    <th>SiteCatId</th>\r\n    <th>Price</th>\r\n    <th>Offer</th>\r\n    <th>update</th>\r\n    <th>delete</th>\r\n  </tr>\r\n");
#nullable restore
#line 13 "E:\sabashop\Areas\Admin\Views\Product\Show.cshtml"
     if (ViewBag.Show != null)
    {
        int i =  1;
        foreach (var item in ViewBag.Show)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n              <td>");
#nullable restore
#line 19 "E:\sabashop\Areas\Admin\Views\Product\Show.cshtml"
             Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n              <td>");
#nullable restore
#line 20 "E:\sabashop\Areas\Admin\Views\Product\Show.cshtml"
             Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n              <td>");
#nullable restore
#line 21 "E:\sabashop\Areas\Admin\Views\Product\Show.cshtml"
             Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n              <td>");
#nullable restore
#line 22 "E:\sabashop\Areas\Admin\Views\Product\Show.cshtml"
             Write(item.SiteCategory);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n              <td>");
#nullable restore
#line 23 "E:\sabashop\Areas\Admin\Views\Product\Show.cshtml"
             Write(item.price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n              <td>");
#nullable restore
#line 24 "E:\sabashop\Areas\Admin\Views\Product\Show.cshtml"
             Write(item.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n              <td>");
#nullable restore
#line 25 "E:\sabashop\Areas\Admin\Views\Product\Show.cshtml"
             Write(item.offer);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n              <td>\r\n                  <img");
            BeginWriteAttribute("src", " src=\"", 643, "\"", 680, 2);
            WriteAttributeValue("", 649, "/fileUpload/product/", 649, 20, true);
#nullable restore
#line 27 "E:\sabashop\Areas\Admin\Views\Product\Show.cshtml"
WriteAttributeValue("", 669, item.Image, 669, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 681, "\"", 687, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n              </td>\r\n              <td>\r\n                  <a");
            BeginWriteAttribute("href", " href=\"", 752, "\"", 789, 2);
            WriteAttributeValue("", 759, "/admin/produtc/update/", 759, 22, true);
#nullable restore
#line 30 "E:\sabashop\Areas\Admin\Views\Product\Show.cshtml"
WriteAttributeValue("", 781, item.Id, 781, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">update</a>\r\n              </td>\r\n              <td>\r\n                  <a");
            BeginWriteAttribute("href", " href=\"", 864, "\"", 901, 2);
            WriteAttributeValue("", 871, "/admin/produtc/Delete/", 871, 22, true);
#nullable restore
#line 33 "E:\sabashop\Areas\Admin\Views\Product\Show.cshtml"
WriteAttributeValue("", 893, item.Id, 893, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">delete</a>\r\n              </td>\r\n            </tr>\r\n");
#nullable restore
#line 36 "E:\sabashop\Areas\Admin\Views\Product\Show.cshtml"
            i++;
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
