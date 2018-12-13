namespace TemplateMethod
{
    public class ConcreteClass1 : AbstractClass
    {
        protected override void PrimitiveOperation1()
        {
            System.Console.WriteLine("ConcreteClass1->PrimitiveOperation1 called");
        }

        protected override void PrimitiveOperation2()
        {
            System.Console.WriteLine("ConcreteClass1->PrimitiveOperation2 called");
        }
    }
}