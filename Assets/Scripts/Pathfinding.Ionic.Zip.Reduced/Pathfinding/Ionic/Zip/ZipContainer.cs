using System.IO;
using System.Text;
using Pathfinding.Ionic.Zlib;

namespace Pathfinding.Ionic.Zip
{
	internal class ZipContainer
	{
		private ZipFile _zf;

		private ZipOutputStream _zos;

		private ZipInputStream _zis;

		public ZipFile ZipFile
		{
			get
			{
				return null;
			}
		}

		public ZipOutputStream ZipOutputStream
		{
			get
			{
				return null;
			}
		}

		public string Password
		{
			get
			{
				return null;
			}
		}

		public Zip64Option Zip64
		{
			get
			{
				return default(Zip64Option);
			}
		}

		public int BufferSize
		{
			get
			{
				return 0;
			}
		}

		public ParallelDeflateOutputStream ParallelDeflater
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public long ParallelDeflateThreshold
		{
			get
			{
				return 0L;
			}
		}

		public int ParallelDeflateMaxBufferPairs
		{
			get
			{
				return 0;
			}
		}

		public int CodecBufferSize
		{
			get
			{
				return 0;
			}
		}

		public CompressionStrategy Strategy
		{
			get
			{
				return default(CompressionStrategy);
			}
		}

		public Zip64Option UseZip64WhenSaving
		{
			get
			{
				return default(Zip64Option);
			}
		}

		public Encoding AlternateEncoding
		{
			get
			{
				return null;
			}
		}

		public Encoding DefaultEncoding
		{
			get
			{
				return null;
			}
		}

		public ZipOption AlternateEncodingUsage
		{
			get
			{
				return default(ZipOption);
			}
		}

		public Stream ReadStream
		{
			get
			{
				return null;
			}
		}

		public ZipContainer(object o)
		{
		}
	}
}
