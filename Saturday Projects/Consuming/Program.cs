using System;
using System.Reflection;
class Program
{
    public static void Main()
    {
        Assembly assembly = Assembly.LoadFrom("D:\\Study\\Cg Training\\Saturday Projects\\DLL\\bin\\Debug\net10.0\\DLL.dll");
        Type type = assembly.GetType();
        object obj = Activator.CreateInstance(type);
        MethodInfo[] method = type.GetMethod("M1");
        object result = method.Invoke(obj,null);
    }
}