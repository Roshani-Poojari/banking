using BankingApplication.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BankingApplication.Controllers
{
    public class MakerController : Controller
    {
        // GET: Maker
        public ActionResult Index()
        {
            using(var session = NHibernateHelper.CreateSession())
            {
                return Content("Hello");
            }
        }

        public ActionResult ViewDeposits()
        {
            return View();
        }
        public ActionResult GetAllDeposits(int page, int rows, string sidx, string sord)
        {
            var depositRecords = _makerService.GetAllDeposits();
            var depositRecordList = depositRecords;

            //Get total count of records(for pagination)
            int totalCount = depositRecords.Count();
            //Calculate total pages
            int totalPages = (int)Math.Ceiling((double)totalCount / rows);

            //for sorting 
            switch (sidx)
            {
                case "AccountNumber":
                    depositRecordList = sord == "asc" ? depositRecordList.OrderBy(d => d.Account).ToList()
                        : depositRecordList.OrderByDescending(d => d.Account).ToList();
                    break;
                case "Amount":
                    depositRecordList = sord == "asc" ? depositRecordList.OrderBy(d => d.Amount).ToList()
                        : depositRecordList.OrderByDescending(d => d.Amount).ToList();
                    break;
                case "DepositDateTime":
                    depositRecordList = sord == "asc" ? depositRecordList.OrderBy(d => d.DepositDateTime).ToList()
                        : depositRecordList.OrderByDescending(d => d.DepositDateTime).ToList();
                    break;
                case "DepositStatus":
                    depositRecordList = sord == "asc" ? depositRecordList.OrderBy(d => d.DepositStatus).ToList()
                        : depositRecordList.OrderByDescending(d => d.DepositStatus).ToList();
                    break;
                case "TransactionReferenceNumber":
                    depositRecordList = sord == "asc" ? depositRecordList.OrderBy(d => d.TransactionReferenceNumber).ToList()
                        : depositRecordList.OrderByDescending(d => d.TransactionReferenceNumber).ToList();
                    break;
                case "UTRNumber":
                    depositRecordList = sord == "asc" ? depositRecordList.OrderBy(d => d.UTRNumber).ToList()
                        : depositRecordList.OrderByDescending(d => d.UTRNumber).ToList();
                    break;
                case "ApprovedOn":
                    depositRecordList = sord == "asc" ? depositRecordList.OrderBy(d => d.ApprovedOn).ToList()
                        : depositRecordList.OrderByDescending(d => d.ApprovedOn).ToList();
                    break;
                case "CreatedOn":
                    depositRecordList = sord == "asc" ? depositRecordList.OrderBy(d => d.CreatedOn).ToList()
                        : depositRecordList.OrderByDescending(d => d.CreatedOn).ToList();
                    break;
                case "ModifiedOn":
                    depositRecordList = sord == "asc" ? depositRecordList.OrderBy(d => d.ModifiedOn).ToList()
                        : depositRecordList.OrderByDescending(d => d.ModifiedOn).ToList();
                    break;
            }
            var jsonData = new
            {
                total = totalPages,
                page,
                records = totalCount,
                rows = depositRecordList.Select(cd => new
                {
                    cell = new string[]
                    {
                        cd.Id.ToString(),
                        cd.Name,
                        cd.Email,
                        cd.AccountNumber.ToString(),
                        cd.Balance.ToString(),
                        cd.IFSC,
                        cd.Branch
                    }
                })
                .Skip((page - 1) * rows).Take(rows).ToArray()
            };
            return Json(jsonData, JsonRequestBehavior.AllowGet);
        }
    }
}