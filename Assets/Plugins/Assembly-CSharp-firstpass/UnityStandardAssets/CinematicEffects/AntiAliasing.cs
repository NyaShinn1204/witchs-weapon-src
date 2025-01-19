using UnityEngine;

namespace UnityStandardAssets.CinematicEffects
{
	[ExecuteInEditMode]
	[ImageEffectAllowedInSceneView]
	public class AntiAliasing : MonoBehaviour
	{
		public enum Method
		{
			Smaa = 0,
			Fxaa = 1
		}

		[SerializeField]
		private SMAA m_SMAA;

		[SerializeField]
		private FXAA m_FXAA;

		[SerializeField]
		[HideInInspector]
		private int m_Method;

		private Camera m_Camera;

		public int method
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public IAntiAliasing current
		{
			get
			{
				return null;
			}
		}

		public Camera cameraComponent
		{
			get
			{
				return null;
			}
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnPreCull()
		{
		}

		private void OnPostRender()
		{
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}
	}
}
