// Namespace correspondiente a patrones creacionales
namespace PatronesCoreNet.Creational
{
    // Producto abstracto: define una interfaz común para los productos.
    public abstract class Product
    {
        public abstract string GetName();
    }

    // Producto concreto A: implementación específica del producto.
    public class ConcreteProductA : Product
    {
        public override string GetName() => "Soy el Producto A";
    }

    // Producto concreto B: otra implementación específica.
    public class ConcreteProductB : Product
    {
        public override string GetName() => "Soy el Producto B";
    }

    // Creador abstracto: define el método de fábrica.
    public abstract class Creator
    {
        public abstract Product FactoryMethod();
    }

    // Creador concreto A: devuelve un producto específico.
    public class ConcreteCreatorA : Creator
    {
        public override Product FactoryMethod() => new ConcreteProductA();
    }

    // Creador concreto B: devuelve otro producto específico.
    public class ConcreteCreatorB : Creator
    {
        public override Product FactoryMethod() => new ConcreteProductB();
    }
}
