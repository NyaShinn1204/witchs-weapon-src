using System.IO;
using System.Runtime.CompilerServices;
using Pathfinding.Ionic.Crc;

namespace Pathfinding.Ionic.Zip
{
	public class ZipInputStream : Stream
	{
		private Stream _inputStream;

		private ZipEntry _currentEntry;

		private bool _needSetup;

		private CrcCalculatorStream _crcStream;

		private long _LeftToRead;

		internal string _Password;

		private long _endOfEntry;

		private string _name;

		private bool _leaveUnderlyingStreamOpen;

		private bool _closed;

		private bool _findRequired;

		private bool _exceptionPending;

		[CompilerGenerated]
		private int _003CCodecBufferSize_003Ek__BackingField;

		public int CodecBufferSize
		{
			[CompilerGenerated]
			get
			{
				return _003CCodecBufferSize_003Ek__BackingField;
			}
		}

		internal Stream ReadStream
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

		private void SetupStream()
		{
		}

		public override int Read(byte[] buffer, int offset, int count)
		{
			return 0;
		}

		protected override void Dispose(bool disposing)
		{
		}

		public override void Flush()
		{
		}

		public override void Write(byte[] buffer, int offset, int count)
		{
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
