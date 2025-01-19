using System.Runtime.InteropServices;

namespace DG.Tweening.Plugins.Options
{
	[StructLayout(LayoutKind.Sequential, Size = 4)]
	public struct UintOptions : IPlugOptions
	{
		public bool isNegativeChangeValue;

		public void Reset()
		{
		}
	}
}
