using DG.Tweening.Core;
using DG.Tweening.Core.Enums;
using DG.Tweening.Core.Surrogates;
using DG.Tweening.Plugins.Core;
using DG.Tweening.Plugins.Options;

namespace DG.Tweening.Plugins
{
	public class QuaternionWrapperPlugin : ABSTweenPlugin<QuaternionWrapper, Vector3Wrapper, QuaternionOptions>
	{
		public override void Reset(TweenerCore<QuaternionWrapper, Vector3Wrapper, QuaternionOptions> t)
		{
		}

		public override void SetFrom(TweenerCore<QuaternionWrapper, Vector3Wrapper, QuaternionOptions> t, bool isRelative)
		{
		}

		public override Vector3Wrapper ConvertToStartValue(TweenerCore<QuaternionWrapper, Vector3Wrapper, QuaternionOptions> t, QuaternionWrapper value)
		{
			return default(Vector3Wrapper);
		}

		public override void SetRelativeEndValue(TweenerCore<QuaternionWrapper, Vector3Wrapper, QuaternionOptions> t)
		{
		}

		public override void SetChangeValue(TweenerCore<QuaternionWrapper, Vector3Wrapper, QuaternionOptions> t)
		{
		}

		public override float GetSpeedBasedDuration(QuaternionOptions options, float unitsXSecond, Vector3Wrapper changeValue)
		{
			return 0f;
		}

		public override void EvaluateAndApply(QuaternionOptions options, Tween t, bool isRelative, DOGetter<QuaternionWrapper> getter, DOSetter<QuaternionWrapper> setter, float elapsed, Vector3Wrapper startValue, Vector3Wrapper changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice)
		{
		}
	}
}
