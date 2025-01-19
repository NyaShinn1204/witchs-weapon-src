using System.Collections.Generic;

namespace Pathfinding
{
	public class RichPath
	{
		private int currentPart;

		private List<RichPathPart> parts;

		public Seeker seeker;

		public void Initialize(Seeker s, Path p, bool mergePartEndpoints, RichFunnel.FunnelSimplification simplificationMode)
		{
		}

		public bool PartsLeft()
		{
			return false;
		}

		public void NextPart()
		{
		}

		public RichPathPart GetCurrentPart()
		{
			return null;
		}
	}
}
