#pragma checksum "C:\Personal\Learn\loan\Loan\Loan\Views\LoanApplications\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e7e3a80831d8b4bd00026b590a320c91ab0c949"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LoanApplications_Details), @"mvc.1.0.view", @"/Views/LoanApplications/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e7e3a80831d8b4bd00026b590a320c91ab0c949", @"/Views/LoanApplications/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a17cc41d179f4c6717dddb3330348263a772b4fb", @"/Views/_ViewImports.cshtml")]
    public class Views_LoanApplications_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Loan.Models.LoanModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Personal\Learn\loan\Loan\Loan\Views\LoanApplications\Details.cshtml"
  
    ViewData["Title"] = "Loan Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Loan Application Details</h2>\r\n<hr />\r\n");
#nullable restore
#line 9 "C:\Personal\Learn\loan\Loan\Loan\Views\LoanApplications\Details.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Personal\Learn\loan\Loan\Loan\Views\LoanApplications\Details.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div id=\"BusinessInfo\">\r\n        <div class=\"form-horizontal\">\r\n            <h4>Personal Info</h4>\r\n            <hr />\r\n\r\n\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 20 "C:\Personal\Learn\loan\Loan\Loan\Views\LoanApplications\Details.cshtml"
           Write(Html.LabelFor(model => model.Customer.FirstName, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <span>");
#nullable restore
#line 21 "C:\Personal\Learn\loan\Loan\Loan\Views\LoanApplications\Details.cshtml"
                 Write(Model.Customer.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                <br />\r\n                ");
#nullable restore
#line 23 "C:\Personal\Learn\loan\Loan\Loan\Views\LoanApplications\Details.cshtml"
           Write(Html.LabelFor(model => model.Customer.LastName, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <span>");
#nullable restore
#line 24 "C:\Personal\Learn\loan\Loan\Loan\Views\LoanApplications\Details.cshtml"
                 Write(Model.Customer.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> <br />\r\n\r\n                ");
#nullable restore
#line 26 "C:\Personal\Learn\loan\Loan\Loan\Views\LoanApplications\Details.cshtml"
           Write(Html.LabelFor(model => model.Customer.PhoneNumber, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <span>");
#nullable restore
#line 27 "C:\Personal\Learn\loan\Loan\Loan\Views\LoanApplications\Details.cshtml"
                 Write(Model.Customer.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> <br />\r\n\r\n\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n");
            WriteLiteral("    <div id=\"BusinessInfo\">\r\n        <div class=\"form-horizontal\">\r\n            <h4>Business Info</h4>\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 39 "C:\Personal\Learn\loan\Loan\Loan\Views\LoanApplications\Details.cshtml"
           Write(Html.LabelFor(model => model.BusinessInfo.BusinessName, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <span>");
#nullable restore
#line 40 "C:\Personal\Learn\loan\Loan\Loan\Views\LoanApplications\Details.cshtml"
                 Write(Model.BusinessInfo.BusinessName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><br />\r\n                ");
#nullable restore
#line 41 "C:\Personal\Learn\loan\Loan\Loan\Views\LoanApplications\Details.cshtml"
           Write(Html.LabelFor(model => model.BusinessInfo.BusinessPhoneNumber, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <span>");
#nullable restore
#line 42 "C:\Personal\Learn\loan\Loan\Loan\Views\LoanApplications\Details.cshtml"
                 Write(Model.BusinessInfo.BusinessPhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><br />\r\n                ");
#nullable restore
#line 43 "C:\Personal\Learn\loan\Loan\Loan\Views\LoanApplications\Details.cshtml"
           Write(Html.LabelFor(model => model.BusinessInfo.Address, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <span>");
#nullable restore
#line 44 "C:\Personal\Learn\loan\Loan\Loan\Views\LoanApplications\Details.cshtml"
                 Write(Model.BusinessInfo.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><br />\r\n                ");
#nullable restore
#line 45 "C:\Personal\Learn\loan\Loan\Loan\Views\LoanApplications\Details.cshtml"
           Write(Html.LabelFor(model => model.BusinessInfo.City, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <span>");
#nullable restore
#line 46 "C:\Personal\Learn\loan\Loan\Loan\Views\LoanApplications\Details.cshtml"
                 Write(Model.BusinessInfo.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><br />\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            WriteLiteral("    <div id=\"LoanApplication\">\r\n        <div class=\"form-horizontal\">\r\n            <h4>Loan Application</h4>\r\n            <hr />\r\n\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 58 "C:\Personal\Learn\loan\Loan\Loan\Views\LoanApplications\Details.cshtml"
           Write(Html.LabelFor(model => model.NumberOfDefaults, htmlAttributes: new { @class = "control-label col-md-3" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <span>");
#nullable restore
#line 59 "C:\Personal\Learn\loan\Loan\Loan\Views\LoanApplications\Details.cshtml"
                 Write(Model.NumberOfDefaults);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><br />\r\n                ");
#nullable restore
#line 60 "C:\Personal\Learn\loan\Loan\Loan\Views\LoanApplications\Details.cshtml"
           Write(Html.LabelFor(model => model.PaybackMonths, htmlAttributes: new { @class = "control-label col-md-3" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <span>");
#nullable restore
#line 61 "C:\Personal\Learn\loan\Loan\Loan\Views\LoanApplications\Details.cshtml"
                 Write(Model.PaybackMonths);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><br />\r\n                ");
#nullable restore
#line 62 "C:\Personal\Learn\loan\Loan\Loan\Views\LoanApplications\Details.cshtml"
           Write(Html.LabelFor(model => model.RiskRating, htmlAttributes: new { @class = "control-label col-md-3" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <span>");
#nullable restore
#line 63 "C:\Personal\Learn\loan\Loan\Loan\Views\LoanApplications\Details.cshtml"
                 Write(Model.RiskRating);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><br />\r\n                ");
#nullable restore
#line 64 "C:\Personal\Learn\loan\Loan\Loan\Views\LoanApplications\Details.cshtml"
           Write(Html.LabelFor(model => model.TotalOutstandingDebt, htmlAttributes: new { @class = "control-label col-md-3" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <span>");
#nullable restore
#line 65 "C:\Personal\Learn\loan\Loan\Loan\Views\LoanApplications\Details.cshtml"
                 Write(Model.TotalOutstandingDebt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 70 "C:\Personal\Learn\loan\Loan\Loan\Views\LoanApplications\Details.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    ");
#nullable restore
#line 73 "C:\Personal\Learn\loan\Loan\Loan\Views\LoanApplications\Details.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Loan.Models.LoanModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
