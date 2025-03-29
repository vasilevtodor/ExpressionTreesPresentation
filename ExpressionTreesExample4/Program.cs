using System.Linq.Expressions;
using System.Reflection;

Expression<Func<string, string, string>> getKitDescription =
    (primaryColor, secondaryColor) => $"Primary Color - {primaryColor}, Secondary Color - {secondaryColor}";

Func<string, string, string> func = getKitDescription.Compile();
Console.WriteLine(func("Blue", "White"));


#region Building

//ParameterExpression primaryColorParam = Expression.Parameter(typeof(string), "primaryColor");
//ParameterExpression secondaryColorParam = Expression.Parameter(typeof(string), "secondaryColor");

//ConstantExpression formatString = Expression.Constant("Primary Color - {0}, Secondary Color - {1}");

//// string.Format("Primary Color - {0}, Secondary Color - {1}", primaryColor, secondaryColor)
//MethodInfo? formatMethod = typeof(string).GetMethod("Format", new Type[] { typeof(string), typeof(object), typeof(object) });

//MethodCallExpression formatExpression = Expression.Call(
//    formatMethod!,
//    formatString,
//    primaryColorParam,
//    secondaryColorParam
//);

//Expression<Func<string, string, string>> lambda = Expression.Lambda<Func<string, string, string>>(formatExpression, primaryColorParam, secondaryColorParam);

//Func<string, string, string> compiled = lambda.Compile();
//Console.WriteLine(compiled("Red", "Blue"));

#endregion