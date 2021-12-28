using System.Reflection;

namespace BinPull
{
    internal class Invoker
    {
        public static Assembly Invoke(byte[] bin)
        {
            var asm = Assembly.Load(bin);
            return asm;
        }

        public static void Run(Assembly assembly, string[] param)
        {
            assembly.EntryPoint.Invoke(null, new object[] { param });
        }
    }
}
