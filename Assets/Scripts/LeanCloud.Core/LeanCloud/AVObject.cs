using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;
using LeanCloud.Core.Internal;
using LeanCloud.Storage.Internal;

namespace LeanCloud
{
	public class AVObject : IEnumerable<KeyValuePair<string, object>>, IEnumerable, INotifyPropertyChanged, INotifyPropertyUpdated, INotifyCollectionPropertyUpdated, IAVObject
	{
		private static readonly string AutoClassName;

		private static readonly bool isCompiledByIL2CPP;

		internal readonly object mutex;

		private readonly LinkedList<IDictionary<string, IAVFieldOperation>> operationSetQueue;

		private readonly IDictionary<string, object> estimatedData;

		private static readonly ThreadLocal<bool> isCreatingPointer;

		private bool hasBeenFetched;

		private bool dirty;

		internal TaskQueue taskQueue;

		private IObjectState state;

		private SynchronizedEventHandler<PropertyChangedEventArgs> propertyChanged;

		private SynchronizedEventHandler<PropertyUpdatedEventArgs> propertyUpdated;

		private SynchronizedEventHandler<CollectionPropertyUpdatedEventArgs> collectionUpdated;

		public IObjectState State
		{
			get
			{
				return null;
			}
		}

		internal static IAVObjectController ObjectController
		{
			get
			{
				return null;
			}
		}

		internal static IObjectSubclassingController SubclassingController
		{
			get
			{
				return null;
			}
		}

		private bool HasDirtyChildren
		{
			get
			{
				return false;
			}
		}

		private bool CanBeSerialized
		{
			get
			{
				return false;
			}
		}

		public virtual object Item
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool IsDataAvailable
		{
			get
			{
				return false;
			}
		}

		internal IDictionary<string, IAVFieldOperation> CurrentOperations
		{
			get
			{
				return null;
			}
		}

		public ICollection<string> Keys
		{
			get
			{
				return null;
			}
		}

		public AVACL ACL
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsNew
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public DateTime? UpdatedAt
		{
			get
			{
				return null;
			}
		}

		public DateTime? CreatedAt
		{
			get
			{
				return null;
			}
		}

		public bool IsDirty
		{
			get
			{
				return false;
			}
			internal set
			{
			}
		}

		public string ObjectId
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string ClassName
		{
			get
			{
				return null;
			}
		}

		public event PropertyChangedEventHandler PropertyChanged
		{
			add
			{
			}
			remove
			{
			}
		}

		public event PropertyUpdatedEventHandler PropertyUpdated
		{
			add
			{
			}
			remove
			{
			}
		}

		public event CollectionPropertyUpdatedEventHandler CollectionPropertyUpdated
		{
			add
			{
			}
			remove
			{
			}
		}

		internal void MutateState(Action<MutableObjectState> func)
		{
		}

		public static string GetSubClassName<TAVObject>()
		{
			return null;
		}

		protected AVObject()
		{
		}

		public AVObject(string className)
		{
		}

		public static AVObject Create(string className)
		{
			return null;
		}

		public static AVObject CreateWithoutData(string className, string objectId)
		{
			return null;
		}

		public static T Create<T>() where T : AVObject
		{
			return null;
		}

		public static T CreateWithoutData<T>(string objectId) where T : AVObject
		{
			return null;
		}

		public static T FromState<T>(IObjectState state, string defaultClassName) where T : AVObject
		{
			return null;
		}

		public static IDictionary<string, string> GetPropertyMappings(string className)
		{
			return null;
		}

		private static string GetFieldForPropertyName(string className, string propertyName)
		{
			return null;
		}

		protected virtual void SetProperty<T>(T value, string propertyName)
		{
		}

		protected AVRelation<T> GetRelationProperty<T>(string propertyName) where T : AVObject
		{
			return null;
		}

		protected virtual T GetProperty<T>(string propertyName)
		{
			return default(T);
		}

