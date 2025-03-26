using ExpressionTreesExample5;
using System.Linq.Expressions;

Expression<Func<FootballKit, bool>> expression = kit => kit.KitType == "Home" && kit.Color == "Red";

string sqlWhereClause = new SqlTranslator().Translate(expression.Body);
Console.WriteLine("Generated SQL:");
Console.WriteLine($"SELECT * FROM FootballKits WHERE {sqlWhereClause}");

public class FootballKit
{
    public string KitType { get; set; }  // Home, Away, Third
    public string TeamName { get; set; }
    public string Color { get; set; }
}
