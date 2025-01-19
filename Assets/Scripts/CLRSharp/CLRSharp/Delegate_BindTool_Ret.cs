using System;

namespace CLRSharp
{
	public class Delegate_BindTool_Ret<TRet> : IDelegate_BindTool
	{
		private delegate TRet Action();

		public Delegate CreateDele(Type deletype, ThreadContext context, CLRSharp_Instance _this, IMethod _method)
		{
			return null;
		}
	}
	public class Delegate_BindTool_Ret<TRet, T1> : IDelegate_BindTool
	{
		private delegate TRet Action(T1 p1);

		public Delegate CreateDele(Type deletype, ThreadContext context, CLRSharp_Instance _this, IMethod _method)
		{
			return null;
		}
	}
	public class Delegate_BindTool_Ret<TRet, T1, T2> : IDelegate_BindTool
	{
		private delegate TRet Action(T1 p1, T2 p2);

		public Delegate CreateDele(Type deletype, ThreadContext context, CLRSharp_Instance _this, IMethod _method)
		{
			return null;
		}
	}
	public class Delegate_BindTool_Ret<TRet, T1, T2, T3> : IDelegate_BindTool
	{
		private delegate TRet Action(T1 p1, T2 p2, T3 p3);

		public Delegate CreateDele(Type deletype, ThreadContext context, CLRSharp_Instance _this, IMethod _method)
		{
			return null;
		}
	}
}
