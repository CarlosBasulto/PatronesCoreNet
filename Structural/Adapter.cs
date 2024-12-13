// Namespace correspondiente a patrones estructurales
namespace PatronesCoreNet.Structural
{
    // Interfaz objetivo: define la funcionalidad esperada.
    public interface ITarget
    {
        string Request();
    }

    // Clase adaptada: tiene una funcionalidad diferente que queremos adaptar.
    public class Adaptee
    {
        public string SpecificRequest() => "Soy un método incompatible";
    }

    // Adaptador: convierte la interfaz de Adaptee a la interfaz objetivo.
    public class Adapter : ITarget
    {
        private readonly Adaptee _adaptee;

        public Adapter(Adaptee adaptee)
        {
            _adaptee = adaptee;
        }

        public string Request() => $"Adaptado: {_adaptee.SpecificRequest()}";
    }
}
