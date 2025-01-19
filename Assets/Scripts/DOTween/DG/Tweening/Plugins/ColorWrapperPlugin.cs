using DG.Tweening.Core;
using DG.Tweening.Core.Enums;
using DG.Tweening.Core.Surrogates;
using DG.Tweening.Plugins.Core;
using DG.Tweening.Plugins.Options;

namespace DG.Tweening.Plugins
{
	public class ColorWrapperPlugin : ABSTweenPlugin<ColorWrapper, ColorWrapper, ColorOptions>
	{
		public override void Reset(TweenerCore<ColorWrapper, ColorWrapper, ColorOptions> t)
		{
		}

		public override void SetFrom(TweenerCore<ColorWrapper, ColorWrapper, ColorOptions> t, bool isRelative)
		{
		}

		public override ColorWrapper ConvertToStartValue(TweenerCore<ColorWrapper, ColorWrapper, ColorOptions> t, ColorWrapper value)
		{
			return default(ColorWrapper);
		}

		public override void SetRelativeEndValue(TweenerCore<ColorWrapper, ColorWrapper, ColorOptions> t)
		{
		}

		public override void SetChangeValue(TweenerCore<ColorWrapper, ColorWrapper, ColorOptions> t)
		{
		}

		public override float GetSpeedBasedDuration(ColorOptions options, float unitsXSecond, ColorWrapper changeValue)
		{
			return 0f;
		}

		public override void EvaluateAndApply(ColorOptions options, Tween t, bool isRelative, DOGetter<ColorWrapper> getter, DOSetter<ColorWrapper> setter, float elapsed, ColorWrapper startValue, ColorWrapper changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice)
		{
		}
	}
}
