#pragma checksum "C:\Users\VINNOTH ALABAMA\Desktop\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\Manufacturer\_CreateOrUpdate.Products.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d63496cb2f250af423b9a11a6cd1d8bb99d626fd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Manufacturer__CreateOrUpdate_Products), @"mvc.1.0.view", @"/Areas/Admin/Views/Manufacturer/_CreateOrUpdate.Products.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
#nullable restore
#line 9 "C:\Users\VINNOTH ALABAMA\Desktop\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using System.Text.Encodings.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\VINNOTH ALABAMA\Desktop\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.ViewFeatures;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\VINNOTH ALABAMA\Desktop\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\VINNOTH ALABAMA\Desktop\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Primitives;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\VINNOTH ALABAMA\Desktop\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\VINNOTH ALABAMA\Desktop\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Core.Domain.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\VINNOTH ALABAMA\Desktop\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Core.Events;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\VINNOTH ALABAMA\Desktop\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Core.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\VINNOTH ALABAMA\Desktop\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Services.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\VINNOTH ALABAMA\Desktop\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using static Nop.Services.Common.NopLinksDefaults;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\VINNOTH ALABAMA\Desktop\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Affiliates;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\VINNOTH ALABAMA\Desktop\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Blogs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\VINNOTH ALABAMA\Desktop\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Catalog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\VINNOTH ALABAMA\Desktop\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Cms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\VINNOTH ALABAMA\Desktop\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\VINNOTH ALABAMA\Desktop\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Customers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\VINNOTH ALABAMA\Desktop\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Directory;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\VINNOTH ALABAMA\Desktop\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Discounts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\VINNOTH ALABAMA\Desktop\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.ExternalAuthentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\VINNOTH ALABAMA\Desktop\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Forums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\VINNOTH ALABAMA\Desktop\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Home;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\VINNOTH ALABAMA\Desktop\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\VINNOTH ALABAMA\Desktop\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Logging;

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\VINNOTH ALABAMA\Desktop\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Messages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\VINNOTH ALABAMA\Desktop\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.MultiFactorAuthentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\VINNOTH ALABAMA\Desktop\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.News;

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\VINNOTH ALABAMA\Desktop\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Orders;

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\VINNOTH ALABAMA\Desktop\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Payments;

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\VINNOTH ALABAMA\Desktop\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Plugins;

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\VINNOTH ALABAMA\Desktop\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Plugins.Marketplace;

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\VINNOTH ALABAMA\Desktop\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Polls;

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\VINNOTH ALABAMA\Desktop\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Reports;

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\VINNOTH ALABAMA\Desktop\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Security;

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\VINNOTH ALABAMA\Desktop\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Settings;

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\VINNOTH ALABAMA\Desktop\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Shipping;

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\VINNOTH ALABAMA\Desktop\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.ShoppingCart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Users\VINNOTH ALABAMA\Desktop\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Stores;

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\VINNOTH ALABAMA\Desktop\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Tasks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "C:\Users\VINNOTH ALABAMA\Desktop\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Tax;

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Users\VINNOTH ALABAMA\Desktop\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Templates;

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\Users\VINNOTH ALABAMA\Desktop\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Topics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Users\VINNOTH ALABAMA\Desktop\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Vendors;

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "C:\Users\VINNOTH ALABAMA\Desktop\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "C:\Users\VINNOTH ALABAMA\Desktop\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework;

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "C:\Users\VINNOTH ALABAMA\Desktop\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Menu;

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "C:\Users\VINNOTH ALABAMA\Desktop\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "C:\Users\VINNOTH ALABAMA\Desktop\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Events;

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "C:\Users\VINNOTH ALABAMA\Desktop\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "C:\Users\VINNOTH ALABAMA\Desktop\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "C:\Users\VINNOTH ALABAMA\Desktop\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Models.DataTables;

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "C:\Users\VINNOTH ALABAMA\Desktop\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Security.Captcha;

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "C:\Users\VINNOTH ALABAMA\Desktop\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Security.Honeypot;

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "C:\Users\VINNOTH ALABAMA\Desktop\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Themes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "C:\Users\VINNOTH ALABAMA\Desktop\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.UI;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d63496cb2f250af423b9a11a6cd1d8bb99d626fd", @"/Areas/Admin/Views/Manufacturer/_CreateOrUpdate.Products.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"181066c519b5e3a88fbfc1b430cb86e3463f4c97", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Manufacturer__CreateOrUpdate_Products : Nop.Web.Framework.Mvc.Razor.NopRazorPage<ManufacturerModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\VINNOTH ALABAMA\Desktop\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\Manufacturer\_CreateOrUpdate.Products.cshtml"
 if (Model.Id > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"card-body\">\r\n    ");
