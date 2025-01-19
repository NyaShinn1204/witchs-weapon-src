using System.Runtime.InteropServices;

namespace Pathfinding
{
	[StructLayout(LayoutKind.Sequential, Size = 16)]
	public struct Progress
	{
		public float progress;

		public string description;

		public Progress(float p, string d)
		{
			progress = 0f;
			description = null;
		}
	}
}
