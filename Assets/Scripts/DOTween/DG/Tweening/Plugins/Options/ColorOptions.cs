using System.Runtime.InteropServices;

namespace DG.Tweening.Plugins.Options
{
	[StructLayout(LayoutKind.Sequential, Size = 4)]
	public struct ColorOptions : IPlugOptions
	{
		public bool alphaOnly;

		public void Reset()
		{
		}
	}
}
