using System;
using ParadoxNotion.Serialization.FullSerializer;

namespace ParadoxNotion.Serialization
{
	public class fsRecoveryProcessor<TCanProcess, TMissing> : fsObjectProcessor where TMissing : IMissingRecoverable, TCanProcess
	{
		public override bool CanProcess(Type type)
		{
			return false;
		}

		public override void OnBeforeDeserialize(Type storageType, ref fsData data)
		{
		}
	}
}
