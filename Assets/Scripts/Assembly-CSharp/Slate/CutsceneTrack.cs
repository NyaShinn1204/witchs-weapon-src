using System.Collections.Generic;
using UnityEngine;

namespace Slate
{
	public abstract class CutsceneTrack : MonoBehaviour, IDirectable
	{
		[SerializeField]
		private string _name;

		[SerializeField]
		private Color _color;

		[SerializeField]
		[HideInInspector]
		private bool _active;

		[SerializeField]
		[HideInInspector]
		private bool _isLocked;

		[SerializeField]
		[HideInInspector]
		private List<ActionClip> _actionClips;

		IEnumerable<IDirectable> IDirectable.children
		{
			get
			{
				return null;
			}
		}

		public GameObject actor
		{
			get
			{
				return null;
			}
		}

		public new string name
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Color color
		{
			get
			{
				return default(Color);
			}
		}

		public List<ActionClip> actions
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual string info
		{
			get
			{
				return null;
			}
		}

		public int layerOrder { get; set; }

		public IDirector root
		{
			get
			{
				return null;
			}
		}

		public IDirectable parent { get; private set; }

		public bool isCollapsed
		{
			get
			{
				return false;
			}
		}

		public bool isActive
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool isLocked
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public virtual float startTime
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public virtual float endTime
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public virtual float blendIn
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public virtual float blendOut
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		bool IDirectable.Initialize()
		{
			return false;
		}

		void IDirectable.Enter()
		{
		}

		void IDirectable.Update(float time, float previousTime)
		{
		}

		void IDirectable.Exit()
		{
		}

		void IDirectable.ReverseEnter()
		{
		}

		void IDirectable.Reverse()
		{
		}

		void IDirectable.RootEnabled()
		{
		}

		void IDirectable.RootDisabled()
		{
		}

		void IDirectable.RootUpdated(float time, float previousTime)
		{
		}

		public void PostCreate(IDirectable parent)
		{
		}

		public void Validate(IDirector root, IDirectable parent)
		{
		}

		protected virtual void OnCreate()
		{
		}

		protected virtual void OnAfterValidate()
		{
		}

		protected virtual bool OnInitialize()
		{
			return false;
		}

		protected virtual void OnEnter()
		{
		}

		protected virtual void OnUpdate(float time, float previousTime)
		{
		}

		protected virtual void OnExit()
		{
		}

		protected virtual void OnReverseEnter()
		{
		}

		protected virtual void OnReverse()
		{
		}

		protected virtual void OnDrawGizmosSelected()
		{
		}

		protected virtual void OnSceneGUI()
		{
		}

		protected virtual void OnRootEnabled()
		{
		}

		protected virtual void OnRootDisabled()
		{
		}

		protected virtual void OnRootUpdated(float time, float previousTime)
		{
		}

		public float GetTrackWeight(float time)
		{
			return 0f;
		}

		public float GetTrackWeight(float time, float blendInOut)
		{
			return 0f;
		}

		public float GetTrackWeight(float time, float blendIn, float blendOut)
		{
			return 0f;
		}

		public Vector3 TransformPoint(Vector3 point, TransformSpace space)
		{
			return default(Vector3);
		}

		public Vector3 InverseTransformPoint(Vector3 point, TransformSpace space)
		{
			return default(Vector3);
		}

		public Vector3 ActorPositionInSpace(TransformSpace space)
		{
			return default(Vector3);
		}

		public Transform GetSpaceTransform(TransformSpace space)
		{
			return null;
		}
	}
}
