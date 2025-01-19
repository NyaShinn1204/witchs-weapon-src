using System;
using System.Runtime.CompilerServices;

namespace CLRSharp
{
	public class Type_Common_System : ICLRType_System, ICLRType
	{
		[CompilerGenerated]
		private ICLRType[] _003CSubTypes_003Ek__BackingField;

		public Type TypeForSystem { get; private set; }

		public ICLRSharp_Environment env { get; private set; }

		private ICLRType[] SubTypes
		{
			[CompilerGenerated]
			set
			{
				_003CSubTypes_003Ek__BackingField = value;
			}
		}

		public string Name
		{
			get
			{
				return null;
			}
		}

		public string FullName
		{
			get
			{
				return null;
			}
		}

		public string FullNameWithAssembly { get; private set; }

		public Type_Common_System(ICLRSharp_Environment env, Type type, ICLRType[] subtype)
		{
		}

		public virtual IMethod GetMethod(string funcname, MethodParamList types)
		{
			return null;
		}

		public object InitObj()
		{
			return null;
		}

		public virtual IMethod GetMethodT(string funcname, MethodParamList ttypes, MethodParamList types)
		{
			return null;
		}

		public virtual IField GetField(string name)
		{
			return null;
		}

		public bool IsInst(object obj)
		{
			return false;
		}

		public ICLRType GetNestType(ICLRSharp_Environment env, string fullname)
		{
			return null;
		}

		public Delegate CreateDelegate(Type deletype, object _this, IMethod_System _method)
		{
			return null;
		}

		public bool IsEnum()
		{
			return false;
		}
	}
}
