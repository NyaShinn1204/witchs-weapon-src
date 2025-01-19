using System;
using System.Collections.Generic;

namespace CLRSharp
{
	public class CLRSharp_Instance
	{
		public object system_base;

		public Dictionary<string, object> Fields;

		public Dictionary<IMethod, Delegate> Delegates;

		public ICLRType_Sharp type { get; private set; }

		public CLRSharp_Instance(ICLRType_Sharp type)
		{
		}

		public Delegate GetDelegate(ThreadContext context, Type deleType, IMethod method)
		{
			return null;
		}
	}
}
