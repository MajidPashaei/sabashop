#pragma checksum "E:\sabashop\Areas\Admin\Views\Slider\ShowListSlider.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "492dbedc44aa4e029856bd8ab1c7442445f28fa6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Slider_ShowListSlider), @"mvc.1.0.view", @"/Areas/Admin/Views/Slider/ShowListSlider.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"492dbedc44aa4e029856bd8ab1c7442445f28fa6", @"/Areas/Admin/Views/Slider/ShowListSlider.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bec31618b1c9538a5b46fabeceacc7caabcdc81f", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Slider_ShowListSlider : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\sabashop\Areas\Admin\Views\Slider\ShowListSlider.cshtml"
 if ( ViewBag.msg != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p class=\"alert alert-danger\"> ");
#nullable restore
#line 3 "E:\sabashop\Areas\Admin\Views\Slider\ShowListSlider.cshtml"
                              Write(ViewBag.msg);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 4 "E:\sabashop\Areas\Admin\Views\Slider\ShowListSlider.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n<table>\r\n  <tr>\r\n    <th>number</th>\r\n    <th>img</th>\r\n    <th>link</th>\r\n    <th>Delete</th>\r\n    <th>update</th>\r\n  </tr>\r\n");
#nullable restore
#line 18 "E:\sabashop\Areas\Admin\Views\Slider\ShowListSlider.cshtml"
   if (ViewBag.show != null)
  {
      int i = 1 ;
      foreach (var item in ViewBag.show)
      {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr style=\" text-align: center;\">\r\n          <td style=\" text-align: center;\">");
#nullable restore
#line 24 "E:\sabashop\Areas\Admin\Views\Slider\ShowListSlider.cshtml"
                                      Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td style=\" text-align: center;\">\r\n              <img");
            BeginWriteAttribute("src", " src=\"", 486, "\"", 522, 2);
            WriteAttributeValue("", 492, "/FileUpload/slider/", 492, 19, true);
#nullable restore
#line 26 "E:\sabashop\Areas\Admin\Views\Slider\ShowListSlider.cshtml"
WriteAttributeValue("", 511, item.Image, 511, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width: 20%; text-align: center;\"");
            BeginWriteAttribute("alt", " alt=\"", 563, "\"", 569, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n          </td>\r\n          <td>");
#nullable restore
#line 28 "E:\sabashop\Areas\Admin\Views\Slider\ShowListSlider.cshtml"
         Write(item.LinkTO);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td><a class=\"btn btn-sm btn-info\" style=\" text-align: center;\"");
            BeginWriteAttribute("href", " href=\"", 696, "\"", 737, 2);
            WriteAttributeValue("", 703, "/admin/slider/DeletSlider/", 703, 26, true);
#nullable restore
#line 29 "E:\sabashop\Areas\Admin\Views\Slider\ShowListSlider.cshtml"
WriteAttributeValue("", 729, item.Id, 729, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">delete</a></td>\r\n\r\n          <td><a class=\"btn btn-sm btn-info\" style=\" text-align: center;\"");
            BeginWriteAttribute("href", " href=\"", 831, "\"", 871, 2);
            WriteAttributeValue("", 838, "/admin/slider/GoToUpdate/", 838, 25, true);
#nullable restore
#line 31 "E:\sabashop\Areas\Admin\Views\Slider\ShowListSlider.cshtml"
WriteAttributeValue("", 863, item.Id, 863, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">update</a></td>\r\n        </tr>  \r\n");
#nullable restore
#line 33 "E:\sabashop\Areas\Admin\Views\Slider\ShowListSlider.cshtml"
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
