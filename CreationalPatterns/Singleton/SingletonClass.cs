namespace Singleton
{
    /* Singleton class
    
    The Singleton pattern is a design pattern that restricts the instantiation of a class to a single instance.
    This is useful when exactly one object is needed to coordinate actions across the system or application.
    
     */
    // EN : The Singleton should always be a 'sealed' class to prevent class
    // inheritance through external classes and also through nested classes.
    public sealed class SingletonClass
    {
        //The Singleton class maintains a static reference to the single instance (instance).
        private static SingletonClass? instance;

        private static readonly object lockObject = new object();
         
        // Make the default constructor private, to prevent instantiation from outside the class.
        private SingletonClass()
        {

        }

        //The Instance property provides a way to access the Singleton's instance.
       
        //When Instance is accessed, it checks if instance is null. 
        //If it is, it creates a new Singleton object and assigns it to instance
        public static SingletonClass Instance
        {
         get
           {
            // Lock the object to prevent multiple threads from creating multiple instances.
            lock (lockObject)
            {
                if (instance is null)
                {
                    instance = new SingletonClass();
                }

                // If instance is not null, it simply returns the existing Singleton object.
                return instance;
            }
          }
        }


      public static readonly Lazy<SingletonClass> lazy = 
      new Lazy<SingletonClass>(() => new SingletonClass());
      public static SingletonClass InstanceLazy => lazy.Value;
      
        
    }
}

/*
An important note about the Singleton pattern is that it poses a significant issue for multithreading, 
especially in a scenario where multiple threads may simultaneously attempt to create an instance of the Singleton 
class. This can lead to multiple instances if proper synchronization is not enforced, thus violating the core 
principle of the Singleton pattern that only one instance of the class should ever exist.


There are multiple solutions to this problem, 
such as eager initialization, double-checked locking, or lazy initialization.
*/