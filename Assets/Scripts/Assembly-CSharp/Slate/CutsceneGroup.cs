using System;
using System.Collections.Generic;
using UnityEngine;

namespace Slate
{
	public abstract class CutsceneGroup : MonoBehaviour, IDirectable
	{
		public enum ActorReferenceMode
		{
			UseOriginal = 0,
			UseInstanceHideOriginal = 1
		}

		public enum ActorInitialTransformation
		{
			UseOriginal = 0,
			UseLocal = 1
		}

		[SerializeField]
		[HideInInspector]
		private List<CutsceneTrack> _tracks;

		[SerializeField]
		[HideInInspector]
		private List<Section> _sections;

		[SerializeField]
		[HideInInspector]
		private bool _isCollapsed;

		[SerializeField]
		[HideInInspector]
		private bool _active;

		[SerializeField]
		[HideInInspector]
		private bool _isLocked;

		private TransformSnapshot transformSnapshot;

		private ObjectSnapshot objectSnapshot;

		private GameObject originalActor;

		IEnumerable<IDirectable> IDirectable.children
		{
			get
			{
				return null;
			}
		}

		float IDirectable.startTime
		{
			get
			{
				return 0f;
			}
		}

		float IDirectable.endTime
		{
			get
			{
				return 0f;
			}
		}

		float IDirectable.blendIn
		{
			get
			{
				return 0f;
			}
		}

		float IDirectable.blendOut
		{
			get
			{
				return 0f;
			}
		}

		IDirectable IDirectable.parent
		{
			get
			{
				return null;
			}
		}

		public new abstract string name { get; set; }

		public abstract GameObject actor { get; set; }

		public abstract ActorReferenceMode referenceMode { get; set; }

		public abstract ActorInitialTransformation initialTransformation { get; set; }

		public abstract Vector3 initialLocalPosition { get; set; }

		public abstract Vector3 initialLocalRotation { get; set; }

		public abstract bool displayVirtualMeshGizmo { get; set; }

		public List<CutsceneTrack> tracks
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<Section> sections
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public IDirector root { get; private set; }

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

		public bool isCollapsed
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

		public event Action<Section> OnSectionReached
		{
			add
			{
			}
			remove
			{
			}
		}

		public void Validate(IDirector root, IDirectable parent)
		{
		}

		public Section GetSectionByName(string name)
		{
			return null;
		}

		public Section GetSectionByUID(string UID)
		{
			return null;
		}

		public Section GetSectionAfter(float time)
		{
			return null;
		}

		public Section GetSectionBefore(float time)
		{
			return null;
		}

		public Vector3 TransformPoint(Vector3 point, TransformSpace space)
		{
			return default(Vector3);
		}

		public Vector3 InverseTransformPoint(Vector3 point, TransformSpace space)
		{
			return default(Vector3);
		}

		public Transform GetSpaceTransform(TransformSpace space)
		{
			return null;
		}

		public Vector3 ActorPositionInSpace(TransformSpace space)
		{
			return default(Vector3);
		}

		bool IDirectable.Initialize()
		{
			return false;
		}

		void IDirectable.Enter()
		{
		}

		void IDirectable.Reverse()
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

		void IDirectable.RootEnabled()
		{
		}

		void IDirectable.RootDisabled()
		{
		}

		void IDirectable.RootUpdated(float time, float previousTime)
		{
		}

		private void Store()
		{
		}

		private void Restore()
		{
		}

		private void InstantiateLocalActor()
		{
		}

		private void ReleaseLocalActorInstance()
		{
		}

		private void InitLocalCoords(GameObject target)
		{
		}
	}
}
