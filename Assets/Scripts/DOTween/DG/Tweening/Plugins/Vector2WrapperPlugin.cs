using DG.Tweening.Core;
using DG.Tweening.Core.Enums;
using DG.Tweening.Core.Surrogates;
using DG.Tweening.Plugins.Core;
using DG.Tweening.Plugins.Options;

namespace DG.Tweening.Plugins
{
	public class Vector2WrapperPlugin : ABSTweenPlugin<Vector2Wrapper, Vector2Wrapper, VectorOptions>
	{
		public override void Reset(TweenerCore<Vector2Wrapper, Vector2Wrapper, VectorOptions> t)
		{
		}

		public override void SetFrom(TweenerCore<Vector2Wrapper, Vector2Wrapper, VectorOptions> t, bool isRelative)
		{
		}

		public override Vector2Wrapper ConvertToStartValue(TweenerCore<Vector2Wrapper, Vector2Wrapper, VectorOptions> t, Vector2Wrapper value)
		{
			return default(Vector2Wrapper);
		}

		public override void SetRelativeEndValue(TweenerCore<Vector2Wrapper, Vector2Wrapper, VectorOptions> t)
		{
		}

		public override void SetChangeValue(TweenerCore<Vector2Wrapper, Vector2Wrapper, VectorOptions> t)
		{
		}

		public override float GetSpeedBasedDuration(VectorOptions options, float unitsXSecond, Vector2Wrapper changeValue)
		{
			return 0f;
		}

		public override void EvaluateAndApply(VectorOptions options, Tween t, bool isRelative, DOGetter<Vector2Wrapper> getter, DOSetter<Vector2Wrapper> setter, float elapsed, Vector2Wrapper startValue, Vector2Wrapper changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice)
		{
		}
	}
}
