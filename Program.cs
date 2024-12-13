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

             Console.WriteLine("Demostración de Patrones de Diseño (Nuevos Ejemplos):");

            // -----------------------
            // 1. Patrón Creacional: Factory Method
            // -----------------------
            Console.WriteLine("\nPatrón Creacional: Factory Method");
            Creator creatorA = new ConcreteCreatorA();
            Creator creatorB = new ConcreteCreatorB();
            Console.WriteLine(creatorA.FactoryMethod().GetName());
            Console.WriteLine(creatorB.FactoryMethod().GetName());

            // -----------------------
            // 2. Patrón Estructural: Adapter
            // -----------------------
            Console.WriteLine("\nPatrón Estructural: Adapter");
            Adaptee adaptee = new Adaptee();
            ITarget adapter = new Adapter(adaptee);
            Console.WriteLine(adapter.Request());

            // -----------------------
            // 3. Patrón de Comportamiento: Observer
            // -----------------------
            Console.WriteLine("\nPatrón de Comportamiento: Observer");
            ConcreteSubject subject = new ConcreteSubject();
            ConcreteObserver observer1 = new ConcreteObserver("Observador 1");
            ConcreteObserver observer2 = new ConcreteObserver("Observador 2");

            // Añadir observadores
            subject.Attach(observer1);
            subject.Attach(observer2);

            // Enviar notificaciones
            subject.Notify("Evento 1");
            subject.Detach(observer1);
            subject.Notify("Evento 2");
        }
    }
}
