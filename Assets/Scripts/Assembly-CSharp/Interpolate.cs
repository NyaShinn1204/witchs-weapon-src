using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using UnityEngine;

public class Interpolate
{
	public enum EaseType
	{
		Linear = 0,
		EaseInQuad = 1,
		EaseOutQuad = 2,
		EaseInOutQuad = 3,
		EaseInCubic = 4,
		EaseOutCubic = 5,
		EaseInOutCubic = 6,
		EaseInQuart = 7,
		EaseOutQuart = 8,
		EaseInOutQuart = 9,
		EaseInQuint = 10,
		EaseOutQuint = 11,
		EaseInOutQuint = 12,
		EaseInSine = 13,
		EaseOutSine = 14,
		EaseInOutSine = 15,
		EaseInExpo = 16,
		EaseOutExpo = 17,
		EaseInOutExpo = 18,
		EaseInCirc = 19,
		EaseOutCirc = 20,
		EaseInOutCirc = 21
	}

	public delegate Vector3 ToVector3<T>(T v);

	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate float Function(float a, float b, float c, float d);

	private static Vector3 Identity(Vector3 v)
	{
		return default(Vector3);
	}

	private static Vector3 TransformDotPosition(Transform t)
	{
		return default(Vector3);
	}

	[DebuggerHidden]
	private static IEnumerable<float> NewTimer(float duration)
	{
		return null;
	}

	[DebuggerHidden]
	private static IEnumerable<float> NewCounter(int start, int end, int step)
	{
		return null;
	}

	public static IEnumerator NewEase(Function ease, Vector3 start, Vector3 end, float duration)
	{
		return null;
	}

	public static IEnumerator NewEase(Function ease, Vector3 start, Vector3 end, int slices)
	{
		return null;
	}

	[DebuggerHidden]
	private static IEnumerator NewEase(Function ease, Vector3 start, Vector3 end, float total, IEnumerable<float> driver)
	{
		return null;
	}

	private static Vector3 Ease(Function ease, Vector3 start, Vector3 distance, float elapsedTime, float duration)
	{
		return default(Vector3);
	}

	public static Function Ease(EaseType type)
	{
		return null;
	}

	public static IEnumerable<Vector3> NewBezier(Function ease, Transform[] nodes, float duration)
	{
		return null;
	}

	public static IEnumerable<Vector3> NewBezier(Function ease, Transform[] nodes, int slices)
	{
		return null;
	}

	public static IEnumerable<Vector3> NewBezier(Function ease, Vector3[] points, float duration)
	{
		return null;
	}

	public static IEnumerable<Vector3> NewBezier(Function ease, Vector3[] points, int slices)
	{
		return null;
	}

	[DebuggerHidden]
	private static IEnumerable<Vector3> NewBezier<T>(Function ease, IList nodes, ToVector3<T> toVector3, float maxStep, IEnumerable<float> steps)
	{
		return null;
	}

	private static Vector3 Bezier(Function ease, Vector3[] points, float elapsedTime, float duration)
	{
		return default(Vector3);
	}

	public static IEnumerable<Vector3> NewCatmullRom(Transform[] nodes, int slices, bool loop)
	{
		return null;
	}

	public static IEnumerable<Vector3> NewCatmullRom(Vector3[] points, int slices, bool loop)
	{
		return null;
	}

	[DebuggerHidden]
	private static IEnumerable<Vector3> NewCatmullRom<T>(IList nodes, ToVector3<T> toVector3, int slices, bool loop)
	{
		return null;
	}

	private static Vector3 CatmullRom(Vector3 previous, Vector3 start, Vector3 end, Vector3 next, float elapsedTime, float duration)
	{
		return default(Vector3);
	}

	private static float Linear(float start, float distance, float elapsedTime, float duration)
	{
		return 0f;
	}

	private static float EaseInQuad(float start, float distance, float elapsedTime, float duration)
	{
		return 0f;
	}

	private static float EaseOutQuad(float start, float distance, float elapsedTime, float duration)
	{
		return 0f;
	}

	private static float EaseInOutQuad(float start, float distance, float elapsedTime, float duration)
	{
		return 0f;
	}

	private static float EaseInCubic(float start, float distance, float elapsedTime, float duration)
	{
		return 0f;
	}

	private static float EaseOutCubic(float start, float distance, float elapsedTime, float duration)
	{
		return 0f;
	}

	private static float EaseInOutCubic(float start, float distance, float elapsedTime, float duration)
	{
		return 0f;
	}

	private static float EaseInQuart(float start, float distance, float elapsedTime, float duration)
	{
		return 0f;
	}

	private static float EaseOutQuart(float start, float distance, float elapsedTime, float duration)
	{
		return 0f;
	}

	private static float EaseInOutQuart(float start, float distance, float elapsedTime, float duration)
	{
		return 0f;
	}

	private static float EaseInQuint(float start, float distance, float elapsedTime, float duration)
	{
		return 0f;
	}

	private static float EaseOutQuint(float start, float distance, float elapsedTime, float duration)
	{
		return 0f;
	}

	private static float EaseInOutQuint(float start, float distance, float elapsedTime, float duration)
	{
		return 0f;
	}

	private static float EaseInSine(float start, float distance, float elapsedTime, float duration)
	{
		return 0f;
	}

	private static float EaseOutSine(float start, float distance, float elapsedTime, float duration)
	{
		return 0f;
	}

	private static float EaseInOutSine(float start, float distance, float elapsedTime, float duration)
	{
		return 0f;
	}

	private static float EaseInExpo(float start, float distance, float elapsedTime, float duration)
	{
		return 0f;
	}

	private static float EaseOutExpo(float start, float distance, float elapsedTime, float duration)
	{
		return 0f;
	}

	private static float EaseInOutExpo(float start, float distance, float elapsedTime, float duration)
	{
		return 0f;
	}

	private static float EaseInCirc(float start, float distance, float elapsedTime, float duration)
	{
		return 0f;
	}

	private static float EaseOutCirc(float start, float distance, float elapsedTime, float duration)
	{
		return 0f;
	}

	private static float EaseInOutCirc(float start, float distance, float elapsedTime, float duration)
	{
		return 0f;
	}
}
