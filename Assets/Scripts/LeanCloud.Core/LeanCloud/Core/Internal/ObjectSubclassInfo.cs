using System;
using System.Collections.Generic;
using System.Reflection;

namespace LeanCloud.Core.Internal
{
	internal class ObjectSubclassInfo
	{
		public TypeInfo TypeInfo { get; private set; }

		public string ClassName { get; private set; }

		public IDictionary<string, string> PropertyMappings { get; private set; }

		private ConstructorInfo Constructor { get; set; }

		public ObjectSubclassInfo(Type type, ConstructorInfo constructor)
		{
		}

		public AVObject Instantiate()
		{
			return null;
		}

		internal static string GetClassName(TypeInfo type)
		{
			return null;
		}
	}
}
