using DG.Tweening.Core;
using DG.Tweening.Plugins.Core.PathCore;
using DG.Tweening.Plugins.Options;
using UnityEngine;

namespace DG.Tweening
{
	public static class ShortcutExtensions
	{
		public static Tweener DOFade(this AudioSource target, float endValue, float duration)
		{
			return null;
		}

		public static Tweener DOPitch(this AudioSource target, float endValue, float duration)
		{
			return null;
		}

		public static Tweener DOAspect(this Camera target, float endValue, float duration)
		{
			return null;
		}

		public static Tweener DOColor(this Camera target, Color endValue, float duration)
		{
			return null;
		}

		public static Tweener DOFarClipPlane(this Camera target, float endValue, float duration)
		{
			return null;
		}

		public static Tweener DOFieldOfView(this Camera target, float endValue, float duration)
		{
			return null;
		}

		public static Tweener DONearClipPlane(this Camera target, float endValue, float duration)
		{
			return null;
		}

		public static Tweener DOOrthoSize(this Camera target, float endValue, float duration)
		{
			return null;
		}

		public static Tweener DOPixelRect(this Camera target, Rect endValue, float duration)
		{
			return null;
		}

		public static Tweener DORect(this Camera target, Rect endValue, float duration)
		{
			return null;
		}

		public static Tweener DOShakePosition(this Camera target, float duration, float strength = 3f, int vibrato = 10, float randomness = 90f, bool fadeOut = true)
		{
			return null;
		}

		public static Tweener DOShakePosition(this Camera target, float duration, Vector3 strength, int vibrato = 10, float randomness = 90f, bool fadeOut = true)
		{
			return null;
		}

		public static Tweener DOShakeRotation(this Camera target, float duration, float strength = 90f, int vibrato = 10, float randomness = 90f, bool fadeOut = true)
		{
			return null;
		}

		public static Tweener DOShakeRotation(this Camera target, float duration, Vector3 strength, int vibrato = 10, float randomness = 90f, bool fadeOut = true)
		{
			return null;
		}

		public static Tweener DOColor(this Light target, Color endValue, float duration)
		{
			return null;
		}

		public static Tweener DOIntensity(this Light target, float endValue, float duration)
		{
			return null;
		}

		public static Tweener DOShadowStrength(this Light target, float endValue, float duration)
		{
			return null;
		}

		public static Tweener DOColor(this LineRenderer target, Color2 startValue, Color2 endValue, float duration)
		{
			return null;
		}

		public static Tweener DOColor(this Material target, Color endValue, float duration)
		{
			return null;
		}

		public static Tweener DOColor(this Material target, Color endValue, string property, float duration)
		{
			return null;
		}

		public static Tweener DOFade(this Material target, float endValue, float duration)
		{
			return null;
		}

		public static Tweener DOFade(this Material target, float endValue, string property, float duration)
		{
			return null;
		}

		public static Tweener DOFloat(this Material target, float endValue, string property, float duration)
		{
			return null;
		}

		public static Tweener DOOffset(this Material target, Vector2 endValue, float duration)
		{
			return null;
		}

		public static Tweener DOOffset(this Material target, Vector2 endValue, string property, float duration)
		{
			return null;
		}

		public static Tweener DOTiling(this Material target, Vector2 endValue, float duration)
		{
			return null;
		}

		public static Tweener DOTiling(this Material target, Vector2 endValue, string property, float duration)
		{
			return null;
		}

		public static Tweener DOVector(this Material target, Vector4 endValue, string property, float duration)
		{
			return null;
		}

