using System;

namespace CLRSharp
{
	public class CrossBind_IDisposable : ICrossBind
	{
		private class Base_IDisposable : IDisposable
		{
			private CLRSharp_Instance inst;

			public Base_IDisposable(CLRSharp_Instance inst)
			{
			}

			public void Dispose()
			{
			}
		}

		public Type Type
		{
			get
			{
				return null;
			}
		}

		public object CreateBind(CLRSharp_Instance inst)
		{
			return null;
		}
	}
}
