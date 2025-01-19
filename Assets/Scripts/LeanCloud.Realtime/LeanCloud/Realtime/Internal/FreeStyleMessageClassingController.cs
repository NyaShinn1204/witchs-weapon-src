using System;
using System.Collections.Generic;
using System.Threading;

namespace LeanCloud.Realtime.Internal
{
	internal class FreeStyleMessageClassingController : IFreeStyleMessageClassingController
	{
		private static readonly string messageClassName;

		private readonly IDictionary<string, FreeStyleMessageClassInfo> registeredInterfaces;

		private readonly ReaderWriterLockSlim mutex;

		public Type GetType(IDictionary<string, object> msg)
		{
			return null;
		}

		public IAVIMMessage Instantiate(string msgStr, IDictionary<string, object> buildInData)
		{
			return null;
		}

		public IAVIMMessage DecodeProperties(IAVIMMessage message, IDictionary<string, object> buildInData)
		{
			return null;
		}

		public IDictionary<string, object> EncodeProperties(IAVIMMessage subclass)
		{
			return null;
		}

		public bool IsTypeValid(IDictionary<string, object> msg, Type type)
		{
			return false;
		}

		public void RegisterSubclass(Type type)
		{
		}

		public string GetClassName(Type type)
		{
			return null;
		}

		public int GetTypeInt(Type type)
		{
			return 0;
		}

		public IDictionary<string, string> GetPropertyMappings(string className)
		{
			return null;
		}
	}
}
