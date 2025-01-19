using Mono.Cecil;

namespace CLRSharp
{
	public class Field_Common_CLRSharp : IField
	{
		public Type_Common_CLRSharp _DeclaringType;

		public FieldDefinition field;

		public ICLRType FieldType { get; private set; }

		public ICLRType DeclaringType
		{
			get
			{
				return null;
			}
		}

		public bool isStatic
		{
			get
			{
				return false;
			}
		}

		public Field_Common_CLRSharp(Type_Common_CLRSharp type, FieldDefinition field)
		{
		}

		public void Set(object _this, object value)
		{
		}

		public object Get(object _this)
		{
			return null;
		}
	}
}
