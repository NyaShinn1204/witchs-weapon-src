using System.Runtime.InteropServices;
using UnityEngine;

[StructLayout(LayoutKind.Sequential, Size = 28)]
internal struct Line
{
	public Vector2 point1;

	public Vector2 point2;

	public float a;

	public float b;

	public float c;

	public Line(Vector2 point1, Vector2 point2)
	{
		this.point1 = default(Vector2);
		this.point2 = default(Vector2);
		a = 0f;
		b = 0f;
		c = 0f;
	}
}