		protected virtual T GetProperty<T>(T defaultValue, string propertyName)
		{
			return default(T);
		}

		internal virtual void SetDefaultValues()
		{
		}

		public static void RegisterSubclass<T>() where T : AVObject, new()
		{
		}

		internal static void UnregisterSubclass<T>() where T : AVObject, new()
		{
		}

		public void Revert()
		{
		}

		internal virtual void HandleFetchResult(IObjectState serverState)
		{
		}

		internal void HandleFailedSave(IDictionary<string, IAVFieldOperation> operationsBeforeSave)
		{
		}

		internal virtual void HandleSave(IObjectState serverState)
		{
		}

		public virtual void MergeFromServer(IObjectState serverState)
		{
		}

		internal void MergeFromObject(AVObject other)
		{
		}

		internal static IEnumerable<object> DeepTraversal(object root, bool traverseParseObjects = false, bool yieldRoot = false)
		{
			return null;
		}

		private static IEnumerable<object> DeepTraversalInternal(object root, bool traverseParseObjects, ICollection<object> seen)
		{
			return null;
		}

		private IEnumerable<AVObject> FindUnsavedChildren()
		{
			return null;
		}

		private IDictionary<string, AVObject> CollectFetchedObjects()
		{
			return null;
		}

		public static IDictionary<string, object> ToJSONObjectForSaving(IDictionary<string, IAVFieldOperation> operations)
		{
			return null;
		}

		internal IDictionary<string, object> EncodeForSaving(IDictionary<string, object> data)
		{
			return null;
		}

		internal IDictionary<string, object> ServerDataToJSONObjectForSerialization()
		{
			return null;
		}

		public IDictionary<string, IAVFieldOperation> StartSave()
		{
			return null;
		}

		protected virtual Task SaveAsync(Task toAwait, CancellationToken cancellationToken)
		{
			return null;
		}

		public virtual Task SaveAsync()
		{
			return null;
		}

		public virtual Task SaveAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		internal virtual Task<AVObject> FetchAsyncInternal(Task toAwait, IDictionary<string, object> queryString, CancellationToken cancellationToken)
		{
			return null;
		}

		private static Task DeepSaveAsync(object obj, string sessionToken, CancellationToken cancellationToken)
		{
			return null;
		}

		public static Task SaveAllAsync<T>(IEnumerable<T> objects) where T : AVObject
		{
			return null;
		}

		public static Task SaveAllAsync<T>(IEnumerable<T> objects, CancellationToken cancellationToken) where T : AVObject
		{
			return null;
		}

		internal Task<AVObject> FetchAsyncInternal(CancellationToken cancellationToken)
		{
			return null;
		}

		internal Task<AVObject> FetchAsyncInternal(IDictionary<string, object> queryString, CancellationToken cancellationToken)
		{
			return null;
		}

		internal Task<AVObject> FetchIfNeededAsyncInternal(Task toAwait, CancellationToken cancellationToken)
		{
			return null;
		}

		internal Task<AVObject> FetchIfNeededAsyncInternal(CancellationToken cancellationToken)
		{
			return null;
		}

		public static Task<IEnumerable<T>> FetchAllIfNeededAsync<T>(IEnumerable<T> objects) where T : AVObject
		{
			return null;
		}

		public static Task<IEnumerable<T>> FetchAllIfNeededAsync<T>(IEnumerable<T> objects, CancellationToken cancellationToken) where T : AVObject
		{
			return null;
		}

		public static Task<IEnumerable<T>> FetchAllAsync<T>(IEnumerable<T> objects) where T : AVObject
		{
			return null;
		}

		public static Task<IEnumerable<T>> FetchAllAsync<T>(IEnumerable<T> objects, CancellationToken cancellationToken) where T : AVObject
		{
			return null;
		}

		private static Task<IEnumerable<T>> FetchAllInternalAsync<T>(IEnumerable<T> objects, bool force, Task toAwait, CancellationToken cancellationToken) where T : AVObject
		{
			return null;
		}

