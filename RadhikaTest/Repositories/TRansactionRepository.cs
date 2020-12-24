using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RadhikaTest.Repositories
{
    public class TransactionType
    {
        public int Id { get; set; }
    }
    public class TRansactionRepository
    {
        public List<TransactionDataModel> List(decimal LoanNumber)
        {

            //call sp

            return new List<TransactionDataModel>();
        }

        public List<TransactionDataModel> List(decimal LoanNumber, List<int> transactionTypes)
        {

            //call sp

            return new List<TransactionDataModel>();
        }
        public List<TransactionType> ListTypes()
        {

            //call sp

            return new List<TransactionType>();
        }
    }
}
