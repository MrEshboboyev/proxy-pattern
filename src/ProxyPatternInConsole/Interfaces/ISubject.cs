namespace ProxyPatternInConsole.Interfaces;

// The Subject interface declares a set of methods for controlling the RealSubject and the Proxy.
// As long as the client works with RealSubject using this interface,
// you'll be able to pass it a proxy instead of a real subject.
public interface ISubject
{
    void Request();
}
