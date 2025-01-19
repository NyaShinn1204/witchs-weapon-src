using System;
using System.Collections.Generic;
using System.Threading;

namespace LeanCloud.Core.Internal
{
	internal class ObjectSubclassingController : IObjectSubclassingController
	{
		private static readonly string avObjectClassName;

		private readonly ReaderWriterLockSlim mutex;

		private readonly IDictionary<string, ObjectSubclassInfo> registeredSubclasses;

		private Dictionary<string, Action> registerActions;

		public string GetClassName(Type type)
		{
			return null;
		}

		public Type GetType(string className)
		{
			return null;
		}

		public bool IsTypeValid(string className, Type type)
		{
			return false;
		}

		public void RegisterSubclass(Type type)
		{
		}

		public void UnregisterSubclass(Type type)
		{
		}

		public void AddRegisterHook(Type t, Action action)
		{
		}

		public AVObject Instantiate(string className)
		{
			return null;
		}

		public IDictionary<string, string> GetPropertyMappings(string className)
		{
			return null;
		}
	}
}
