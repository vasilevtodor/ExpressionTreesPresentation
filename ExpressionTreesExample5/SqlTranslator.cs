using System.Linq.Expressions;
using System.Text;

namespace ExpressionTreesExample5
{
    public class SqlTranslator : ExpressionVisitor, IDisposable
    {
        private readonly StringBuilder _sb = new StringBuilder();

        public string Translate(Expression expression)
        {
            Visit(expression);
            return _sb.ToString();
        }

        // kit => kit.KitType == "Home" && kit.Color == "Red"
        protected override Expression VisitBinary(BinaryExpression node)
        {
            Visit(node.Left);

            switch (node.NodeType)
            {
                case ExpressionType.Equal:
                    _sb.Append(" = ");
                    break;
                case ExpressionType.AndAlso:
                    _sb.Append(" AND ");
                    break;
                case ExpressionType.Or:
                    _sb.Append(" OR ");
                    break;
                case ExpressionType.GreaterThan:
                    _sb.Append(" > ");
                    break;
                case ExpressionType.LessThan:
                    _sb.Append(" < ");
                    break;
            }

            Visit(node.Right);
            return node;
        }

        protected override Expression VisitMember(MemberExpression node)
        {
            _sb.Append(node.Member.Name);
            return node;
        }

        protected override Expression VisitConstant(ConstantExpression node)
        {
            if (node.Type == typeof(string))
                _sb.Append($"'{node.Value}'");
            else
                _sb.Append(node.Value);
            return node;
        }

        public void Dispose()
        {
            _sb.Clear();
        }
    }
}
