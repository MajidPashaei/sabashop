#pragma checksum "E:\sabashop\Areas\Admin\Views\Category\Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "15b3c404b7c2cb5093f886f6bdfdeed0dabd391e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Category_Show), @"mvc.1.0.view", @"/Areas/Admin/Views/Category/Show.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15b3c404b7c2cb5093f886f6bdfdeed0dabd391e", @"/Areas/Admin/Views/Category/Show.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bec31618b1c9538a5b46fabeceacc7caabcdc81f", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Category_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 4 "E:\sabashop\Areas\Admin\Views\Category\Show.cshtml"
 if (ViewBag.msg != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p class=\"alert alert-info\">");
#nullable restore
#line 6 "E:\sabashop\Areas\Admin\Views\Category\Show.cshtml"
                           Write(ViewBag.msg);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 7 "E:\sabashop\Areas\Admin\Views\Category\Show.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<table>\r\n  <tr>\r\n    <th>number</th>\r\n    <th>name</th>\r\n    <th>fathername</th>\r\n    <th>grandfathername</th>\r\n    <th>Update</th>\r\n    <th>Delete</th>\r\n  </tr>\r\n");
#nullable restore
#line 20 "E:\sabashop\Areas\Admin\Views\Category\Show.cshtml"
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
#line 26 "E:\sabashop\Areas\Admin\Views\Category\Show.cshtml"
             Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n              <td>");
#nullable restore
#line 27 "E:\sabashop\Areas\Admin\Views\Category\Show.cshtml"
             Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n              <td>");
#nullable restore
#line 28 "E:\sabashop\Areas\Admin\Views\Category\Show.cshtml"
             Write(item.FatherName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n              <td>");
#nullable restore
#line 29 "E:\sabashop\Areas\Admin\Views\Category\Show.cshtml"
             Write(item.GrandFatherName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n              <td>\r\n                  <a");
            BeginWriteAttribute("href", " href=\"", 580, "\"", 618, 2);
            WriteAttributeValue("", 587, "/admin/category/update/", 587, 23, true);
#nullable restore
#line 31 "E:\sabashop\Areas\Admin\Views\Category\Show.cshtml"
WriteAttributeValue("", 610, item.Id, 610, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">update</a>\r\n              </td>\r\n              <td>\r\n                  <a");
            BeginWriteAttribute("href", " href=\"", 693, "\"", 731, 2);
            WriteAttributeValue("", 700, "/admin/category/delete/", 700, 23, true);
#nullable restore
#line 34 "E:\sabashop\Areas\Admin\Views\Category\Show.cshtml"
WriteAttributeValue("", 723, item.Id, 723, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">delete</a>\r\n              </td>\r\n            </tr>\r\n");
#nullable restore
#line 37 "E:\sabashop\Areas\Admin\Views\Category\Show.cshtml"
            i++;
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
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