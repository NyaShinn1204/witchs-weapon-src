using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential, Size = 32)]
public struct ReleaseTargetParam
{
	public int type;

	public int arg1;

	public int arg2;

	public int arg3;

	public int arg4;

	public long arg5;

	public ReleaseTargetParam(int type, int arg1, int arg2, int arg3, int arg4, long arg5)
	{
		this.type = 0;
		this.arg1 = 0;
		this.arg2 = 0;
		this.arg3 = 0;
		this.arg4 = 0;
		this.arg5 = 0L;
	}
}
