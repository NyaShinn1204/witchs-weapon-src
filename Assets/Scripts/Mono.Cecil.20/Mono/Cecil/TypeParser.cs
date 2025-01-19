namespace Mono.Cecil
{
	internal class TypeParser
	{
		private class Type
		{
			public string type_fullname;

			public string[] nested_names;

			public int arity;

			public int[] specs;

			public Type[] generic_arguments;

			public string assembly;
		}

		private readonly string fullname;

		private readonly int length;

		private int position;

		private TypeParser(string fullname)
		{
		}

		private Type ParseType(bool fq_name)
		{
			return null;
		}

		private static bool TryGetArity(Type type)
		{
			return false;
		}

		private static bool TryGetArity(string name, out int arity)
		{
			arity = default(int);
			return false;
		}

		private static bool ParseInt32(string value, out int result)
		{
			result = default(int);
			return false;
		}

		private static void TryAddArity(string name, ref int arity)
		{
		}

		private string ParsePart()
		{
			return null;
		}

		private static bool IsDelimiter(char chr)
		{
			return false;
		}

		private void TryParseWhiteSpace()
		{
		}

		private string[] ParseNestedNames()
		{
			return null;
		}

		private bool TryParse(char chr)
		{
			return false;
		}

		private static void Add<T>(ref T[] array, T item)
		{
		}

		private int[] ParseSpecs()
		{
			return null;
		}

		private Type[] ParseGenericArguments(int arity)
		{
			return null;
		}

		private string ParseAssemblyName()
		{
			return null;
		}

		public static TypeReference ParseType(ModuleDefinition module, string fullname)
		{
			return null;
		}

		private static TypeReference GetTypeReference(ModuleDefinition module, Type type_info)
		{
			return null;
		}

		private static TypeReference CreateSpecs(TypeReference type, Type type_info)
		{
			return null;
		}

		private static TypeReference TryCreateGenericInstanceType(TypeReference type, Type type_info)
		{
			return null;
		}

		public static void SplitFullName(string fullname, out string @namespace, out string name)
		{
			@namespace = null;
			name = null;
		}

		private static TypeReference CreateReference(Type type_info, ModuleDefinition module, IMetadataScope scope)
		{
			return null;
		}

		private static void AdjustGenericParameters(TypeReference type)
		{
		}

		private static IMetadataScope GetMetadataScope(ModuleDefinition module, Type type_info)
		{
			return null;
		}

		private static AssemblyNameReference MatchReference(ModuleDefinition module, AssemblyNameReference pattern)
		{
			return null;
		}

		private static bool TryGetDefinition(ModuleDefinition module, Type type_info, out TypeReference type)
		{
			type = null;
			return false;
		}

		private static bool TryCurrentModule(ModuleDefinition module, Type type_info)
		{
			return false;
		}
	}
}
