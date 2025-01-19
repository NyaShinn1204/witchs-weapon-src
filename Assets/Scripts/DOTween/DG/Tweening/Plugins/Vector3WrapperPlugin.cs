using DG.Tweening.Core;
using DG.Tweening.Core.Enums;
using DG.Tweening.Core.Surrogates;
using DG.Tweening.Plugins.Core;
using DG.Tweening.Plugins.Options;

namespace DG.Tweening.Plugins
{
	public class Vector3WrapperPlugin : ABSTweenPlugin<Vector3Wrapper, Vector3Wrapper, VectorOptions>
	{
		public override void Reset(TweenerCore<Vector3Wrapper, Vector3Wrapper, VectorOptions> t)
		{
		}

		public override void SetFrom(TweenerCore<Vector3Wrapper, Vector3Wrapper, VectorOptions> t, bool isRelative)
		{
		}

		public override Vector3Wrapper ConvertToStartValue(TweenerCore<Vector3Wrapper, Vector3Wrapper, VectorOptions> t, Vector3Wrapper value)
		{
			return default(Vector3Wrapper);
		}

		public override void SetRelativeEndValue(TweenerCore<Vector3Wrapper, Vector3Wrapper, VectorOptions> t)
		{
		}

		public override void SetChangeValue(TweenerCore<Vector3Wrapper, Vector3Wrapper, VectorOptions> t)
		{
		}

		public override float GetSpeedBasedDuration(VectorOptions options, float unitsXSecond, Vector3Wrapper changeValue)
		{
			return 0f;
		}

		public override void EvaluateAndApply(VectorOptions options, Tween t, bool isRelative, DOGetter<Vector3Wrapper> getter, DOSetter<Vector3Wrapper> setter, float elapsed, Vector3Wrapper startValue, Vector3Wrapper changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice)
		{
		}
	}
}
