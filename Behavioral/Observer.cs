// Namespace correspondiente a patrones de comportamiento
namespace PatronesCoreNet.Behavioral
{
    // Interfaz del observador: define un método de actualización.
    public interface IObserver
    {
        void Update(string message);
    }

    // Interfaz del sujeto: define los métodos para añadir/quitar observadores.
    public interface ISubject
    {
        void Attach(IObserver observer);
        void Detach(IObserver observer);
        void Notify(string message);
    }

    // Clase concreta del sujeto: gestiona la lista de observadores y envía notificaciones.
    public class ConcreteSubject : ISubject
    {
        private readonly List<IObserver> _observers = new();

        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify(string message)
        {
            foreach (var observer in _observers)
            {
                observer.Update(message);
            }
        }
    }

    // Observador concreto: implementa la lógica de respuesta a las notificaciones.
    public class ConcreteObserver : IObserver
    {
        private readonly string _name;

        public ConcreteObserver(string name)
        {
            _name = name;
        }

        public void Update(string message)
        {
            Console.WriteLine($"Observador {_name} recibió: {message}");
        }
    }
}
