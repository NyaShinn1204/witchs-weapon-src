using NodeCanvas.Framework;

namespace NodeCanvas.BehaviourTrees
{
	public abstract class BTDecorator : BTNode
	{
		public sealed override int maxOutConnections
		{
			get
			{
				return 0;
			}
		}

		public sealed override bool showCommentsBottom
		{
			get
			{
				return false;
			}
		}

		protected Connection decoratedConnection
		{
			get
			{
				return null;
			}
		}

		protected Node decoratedNode
		{
			get
			{
				return null;
			}
		}
	}
}