#nullable restore
#line 6 "C:\Users\VINNOTH ALABAMA\Desktop\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\Manufacturer\_CreateOrUpdate.Products.cshtml"
Write(await Html.PartialAsync("Table", new DataTablesModel
    {
        Name = "products-grid",
        UrlRead = new DataUrl("ProductList", "Manufacturer", new RouteValueDictionary { [nameof(Model.ManufacturerProductSearchModel.ManufacturerId)] = Model.ManufacturerProductSearchModel.ManufacturerId }),
        UrlDelete = new DataUrl("ProductDelete", "Manufacturer", null),
        UrlUpdate = new DataUrl("ProductUpdate", "Manufacturer", null),
        Length = Model.ManufacturerProductSearchModel.PageSize,
        LengthMenu = Model.ManufacturerProductSearchModel.AvailablePageSizes,
        ColumnCollection = new List<ColumnProperty>
            {
                new ColumnProperty(nameof(ManufacturerProductModel.ProductName))
                {
                    Title = T("Admin.Catalog.Manufacturers.Products.Fields.Product").Text
                },
                new ColumnProperty(nameof(ManufacturerProductModel.IsFeaturedProduct))
                {
                    Title = T("Admin.Catalog.Manufacturers.Products.Fields.IsFeaturedProduct").Text,
                    Width = "150",
                    ClassName = NopColumnClassDefaults.CenterAll,
                    Render = new RenderBoolean(),
                    Editable = true,
                    EditType = EditType.Checkbox
                },
                new ColumnProperty(nameof(ManufacturerProductModel.DisplayOrder))
                {
                    Title = T("Admin.Catalog.Manufacturers.Products.Fields.DisplayOrder").Text,
                    Width = "150",
                    ClassName = NopColumnClassDefaults.CenterAll,
                    Editable = true,
                    EditType = EditType.Number
                },
                new ColumnProperty(nameof(ManufacturerProductModel.ProductId))
                {
                    Title = T("Admin.Common.View").Text,
                    Width = "150",
                    ClassName = NopColumnClassDefaults.Button,
                    Render = new RenderButtonView(new DataUrl("~/Admin/Product/Edit/", nameof(ManufacturerProductModel.ProductId)))
                },
                new ColumnProperty(nameof(ManufacturerProductModel.Id))
                {
                    Title = T("Admin.Common.Edit").Text,
                    Width = "200",
                    ClassName =  NopColumnClassDefaults.Button,
                    Render = new RenderButtonsInlineEdit()
                },
                new ColumnProperty(nameof(ManufacturerProductModel.Id))
                {
                    Title = T("Admin.Common.Delete").Text,
                    Width = "100",
                    Render = new RenderButtonRemove(T("Admin.Common.Delete").Text),
                    ClassName = NopColumnClassDefaults.Button
                }
            }
    }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
            WriteLiteral("<div class=\"card-footer\">\r\n    <button type=\"submit\" id=\"btnAddNewProduct\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3036, "\"", 3245, 8);
            WriteAttributeValue("", 3046, "javascript:OpenWindow(\'", 3046, 23, true);
#nullable restore
#line 63 "C:\Users\VINNOTH ALABAMA\Desktop\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\Manufacturer\_CreateOrUpdate.Products.cshtml"
WriteAttributeValue("", 3069, Url.Action("ProductAddPopup", "Manufacturer", new { manufacturerId = Model.Id, btnId = "btnRefreshProducts", formId = "manufacturer-form" }), 3069, 143, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3212, "\',", 3212, 2, true);
            WriteAttributeValue(" ", 3214, "800,", 3215, 5, true);
            WriteAttributeValue(" ", 3219, "800,", 3220, 5, true);
            WriteAttributeValue(" ", 3224, "true);", 3225, 7, true);
            WriteAttributeValue(" ", 3231, "return", 3232, 7, true);
            WriteAttributeValue(" ", 3238, "false;", 3239, 7, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">\r\n        ");
#nullable restore
#line 64 "C:\Users\VINNOTH ALABAMA\Desktop\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\Manufacturer\_CreateOrUpdate.Products.cshtml"
   Write(T("Admin.Catalog.Manufacturers.Products.AddNew"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </button>
    <button type=""submit"" id=""btnRefreshProducts"" style=""display: none""></button>
    <script>
        $(document).ready(function () {
            $('#btnRefreshProducts').click(function () {
                //refresh grid
                updateTable('#products-grid');

                //return false to don't reload a page
                return false;
            });
        });
    </script>
</div>
");
#nullable restore
#line 79 "C:\Users\VINNOTH ALABAMA\Desktop\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\Manufacturer\_CreateOrUpdate.Products.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card-body\">\r\n        ");
#nullable restore
#line 83 "C:\Users\VINNOTH ALABAMA\Desktop\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\Manufacturer\_CreateOrUpdate.Products.cshtml"
   Write(T("Admin.Catalog.Manufacturers.Products.SaveBeforeEdit"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 85 "C:\Users\VINNOTH ALABAMA\Desktop\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\Manufacturer\_CreateOrUpdate.Products.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IWorkContext workContext { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IGenericAttributeService genericAttributeService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ManufacturerModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
