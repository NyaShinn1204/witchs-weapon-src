using System.Collections;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Google
{
	public class Future<T>
	{
		private FutureAPIImpl<T> apiImpl;

		public bool Pending
		{
			get
			{
				return false;
			}
		}

		private GoogleSignInStatusCode Status
		{
			get
			{
				return default(GoogleSignInStatusCode);
			}
		}

		private T Result
		{
			get
			{
				return default(T);
			}
		}

		internal Future(FutureAPIImpl<T> impl)
		{
		}

		[DebuggerHidden]
		internal IEnumerator WaitForResult(TaskCompletionSource<T> tcs)
		{
			return null;
		}
	}
}
