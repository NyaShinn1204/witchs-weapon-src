using System;
using System.Collections;

namespace CLRSharp
{
	public class CrossBind_IEnumerable : ICrossBind
	{
		private class Base_IEnumerable : IEnumerable
		{
			private CLRSharp_Instance inst;

			public Base_IEnumerable(CLRSharp_Instance inst)
			{
			}

			public IEnumerator GetEnumerator()
			{
				return null;
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
