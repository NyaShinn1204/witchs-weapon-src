using System;
using System.IO;
using Mono.Cecil.Cil;
using Mono.Cecil.PE;
using Mono.Collections.Generic;

namespace Mono.Cecil
{
	public sealed class ModuleDefinition : ModuleReference, ICustomAttributeProvider, IMetadataTokenProvider
	{
		internal Image Image;

		internal MetadataSystem MetadataSystem;

		internal ReadingMode ReadingMode;

		internal ISymbolReaderProvider SymbolReaderProvider;

		internal ISymbolReader symbol_reader;

		internal IAssemblyResolver assembly_resolver;

		internal IMetadataResolver metadata_resolver;

		internal TypeSystem type_system;

		private readonly MetadataReader reader;

		private readonly string fq_name;

		internal ModuleKind kind;

		private TargetRuntime runtime;

		private TargetArchitecture architecture;

		private ModuleAttributes attributes;

		private ModuleCharacteristics characteristics;

		private Guid mvid;

		internal AssemblyDefinition assembly;

		private MethodDefinition entry_point;

		private Collection<CustomAttribute> custom_attributes;

		private Collection<AssemblyNameReference> references;

		private Collection<ModuleReference> modules;

		private Collection<Resource> resources;

		private Collection<ExportedType> exported_types;

		private TypeDefinitionCollection types;

		private readonly object module_lock;

		public TargetRuntime Runtime
		{
			get
			{
				return default(TargetRuntime);
			}
		}

		public string FullyQualifiedName
		{
			get
			{
				return null;
			}
		}

		public Guid Mvid
		{
			set
			{
			}
		}

		internal bool HasImage
		{
			get
			{
				return false;
			}
		}

		public override MetadataScopeType MetadataScopeType
		{
			get
			{
				return default(MetadataScopeType);
			}
		}

		public AssemblyDefinition Assembly
		{
			get
			{
				return null;
			}
		}

		public IAssemblyResolver AssemblyResolver
		{
			get
			{
				return null;
			}
		}

		public IMetadataResolver MetadataResolver
		{
			get
			{
				return null;
			}
		}

		public TypeSystem TypeSystem
		{
			get
			{
				return null;
			}
		}

		public bool HasAssemblyReferences
		{
			get
			{
				return false;
			}
		}

		public Collection<AssemblyNameReference> AssemblyReferences
		{
			get
			{
				return null;
			}
		}

		public bool HasModuleReferences
		{
			get
			{
				return false;
			}
		}

		public Collection<ModuleReference> ModuleReferences
		{
			get
			{
				return null;
			}
		}

		public bool HasResources
		{
			get
			{
				return false;
			}
		}

		public Collection<Resource> Resources
		{
			get
			{
				return null;
			}
		}

		public bool HasCustomAttributes
		{
			get
			{
				return false;
			}
		}

		public Collection<CustomAttribute> CustomAttributes
		{
			get
			{
				return null;
			}
		}

		public bool HasTypes
		{
			get
			{
				return false;
			}
		}

		public Collection<TypeDefinition> Types
		{
			get
			{
				return null;
			}
		}

		public bool HasExportedTypes
		{
			get
			{
				return false;
			}
		}

		public Collection<ExportedType> ExportedTypes
		{
			get
			{
				return null;
			}
		}

		internal object SyncRoot
		{
			get
			{
				return null;
			}
		}

		public bool HasDebugHeader
		{
			get
			{
				return false;
			}
		}

		internal ModuleDefinition()
		{
		}

		internal ModuleDefinition(Image image)
		{
		}

		public TypeDefinition GetType(string fullName)
		{
			return null;
		}

		public TypeDefinition GetType(string @namespace, string name)
		{
			return null;
		}

		private static void CheckFullName(string fullName)
		{
		}

		private TypeDefinition GetNestedType(string fullname)
		{
			return null;
		}

		internal TypeDefinition Resolve(TypeReference type)
		{
			return null;
		}

		internal TRet Read<TItem, TRet>(TItem item, Func<TItem, MetadataReader, TRet> read)
		{
			return default(TRet);
		}

		internal TRet Read<TItem, TRet>(ref TRet variable, TItem item, Func<TItem, MetadataReader, TRet> read) where TRet : class
		{
			return null;
		}

		public ImageDebugDirectory GetDebugHeader(out byte[] header)
		{
			header = null;
			return default(ImageDebugDirectory);
		}

		private void ProcessDebugHeader()
		{
		}

		public void ReadSymbols(ISymbolReader reader)
		{
		}

		public static ModuleDefinition ReadModule(Stream stream)
		{
			return null;
		}

		public static ModuleDefinition ReadModule(string fileName, ReaderParameters parameters)
		{
			return null;
		}

		private static void CheckStream(object stream)
		{
		}

		public static ModuleDefinition ReadModule(Stream stream, ReaderParameters parameters)
		{
			return null;
		}

		private static Stream GetFileStream(string fileName, FileMode mode, FileAccess access, FileShare share)
		{
			return null;
		}
	}
}
