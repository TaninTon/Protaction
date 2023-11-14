
using P05_Interface.ITast;

namespace P05_Interface.CTest
{
    internal class TestData : InterfaceTest
    {
        public int Id { get ; set ; }
        public string Name { get ; set ; }

        public void Input()
        {
            Console.WriteLine($"you id is " + Id);
            Console.WriteLine($"You Name Is " + Name);
        }

        public void Display()
        {
            Id = 2;
            Name = "foo";
        }
    }
}
