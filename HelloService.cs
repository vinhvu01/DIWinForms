namespace DIWinForms
{
    public class HelloService : IHelloService
    {
        public string SayHello(string name)
        {
            return $"Hello, world from {name}!";
        }
    }
}
