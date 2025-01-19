using System;
using System.Reflection;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Framework
{
	[Serializable]
	[SpoofAOT]
	public abstract class Variable
	{
		[SerializeField]
		private string _name;

		[SerializeField]
		private string _id;

		[SerializeField]
		private bool _protected;

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

		public string ID
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

		public bool isProtected
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		protected abstract object objectValue { get; set; }

		public abstract Type varType { get; }

		public abstract bool hasBinding { get; }

		public abstract string propertyPath { get; set; }

		public event Action<string> onNameChanged
		{
			add
			{
			}
			remove
			{
			}
		}

		public event Action<string, object> onValueChanged
		{
			add
			{
			}
			remove
			{
			}
		}

		public Variable()
		{
		}

		protected bool HasValueChangeEvent()
		{
			return false;
		}

		protected void OnValueChanged(string name, object value)
		{
		}

		public abstract void BindProperty(MemberInfo prop, GameObject target = null);

		public abstract void UnBindProperty();

		public abstract void InitializePropertyBinding(GameObject go, bool callSetter = false);

		public bool CanConvertTo(Type toType)
		{
			return false;
		}

		public Func<object> GetGetConverter(Type toType)
		{
			return null;
		}

		public bool CanConvertFrom(Type fromType)
		{
			return false;
		}

		public Action<object> GetSetConverter(Type fromType)
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	public class Variable<T> : Variable
	{
		[SerializeField]
		private T _value;

		[SerializeField]
		private string _propertyPath;

		private Func<T> getter;

		private Action<T> setter;

		public override string propertyPath
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override bool hasBinding
		{
			get
			{
				return false;
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

		public T GetValue()
		{
			return default(T);
		}

		public void SetValue(T newValue)
		{
		}

		public override void BindProperty(MemberInfo prop, GameObject target = null)
		{
		}

		public override void UnBindProperty()
		{
		}

		public override void InitializePropertyBinding(GameObject go, bool callSetter = false)
		{
		}
	}
}
