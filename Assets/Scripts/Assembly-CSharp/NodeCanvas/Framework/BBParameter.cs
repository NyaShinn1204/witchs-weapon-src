using System;
using System.Collections.Generic;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Framework
{
	[Serializable]
	[SpoofAOT]
	public abstract class BBParameter
	{
		[SerializeField]
		private string _name;

		[SerializeField]
		private string _targetVariableID;

		[NonSerialized]
		private IBlackboard _bb;

		[NonSerialized]
		private Variable _varRef;

		private string targetVariableID
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Variable varRef
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public IBlackboard bb
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

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

		public bool useBlackboard
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool isNone
		{
			get
			{
				return false;
			}
		}

		public bool isNull
		{
			get
			{
				return false;
			}
		}

		public Type refType
		{
			get
			{
				return null;
			}
		}

		public object value
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected abstract object objectValue { get; set; }

		public abstract Type varType { get; }

		public BBParameter()
		{
		}

		public static BBParameter CreateInstance(Type t, IBlackboard bb)
		{
			return null;
		}

		public static void SetBBFields(object o, IBlackboard bb)
		{
		}

		public static List<BBParameter> GetObjectBBParameters(object o)
		{
			return null;
		}

		protected abstract void Bind(Variable data);

		private Variable ResolveReference(IBlackboard targetBlackboard, bool useID)
		{
			return null;
		}

		public Variable PromoteToVariable(IBlackboard targetBB)
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	public class BBParameter<T> : BBParameter
	{
		private Func<T> getter;

		private Action<T> setter;

		[SerializeField]
		protected T _value;

		public new T value
		{
			get
			{
				return default(T);
			}
			set
			{
			}
		}

		protected override object objectValue
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override Type varType
		{
			get
			{
				return null;
			}
		}

		public BBParameter()
		{
		}

		public BBParameter(T value)
		{
		}

		protected override void Bind(Variable variable)
		{
		}

		private bool BindGetter(Variable variable)
		{
			return false;
		}

		private bool BindSetter(Variable variable)
		{
			return false;
		}

		public static implicit operator BBParameter<T>(T value)
		{
			return null;
		}
	}
}
