using System.Reflection;

public static class Refleaction
{
    public static void Demo()
    {
        Type myType = typeof(DemoClass);

        MethodInfo[] myMethods = myType.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);

        Console.WriteLine($"The methods in {nameof(DemoClass)} are: ");

        foreach (var methodInfo in myMethods)
        {
            Console.WriteLine(methodInfo.Name);
        }

    } 
}

public class DemoClass {
    public void Method1(){}
    public void Method2(){}
    public void Method3(){}
}