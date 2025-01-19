namespace NodeCanvas.BehaviourTrees
{
	public abstract class BTComposite : BTNode
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
	}
}
