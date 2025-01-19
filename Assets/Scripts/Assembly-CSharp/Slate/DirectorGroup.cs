using UnityEngine;

namespace Slate
{
	public class DirectorGroup : CutsceneGroup
	{
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
