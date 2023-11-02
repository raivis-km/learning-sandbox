using System.Linq.Expressions;

public static class MyExpression{
    public static void ShowResult(){
        Expression<Func<int, int, int>> addExpression = (a, b) => a + b;

        BinaryExpression body = (BinaryExpression)addExpression.Body;
        ParameterExpression left = (ParameterExpression)body.Left;
        ParameterExpression right = (ParameterExpression)body.Right;

        Console.WriteLine("Expression: {0} - {1}", left.Name, right.Name);

        Func<int, int, int> addFunc = addExpression.Compile();

        int result = addFunc(3,5);
        Console.WriteLine("Result: {0}", result);
    }
}