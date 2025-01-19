using System;
using System.Collections.Generic;
using UnityEngine;

namespace NodeCanvas.Framework.Internal
{
	[Serializable]
	public sealed class BlackboardSource : IBlackboard
	{
		[SerializeField]
		private string _name;

		[SerializeField]
		private Dictionary<string, Variable> _variables;

		public string name
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

		public void InitializePropertiesBinding(GameObject targetGO, bool callSetter)
		{
		}

		public Variable AddVariable(string varName, object value)
		{
			return null;
		}

		public Variable AddVariable(string varName, Type type)
		{
			return null;
		}

		public Variable RemoveVariable(string varName)
		{
			return null;
		}

		public T GetValue<T>(string varName)
		{
			return default(T);
		}

		public Variable SetValue(string varName, object value)
		{
			return null;
		}

		public Variable GetVariable(string varName, Type ofType = null)
		{
			return null;
		}

		public Variable GetVariableByID(string ID)
		{
			return null;
		}

		public Variable<T> GetVariable<T>(string varName)
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

		public Variable<T> AddVariable<T>(string varName, T value)
		{
			return null;
		}

		public Variable<T> AddVariable<T>(string varName)
		{
			return null;
		}

		public void ResetVars()
		{
		}
	}
}
