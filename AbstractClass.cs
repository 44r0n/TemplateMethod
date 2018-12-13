namespace TemplateMethod
{
    public abstract class AbstractClass
    {
        protected abstract void PrimitiveOperation1();
        protected abstract void PrimitiveOperation2();

        public void TemplateMethod()
        {
            System.Console.WriteLine("TemplateMethod begins");
            PrimitiveOperation1();
            PrimitiveOperation2();
            System.Console.WriteLine("TemplateMethod end");
        }
    }
}