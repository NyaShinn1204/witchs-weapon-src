using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace System.Reflection
{
	public class TypeInfo : Type
	{
		private static ConditionalWeakTable<Type, TypeInfo> typeInfoMap;

		private Type underlyingType;

		public IEnumerable<Type> ImplementedInterfaces
		{
			get
			{
				return null;
			}
		}

		public override Assembly Assembly
		{
			get
			{
				return null;
			}
		}

		public override string AssemblyQualifiedName
		{
			get
			{
				return null;
			}
		}

		public override Type BaseType
		{
			get
			{
				return null;
			}
		}

		public override string FullName
		{
			get
			{
				return null;
			}
		}

		public override Guid GUID
		{
			get
			{
				return default(Guid);
			}
		}

		public override Module Module
		{
			get
			{
				return null;
			}
		}

		public override string Namespace
		{
			get
			{
				return null;
			}
		}

		public override Type UnderlyingSystemType
		{
			get
			{
				return null;
			}
		}

		public override string Name
		{
			get
			{
				return null;
			}
		}

		internal static TypeInfo FromType(Type type)
		{
			return null;
		}

		private TypeInfo(Type underlyingType)
		{
		}

		public T GetCustomAttribute<T>(bool inherit) where T : Attribute
		{
			return null;
		}

		public T GetCustomAttribute<T>() where T : Attribute
		{
			return null;
		}

		protected override TypeAttributes GetAttributeFlagsImpl()
		{
			return default(TypeAttributes);
		}

		protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
		{
			return null;
		}

		public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr)
		{
			return null;
		}

		public override Type GetElementType()
		{
			return null;
		}

		public override EventInfo GetEvent(string name, BindingFlags bindingAttr)
		{
			return null;
		}

		public override EventInfo[] GetEvents(BindingFlags bindingAttr)
		{
			return null;
		}

		public override FieldInfo GetField(string name, BindingFlags bindingAttr)
		{
			return null;
		}

		public override FieldInfo[] GetFields(BindingFlags bindingAttr)
		{
			return null;
		}

		public override Type GetInterface(string name, bool ignoreCase)
		{
			return null;
		}

		public override Type[] GetInterfaces()
		{
			return null;
		}

		public override MemberInfo[] GetMembers(BindingFlags bindingAttr)
		{
			return null;
		}

		protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
		{
			return null;
		}

		public override MethodInfo[] GetMethods(BindingFlags bindingAttr)
		{
			return null;
		}

		public override Type GetNestedType(string name, BindingFlags bindingAttr)
		{
			return null;
		}

		public override Type[] GetNestedTypes(BindingFlags bindingAttr)
		{
			return null;
		}

		public override PropertyInfo[] GetProperties(BindingFlags bindingAttr)
		{
			return null;
		}

		protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers)
		{
			return null;
		}

		protected override bool HasElementTypeImpl()
		{
			return false;
		}

		public override object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters)
		{
			return null;
		}

		protected override bool IsArrayImpl()
		{
			return false;
		}

		protected override bool IsByRefImpl()
		{
			return false;
		}

		protected override bool IsCOMObjectImpl()
		{
			return false;
		}

		protected override bool IsPointerImpl()
		{
			return false;
		}

		protected override bool IsPrimitiveImpl()
		{
			return false;
		}

		public override object[] GetCustomAttributes(Type attributeType, bool inherit)
		{
			return null;
		}

		public override object[] GetCustomAttributes(bool inherit)
		{
			return null;
		}

		public override bool IsDefined(Type attributeType, bool inherit)
		{
			return false;
		}
	}
}
