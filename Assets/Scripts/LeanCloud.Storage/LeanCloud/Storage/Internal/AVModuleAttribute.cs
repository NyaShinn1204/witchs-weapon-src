using System;

namespace LeanCloud.Storage.Internal
{
	public class AVModuleAttribute : Attribute
	{
		public Type ModuleType { get; private set; }

		public AVModuleAttribute(Type ModuleType)
		{
		}
	}
}