		public static Tweener DOMove(this Rigidbody target, Vector3 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		public static Tweener DOMoveX(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		public static Tweener DOMoveY(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		public static Tweener DOMoveZ(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		public static Tweener DORotate(this Rigidbody target, Vector3 endValue, float duration, RotateMode mode = RotateMode.Fast)
		{
			return null;
		}

		public static Tweener DOLookAt(this Rigidbody target, Vector3 towards, float duration, AxisConstraint axisConstraint = AxisConstraint.None, Vector3? up = null)
		{
			return null;
		}

		public static Sequence DOJump(this Rigidbody target, Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		public static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, Color? gizmoColor = null)
		{
			return null;
		}

		public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, Color? gizmoColor = null)
		{
			return null;
		}

		internal static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}

		internal static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}

		public static Tweener DOResize(this TrailRenderer target, float toStartWidth, float toEndWidth, float duration)
		{
			return null;
		}

		public static Tweener DOTime(this TrailRenderer target, float endValue, float duration)
		{
			return null;
		}

		public static Tweener DOMove(this Transform target, Vector3 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		public static Tweener DOMoveX(this Transform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		public static Tweener DOMoveY(this Transform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		public static Tweener DOMoveZ(this Transform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		public static Tweener DOLocalMove(this Transform target, Vector3 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		public static Tweener DOLocalMoveX(this Transform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		public static Tweener DOLocalMoveY(this Transform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		public static Tweener DOLocalMoveZ(this Transform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		public static Tweener DORotate(this Transform target, Vector3 endValue, float duration, RotateMode mode = RotateMode.Fast)
		{
			return null;
		}

		public static Tweener DORotateQuaternion(this Transform target, Quaternion endValue, float duration)
		{
			return null;
		}

		public static Tweener DOLocalRotate(this Transform target, Vector3 endValue, float duration, RotateMode mode = RotateMode.Fast)
		{
			return null;
		}

		public static Tweener DOLocalRotateQuaternion(this Transform target, Quaternion endValue, float duration)
		{
			return null;
		}

		public static Tweener DOScale(this Transform target, Vector3 endValue, float duration)
		{
			return null;
		}

		public static Tweener DOScale(this Transform target, float endValue, float duration)
		{
			return null;
		}

		public static Tweener DOScaleX(this Transform target, float endValue, float duration)
		{
			return null;
		}

		public static Tweener DOScaleY(this Transform target, float endValue, float duration)
		{
			return null;
		}

		public static Tweener DOScaleZ(this Transform target, float endValue, float duration)
		{
			return null;
		}

		public static Tweener DOLookAt(this Transform target, Vector3 towards, float duration, AxisConstraint axisConstraint = AxisConstraint.None, Vector3? up = null)
		{
			return null;
		}

		public static Tweener DOPunchPosition(this Transform target, Vector3 punch, float duration, int vibrato = 10, float elasticity = 1f, bool snapping = false)
		{
			return null;
		}

		public static Tweener DOPunchScale(this Transform target, Vector3 punch, float duration, int vibrato = 10, float elasticity = 1f)
		{
			return null;
		}

		public static Tweener DOPunchRotation(this Transform target, Vector3 punch, float duration, int vibrato = 10, float elasticity = 1f)
		{
			return null;
		}

		public static Tweener DOShakePosition(this Transform target, float duration, float strength = 1f, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
		{
			return null;
		}

		public static Tweener DOShakePosition(this Transform target, float duration, Vector3 strength, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
		{
			return null;
		}

		public static Tweener DOShakeRotation(this Transform target, float duration, float strength = 90f, int vibrato = 10, float randomness = 90f, bool fadeOut = true)
		{
			return null;
		}

		public static Tweener DOShakeRotation(this Transform target, float duration, Vector3 strength, int vibrato = 10, float randomness = 90f, bool fadeOut = true)
		{
			return null;
		}

		public static Tweener DOShakeScale(this Transform target, float duration, float strength = 1f, int vibrato = 10, float randomness = 90f, bool fadeOut = true)
		{
			return null;
		}

		public static Tweener DOShakeScale(this Transform target, float duration, Vector3 strength, int vibrato = 10, float randomness = 90f, bool fadeOut = true)
		{
			return null;
		}

		public static Sequence DOJump(this Transform target, Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		public static Sequence DOLocalJump(this Transform target, Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		public static TweenerCore<Vector3, Path, PathOptions> DOPath(this Transform target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, Color? gizmoColor = null)
		{
			return null;
		}

		public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Transform target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, Color? gizmoColor = null)
		{
			return null;
		}

		internal static TweenerCore<Vector3, Path, PathOptions> DOPath(this Transform target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}

		internal static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Transform target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}

		public static Tweener DOTimeScale(this Tween target, float endValue, float duration)
		{
			return null;
		}

		public static Tweener DOBlendableColor(this Light target, Color endValue, float duration)
		{
			return null;
		}

		public static Tweener DOBlendableColor(this Material target, Color endValue, float duration)
		{
			return null;
		}

		public static Tweener DOBlendableColor(this Material target, Color endValue, string property, float duration)
		{
			return null;
		}

		public static Tweener DOBlendableMoveBy(this Transform target, Vector3 byValue, float duration, bool snapping = false)
		{
			return null;
		}

		public static Tweener DOBlendableLocalMoveBy(this Transform target, Vector3 byValue, float duration, bool snapping = false)
		{
			return null;
		}

		public static Tweener DOBlendableRotateBy(this Transform target, Vector3 byValue, float duration, RotateMode mode = RotateMode.Fast)
		{
			return null;
		}

		public static Tweener DOBlendableLocalRotateBy(this Transform target, Vector3 byValue, float duration, RotateMode mode = RotateMode.Fast)
		{
			return null;
		}

		public static Tweener DOBlendableScaleBy(this Transform target, Vector3 byValue, float duration)
		{
			return null;
		}

		public static int DOComplete(this Component target, bool withCallbacks = false)
		{
			return 0;
		}

		public static int DOComplete(this Material target, bool withCallbacks = false)
		{
			return 0;
		}

		public static int DOKill(this Component target, bool complete = false)
		{
			return 0;
		}

		public static int DOKill(this Material target, bool complete = false)
		{
			return 0;
		}

		public static int DOFlip(this Component target)
		{
			return 0;
		}

		public static int DOFlip(this Material target)
		{
			return 0;
		}

		public static int DOGoto(this Component target, float to, bool andPlay = false)
		{
			return 0;
		}

		public static int DOGoto(this Material target, float to, bool andPlay = false)
		{
			return 0;
		}

		public static int DOPause(this Component target)
		{
			return 0;
		}

		public static int DOPause(this Material target)
		{
			return 0;
		}

		public static int DOPlay(this Component target)
		{
			return 0;
		}

		public static int DOPlay(this Material target)
		{
			return 0;
		}

		public static int DOPlayBackwards(this Component target)
		{
			return 0;
		}

		public static int DOPlayBackwards(this Material target)
		{
			return 0;
		}

		public static int DOPlayForward(this Component target)
		{
			return 0;
		}

		public static int DOPlayForward(this Material target)
		{
			return 0;
		}

		public static int DORestart(this Component target, bool includeDelay = true)
		{
			return 0;
		}

		public static int DORestart(this Material target, bool includeDelay = true)
		{
			return 0;
		}

		public static int DORewind(this Component target, bool includeDelay = true)
		{
			return 0;
		}

		public static int DORewind(this Material target, bool includeDelay = true)
		{
			return 0;
		}

		public static int DOSmoothRewind(this Component target)
		{
			return 0;
		}

		public static int DOSmoothRewind(this Material target)
		{
			return 0;
		}

		public static int DOTogglePause(this Component target)
		{
			return 0;
		}

		public static int DOTogglePause(this Material target)
		{
			return 0;
		}
	}
}
