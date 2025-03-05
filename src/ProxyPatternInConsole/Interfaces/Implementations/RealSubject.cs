namespace ProxyPatternInConsole.Interfaces.Implementations;

// The Real Subject contains some core business logic. Usually, Real Subjects are capable of doing
// some useful work which may also be very slow or sensitive - e.g. correcting input data.
// A Proxy can solve these issues without any changes to the Real Subject's code.
public class RealSubject : ISubject
{
    public void Request()
    {
        Console.WriteLine("RealSubject: Handling Request.");
    }
}
