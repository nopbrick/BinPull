using System.Collections.Generic;

namespace BinPull
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dummy = new List<string>(args);
            dummy.RemoveRange(0, 1);
            Invoker.Run(Invoker.Invoke(Prog.LoadURL(args[0])), dummy.ToArray());
        }
    }
}
