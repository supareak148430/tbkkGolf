#pragma checksum "C:\Users\Supareak Sangnaul\Desktop\test tbkk\tbkk\tbkk\Pages\Emproyees\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8302f140000e34a11c4f84478c0c6e8252d7cf19"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(tbkk.Pages.Emproyees.Pages_Emproyees_Details), @"mvc.1.0.razor-page", @"/Pages/Emproyees/Details.cshtml")]
namespace tbkk.Pages.Emproyees
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
#line 1 "C:\Users\Supareak Sangnaul\Desktop\test tbkk\tbkk\tbkk\Pages\_ViewImports.cshtml"
using tbkk;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8302f140000e34a11c4f84478c0c6e8252d7cf19", @"/Pages/Emproyees/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1001f92a60c1a37f53eadf389bf666c1fdc42288", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Emproyees_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Supareak Sangnaul\Desktop\test tbkk\tbkk\tbkk\Pages\Emproyees\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Employee</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "C:\Users\Supareak Sangnaul\Desktop\test tbkk\tbkk\tbkk\Pages\Emproyees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "C:\Users\Supareak Sangnaul\Desktop\test tbkk\tbkk\tbkk\Pages\Emproyees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Employee.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "C:\Users\Supareak Sangnaul\Desktop\test tbkk\tbkk\tbkk\Pages\Emproyees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "C:\Users\Supareak Sangnaul\Desktop\test tbkk\tbkk\tbkk\Pages\Emproyees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Employee.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "C:\Users\Supareak Sangnaul\Desktop\test tbkk\tbkk\tbkk\Pages\Emproyees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "C:\Users\Supareak Sangnaul\Desktop\test tbkk\tbkk\tbkk\Pages\Emproyees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Employee.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "C:\Users\Supareak Sangnaul\Desktop\test tbkk\tbkk\tbkk\Pages\Emproyees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "C:\Users\Supareak Sangnaul\Desktop\test tbkk\tbkk\tbkk\Pages\Emproyees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Employee.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "C:\Users\Supareak Sangnaul\Desktop\test tbkk\tbkk\tbkk\Pages\Emproyees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.Call));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "C:\Users\Supareak Sangnaul\Desktop\test tbkk\tbkk\tbkk\Pages\Emproyees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Employee.Call));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 45 "C:\Users\Supareak Sangnaul\Desktop\test tbkk\tbkk\tbkk\Pages\Emproyees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.Line));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 48 "C:\Users\Supareak Sangnaul\Desktop\test tbkk\tbkk\tbkk\Pages\Emproyees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Employee.Line));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 51 "C:\Users\Supareak Sangnaul\Desktop\test tbkk\tbkk\tbkk\Pages\Emproyees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.Image));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 54 "C:\Users\Supareak Sangnaul\Desktop\test tbkk\tbkk\tbkk\Pages\Emproyees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Employee.Image));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 57 "C:\Users\Supareak Sangnaul\Desktop\test tbkk\tbkk\tbkk\Pages\Emproyees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.Addr));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 60 "C:\Users\Supareak Sangnaul\Desktop\test tbkk\tbkk\tbkk\Pages\Emproyees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Employee.Addr));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 63 "C:\Users\Supareak Sangnaul\Desktop\test tbkk\tbkk\tbkk\Pages\Emproyees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 66 "C:\Users\Supareak Sangnaul\Desktop\test tbkk\tbkk\tbkk\Pages\Emproyees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Employee.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 69 "C:\Users\Supareak Sangnaul\Desktop\test tbkk\tbkk\tbkk\Pages\Emproyees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 72 "C:\Users\Supareak Sangnaul\Desktop\test tbkk\tbkk\tbkk\Pages\Emproyees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Employee.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 75 "C:\Users\Supareak Sangnaul\Desktop\test tbkk\tbkk\tbkk\Pages\Emproyees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.Company));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 78 "C:\Users\Supareak Sangnaul\Desktop\test tbkk\tbkk\tbkk\Pages\Emproyees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Employee.Company.CompanyID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 81 "C:\Users\Supareak Sangnaul\Desktop\test tbkk\tbkk\tbkk\Pages\Emproyees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.Department));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 84 "C:\Users\Supareak Sangnaul\Desktop\test tbkk\tbkk\tbkk\Pages\Emproyees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Employee.Department.DepartmentID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 87 "C:\Users\Supareak Sangnaul\Desktop\test tbkk\tbkk\tbkk\Pages\Emproyees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.Location));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 90 "C:\Users\Supareak Sangnaul\Desktop\test tbkk\tbkk\tbkk\Pages\Emproyees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Employee.Location.LocationID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 93 "C:\Users\Supareak Sangnaul\Desktop\test tbkk\tbkk\tbkk\Pages\Emproyees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.EmployeeType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 96 "C:\Users\Supareak Sangnaul\Desktop\test tbkk\tbkk\tbkk\Pages\Emproyees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Employee.EmployeeType.EmployeeTypeID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 99 "C:\Users\Supareak Sangnaul\Desktop\test tbkk\tbkk\tbkk\Pages\Emproyees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.Position));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 102 "C:\Users\Supareak Sangnaul\Desktop\test tbkk\tbkk\tbkk\Pages\Emproyees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Employee.Position.PositionID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8302f140000e34a11c4f84478c0c6e8252d7cf1913953", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 107 "C:\Users\Supareak Sangnaul\Desktop\test tbkk\tbkk\tbkk\Pages\Emproyees\Details.cshtml"
                           WriteLiteral(Model.Employee.EmployeeID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8302f140000e34a11c4f84478c0c6e8252d7cf1916118", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<tbkk.Pages.Emproyees.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<tbkk.Pages.Emproyees.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<tbkk.Pages.Emproyees.DetailsModel>)PageContext?.ViewData;
        public tbkk.Pages.Emproyees.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
