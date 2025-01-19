using ParadoxNotion.Design;
using ParadoxNotion.Serialization;
using ParadoxNotion.Serialization.FullSerializer;

namespace NodeCanvas.Framework.Internal
{
	[DoNotList]
	public class MissingAction : ActionTask, IMissingRecoverable
	{
		[fsProperty]
		public string missingType { get; set; }

		[fsProperty]
		public string recoveryState { get; set; }

		protected override string info
		{
			get
			{
				return null;
			}
		}
	}
}
