using Starcounter;
using System.Linq;

namespace KitchenSink
{
    partial class SortableListPage : Json
    {
        [SortableListPage_json.People]
        partial class SortableListPagePeople : Json
        {
            public SortableListPage ParentPage => this.Parent.Parent as SortableListPage;
            public string FullName => $"{FirstName} {LastName}";
            public bool OrderUpButtonDisabled => this.OrderNo == 0;
            public bool OrderDownButtonDisabled => this.OrderNo == this.ParentPage.People.Count - 1;

            void Handle(Input.OrderDownTrigger down)
            {
                if (OrderDownButtonDisabled) throw new System.Exception("Unable to change order.");

                var personUpper = Db.SQL("SELECT p FROM KitchenSink.Person p WHERE p.OrderNo = ? ", this.OrderNo + 1).First as Person;
                personUpper.OrderNo--;

                (Data as Person).OrderNo++;

                ParentPage.OnData();
            }

            void Handle(Input.OrderUpTrigger up)
            {
                if (OrderUpButtonDisabled) throw new System.Exception("Unable to change order.");

                Db.Transact(() =>
                {
                    var personUpper = Db.SQL("SELECT p FROM KitchenSink.Person p WHERE p.OrderNo = ? ", this.OrderNo-1).First as Person;
                    personUpper.OrderNo++;

                    (Data as Person).OrderNo--;
                });

                ParentPage.OnData();
            }
        }

        protected override void OnData()
        {
            base.OnData();

            People.Clear();

            Db.SQL<Person>("SELECT p FROM Person p ORDER BY p.OrderNo ASC")
                .ToList()
                .Select(p => new SortableListPagePeople() { Data = p })
                .ToList()
                .ForEach(p => this.People.Add(p));
        }

    }
}
