using System;

namespace Google.Impl
{
	internal class NativeFuture : BaseObject, FutureAPIImpl<GoogleSignInUser>
	{
		public bool Pending
		{
			get
			{
				return false;
			}
		}

		public GoogleSignInUser Result
		{
			get
			{
				return null;
			}
		}

		public GoogleSignInStatusCode Status
		{
			get
			{
				return default(GoogleSignInStatusCode);
			}
		}

		internal NativeFuture(IntPtr ptr)
			: base((IntPtr)0)
		{
		}

		public override void Dispose()
		{
		}
	}
}
