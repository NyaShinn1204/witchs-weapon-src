using System;

namespace Pathfinding
{
	[Serializable]
	public class AlternativePath : MonoModifier
	{
		public int penalty;

		public int randomStep;

		private GraphNode[] prevNodes;

		private int prevSeed;

		private int prevPenalty;

		private bool waitingForApply;

		private object lockObject;

		private Random rnd;

		private Random seedGenerator;

		private bool destroyed;

		private GraphNode[] toBeApplied;

		public override ModifierData input
		{
			get
			{
				return default(ModifierData);
			}
		}

		public override ModifierData output
		{
			get
			{
				return default(ModifierData);
			}
		}

		public override void Apply(Path p, ModifierData source)
		{
		}

		public new void OnDestroy()
		{
		}

		private void ClearOnDestroy(Path p)
		{
		}

		private void InversePrevious()
		{
		}

		private void ApplyNow(Path somePath)
		{
		}
	}
}
