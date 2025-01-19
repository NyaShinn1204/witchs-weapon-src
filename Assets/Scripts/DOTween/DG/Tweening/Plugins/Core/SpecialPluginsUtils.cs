using DG.Tweening.Core;
using DG.Tweening.Core.Surrogates;
using DG.Tweening.Plugins.Options;
using UnityEngine;

namespace DG.Tweening.Plugins.Core
{
	internal static class SpecialPluginsUtils
	{
		internal static bool SetLookAt(TweenerCore<QuaternionWrapper, Vector3Wrapper, QuaternionOptions> t)
		{
			return false;
		}

		internal static bool SetPunch(TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t)
		{
			return false;
		}

		internal static bool SetShake(TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t)
		{
			return false;
		}

		internal static bool SetCameraShakePosition(TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t)
		{
			return false;
		}
	}
}
