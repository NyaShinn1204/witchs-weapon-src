using Mono.Cecil;

namespace CLRSharp
{
	public class Method_Common_CLRSharp : IMethod_Sharp, IMethod
	{
		private Type_Common_CLRSharp _DeclaringType;

		public MethodDefinition method_CLRSharp;

		private CodeBody _body;

		public string Name
		{
			get
			{
				return null;
			}
		}

		public bool isStatic
		{
			get
			{
				return false;
			}
		}

		public ICLRType DeclaringType
		{
			get
			{
				return null;
			}
		}

		public ICLRType ReturnType { get; private set; }

		public MethodParamList ParamList { get; private set; }

		public CodeBody body
		{
			get
			{
				return null;
			}
		}

		public Method_Common_CLRSharp(Type_Common_CLRSharp type, MethodDefinition method)
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
