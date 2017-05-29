using Starcounter;

namespace Ahsan
{
    partial class FranchiseViewModel : JsonViewModel
    {
        public string ObjectId { get; set; }
        protected override void OnData()
        {
            base.OnData();
            ObjectId = Data.GetObjectID();
        }
    }
}
