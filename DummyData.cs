using Starcounter;

namespace KitchenSink
{
    public static class DummyData
    {
        public static void Create()
        {
            Db.Transact(() =>
            {
                // For Dropdown page
                if (Db.SQL("SELECT p FROM KitchenSink.SoftwareProduct p").First == null)
                {
                    new SoftwareProduct { Name = "Starcounter Database" };
                    new SoftwareProduct { Name = "Polymer JavaScript library" };
                }

                // For Pagination page
                if (Db.SQL<Book>("SELECT b FROM KitchenSink.Book b").First == null)
                {
                    // change the number of element with adjusting elementsInTotal
                    int elementsInTotal = 100;
                    for (int i = 0; i < elementsInTotal; i++)
                    {
                        var book = new Book
                        {
                            Author = "Arbitrary Author",
                            Title = "Arbitrary Book " + (i + 1),
                            Position = i + 1
                        };
                    }
                }

                // For Breadcrumb page
                if (BreadcrumbTestData.Exists())
                {
                    BreadcrumbTestData.DeleteAll();
                }
                BreadcrumbTestData.Create();

                // For Autocomplete page
                if (Db.SQL("SELECT p FROM KitchenSink.GroceryProduct p").First == null)
                {
                    new GroceryProduct { Name = "Bread", Price = 1 };
                    new GroceryProduct { Name = "Butter", Price = 3 };
                    new GroceryProduct { Name = "Scotch Whisky", Price = 4 };
                    new GroceryProduct { Name = "Irish Whiskey", Price = 2 };
                    new GroceryProduct { Name = "Milk", Price = 5 };
                    new GroceryProduct { Name = "Boiled Mutton", Price = 7 };
                }

                if(Db.SQL("SELECT p FROM KitchenSink.Person p ").First == null)
                {
                    new Person { FirstName = "Lucille", LastName = "Daugherty", OrderNo = 0 };
                    new Person { FirstName = "Naomi", LastName = "Delacruz", OrderNo = 1 };
                    new Person { FirstName = "Nicholas", LastName = "Hettinger", OrderNo = 2 };
                    new Person { FirstName = "Kevin", LastName = "Liggins", OrderNo = 3 };
                    new Person { FirstName = "Mathew", LastName = "Quiroga", OrderNo = 4 };
                    new Person { FirstName = "Vance", LastName = "Whipkey", OrderNo = 5 };
                    new Person { FirstName = "Allene", LastName = "Wong", OrderNo = 6 };
                }
            });
        }
    }
}