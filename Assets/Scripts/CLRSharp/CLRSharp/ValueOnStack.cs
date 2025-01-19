using System;
using System.Collections.Generic;

namespace CLRSharp
{
	public class ValueOnStack
	{
		private static Dictionary<Type, NumberType> typecode;

		public static Queue<VBox> unusedVBox;

		public static NumberType GetTypeCode(Type type)
		{
			return default(NumberType);
		}

		public static VBox MakeVBox(ICLRType type)
		{
			return null;
		}

		public static VBox MakeVBoxBool(bool b)
		{
			return null;
		}

		public static VBox MakeVBox(Type type)
		{
			return null;
		}

		public static VBox MakeVBox(NumberType code)
		{
			return null;
		}

		public static VBox Convert(VBox box, NumberType type)
		{
			return null;
		}

		public static void UnUse(VBox box)
		{
		}
	}
}
