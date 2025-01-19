using System.Runtime.InteropServices;

namespace DG.Tweening.Plugins.Options
{
	[StructLayout(LayoutKind.Sequential, Size = 4)]
	public struct RectOptions : IPlugOptions
	{
		public bool snapping;

		public void Reset()
		{
		}
	}
}
