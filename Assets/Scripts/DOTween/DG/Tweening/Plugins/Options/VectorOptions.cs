using System.Runtime.InteropServices;

namespace DG.Tweening.Plugins.Options
{
	[StructLayout(LayoutKind.Sequential, Size = 8)]
	public struct VectorOptions : IPlugOptions
	{
		public AxisConstraint axisConstraint;

		public bool snapping;

		public void Reset()
		{
		}
	}
}
