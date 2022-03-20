using BusinessModels;
using Loan.App_Code;
using Loan.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using static Loan.App_Code.Utilities;
using X.PagedList;

namespace Loan.Controllers
{
    public class LoanApplicationsController : Controller
    {
       
        LoanHttpClient _loanHttpClient;
        public  LoanApplicationsController()
        {
            _loanHttpClient = new LoanHttpClient();
        }

        public ActionResult Index(int page = 1, string searchBySelected = null, string searchString=null)
        {
            // return a 404 if user browses to before the first page
            if (page < 1)
                return null;

            
            ViewBag.SearchString = searchString;
            ViewBag.SearchBySelected = searchBySelected;

         
            string url = "";
            if (!string.IsNullOrEmpty(ViewBag.SearchBySelected) && !string.IsNullOrWhiteSpace(ViewBag.SearchString))
            {
                EnumTableName table = Utilities.GetTableName(ViewBag.SearchBySelected);
                url = "/" + table.ToString() + "/" + ViewBag.SearchBySelected + "/" + ViewBag.SearchString;
            }

            var modelList = _loanHttpClient.GetList<BusinessModels.Loan>("Loans" + url);
            var models = Mapper.Map(modelList);

           
            X.PagedList.IPagedList<LoanApplicationsModel> pagedModel =null;

            if(string.IsNullOrWhiteSpace(searchString))
                pagedModel = models.AsQueryable().ToPagedList(page, Utilities.PAGE_SIZE);
            else
                pagedModel = models.AsQueryable().ToPagedList();

            ViewBag.SearchBy = Utilities.GetSearchBy();
            ViewBag.PageList = pagedModel;
            return View(pagedModel);
        }

        protected IPagedList<string> GetPagedNames(int? page)
        {
            // return a 404 if user browses to before the first page
            if (page.HasValue && page < 1)
                return null;

            // retrieve list from database/wherever
            var listUnpaged = new List<string> { "a", "b", "c", "d", "e", "aa", "bb", "cc", "dd", "ee", "aaa", "bbb", "ccc", "ddd", "eee", "fff", "ggg", "1", "s", "f", "sd", "dsfds" };

            // page the list
            const int pageSize = 10;
            var listPaged = listUnpaged.ToPagedList(page ?? 1, pageSize);

            // return a 404 if user browses to pages beyond last page. special case first page if no items exist
            if (listPaged.PageNumber != 1 && page.HasValue && page > listPaged.PageCount)
                return null;


            return listPaged;
        }

        // GET: LoanApplicationsController/Details/5
        public ActionResult Details(int id)
        {
            var model = _loanHttpClient.Get<BusinessModels.Loan>("Loans/" + id);
            var m = Mapper.MapLoan(model);
            return View(m);
        }

        // GET: LoanApplicationsController/Create
        public ActionResult Create()
        {
            SetDisplayView(true, false, false);
           
            var loan = new LoanModel();
            loan.EditAction = Utilities.EditAction.new_record;
            return View("Create", loan);
        }

        // POST: LoanApplicationsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LoanApplicationsController/Edit/5
        public ActionResult Edit(int loanId)
        {
            var model = _loanHttpClient.Get<BusinessModels.Loan>("Loans/"+ loanId);
            var m = Mapper.MapLoan(model);
            m.EditAction = Utilities.EditAction.edit_record;

            SetDisplayView(true, false, false);

            return View("Create", m);
        }

        public ActionResult EditLoan(LoanModel loan)
        {
            SetDisplayView(loan.IsCustomerViewVisible, loan.IsBusinessViewVisible, loan.IsLoanViewVisible);
            var loanModel = GetLoan(loan.LoanId, loan.BusinessInfoId, loan.CustomerId, null, null);
            return View("Create", loanModel);
        }


        // POST: LoanApplicationsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }      
      


        // GET: LoanApplicationsController/Delete/5     
     
        public ActionResult Delete(int id)
        {
            try
            {
                _loanHttpClient.Remove<BusinessModels.Loan>("Loans/" + id, out string errorMessage);
            }
            catch (Exception ex)
            {
                //Log the error (uncomment dex variable name and add a line here to write a log.
                return RedirectToAction("Delete", new { id = id, saveChangesError = true });
            }
            return RedirectToAction("Index");
        }

