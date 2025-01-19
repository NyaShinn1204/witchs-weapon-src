using System.IO;
using System.Threading;

public sealed class UploadStream : Stream
{
	private MemoryStream ReadBuffer;

	private MemoryStream WriteBuffer;

	private bool noMoreData;

	private AutoResetEvent ARE;

	private object locker;

	public string Name { get; private set; }

	private bool IsReadBufferEmpty
	{
		get
		{
			return false;
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

	public UploadStream(string name)
	{
	}

	public UploadStream()
	{
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		return 0;
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
	}

	public override void Flush()
	{
	}

	protected override void Dispose(bool disposing)
	{
	}

	public void Finish()
	{
	}

	private bool SwitchBuffers()
	{
		return false;
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		return 0L;
	}

	public override void SetLength(long value)
	{
	}
}
