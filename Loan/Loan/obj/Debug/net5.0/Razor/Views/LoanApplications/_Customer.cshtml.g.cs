#pragma checksum "C:\Personal\Learn\loan\Loan\Loan\Views\LoanApplications\_Customer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "71e1dfc0b11d8eb0ddc2b04b7da84e2fcbdb8dac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LoanApplications__Customer), @"mvc.1.0.view", @"/Views/LoanApplications/_Customer.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71e1dfc0b11d8eb0ddc2b04b7da84e2fcbdb8dac", @"/Views/LoanApplications/_Customer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a17cc41d179f4c6717dddb3330348263a772b4fb", @"/Views/_ViewImports.cshtml")]
    public class Views_LoanApplications__Customer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Loan.Models.CustomerModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Personal\Learn\loan\Loan\Loan\Views\LoanApplications\_Customer.cshtml"
  
    ViewData["Title"] = "Customer";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 9 "C:\Personal\Learn\loan\Loan\Loan\Views\LoanApplications\_Customer.cshtml"
 using (Html.BeginForm("SaveCustomer", "LoanApplications", FormMethod.Post, new { role = "form", id = "saveCustomer" }))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div id=\"Customer\">\r\n        <div class=\"form-horizontal\">\r\n            <h4>Personal Info</h4>\r\n            <hr />\r\n            ");
#nullable restore
#line 15 "C:\Personal\Learn\loan\Loan\Loan\Views\LoanApplications\_Customer.cshtml"
       Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 16 "C:\Personal\Learn\loan\Loan\Loan\Views\LoanApplications\_Customer.cshtml"
       Write(Html.HiddenFor(model => model.CustomerId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 17 "C:\Personal\Learn\loan\Loan\Loan\Views\LoanApplications\_Customer.cshtml"
       Write(Html.HiddenFor(model => model.LoanId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 18 "C:\Personal\Learn\loan\Loan\Loan\Views\LoanApplications\_Customer.cshtml"
       Write(Html.HiddenFor(model => model.BusinessInfoId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 21 "C:\Personal\Learn\loan\Loan\Loan\Views\LoanApplications\_Customer.cshtml"
           Write(Html.LabelFor(model => model.FirstName, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 23 "C:\Personal\Learn\loan\Loan\Loan\Views\LoanApplications\_Customer.cshtml"
               Write(Html.EditorFor(model => model.FirstName, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 24 "C:\Personal\Learn\loan\Loan\Loan\Views\LoanApplications\_Customer.cshtml"
               Write(Html.ValidationMessageFor(model => model.FirstName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 29 "C:\Personal\Learn\loan\Loan\Loan\Views\LoanApplications\_Customer.cshtml"
           Write(Html.LabelFor(model => model.LastName, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 31 "C:\Personal\Learn\loan\Loan\Loan\Views\LoanApplications\_Customer.cshtml"
               Write(Html.EditorFor(model => model.LastName, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 32 "C:\Personal\Learn\loan\Loan\Loan\Views\LoanApplications\_Customer.cshtml"
               Write(Html.ValidationMessageFor(model => model.LastName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 37 "C:\Personal\Learn\loan\Loan\Loan\Views\LoanApplications\_Customer.cshtml"
           Write(Html.LabelFor(model => model.PhoneNumber, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 39 "C:\Personal\Learn\loan\Loan\Loan\Views\LoanApplications\_Customer.cshtml"
               Write(Html.EditorFor(model => model.PhoneNumber, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 40 "C:\Personal\Learn\loan\Loan\Loan\Views\LoanApplications\_Customer.cshtml"
               Write(Html.ValidationMessageFor(model => model.PhoneNumber, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>
            </div>


            <div class=""form-group"">

                <div class=""col-md-offset-2 col-md-10"">
                    <input id=""btnNextCustomer"" type=""submit"" value=""Next"" />
                </div>
            </div>
        </div>
    </div>
");
#nullable restore
#line 53 "C:\Personal\Learn\loan\Loan\Loan\Views\LoanApplications\_Customer.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Loan.Models.CustomerModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
