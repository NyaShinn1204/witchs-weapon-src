using System.Collections.Generic;
using UnityEngine;

namespace Slate
{
	public interface IDirectable
	{
		IDirector root { get; }

		IDirectable parent { get; }

		IEnumerable<IDirectable> children { get; }

		GameObject actor { get; }

		string name { get; }

		bool isActive { get; }

		bool isCollapsed { get; }

		bool isLocked { get; }

		float startTime { get; }

		float endTime { get; }

		float blendIn { get; }

		float blendOut { get; }

		void Validate(IDirector root, IDirectable parent);

		bool Initialize();

		void Enter();

		void Exit();

		void Update(float time, float previousTime);

		void ReverseEnter();

		void Reverse();

		void RootEnabled();

		void RootUpdated(float time, float previousTime);

		void RootDisabled();

		Vector3 TransformPoint(Vector3 point, TransformSpace space);

		Vector3 InverseTransformPoint(Vector3 point, TransformSpace space);

		Transform GetSpaceTransform(TransformSpace space);

		Vector3 ActorPositionInSpace(TransformSpace space);
	}
}
