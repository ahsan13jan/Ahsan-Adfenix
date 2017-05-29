using System;
using Starcounter;

namespace Ahsan
{
    class Program
    {
        static void Main()
        {
            SetMiddleWare();

            // CREATE CORPORATION

            Handle.GET("/Ahsan/MainView", () =>
            {
                return Db.Scope(() =>
                {
                    var ViewModel = new MainViewModel();
                    ViewModel.setView();
                    SetSession(ViewModel);
                    return ViewModel;
                });
            });

            // FRANCHISE DETAIL

            Handle.GET("/FranchiseDetail/{?}", (string id) =>
            {
                return Db.Scope(() =>
                {
                    var franchise = (Franchise)GetObjectById(id);
                    var ViewModel = new FranchiseDetalViewModel() { franchise = franchise };
                    ViewModel.PopulateTransactionList();
                    ViewModel.transaction = new FranchiseTransaction() { Franchise = franchise };
                    SetSession(ViewModel);
                    return ViewModel;
                });
            });


        }

        static IObjectView GetObjectById(string Id)
        {
            return DbHelper.FromID(DbHelper.Base64DecodeObjectID(Id));
        }
        static void SetMiddleWare()
        {
            Application.Current.Use(new HtmlFromJsonProvider());
            Application.Current.Use(new PartialToStandaloneHtmlProvider());
        }
        static void SetSession(JsonViewModel ViewModel)
        {
            if (Session.Current == null)
            {
                Session.Current = new Session(SessionOptions.PatchVersioning);

            };
            ViewModel.Session = Session.Current;

        }
    }
}