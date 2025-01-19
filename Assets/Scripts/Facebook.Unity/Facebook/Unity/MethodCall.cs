using System.Runtime.CompilerServices;

namespace Facebook.Unity
{
	internal abstract class MethodCall<T> where T : IResult
	{
		public string MethodName { get; private set; }

		public FacebookDelegate<T> Callback { protected get; set; }

		protected FacebookBase FacebookImpl
		{
			[CompilerGenerated]
			set
			{
				_003CFacebookImpl_003Ek__BackingField = value;
			}
		}

		protected MethodArguments Parameters
		{
			[CompilerGenerated]
			set
			{
				_003CParameters_003Ek__BackingField = value;
			}
		}

		public MethodCall(FacebookBase facebookImpl, string methodName)
		{
		}

		public abstract void Call(MethodArguments args = null);
	}
}
