using PatronesCoreNet.Creational;
using PatronesCoreNet.Structural;
using PatronesCoreNet.Behavioral;

namespace PatronesCoreNet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demostración de Patrones de Diseño:");

            // Patrón Creacional: Singleton
            var singleton1 = Singleton.Instance;
            var singleton2 = Singleton.Instance;
            Console.WriteLine($"¿Singleton es la misma instancia? {object.ReferenceEquals(singleton1, singleton2)}");

            // Patrón Estructural: Decorator
            var component = new ConcreteComponent();
            var decorator = new ConcreteDecoratorA(component);
            Console.WriteLine(decorator.Operation());

            // Patrón de Comportamiento: Strategy
            var context = new Context(new ConcreteStrategyA());
            Console.WriteLine(context.ExecuteStrategy("datos de ejemplo"));
            context.SetStrategy(new ConcreteStrategyB());
            Console.WriteLine(context.ExecuteStrategy("datos de ejemplo"));
        }
    }
}
