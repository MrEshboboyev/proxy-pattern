﻿using ProxyPatternInConsole.Interfaces;
using ProxyPatternInConsole.Interfaces.Implementations;

namespace ProxyPatternInConsole;

// The Proxy has an interface identical to the RealSubject.
public class Proxy : ISubject
{
    private RealSubject _realSubject;

    public Proxy(RealSubject realSubject)
    {
        _realSubject = realSubject;
    }

    // The most common applications of the Proxy pattern are
    // lazy loading, caching, logging, access control, and more.
    // A proxy can perform one of these things and then, depending on the result,
    // pass the execution to the same method in a linked RealSubject object.
    public void Request()
    {
        if (CheckAccess())
        {
            _realSubject.Request();
            LogAccess();
        }
    }

    public bool CheckAccess()
    {
        // Some real checks should go here.
        Console.WriteLine("Proxy: Checking access prior to firing a real request.");
        return true;
    }

    public void LogAccess()
    {
        Console.WriteLine("Proxy: Logging the time of request.");
    }
}