        // POST: LoanApplicationsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

       

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SaveLoan(LoanModel model, string loanNextBack)
        {
            try
            {
                if (!ValidateLoan(model, out string message))
                {
                    SetDisplayView(false, false, true);
                    ViewBag.ErrorMessage = message;
                    return View("Create", model);
                }

                LoanModel loanModel = null;
                model.IsDraft = loanNextBack == Utilities.NextBack.back.ToString();

                if (model.LoanId > 0)
                {
                    _loanHttpClient.Put<BusinessModels.Loan>("Loans/", model.LoanId, Mapper.MapLoan(model));
                    loanModel = model;
                }
                else
                {
                    var l = _loanHttpClient.Post<BusinessModels.Loan>("Loans/", Mapper.MapLoan(model));
                    loanModel = Mapper.MapLoan(l);
                }

                if (loanNextBack == NextBack.back.ToString())
                {
                 
                    return RedirectToAction("EditLoan", new LoanModel { IsBusinessViewVisible = true, LoanId = loanModel.LoanId, BusinessInfoId = loanModel.BusinessInfoId, CustomerId = loanModel.CustomerId });
                }
                else
                {
                    return RedirectToAction("Index");
                }
            }
            catch(Exception e)
            {
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SaveCustomer(CustomerModel model)
        {  
            if (!ValidateCustomer(model, out string message))
            {
                SetDisplayView(true, false, false);
                ViewBag.ErrorMessage = message;
                return View("Create", model);
            }

            SetDisplayView(false, true, false);

            LoanModel loanModel = null;
            if (model.CustomerId > 0)
            {
                //update customer
                _loanHttpClient.Put<BusinessModels.Customer>("Customers/", model.CustomerId, Mapper.Map(model));
                //get all loan records
                loanModel = GetLoan(model.LoanId, model.BusinessInfoId, model.CustomerId, null, model);

                return View("Create", loanModel);
            }
            else
            {
              var customer =  _loanHttpClient.Post<BusinessModels.Customer>("Customers/", Mapper.Map(model));

              return RedirectToAction("EditLoan", new LoanModel {IsBusinessViewVisible = true, LoanId = model.LoanId, BusinessInfoId = model.BusinessInfoId, CustomerId = customer.CustomerId });
            }
           
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SaveBusinessInfo(BusinessInfoModel model, string businessInfoNextBack)
        {
            try
            {
                if (!ValidateBusinessInfo(model, out string message))
                {
                    SetDisplayView(false, true, false);
                    ViewBag.ErrorMessage = message;
                    return View("Create", model);
                }

                LoanModel loanModel = null;

                SetDisplayView(businessInfoNextBack == Utilities.NextBack.back.ToString(), false, businessInfoNextBack == Utilities.NextBack.next.ToString());

                if (model.BusinessInfoId > 0)
                {
                    _loanHttpClient.Put<BusinessModels.BusinessInfo>("BusinessInfoes/", model.BusinessInfoId, Mapper.Map(model));
                    loanModel = GetLoan(model.LoanId, model.BusinessInfoId, model.CustomerId, model,null);
                    return View("Create", loanModel);
                }
                else
                {
                    var b = _loanHttpClient.Post<BusinessModels.BusinessInfo>("BusinessInfoes/", Mapper.Map(model));                  

                    return RedirectToAction("EditLoan",
                        new LoanModel { 
                            IsCustomerViewVisible = businessInfoNextBack == Utilities.NextBack.back.ToString(), 
                            IsLoanViewVisible = businessInfoNextBack == Utilities.NextBack.next.ToString(), LoanId = model.LoanId, 
                            BusinessInfoId = b.BusinessInfoId, 
                            CustomerId = model.CustomerId });

                }

            }
            catch (Exception e)
            {
                return View();
            }
        }

        private LoanModel GetLoan(int loanId, int businessInfoId, int customerId, BusinessInfoModel bModel=null, CustomerModel cModel=null)
        {
            LoanModel loanModel = null;

            //get loan if needed
            if(loanId > 0)
            {
                var loan = _loanHttpClient.Get<BusinessModels.Loan>("Loans/" + loanId);
                loanModel = Mapper.MapLoan(loan);
            }
            else
            {
                loanModel = new LoanModel();
            }
            

            //get business info if needed
            if(bModel != null && bModel.BusinessInfoId > 0)
            {
                loanModel.BusinessInfo = bModel;
                loanModel.BusinessInfoId = bModel.BusinessInfoId;
            }
            else if(loanModel.BusinessInfoId != businessInfoId && businessInfoId > 0)
            {
                var b = _loanHttpClient.Get<BusinessModels.BusinessInfo>("BusinessInfoes/" + businessInfoId);
                loanModel.BusinessInfo = Mapper.Map(b);
                loanModel.BusinessInfoId  = businessInfoId;
            }


            //get customer info if needed
            if (cModel != null && cModel.CustomerId > 0)
            {
                loanModel.Customer = cModel;
                loanModel.CustomerId = cModel.CustomerId;
            }
            else  if (loanModel.CustomerId != customerId && customerId > 0)
            {
                var c = _loanHttpClient.Get<BusinessModels.Customer>("Customers/" + customerId);
                loanModel.Customer = Mapper.Map(c);
                loanModel.CustomerId = customerId;
            }

            return loanModel;
        }

        private void SetDisplayView(bool isCustomerVisible, bool isBusinessVisible, bool isLoanVisible)
        {
            ViewBag.DisplayCustomer = isCustomerVisible ? "box" : "none";
            ViewBag.DisplayBusinessInfo = isBusinessVisible?"box" : "none";
            ViewBag.DisplayLoan = isLoanVisible?"box":"none";
        }

        private bool ValidateLoan(LoanModel l, out string message)
        {
            message = "";
            if (l.PaybackMonths < 1)
            {
                message = "Payback months is incorrect";
                return false;
            }
            return true;
        }

        private bool ValidateCustomer(CustomerModel m, out string message)
        {
            message = "";
            if (string.IsNullOrWhiteSpace(m.FirstName ))
            {
                message = "First Name is incorrect";
                return false;
            }

            if (string.IsNullOrWhiteSpace(m.LastName))
            {
                message = "Last Name is incorrect";
                return false;
            }
            return true;
        }

        private bool ValidateBusinessInfo(BusinessInfoModel m, out string message)
        {
            message = "";
            if (string.IsNullOrWhiteSpace(m.BusinessName))
            {
                message = "Business Name is incorrect";
                return false;
            }

            return true;
        }

    }
}
