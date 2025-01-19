using System.IO;
using System.Text;
using Mono.Cecil.Cil;
using Mono.Cecil.Metadata;
using Mono.Collections.Generic;

namespace Mono.Cecil
{
	internal static class Mixin
	{
		internal static object NoValue;

		internal static object NotResolved;

		public static uint ReadCompressedUInt32(byte[] data, ref int position)
		{
			return 0u;
		}

		public static MetadataToken GetMetadataToken(CodedIndex self, uint data)
		{
			return default(MetadataToken);
		}

		public static int GetSize(CodedIndex self, Func<Table, int> counter)
		{
			return 0;
		}

		public static void CheckName(string name)
		{
		}

		public static void ResolveConstant(IConstantProvider self, ref object constant, ModuleDefinition module)
		{
		}

		public static bool GetHasCustomAttributes(ICustomAttributeProvider self, ModuleDefinition module)
		{
			return false;
		}

		public static Collection<CustomAttribute> GetCustomAttributes(ICustomAttributeProvider self, ref Collection<CustomAttribute> variable, ModuleDefinition module)
		{
			return null;
		}

		public static bool ContainsGenericParameter(IGenericInstance self)
		{
			return false;
		}

		public static void GenericInstanceFullName(IGenericInstance self, StringBuilder builder)
		{
		}

		public static bool GetHasGenericParameters(IGenericParameterProvider self, ModuleDefinition module)
		{
			return false;
		}

		public static Collection<GenericParameter> GetGenericParameters(IGenericParameterProvider self, ref Collection<GenericParameter> collection, ModuleDefinition module)
		{
			return null;
		}

		public static bool GetHasMarshalInfo(IMarshalInfoProvider self, ModuleDefinition module)
		{
			return false;
		}

		public static MarshalInfo GetMarshalInfo(IMarshalInfoProvider self, ref MarshalInfo variable, ModuleDefinition module)
		{
			return null;
		}

		public static bool GetAttributes(uint self, uint attributes)
		{
			return false;
		}

		public static uint SetAttributes(uint self, uint attributes, bool value)
		{
			return 0u;
		}

		public static bool GetAttributes(ushort self, ushort attributes)
		{
			return false;
		}

		public static void MethodSignatureFullName(IMethodSignature self, StringBuilder builder)
		{
		}

		public static ParameterDefinition GetParameter(MethodBody self, int index)
		{
			return null;
		}

		public static VariableDefinition GetVariable(MethodBody self, int index)
		{
			return null;
		}

		public static void CheckModifier(TypeReference modifierType, TypeReference type)
		{
		}

		public static void CheckParameters(object parameters)
		{
		}

		public static bool HasImage(ModuleDefinition self)
		{
			return false;
		}

		public static bool IsCorlib(ModuleDefinition module)
		{
			return false;
		}

		public static string GetFullyQualifiedName(Stream self)
		{
			return null;
		}

		public static TargetRuntime ParseRuntime(string self)
		{
			return default(TargetRuntime);
		}

		public static bool GetHasSecurityDeclarations(ISecurityDeclarationProvider self, ModuleDefinition module)
		{
			return false;
		}

		public static Collection<SecurityDeclaration> GetSecurityDeclarations(ISecurityDeclarationProvider self, ref Collection<SecurityDeclaration> variable, ModuleDefinition module)
		{
			return null;
		}

		public static TypeDefinition GetNestedType(TypeDefinition self, string name)
		{
			return null;
		}

		public static bool IsPrimitive(ElementType self)
		{
			return false;
		}

		public static bool IsTypeOf(TypeReference self, string @namespace, string name)
		{
			return false;
		}

		public static TypeDefinition CheckedResolve(TypeReference self)
		{
			return null;
		}

		public static void CheckType(TypeReference type)
		{
		}

		public static bool IsNullOrEmpty<T>(T[] self)
		{
			return false;
		}

		public static bool IsNullOrEmpty<T>(Collection<T> self)
		{
			return false;
		}
	}
}
