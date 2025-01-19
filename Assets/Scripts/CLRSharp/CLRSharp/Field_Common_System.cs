using System.Reflection;

namespace CLRSharp
{
	internal class Field_Common_System : IField
	{
		public FieldInfo info;

		public ICLRType FieldType { get; private set; }

		public ICLRType DeclaringType { get; private set; }

		public bool isStatic
		{
			get
			{
				return false;
			}
		}

		public Field_Common_System(ICLRSharp_Environment env, FieldInfo field)
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
