using System.Runtime.InteropServices;

namespace DG.Tweening.Plugins.Options
{
	[StructLayout(LayoutKind.Sequential, Size = 24)]
	public struct StringOptions : IPlugOptions
	{
		public bool richTextEnabled;

		public ScrambleMode scrambleMode;

		public char[] scrambledChars;

		internal int startValueStrippedLength;

		internal int changeValueStrippedLength;

		public void Reset()
		{
		}
	}
}
