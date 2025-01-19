using System;
using System.Collections.Generic;

namespace LeanCloud.Core.Internal
{
	public interface IObjectSubclassingController
	{
		string GetClassName(Type type);

		Type GetType(string className);

		bool IsTypeValid(string className, Type type);

		void RegisterSubclass(Type t);

		void UnregisterSubclass(Type t);

		void AddRegisterHook(Type t, Action action);

		AVObject Instantiate(string className);

		IDictionary<string, string> GetPropertyMappings(string className);
	}
}
