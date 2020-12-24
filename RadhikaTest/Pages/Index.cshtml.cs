using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using RadhikaTest.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RadhikaTest.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private TransactionService _svc;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        public IndexModel()
        {
            _svc = new TransactionService();
        }
        public void OnGet(decimal loan)
        {
            try
            {
                var l = _svc.BuildOnGetModel(loan);

                var gv = l.Transactions;
                var chkLIs = l.TransactionTypes;
                
            }
            catch (Exception)
            {

                //show error lable
                //log
            }
           
        }
        public void OnPostFilter()
        {

             //after post
            var l = _svc.BuildOnGetModel(1099.00m);

            var gv = l.Transactions;
            var chkLIs = l.TransactionTypes;

        }
    }
}
