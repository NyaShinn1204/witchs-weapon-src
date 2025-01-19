using DG.Tweening.Core;
using DG.Tweening.Core.Enums;
using DG.Tweening.Core.Surrogates;
using DG.Tweening.Plugins.Core;
using DG.Tweening.Plugins.Options;

namespace DG.Tweening.Plugins
{
	public class Vector4WrapperPlugin : ABSTweenPlugin<Vector4Wrapper, Vector4Wrapper, VectorOptions>
	{
		public override void Reset(TweenerCore<Vector4Wrapper, Vector4Wrapper, VectorOptions> t)
		{
		}

		public override void SetFrom(TweenerCore<Vector4Wrapper, Vector4Wrapper, VectorOptions> t, bool isRelative)
		{
		}

		public override Vector4Wrapper ConvertToStartValue(TweenerCore<Vector4Wrapper, Vector4Wrapper, VectorOptions> t, Vector4Wrapper value)
		{
			return default(Vector4Wrapper);
		}

		public override void SetRelativeEndValue(TweenerCore<Vector4Wrapper, Vector4Wrapper, VectorOptions> t)
		{
		}

		public override void SetChangeValue(TweenerCore<Vector4Wrapper, Vector4Wrapper, VectorOptions> t)
		{
		}

		public override float GetSpeedBasedDuration(VectorOptions options, float unitsXSecond, Vector4Wrapper changeValue)
		{
			return 0f;
		}

		public override void EvaluateAndApply(VectorOptions options, Tween t, bool isRelative, DOGetter<Vector4Wrapper> getter, DOSetter<Vector4Wrapper> setter, float elapsed, Vector4Wrapper startValue, Vector4Wrapper changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice)
		{
		}
	}
}
