using System;
using System.Runtime.InteropServices;

namespace CLRSharp
{
	public class Delegate_BindTool : IDelegate_BindTool
	{
		[StructLayout(LayoutKind.Auto, Size = 8)]
		private delegate void Action();

		public Delegate CreateDele(Type deletype, ThreadContext context, CLRSharp_Instance _this, IMethod _method)
		{
			return null;
		}
	}
	public class Delegate_BindTool<T1> : IDelegate_BindTool
	{
		private delegate void Action(T1 p1);

		public Delegate CreateDele(Type deletype, ThreadContext context, CLRSharp_Instance _this, IMethod _method)
		{
			return null;
		}
	}
	public class Delegate_BindTool<T1, T2> : IDelegate_BindTool
	{
		private delegate void Action(T1 p1, T2 p2);

		public Delegate CreateDele(Type deletype, ThreadContext context, CLRSharp_Instance _this, IMethod _method)
		{
			return null;
		}
	}
	public class Delegate_BindTool<T1, T2, T3> : IDelegate_BindTool
	{
		private delegate void Action(T1 p1, T2 p2, T3 p3);

		public Delegate CreateDele(Type deletype, ThreadContext context, CLRSharp_Instance _this, IMethod _method)
		{
			return null;
		}
	}
	public class Delegate_BindTool<T1, T2, T3, T4> : IDelegate_BindTool
	{
		private delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4);

		public Delegate CreateDele(Type deletype, ThreadContext context, CLRSharp_Instance _this, IMethod _method)
		{
			return null;
		}
	}
}
