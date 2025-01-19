using System.IO;

namespace System.Threading.Tasks
{
	public static class TaskExtensions
	{
		public static Task Unwrap(this Task<Task> task)
		{
			return null;
		}

		public static Task<T> Unwrap<T>(this Task<Task<T>> task)
		{
			return null;
		}

		public static Task CopyToAsync(this Stream stream, Stream destination)
		{
			return null;
		}

		public static Task CopyToAsync(this Stream stream, Stream destination, int bufferSize, CancellationToken cancellationToken)
		{
			return null;
		}

		public static Task<int> ReadAsync(this Stream stream, byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			return null;
		}

		public static Task WriteAsync(this Stream stream, byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			return null;
		}
	}
}
