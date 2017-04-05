using Starcounter;

namespace KitchenSink
{
    [Database]
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int OrderNo { get; set; }
    }
}
