namespace PatronesCoreNet.Behavioral
{
    public interface IStrategy
    {
        string Execute(string data);
    }

    public class ConcreteStrategyA : IStrategy
    {
        public string Execute(string data) => $"Estrategia A aplicada a {data}";
    }

    public class ConcreteStrategyB : IStrategy
    {
        public string Execute(string data) => $"Estrategia B aplicada a {data}";
    }

    public class Context
    {
        private IStrategy _strategy;

        public Context(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public void SetStrategy(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public string ExecuteStrategy(string data)
        {
            return _strategy.Execute(data);
        }
    }
}
