using RadhikaTest.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RadhikaTest.Services
{


    public class TransactionModel
    {
        public int Id { get; set; }
        public string EmployeeName { get; set; }

    }
    public class TransactionTypeModel
    {
        public int Id { get; set; }
        public string TypeName { get; set; }

    }
    public class TransactionGetViewModel
    {
        public List<TransactionModel> Transactions { get; set; }
        public List<TransactionTypeModel> TransactionTypes { get; set; }
        public decimal LoanNumber { get; set; }
        public int EMployeeId { get; set; }
        public int RoleId { get; set; }

    }

    public class TransactionService
    {
        private TRansactionRepository _repo;

        public TransactionService()
        {
            _repo = new TRansactionRepository();
        }


        public TransactionGetViewModel BuildOnGetModel(decimal loanNumber, List<int> filterTransactoinTypes =null)
        {
            //db calls


            var transactonList =filterTransactoinTypes==null? _repo.List(loanNumber):_repo.List(loanNumber, filterTransactoinTypes);

                        //business logic


            //Model conversion

            var retModel = new TransactionGetViewModel();
            var tranReeturnList = new List<TransactionModel>();
            foreach (var tr in transactonList)
            {
                tranReeturnList.Add(new TransactionModel
                {
                    EmployeeName = tr.EmployeeId.ToString(),
                    Id = tr.Id

                });
            }

            retModel.Transactions = tranReeturnList;
            retModel.TransactionTypes = Typeslist();
            return retModel;



        }

        public List<TransactionTypeModel> Typeslist()
        {
            var tranTypes = _repo.ListTypes();
            var typesRepurnList = new List<TransactionTypeModel>();
            foreach (var item in tranTypes)
            {
                typesRepurnList.Add(new TransactionTypeModel() { Id = item.Id, TypeName = "sdfsdfs" });
            }
            return typesRepurnList;
        }

    }


}
