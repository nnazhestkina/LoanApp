#pragma checksum "C:\Personal\Learn\loan\Loan\Loan\Views\LoanApplications\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "368b355fd899146414d7629dcae171a627d931f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LoanApplications_Index), @"mvc.1.0.view", @"/Views/LoanApplications/Index.cshtml")]
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
#line 1 "C:\Personal\Learn\loan\Loan\Loan\Views\_ViewImports.cshtml"
using Loan;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Personal\Learn\loan\Loan\Loan\Views\_ViewImports.cshtml"
using Loan.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Personal\Learn\loan\Loan\Loan\Views\LoanApplications\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"368b355fd899146414d7629dcae171a627d931f4", @"/Views/LoanApplications/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a17cc41d179f4c6717dddb3330348263a772b4fb", @"/Views/_ViewImports.cshtml")]
    public class Views_LoanApplications_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<X.PagedList.IPagedList<Loan.Models.LoanApplicationsModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/PagedList.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "368b355fd899146414d7629dcae171a627d931f44322", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 5 "C:\Personal\Learn\loan\Loan\Loan\Views\LoanApplications\Index.cshtml"
  
    ViewBag.Title = "Loan Applications";
    var pagedList = (X.PagedList.IPagedList)ViewBag.PageList;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Loan Applications</h2>\r\n\r\n<p>\r\n    ");
#nullable restore
#line 13 "C:\Personal\Learn\loan\Loan\Loan\Views\LoanApplications\Index.cshtml"
Write(Html.ActionLink("Create New", "Create"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n");
#nullable restore
#line 15 "C:\Personal\Learn\loan\Loan\Loan\Views\LoanApplications\Index.cshtml"
 using (Html.BeginForm("Index", "LoanApplications", FormMethod.Get, new { id = "formLoan" }))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\r\n        Search by:\r\n\r\n\r\n        ");
#nullable restore
#line 21 "C:\Personal\Learn\loan\Loan\Loan\Views\LoanApplications\Index.cshtml"
   Write(Html.DropDownList("SearchBySelected", new SelectList(ViewBag.SearchBy, "Key", "Value"), ViewBag.SearchBySelected as string));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 22 "C:\Personal\Learn\loan\Loan\Loan\Views\LoanApplications\Index.cshtml"
   Write(Html.TextBox("SearchString", ViewBag.SearchString as string));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        <input type=\"submit\" value=\"Search\" />\r\n    </p>\r\n");
#nullable restore
#line 26 "C:\Personal\Learn\loan\Loan\Loan\Views\LoanApplications\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<table class=""table"">
    <tr>
        <th>
            Name
        </th>
        <th>
            Phone
        </th>
        <th>
            Business Name
        </th>
        <th>
            Ammount Requested
        </th>
        <th>
            APR
        </th>
        <th></th>
    </tr>


");
#nullable restore
#line 50 "C:\Personal\Learn\loan\Loan\Loan\Views\LoanApplications\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 54 "C:\Personal\Learn\loan\Loan\Loan\Views\LoanApplications\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 57 "C:\Personal\Learn\loan\Loan\Loan\Views\LoanApplications\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 60 "C:\Personal\Learn\loan\Loan\Loan\Views\LoanApplications\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.BusinessName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 63 "C:\Personal\Learn\loan\Loan\Loan\Views\LoanApplications\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.LoanAmmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 66 "C:\Personal\Learn\loan\Loan\Loan\Views\LoanApplications\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.APR));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 69 "C:\Personal\Learn\loan\Loan\Loan\Views\LoanApplications\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { loanId = item.ID, customerId = item.CustomerId, businessId = item.BusinessInfoId }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 70 "C:\Personal\Learn\loan\Loan\Loan\Views\LoanApplications\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { id = item.ID }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n\r\n                <a");
            BeginWriteAttribute("onclick", " onclick=\'", 1904, "\'", 1937, 3);
            WriteAttributeValue("", 1914, "ConfirmDelete(", 1914, 14, true);
#nullable restore
#line 72 "C:\Personal\Learn\loan\Loan\Loan\Views\LoanApplications\Index.cshtml"
WriteAttributeValue("", 1928, item.ID, 1928, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1936, ")", 1936, 1, true);
            EndWriteAttribute();
            WriteLiteral(" href=\"#\">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 75 "C:\Personal\Learn\loan\Loan\Loan\Views\LoanApplications\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>\r\n<br />\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 84 "C:\Personal\Learn\loan\Loan\Loan\Views\LoanApplications\Index.cshtml"
Write(Html.PagedListPager(pagedList, page => Url.Action("Index", new { page })));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"

    <script>

        function ConfirmDelete(id) {

            var result = confirm(""Do you want to delete?"");
            if (result) {
                $.ajax({
                    url: 'LoanApplications/Delete',
                    data: { id: id }
                }).done(function () {
                    location.reload();
                });
            }
        }

    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<X.PagedList.IPagedList<Loan.Models.LoanApplicationsModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591