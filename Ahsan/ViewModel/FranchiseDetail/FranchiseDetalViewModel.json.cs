using Starcounter;
using Starcounter.Templates;

namespace Ahsan
{
    partial class FranchiseDetalViewModel : JsonViewModel
    {

        #region Properties

        public Franchise franchise { get; set; }
        public FranchiseTransaction transaction { get; set; }

        #endregion

        #region Actions
        void Handle(Input.SaveFranchise action)
        {
            Transaction.Commit();
        }
        void Handle(Input.SaveTransaction action)
        {
            Transaction.Commit();
            AddTransaction(this.transaction);
            transaction = new FranchiseTransaction() { Franchise = this.franchise };
        }
        #endregion

        #region Methods
        public void PopulateTransactionList()
        {
            QueryResultRows<FranchiseTransaction> list = Db.SQL<FranchiseTransaction>("SELECT t FROM FranchiseTransaction t WHERE t.Franchise = ?", franchise);

            foreach (var trans in list)
                AddTransaction(trans);

        }

        public void AddTransaction(FranchiseTransaction transaction)
        {
            TransactionList.Add(new TransactionDetailViewModel() { Data = transaction });
        }
        #endregion

    }
}
