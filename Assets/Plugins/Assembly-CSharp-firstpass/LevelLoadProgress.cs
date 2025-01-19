using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential, Size = 16)]
public struct LevelLoadProgress
{
	public string Message { get; set; }

	public float Progress { get; set; }

	public LevelLoadProgress(string message, float progress)
	{
		Message = null;
		Progress = 0f;
	}
}
