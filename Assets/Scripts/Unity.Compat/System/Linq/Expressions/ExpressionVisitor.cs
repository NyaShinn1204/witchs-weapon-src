using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace System.Linq.Expressions
{
	public abstract class ExpressionVisitor
	{
		public virtual Expression Visit(Expression exp)
		{
			return null;
		}

		protected virtual MemberBinding VisitBinding(MemberBinding binding)
		{
			return null;
		}

		protected virtual ElementInit VisitElementInitializer(ElementInit initializer)
		{
			return null;
		}

		protected virtual Expression VisitUnary(UnaryExpression u)
		{
			return null;
		}

		protected virtual Expression VisitBinary(BinaryExpression b)
		{
			return null;
		}

		protected virtual Expression VisitIndex(IndexExpression e)
		{
			return null;
		}

		protected virtual Expression VisitTypeIs(TypeBinaryExpression b)
		{
			return null;
		}

		protected virtual Expression VisitConstant(ConstantExpression c)
		{
			return null;
		}

		protected virtual Expression VisitConditional(ConditionalExpression c)
		{
			return null;
		}

		protected virtual Expression VisitParameter(ParameterExpression p)
		{
			return null;
		}

		protected virtual Expression VisitMember(MemberExpression m)
		{
			return null;
		}

		protected virtual Expression VisitMethodCall(MethodCallExpression m)
		{
			return null;
		}

		protected virtual ReadOnlyCollection<Expression> VisitExpressionList(ReadOnlyCollection<Expression> original)
		{
			return null;
		}

		protected virtual MemberAssignment VisitMemberAssignment(MemberAssignment assignment)
		{
			return null;
		}

		protected virtual MemberMemberBinding VisitMemberMemberBinding(MemberMemberBinding binding)
		{
			return null;
		}

		protected virtual MemberListBinding VisitMemberListBinding(MemberListBinding binding)
		{
			return null;
		}

		protected virtual IEnumerable<MemberBinding> VisitBindingList(ReadOnlyCollection<MemberBinding> original)
		{
			return null;
		}

		protected virtual IEnumerable<ElementInit> VisitElementInitializerList(ReadOnlyCollection<ElementInit> original)
		{
			return null;
		}

		protected virtual Expression VisitLambda(LambdaExpression lambda)
		{
			return null;
		}

		protected virtual NewExpression VisitNew(NewExpression nex)
		{
			return null;
		}

		protected virtual Expression VisitMemberInit(MemberInitExpression init)
		{
			return null;
		}

		protected virtual Expression VisitListInit(ListInitExpression init)
		{
			return null;
		}

		protected virtual Expression VisitNewArray(NewArrayExpression na)
		{
			return null;
		}

		protected virtual Expression VisitInvocation(InvocationExpression iv)
		{
			return null;
		}
	}
}
