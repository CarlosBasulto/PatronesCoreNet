namespace PatronesCoreNet.Structural
{
    public abstract class Component
    {
        public abstract string Operation();
    }

    public class ConcreteComponent : Component
    {
        public override string Operation() => "Componente base";
    }

    public abstract class Decorator : Component
    {
        protected Component _component;

        public Decorator(Component component)
        {
            _component = component;
        }

        public override string Operation() => _component.Operation();
    }

    public class ConcreteDecoratorA : Decorator
    {
        public ConcreteDecoratorA(Component component) : base(component) { }

        public override string Operation() => $"Decorador A ({base.Operation()})";
    }
}
