using System.Collections.ObjectModel;

namespace System.Linq.Expressions
{
	public abstract class IndexExpression : Expression
	{
		public abstract Collection<Expression> Arguments { get; }

		public abstract Expression Object { get; }
	}
}
