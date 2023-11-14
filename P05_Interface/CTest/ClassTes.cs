

using P05_Interface.ITast;

namespace P05_Interface.CTest
{
    public class ClassTest : InterfaceTest

    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ClassTest()
        {
            Input();
        }

        public void Display()
        {
            Console.WriteLine($"{Id} {Name}");
        }

        public void Input()
        {
            Id = 1;
            Name = "test";
        }


    }
}
