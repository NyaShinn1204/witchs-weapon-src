using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using Pathfinding.Ionic.Crc;
using Pathfinding.Ionic.Zlib;

namespace Pathfinding.Ionic.Zip
{
	public class ZipOutputStream : Stream
	{
		internal string _password;

		private string _comment;

		private Stream _outputStream;

		private ZipEntry _currentEntry;

		internal Zip64Option _zip64;

		private Dictionary<string, ZipEntry> _entriesWritten;

		private int _entryCount;

		private ZipOption _alternateEncodingUsage;

		private Encoding _alternateEncoding;

		private bool _leaveUnderlyingStreamOpen;

		private bool _disposed;

		private bool _exceptionPending;

		private bool _anyEntriesUsedZip64;

		private bool _directoryNeededZip64;

		private CountingStream _outputCounter;

		private Stream _encryptor;

		private Stream _deflater;

		private CrcCalculatorStream _entryOutputStream;

		private bool _needToWriteEntryHeader;

		private string _name;

		internal ParallelDeflateOutputStream ParallelDeflater;

		private long _ParallelDeflateThreshold;

		private int _maxBufferPairs;

		[CompilerGenerated]
		private int _003CCodecBufferSize_003Ek__BackingField;

		[CompilerGenerated]
		private CompressionStrategy _003CStrategy_003Ek__BackingField;

		public int CodecBufferSize
		{
			[CompilerGenerated]
			get
			{
				return _003CCodecBufferSize_003Ek__BackingField;
			}
		}

		public CompressionStrategy Strategy
		{
			[CompilerGenerated]
			get
			{
				return _003CStrategy_003Ek__BackingField;
			}
		}

		public string Comment
		{
			get
			{
				return null;
			}
		}

		public Zip64Option EnableZip64
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

		public ZipOption AlternateEncodingUsage
		{
			get
			{
				return default(ZipOption);
			}
		}

		public static Encoding DefaultEncoding
		{
			get
			{
				return null;
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

		internal Stream OutputStream
		{
			get
			{
				return null;
			}
		}

		public override bool CanRead
		{
			get
			{
				return false;
			}
		}

		public override bool CanSeek
		{
			get
			{
				return false;
			}
		}

		public override bool CanWrite
		{
			get
			{
				return false;
			}
		}

		public override long Length
		{
			get
			{
				return 0L;
			}
		}

		public override long Position
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public override string ToString()
		{
			return null;
		}

		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		private void _InitiateCurrentEntry(bool finishing)
		{
		}

		private void _FinishCurrentEntry()
		{
		}

		protected override void Dispose(bool disposing)
		{
		}

		public override void Flush()
		{
		}

		public override int Read(byte[] buffer, int offset, int count)
		{
			return 0;
		}

		public override long Seek(long offset, SeekOrigin origin)
		{
			return 0L;
		}

		public override void SetLength(long value)
		{
		}
	}
}
