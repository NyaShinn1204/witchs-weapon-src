using Mono.Cecil.PE;
using Mono.Collections.Generic;

namespace Mono.Cecil
{
	internal sealed class ImmediateModuleReader : ModuleReader
	{
		public ImmediateModuleReader(Image image)
			: base(null, default(ReadingMode))
		{
		}

		protected override void ReadModule()
		{
		}

		public static void ReadModule(ModuleDefinition module)
		{
		}

		private static void ReadTypes(Collection<TypeDefinition> types)
		{
		}

		private static void ReadType(TypeDefinition type)
		{
		}

		private static void ReadGenericParameters(IGenericParameterProvider provider)
		{
		}

		private static void ReadSecurityDeclarations(ISecurityDeclarationProvider provider)
		{
		}

		private static void ReadCustomAttributes(ICustomAttributeProvider provider)
		{
		}

		private static void ReadFields(TypeDefinition type)
		{
		}

		private static void ReadMethods(TypeDefinition type)
		{
		}

		private static void ReadParameters(MethodDefinition method)
		{
		}

		private static void ReadProperties(TypeDefinition type)
		{
		}

		private static void ReadEvents(TypeDefinition type)
		{
		}

		private static void Read(object collection)
		{
		}
	}
}
