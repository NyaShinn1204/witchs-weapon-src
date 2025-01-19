using System.Reflection;

namespace CLRSharp
{
	internal class Method_Common_System : IMethod_System, IMethod
	{
		public bool isStatic
		{
			get
			{
				return false;
			}
		}

		public string Name
		{
			get
			{
				return null;
			}
		}

		public ICLRType DeclaringType { get; private set; }

		public ICLRType ReturnType { get; private set; }

		public MethodParamList ParamList { get; private set; }

		public MethodBase method_System { get; private set; }

		public Method_Common_System(ICLRType DeclaringType, MethodBase method)
		{
		}

		public object Invoke(ThreadContext context, object _this, object[] _params, bool bVisual)
		{
			return null;
		}

		public object Invoke(ThreadContext context, object _this, object[] _params)
		{
			return null;
		}

		public object Invoke(ThreadContext context, object _this, object[] _params, bool bVisual, bool autoLogDump)
		{
			return null;
		}
	}
}
