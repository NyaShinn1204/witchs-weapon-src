using System.IO;
using Mono.Cecil.Cil;

namespace Mono.Cecil
{
	public sealed class ReaderParameters
	{
		private ReadingMode reading_mode;

		private IAssemblyResolver assembly_resolver;

		private IMetadataResolver metadata_resolver;

		private Stream symbol_stream;

		private ISymbolReaderProvider symbol_reader_provider;

		private bool read_symbols;

		public ReadingMode ReadingMode
		{
			get
			{
				return default(ReadingMode);
			}
			set
			{
			}
		}

		public IAssemblyResolver AssemblyResolver
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public IMetadataResolver MetadataResolver
		{
			get
			{
				return null;
			}
		}

		public Stream SymbolStream
		{
			get
			{
				return null;
			}
		}

		public ISymbolReaderProvider SymbolReaderProvider
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool ReadSymbols
		{
			get
			{
				return false;
			}
		}

		public ReaderParameters()
		{
		}

		public ReaderParameters(ReadingMode readingMode)
		{
		}
	}
}