		internal Task DeleteAsync(Task toAwait, CancellationToken cancellationToken)
		{
			return null;
		}

		public Task DeleteAsync()
		{
			return null;
		}

		public Task DeleteAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		public static Task DeleteAllAsync<T>(IEnumerable<T> objects) where T : AVObject
		{
			return null;
		}

		public static Task DeleteAllAsync<T>(IEnumerable<T> objects, CancellationToken cancellationToken) where T : AVObject
		{
			return null;
		}

		private static void CollectDirtyChildren(object node, IList<AVObject> dirtyChildren, ICollection<AVObject> seen, ICollection<AVObject> seenNew)
		{
		}

		private static void CollectDirtyChildren(object node, IList<AVObject> dirtyChildren)
		{
		}

		private static bool CanBeSerializedAsValue(object value)
		{
			return false;
		}

		private static Task<T> EnqueueForAll<T>(IEnumerable<AVObject> objects, Func<Task, Task<T>> taskStart, CancellationToken cancellationToken)
		{
			return null;
		}

		public virtual void Remove(string key)
		{
		}

		private IEnumerable<string> ApplyOperations(IDictionary<string, IAVFieldOperation> operations, IDictionary<string, object> map)
		{
			return null;
		}

		internal void RebuildEstimatedData()
		{
		}

		internal void PerformOperation(string key, IAVFieldOperation operation)
		{
		}

		internal virtual void OnSettingValue(ref string key, ref object value)
		{
		}

		internal void Set(string key, object value)
		{
		}

		internal void SetIfDifferent<T>(string key, T value)
		{
		}

		public void Increment(string key)
		{
		}

		public void Increment(string key, long amount)
		{
		}

		public void Increment(string key, double amount)
		{
		}

		public void AddToList(string key, object value)
		{
		}

		public void AddRangeToList<T>(string key, IEnumerable<T> values)
		{
		}

		public void AddUniqueToList(string key, object value)
		{
		}

		public void AddRangeUniqueToList<T>(string key, IEnumerable<T> values)
		{
		}

		public void RemoveAllFromList<T>(string key, IEnumerable<T> values)
		{
		}

		public bool ContainsKey(string key)
		{
			return false;
		}

		public T Get<T>(string key)
		{
			return default(T);
		}

		public AVRelation<T> GetRelation<T>(string key) where T : AVObject
		{
			return null;
		}

		public AVQuery<T> GetRelationRevserseQuery<T>(string parentClassName, string key) where T : AVObject
		{
			return null;
		}

		public virtual bool TryGetValue<T>(string key, out T result)
		{
			result = default(T);
			return false;
		}

		private bool CheckIsDataAvailable(string key)
		{
			return false;
		}

		private void CheckGetAccess(string key)
		{
		}

		private void CheckKeyIsMutable(string key)
		{
		}

		protected virtual bool IsKeyMutable(string key)
		{
			return false;
		}

		public bool HasSameId(AVObject other)
		{
			return false;
		}

		public bool IsKeyDirty(string key)
		{
			return false;
		}

		private bool CheckIsDirty(bool considerChildren)
		{
			return false;
		}

		private void SetObjectIdInternal(string objectId)
		{
		}

		public void Add(string key, object value)
		{
		}

		IEnumerator<KeyValuePair<string, object>> IEnumerable<KeyValuePair<string, object>>.GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		public static AVQuery<AVObject> GetQuery(string className)
		{
			return null;
		}

		protected virtual void OnFieldsChanged(IEnumerable<string> fieldNames)
		{
		}

		protected virtual void OnPropertyChanged(string propertyName)
		{
		}

		protected virtual void OnPropertyUpdated(string propertyName, object newValue, object oldValue)
		{
		}

		protected virtual void OnCollectionPropertyUpdated(string propertyName, NotifyCollectionUpdatedAction action, IEnumerable oldValues, IEnumerable newValues)
		{
		}
	}
}
