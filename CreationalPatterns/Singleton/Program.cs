using Singleton;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// The client code.
SingletonClass s1 = SingletonClass.Instance;

SingletonClass s2 = SingletonClass.Instance;

SingletonClass s3 = SingletonClass.InstanceLazy;
SingletonClass s4 = SingletonClass.InstanceLazy;

if (s1 == s2)
{
    Console.WriteLine("Singleton works, both variables contain the same instance.");
}
else
{
    Console.WriteLine("Singleton failed, variables contain different instances.");
}

if (s3 == s4)
{
    Console.WriteLine("Singleton works, both variables contain the same instance.");
}
else
{
    Console.WriteLine("Singleton failed, variables contain different instances.");
}

