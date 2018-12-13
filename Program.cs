using System;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractClass abstractClass = new ConcreteClass1();
            abstractClass.TemplateMethod();
            abstractClass = new ConcreteClass2();
            abstractClass.TemplateMethod();

        }
    }
}
