using System;
using System.Collections.Generic;
using System.Reflection;

namespace LeanCloud.Realtime.Internal
{
	internal class FreeStyleMessageClassInfo
	{
		public TypeInfo TypeInfo { get; private set; }

		public IDictionary<string, string> PropertyMappings { get; private set; }

		private ConstructorInfo Constructor { get; set; }

		public int TypeInt { get; set; }

		public FreeStyleMessageClassInfo(Type type, ConstructorInfo constructor)
		{
		}

		public bool Validate(string msgStr)
		{
			return false;
		}

		public IAVIMMessage Instantiate(string msgStr)
		{
			return null;
		}

		public static string GetMessageClassName(TypeInfo type)
		{
			return null;
		}

		public static int GetTypedInteger(TypeInfo type)
		{
			return 0;
		}
	}
}
