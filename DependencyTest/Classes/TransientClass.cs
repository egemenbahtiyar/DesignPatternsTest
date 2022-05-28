using DependencyTest.Interfaces;

namespace DependencyTest.Classes
{
    public class TransientClass : IDeneme1
    {
        public string IChildInterfaceFunction()
        {
            return "Transient Class was worked.(ChildInterfaceFunction)";
        }
        public string Deneme1Function()
        {
            return "Transient Class 1 was worked.";
        }

        public string Deneme2Function()
        {
            return "Transient Class 2 was worked.";
        }
    }
}
