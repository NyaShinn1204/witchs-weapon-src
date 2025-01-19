using System.IO;

namespace Org.BouncyCastle.Utilities.IO
{
	public abstract class BaseInputStream : Stream
	{
		private bool closed;

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

		public override void Close()
		{
		}

		public sealed override void Flush()
		{
		}

		public override int Read(byte[] buffer, int offset, int count)
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

		public sealed override void Write(byte[] buffer, int offset, int count)
		{
		}
	}
}
