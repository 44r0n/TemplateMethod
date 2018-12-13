namespace TemplateMethod
{
    public class ConcreteClass2 : AbstractClass
    {
        protected override void PrimitiveOperation1()
        {
            System.Console.WriteLine("ConcreteClass2->PrimitiveOperation1 called");
        }

        protected override void PrimitiveOperation2()
        {
            System.Console.WriteLine("ConcreteClass2->PrimitiveOperation2 called");
        }
    }
}