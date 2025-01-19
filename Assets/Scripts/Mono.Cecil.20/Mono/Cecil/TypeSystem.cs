using System;
using Mono.Cecil.Metadata;

namespace Mono.Cecil
{
	public abstract class TypeSystem
	{
		private sealed class CoreTypeSystem : TypeSystem
		{
			public CoreTypeSystem(ModuleDefinition module)
			{
			}

			internal override TypeReference LookupType(string @namespace, string name)
			{
				return null;
			}

			private TypeReference LookupTypeDefinition(string @namespace, string name)
			{
				return null;
			}

			private TypeReference LookupTypeForwarded(string @namespace, string name)
			{
				return null;
			}

			private static void Initialize(object obj)
			{
			}
		}

		private sealed class CommonTypeSystem : TypeSystem
		{
			private AssemblyNameReference corlib;

			public CommonTypeSystem(ModuleDefinition module)
			{
			}

			internal override TypeReference LookupType(string @namespace, string name)
			{
				return null;
			}

			public AssemblyNameReference GetCorlibReference()
			{
				return null;
			}

			private Version GetCorlibVersion()
			{
				return null;
			}

			private TypeReference CreateTypeReference(string @namespace, string name)
			{
				return null;
			}
		}

		private readonly ModuleDefinition module;

		private TypeReference type_object;

		private TypeReference type_void;

		private TypeReference type_bool;

		private TypeReference type_char;

		private TypeReference type_sbyte;

		private TypeReference type_byte;

		private TypeReference type_int16;

		private TypeReference type_uint16;

		private TypeReference type_int32;

		private TypeReference type_uint32;

		private TypeReference type_int64;

		private TypeReference type_uint64;

		private TypeReference type_single;

		private TypeReference type_double;

		private TypeReference type_intptr;

		private TypeReference type_uintptr;

		private TypeReference type_string;

		private TypeReference type_typedref;

		public IMetadataScope Corlib
		{
			get
			{
				return null;
			}
		}

		public TypeReference Object
		{
			get
			{
				return null;
			}
		}

		public TypeReference Void
		{
			get
			{
				return null;
			}
		}

		public TypeReference Boolean
		{
			get
			{
				return null;
			}
		}

		public TypeReference Char
		{
			get
			{
				return null;
			}
		}

		public TypeReference SByte
		{
			get
			{
				return null;
			}
		}

		public TypeReference Byte
		{
			get
			{
				return null;
			}
		}

		public TypeReference Int16
		{
			get
			{
				return null;
			}
		}

		public TypeReference UInt16
		{
			get
			{
				return null;
			}
		}

		public TypeReference Int32
		{
			get
			{
				return null;
			}
		}

		public TypeReference UInt32
		{
			get
			{
				return null;
			}
		}

		public TypeReference Int64
		{
			get
			{
				return null;
			}
		}

		public TypeReference UInt64
		{
			get
			{
				return null;
			}
		}

		public TypeReference Single
		{
			get
			{
				return null;
			}
		}

		public TypeReference Double
		{
			get
			{
				return null;
			}
		}

		public TypeReference IntPtr
		{
			get
			{
				return null;
			}
		}

		public TypeReference UIntPtr
		{
			get
			{
				return null;
			}
		}

		public TypeReference String
		{
			get
			{
				return null;
			}
		}

		public TypeReference TypedReference
		{
			get
			{
				return null;
			}
		}

		private TypeSystem(ModuleDefinition module)
		{
		}

		internal static TypeSystem CreateTypeSystem(ModuleDefinition module)
		{
			return null;
		}

		internal abstract TypeReference LookupType(string @namespace, string name);

		private TypeReference LookupSystemType(ref TypeReference typeRef, string name, ElementType element_type)
		{
			return null;
		}

		private TypeReference LookupSystemValueType(ref TypeReference typeRef, string name, ElementType element_type)
		{
			return null;
		}
	}
}
