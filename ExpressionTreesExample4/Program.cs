using System.Linq.Expressions;
using System.Reflection;

Expression<Func<string, string, string>> getKitDescription =
    (primaryColor, secondaryColor) => $"Primary Color - {primaryColor}, Secondary Color - {secondaryColor}";

//Func<string, string, string> func = getKitDescription.Compile();
//Console.WriteLine(func("Blue", "White"));



Console.WriteLine(getKitDescription.ToString());


#region Building

//ParameterExpression primaryColorParam = Expression.Parameter(typeof(string), "primaryColor");
//ParameterExpression secondaryColorParam = Expression.Parameter(typeof(string), "secondaryColor");

//ConstantExpression constant1 = Expression.Constant("Primary Color - ");
//ConstantExpression constant2 = Expression.Constant(", Secondary Color - ");

//// string.Concat("Primary Color - ", primaryColor, ", Secondary Color - ", secondaryColor)
//MethodInfo? concatMethod = typeof(string).GetMethod("Concat", new Type[] { typeof(string), typeof(string), typeof(string), typeof(string) });

//MethodCallExpression body = Expression.Call(
//    concatMethod,
//    constant1,
//    primaryColorParam,
//    constant2,
//    secondaryColorParam
//);

//Expression<Func<string, string, string>> lambda = Expression.Lambda<Func<string, string, string>>(body, primaryColorParam, secondaryColorParam);

//Func<string, string, string> compiled = lambda.Compile();
//Console.WriteLine(compiled("Red", "Blue"));

#endregion