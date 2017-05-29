using Starcounter;
using System;

namespace Ahsan
{
    enum SortType
    {
        NumberOfHomes, TotalCommission, AverageCommission, Trend
    }
    partial class CorporationViewModel : JsonViewModel
    {

        #region Properties
        public string FranchiseNameToAdd;
        #endregion

        #region Override
        protected override void OnData()
        {
            base.OnData();
            PopulateFranchiseList();
        }

        #endregion

        #region Action
        void Handle(Input.AddFranchise action)
        {
            var obj = new Franchise
            {
                Name = FranchiseNameToAdd,
                Corporation = (Corporation)this.Data,
                Trend = 0
            };
            Transaction.Commit();
            AddFranchiseVM(obj);
        }

        void Handle(Input.SortOnNumberOfHomes action)
        {
            SortFranchiseList(SortType.NumberOfHomes);
        }

        void Handle(Input.SortOnTotalComission action)
        {
            SortFranchiseList(SortType.TotalCommission);

        }

        void Handle(Input.SortOnAverageComission action)
        {
            SortFranchiseList(SortType.AverageCommission);

        }
        void Handle(Input.SortOnTrend action)
        {
            SortFranchiseList(SortType.Trend);

        }

        #endregion

        #region Methods
        void PopulateFranchiseList()
        {
            try
            {
                if (Data != null)
                {
                    QueryResultRows<Franchise> FranchiseLists = Db.SQL<Franchise>("SELECT f FROM Franchise f WHERE f.Corporation = ?", Data);
                    foreach (var franchise in FranchiseLists)
                    {
                        AddFranchiseVM(franchise);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

        }

        void SortFranchiseList(SortType type)
        {
            try
            {
                if (Data != null)
                {
                    string TypeString = "";
                    switch (type)
                    {
                        case SortType.NumberOfHomes:
                            TypeString = "NumberOfHomesSold";
                            break;
                        case SortType.TotalCommission:
                            TypeString = "TotalCommission";
                            break;
                        case SortType.AverageCommission:
                            TypeString = "AverageCommision";
                            break;
                        case SortType.Trend:
                            TypeString = "Trend";
                            break;
                    }

                    string QueryString = string.Format("SELECT f FROM Franchise f WHERE f.Corporation = ? ORDER BY f.{0}", TypeString);
                    FranchiseList.Clear();
                    QueryResultRows<Franchise> FranchiseLists = Db.SQL<Franchise>(QueryString, Data);
                    foreach (var franchise in FranchiseLists)
                    {
                        AddFranchiseVM(franchise);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public void AddFranchiseVM(Franchise franchise)
        {
            FranchiseList.Add(new FranchiseViewModel() { Data = franchise });
        }
        #endregion
    }
}
