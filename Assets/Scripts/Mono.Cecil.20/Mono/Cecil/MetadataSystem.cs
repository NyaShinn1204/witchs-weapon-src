using System.Collections.Generic;
using Mono.Cecil.Metadata;

namespace Mono.Cecil
{
	internal sealed class MetadataSystem
	{
		internal AssemblyNameReference[] AssemblyReferences;

		internal ModuleReference[] ModuleReferences;

		internal TypeDefinition[] Types;

		internal TypeReference[] TypeReferences;

		internal FieldDefinition[] Fields;

		internal MethodDefinition[] Methods;

		internal MemberReference[] MemberReferences;

		internal Dictionary<uint, uint[]> NestedTypes;

		internal Dictionary<uint, uint> ReverseNestedTypes;

		internal Dictionary<uint, MetadataToken[]> Interfaces;

		internal Dictionary<uint, Row<ushort, uint>> ClassLayouts;

		internal Dictionary<uint, uint> FieldLayouts;

		internal Dictionary<uint, uint> FieldRVAs;

		internal Dictionary<MetadataToken, uint> FieldMarshals;

		internal Dictionary<MetadataToken, Row<ElementType, uint>> Constants;

		internal Dictionary<uint, MetadataToken[]> Overrides;

		internal Dictionary<MetadataToken, Range> CustomAttributes;

		internal Dictionary<MetadataToken, Range> SecurityDeclarations;

		internal Dictionary<uint, Range> Events;

		internal Dictionary<uint, Range> Properties;

		internal Dictionary<uint, Row<MethodSemanticsAttributes, MetadataToken>> Semantics;

		internal Dictionary<uint, Row<PInvokeAttributes, uint, uint>> PInvokes;

		internal Dictionary<MetadataToken, Range> GenericParameters;

		internal Dictionary<uint, MetadataToken[]> GenericConstraints;

		private static Dictionary<string, Row<ElementType, bool>> primitive_value_types;

		private static void InitializePrimitives()
		{
		}

		public static void TryProcessPrimitiveTypeReference(TypeReference type)
		{
		}

		public static bool TryGetPrimitiveElementType(TypeDefinition type, out ElementType etype)
		{
			etype = default(ElementType);
			return false;
		}

		private static bool TryGetPrimitiveData(TypeReference type, out Row<ElementType, bool> primitive_data)
		{
			primitive_data = null;
			return false;
		}

		public TypeDefinition GetTypeDefinition(uint rid)
		{
			return null;
		}

		public void AddTypeDefinition(TypeDefinition type)
		{
		}

		public TypeReference GetTypeReference(uint rid)
		{
			return null;
		}

		public void AddTypeReference(TypeReference type)
		{
		}

		public FieldDefinition GetFieldDefinition(uint rid)
		{
			return null;
		}

		public void AddFieldDefinition(FieldDefinition field)
		{
		}

		public MethodDefinition GetMethodDefinition(uint rid)
		{
			return null;
		}

		public void AddMethodDefinition(MethodDefinition method)
		{
		}

		public MemberReference GetMemberReference(uint rid)
		{
			return null;
		}

		public void AddMemberReference(MemberReference member)
		{
		}

		public bool TryGetNestedTypeMapping(TypeDefinition type, out uint[] mapping)
		{
			mapping = null;
			return false;
		}

		public void SetNestedTypeMapping(uint type_rid, uint[] mapping)
		{
		}

		public void RemoveNestedTypeMapping(TypeDefinition type)
		{
		}

		public bool TryGetReverseNestedTypeMapping(TypeDefinition type, out uint declaring)
		{
			declaring = default(uint);
			return false;
		}

		public void SetReverseNestedTypeMapping(uint nested, uint declaring)
		{
		}

		public void RemoveReverseNestedTypeMapping(TypeDefinition type)
		{
		}

		public bool TryGetInterfaceMapping(TypeDefinition type, out MetadataToken[] mapping)
		{
			mapping = null;
			return false;
		}

		public void SetInterfaceMapping(uint type_rid, MetadataToken[] mapping)
		{
		}

		public void RemoveInterfaceMapping(TypeDefinition type)
		{
		}

		public void AddPropertiesRange(uint type_rid, Range range)
		{
		}

		public bool TryGetPropertiesRange(TypeDefinition type, out Range range)
		{
			range = default(Range);
			return false;
		}

		public void RemovePropertiesRange(TypeDefinition type)
		{
		}

		public void AddEventsRange(uint type_rid, Range range)
		{
		}

		public bool TryGetEventsRange(TypeDefinition type, out Range range)
		{
			range = default(Range);
			return false;
		}

		public void RemoveEventsRange(TypeDefinition type)
		{
		}

		public bool TryGetGenericParameterRange(IGenericParameterProvider owner, out Range range)
		{
			range = default(Range);
			return false;
		}

		public void RemoveGenericParameterRange(IGenericParameterProvider owner)
		{
		}

		public bool TryGetCustomAttributeRange(ICustomAttributeProvider owner, out Range range)
		{
			range = default(Range);
			return false;
		}

		public void RemoveCustomAttributeRange(ICustomAttributeProvider owner)
		{
		}

		public bool TryGetSecurityDeclarationRange(ISecurityDeclarationProvider owner, out Range range)
		{
			range = default(Range);
			return false;
		}

		public void RemoveSecurityDeclarationRange(ISecurityDeclarationProvider owner)
		{
		}

		public bool TryGetGenericConstraintMapping(GenericParameter generic_parameter, out MetadataToken[] mapping)
		{
			mapping = null;
			return false;
		}

		public void SetGenericConstraintMapping(uint gp_rid, MetadataToken[] mapping)
		{
		}

		public void RemoveGenericConstraintMapping(GenericParameter generic_parameter)
		{
		}

		public bool TryGetOverrideMapping(MethodDefinition method, out MetadataToken[] mapping)
		{
			mapping = null;
			return false;
		}

		public void SetOverrideMapping(uint rid, MetadataToken[] mapping)
		{
		}

		public void RemoveOverrideMapping(MethodDefinition method)
		{
		}

		public TypeDefinition GetFieldDeclaringType(uint field_rid)
		{
			return null;
		}

		public TypeDefinition GetMethodDeclaringType(uint method_rid)
		{
			return null;
		}

		private static TypeDefinition BinaryRangeSearch(TypeDefinition[] types, uint rid, bool field)
		{
			return null;
		}
	}
}
