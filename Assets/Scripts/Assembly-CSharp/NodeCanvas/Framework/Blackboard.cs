using System;
using System.Collections.Generic;
using NodeCanvas.Framework.Internal;
using UnityEngine;

namespace NodeCanvas.Framework
{
	public class Blackboard : MonoBehaviour, ISerializationCallbackReceiver, IBlackboard
	{
		[SerializeField]
		private string _serializedBlackboard;

		[SerializeField]
		private List<UnityEngine.Object> _objectReferences;

		[NonSerialized]
		private BlackboardSource _blackboard;

		[NonSerialized]
		private bool hasDeserialized;

		public new string name
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public object Item
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Dictionary<string, Variable> variables
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public GameObject propertiesBindTarget
		{
			get
			{
				return null;
			}
		}

		public event Action<Variable> onVariableAdded
		{
			add
			{
			}
			remove
			{
			}
		}

		public event Action<Variable> onVariableRemoved
		{
			add
			{
			}
			remove
			{
			}
		}

		void ISerializationCallbackReceiver.OnBeforeSerialize()
		{
		}

		void ISerializationCallbackReceiver.OnAfterDeserialize()
		{
		}

		protected virtual void Awake()
		{
		}

		public Variable AddVariable(string name, Type type)
		{
			return null;
		}

		public Variable AddVariable(string name, object value)
		{
			return null;
		}

		public Variable RemoveVariable(string name)
		{
			return null;
		}

		public Variable GetVariable(string name, Type ofType = null)
		{
			return null;
		}

		public Variable GetVariableByID(string ID)
		{
			return null;
		}

		public Variable<T> GetVariable<T>(string name)
		{
			return null;
		}

		public T GetValue<T>(string name)
		{
			return default(T);
		}

		public Variable SetValue(string name, object value)
		{
			return null;
		}

		public string[] GetVariableNames()
		{
			return null;
		}

		public string[] GetVariableNames(Type ofType)
		{
			return null;
		}

		public string Save()
		{
			return null;
		}

		public string Save(string saveKey)
		{
			return null;
		}

		public bool Load()
		{
			return false;
		}

		public bool Load(string saveKey)
		{
			return false;
		}

		public string Serialize()
		{
			return null;
		}

		public bool Deserialize(string json, bool removeNonExisting = true)
		{
			return false;
		}
	}
}
