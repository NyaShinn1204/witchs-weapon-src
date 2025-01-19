using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace LeanCloud.Core.Internal
{
	public static class AVObjectExtensions
	{
		public static T FromState<T>(IObjectState state, string defaultClassName) where T : AVObject
		{
			return null;
		}

		public static IObjectState GetState(this AVObject obj)
		{
			return null;
		}

		public static void HandleFetchResult(this AVObject obj, IObjectState serverState)
		{
		}

		public static IDictionary<string, IAVFieldOperation> GetCurrentOperations(this AVObject obj)
		{
			return null;
		}

		public static IDictionary<string, object> Encode(this AVObject obj)
		{
			return null;
		}

		public static IEnumerable<object> DeepTraversal(object root, bool traverseParseObjects = false, bool yieldRoot = false)
		{
			return null;
		}

		public static void SetIfDifferent<T>(this AVObject obj, string key, T value)
		{
		}

		public static IDictionary<string, object> ServerDataToJSONObjectForSerialization(this AVObject obj)
		{
			return null;
		}

		public static void Set(this AVObject obj, string key, object value)
		{
		}

		public static void DisableHooks(this AVObject obj, IEnumerable<string> hookKeys)
		{
		}

		public static void DisableHook(this AVObject obj, string hookKey)
		{
		}

		public static void DisableAfterHook(this AVObject obj)
		{
		}

		public static void DisableBeforeHook(this AVObject obj)
		{
		}

		public static void DisableBeforeSave(this AVObject obj)
		{
		}

		public static void DisableAfterSave(this AVObject obj)
		{
		}

		public static void DisableBeforeUpdate(this AVObject obj)
		{
		}

		public static void DisableAfterUpdate(this AVObject obj)
		{
		}

		public static void DisableBeforeDelete(this AVObject obj)
		{
		}

		public static void DisableAfterDelete(this AVObject obj)
		{
		}

		public static void OnPropertyChanged(this AVObject avObj, string propertyName, PropertyChangedEventHandler handler)
		{
		}

		public static void OnPropertyUpdated(this AVObject avObj, string propertyName, PropertyUpdatedEventHandler handler)
		{
		}

		public static void OnPropertyUpdated(this AVObject avObj, string propertyName, Action<object, object> handler)
		{
		}

		public static void OnCollectionPropertyUpdated(this AVObject avObj, string propertyName, CollectionPropertyUpdatedEventHandler handler)
		{
		}

		public static void OnCollectionPropertyAdded(this AVObject avObj, string propertyName, Action<IEnumerable> handler)
		{
		}

		public static void OnCollectionPropertyRemoved(this AVObject avObj, string propertyName, Action<IEnumerable> handler)
		{
		}
	}
}
