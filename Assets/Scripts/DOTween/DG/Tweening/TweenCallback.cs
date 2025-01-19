using System.Runtime.InteropServices;

namespace DG.Tweening
{
	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void TweenCallback();
	public delegate void TweenCallback<in T>(T value);
}
