using System;
using System.Collections;

namespace CLRSharp
{
	public class CrossBind_IEnumerator : ICrossBind
	{
		private class Base_IEnumerator : IEnumerator
		{
			private CLRSharp_Instance inst;

			private IMethod _MoveNext;

			private IMethod _get_Current;

			private IMethod _Reset;

			public object Current
			{
				get
				{
					return null;
				}
			}

			public Base_IEnumerator(CLRSharp_Instance inst)
			{
			}

			public bool MoveNext()
			{
				return false;
			}

			public void Reset()
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
