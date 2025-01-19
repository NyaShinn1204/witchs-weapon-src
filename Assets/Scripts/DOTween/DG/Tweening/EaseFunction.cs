using System.Runtime.InteropServices;

namespace DG.Tweening
{
	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate float EaseFunction(float time, float duration, float overshootOrAmplitude, float period);
}
