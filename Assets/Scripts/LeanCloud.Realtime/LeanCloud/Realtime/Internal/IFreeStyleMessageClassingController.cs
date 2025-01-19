using System;
using System.Collections.Generic;

namespace LeanCloud.Realtime.Internal
{
	internal interface IFreeStyleMessageClassingController
	{
		bool IsTypeValid(IDictionary<string, object> msg, Type type);

		void RegisterSubclass(Type t);

		IAVIMMessage Instantiate(string msgStr, IDictionary<string, object> buildInData);

		IDictionary<string, object> EncodeProperties(IAVIMMessage subclass);

		Type GetType(IDictionary<string, object> msg);

		string GetClassName(Type type);

		IDictionary<string, string> GetPropertyMappings(string className);
	}
}
