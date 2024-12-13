namespace PatronesCoreNet.Creational
{
    public sealed class Singleton
    {
        private static Singleton? _instance;
        private static readonly object _lock = new object();
        public string Data { get; private set; }

        private Singleton()
        {
            Data = $"Instancia creada en {DateTime.Now}";
        }

        public static Singleton Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Singleton();
                    }
                    return _instance;
                }
            }
        }
    }
}
