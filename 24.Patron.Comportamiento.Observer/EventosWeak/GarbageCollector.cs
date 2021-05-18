using System;

namespace _24.Patron.Comportamiento.Observer.EventosWeak
{
    public static class GarbageCollector
    {
        public static void FireGC()
        {
            Console.WriteLine("Empezar GC");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            Console.WriteLine("Finalizar GC");
        }
    }
}