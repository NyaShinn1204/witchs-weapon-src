using System.IO;

namespace Org.BouncyCastle.Utilities.Zlib
{
	public class ZOutputStream : Stream
	{
		private const int BufferSize = 512;

		protected ZStream z;

		protected int flushLevel;

		protected byte[] buf;

		protected byte[] buf1;

		protected bool compress;

		protected Stream output;

		protected bool closed;

		public sealed override bool CanRead
		{
			get
			{
				return false;
			}
		}

		public sealed override bool CanSeek
		{
			get
			{
				return false;
			}
		}

		public sealed override bool CanWrite
		{
			get
			{
				return false;
			}
		}

		public virtual int FlushMode
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public sealed override long Length
		{
			get
			{
				return 0L;
			}
		}

		public sealed override long Position
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public virtual long TotalIn
		{
			get
			{
				return 0L;
			}
		}

		public virtual long TotalOut
		{
			get
			{
				return 0L;
			}
		}

		public ZOutputStream(Stream output)
		{
		}

		public ZOutputStream(Stream output, bool nowrap)
		{
		}

		public ZOutputStream(Stream output, ZStream z)
		{
		}

		public ZOutputStream(Stream output, int level)
		{
		}

		public ZOutputStream(Stream output, int level, bool nowrap)
		{
		}

		private static ZStream GetDefaultZStream(bool nowrap)
		{
			return null;
		}

		public override void Close()
		{
		}

		private void DoClose()
		{
		}

		public virtual void End()
		{
		}

		public virtual void Finish()
		{
		}

		public override void Flush()
		{
		}

		public sealed override int Read(byte[] buffer, int offset, int count)
		{
			return 0;
		}

		public sealed override long Seek(long offset, SeekOrigin origin)
		{
			return 0L;
		}

		public sealed override void SetLength(long value)
		{
		}

		public override void Write(byte[] b, int off, int len)
		{
		}

		public override void WriteByte(byte b)
		{
		}
	}
}
