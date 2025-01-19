using System;
using System.Reflection;

namespace Mono.Cecil.Cil
{
	internal static class SymbolProvider
	{
		private static readonly string symbol_kind;

		private static ISymbolReaderProvider reader_provider;

		private static AssemblyName GetPlatformSymbolAssemblyName()
		{
			return null;
		}

		private static Type GetPlatformType(string fullname)
		{
			return null;
		}

		public static ISymbolReaderProvider GetPlatformReaderProvider()
		{
			return null;
		}

		private static string GetProviderTypeName(string name)
		{
			return null;
		}
	}
}
