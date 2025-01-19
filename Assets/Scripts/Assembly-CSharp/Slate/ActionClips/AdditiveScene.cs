using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Slate.ActionClips
{
	public class AdditiveScene : DirectorActionClip, ISubClipContainable, IDirectable
	{
		[SerializeField]
		[HideInInspector]
		private float _length;

		[SerializeField]
		[HideInInspector]
		protected string _scenePath;

		public Vector3 scenePosition;

		public MiniTransformSpace space;

		public bool updateRootCutscenes;

		public float timeOffset;

		private Scene subScene;

		private List<Cutscene> rootCutscenes;

		private bool temporary;

		private bool waitLoad;

		float ISubClipContainable.subClipOffset
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public override bool isValid
		{
			get
			{
				return false;
			}
		}

		public override float length
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		protected override void OnEnter()
		{
		}

		protected override void OnReverseEnter()
		{
		}

		protected override void OnUpdate(float time)
		{
		}

		protected override void OnExit()
		{
		}

		protected override void OnReverse()
		{
		}

		private void Activate()
		{
		}

		private void Deactivate()
		{
		}

		private string CleanPath(string path)
		{
			return null;
		}

		private void InitializeSubSceneCutscenes()
		{
		}

		private void DenitializeSubSceneCutscenes(bool forward)
		{
		}
	}
}
