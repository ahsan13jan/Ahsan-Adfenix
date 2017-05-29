using Starcounter;
using System;
using System.Collections.Generic;

namespace Ahsan
{
    partial class MainViewModel : JsonViewModel
    {
        #region Properties
        public string CoporationNameToAdd;
        #endregion

        #region Actions
        void Handle(Input.CreateCorporation action)
        {

            var Corporation = new Corporation
            {
                Name = CoporationNameToAdd
            };
            Transaction.Commit();
            AddCorporationVM(Corporation);
        }

        public void AddCorporationVM(Corporation corporation)
        {
            CorporationList.Add(new CorporationViewModel() { Data = corporation });
        }
        #endregion

        #region Methods
        public void setView()
        {
            try
            {
                var corporationList = Db.SQL<Corporation>("SELECT c from Corporation c");
                foreach (var corp in corporationList)
                {
                    CorporationList.Add(new CorporationViewModel() { Data = corp });
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        #endregion

    }
}
