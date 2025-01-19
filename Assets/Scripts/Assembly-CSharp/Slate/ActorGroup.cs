using UnityEngine;

namespace Slate
{
	public class ActorGroup : CutsceneGroup
	{
		[SerializeField]
		private string _name;

		[SerializeField]
		private GameObject _actor;

		[SerializeField]
		[HideInInspector]
		private ActorReferenceMode _referenceMode;

		[SerializeField]
		[HideInInspector]
		private ActorInitialTransformation _initialCoordinates;

		[SerializeField]
		[HideInInspector]
		private Vector3 _initialLocalPosition;

		[SerializeField]
		[HideInInspector]
		private Vector3 _initialLocalRotation;

		[SerializeField]
		[HideInInspector]
		private bool _displayVirtualMeshGizmo;

		public override string name
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override GameObject actor
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override ActorReferenceMode referenceMode
		{
			get
			{
				return default(ActorReferenceMode);
			}
			set
			{
			}
		}

		public override ActorInitialTransformation initialTransformation
		{
			get
			{
				return default(ActorInitialTransformation);
			}
			set
			{
			}
		}

		public override Vector3 initialLocalPosition
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public override Vector3 initialLocalRotation
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public override bool displayVirtualMeshGizmo
		{
			get
			{
				return false;
			}
			set
			{
			}
		}
	}
}
