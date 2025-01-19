using System.Collections.Generic;
using UnityEngine;
using WaterBell.ProjX.Battle.Unit;

public class ActionMngr : AIPath
{
	public class DashAct
	{
		private ActionMngr _p;

		private const float slowdownFrameNum = 4f;

		public float dashTimer;

		public float dashFullSpeedPerSec;

		public DashAct(ActionMngr aMngr)
		{
		}

		public void BeginRush(float time, float dist)
		{
		}

		public void EndRush()
		{
		}

		public void OnRush()
		{
		}
	}

	public class StunOnGroundAct
	{
		private ActionMngr _p;

		public StunOnGroundAct(ActionMngr aMngr)
		{
		}

		public void Do()
		{
		}

		public void On()
		{
		}
	}

	public class TemptAct
	{
		private ActionMngr _p;

		private Vector3 _positionInit;

		private Vector3 _positionTarget;

		private float _time;

		public TemptAct(ActionMngr aMngr)
		{
		}

		public void Do()
		{
		}

		public void Update()
		{
		}
	}

	public class BeCatchAct
	{
		public Transform point;

		public Transform parentPre;

		public Vector3 offsetPost;

		private ActionMngr _p;

		public BeCatchAct(ActionMngr aMngr)
		{
		}

		public void Do(Transform sPoint)
		{
		}

		public void Reset()
		{
		}

		public void Update()
		{
		}
	}

	public class RelifeAct
	{
		public bool isRelife;

		public float time;

		private ActionMngr _actionMngr;

		public RelifeAct(ActionMngr sActionMngr)
		{
		}

		public void DoRelifeWait()
		{
		}

		public void DoRelife()
		{
		}

		public void Update()
		{
		}
	}

	public class FollowerAct
	{
		private ActionMngr _actionMngr;

		public FollowerAct(ActionMngr sActionMngr)
		{
		}

		public void Do(Vector3 sPosition)
		{
		}

		public void changTargetPoisiton(Vector3 sPosition)
		{
		}
	}

	public class MoveAct
	{
		private ActionMngr _p;

		public float speedRun;

		public MoveAct(ActionMngr aMngr)
		{
		}

		public void DoMoveToTarget()
		{
		}

		public void DoMoveToDir(Vector3 mvDir, bool isInitMove = false)
		{
		}

		public void BasicMove()
		{
		}

		public void OnNavigateByAI()
		{
		}

		public void OnSlowDown()
		{
		}
	}

	public class StandOnGroundAct
	{
		private enum StandByAI
		{
			LEFT = 0,
			RIGHT = 1,
			BACK = 2,
			FORE = 3,
			STAND = 4,
			NULL = 5
		}

		private ActionMngr _p;

		private HashSet<StandByAI> _isLogUnFindAnim;

		private StandByAI _stateAI;

		private float _stateTime;

		private bool _isUnfullStateAI;

		public StandOnGroundAct(ActionMngr aMngr)
		{
		}

		public void Guard()
		{
		}

		public void Still()
		{
		}

		public void QuestFailed()
		{
		}

		public void QuestWin()
		{
		}

		public void Spawn()
		{
		}

		public void Attacked()
		{
		}

		public void StandUpFromGround()
		{
		}

		public void ChargeSkill(int animation)
		{
		}

		private bool IsLogUnFindAnim(StandByAI sType)
		{
			return false;
		}

		public void ResetStandByAI()
		{
		}

		public void OnStandByAI()
		{
		}
	}

	public class ForceAct
	{
		private ActionMngr _p;

		public float timeFly;

		public ForceAct(ActionMngr aMngr)
		{
		}

		private void AddAirForce(Vector3 speed, string animState)
		{
		}

		public void KnockAndFlyIntoAir(Vector3 speed)
		{
		}

		public void OnFreeFalling()
		{
		}

		public void OnFreeFallingGround()
		{
		}
	}

	public Entity unit;

	public CharacterStateManager stateMngr;

	public AnimatorController animatorController;

	public DashAct dashAct;

	public MoveAct moveAct;

	public StunOnGroundAct stunOGAct;

	public StandOnGroundAct standOGAct;

	public ForceAct forceAct;

	public BeCatchAct beCatchAct;

	public RelifeAct relifeAct;

	public FollowerAct followerAct;

	public TemptAct temptAct;

	public SkillModfiyPost skillModfiyPost;

	public bool needReverse;

	public bool pushable;

	public bool rotateWhenAct;

	public float mass;

	public float resistance;

	public const float WEIGHT_DASH_MUTIPLE = 1f;

	public const float WEIGHT_STAND_MUTIPLE = 1f;

	public const float WEIGHT_MOVE_MUTIPLE = 1f;

	public bool needsTurn;

	private Vector3 _endPositon;

	public Vector3 endDir;

	public float sqrDist;

	private float _reachedRange;

	public Vector3 savedSpeed;

	protected Collider unitCollider
	{
		get
		{
			return null;
		}
	}

	public Vector3 endPositon
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public Vector3 currentSpeed
	{
		get
		{
			return default(Vector3);
		}
	}

	public static void BindUnit(ActionMngr aMngr, Entity unit)
	{
	}

	public virtual void SetMassState(MassState state)
	{
	}

	public override Vector3 GetFeetPosition()
	{
		return default(Vector3);
	}

	public virtual float GetSqrLength()
	{
		return 0f;
	}

	public virtual float GetTotalLength()
	{
		return 0f;
	}

	public virtual float GetReachedRange()
	{
		return 0f;
	}

	public void UpdateReachedRange()
	{
	}

	public virtual float GetDashAutoSlowDownRange()
	{
		return 0f;
	}

	public virtual float GetDashAutoStopRange()
	{
		return 0f;
	}

	public virtual void setTarget(Transform t)
	{
	}

	public override float TrySearchPath()
	{
		return 0f;
	}

	public override void SearchPath()
	{
	}

	public override void OnTargetReached()
	{
	}

	public void PublicRotateTowards(Vector3 dir)
	{
	}

	public void PublicRotateTowardsBone(Transform trans, Vector3 dir)
	{
	}

	protected override void RotateTowards(Vector3 dir)
	{
	}

	protected void RotateTowards(Vector3 dir, float roSpeed)
	{
	}

	public virtual void UpdateRotation(bool lookAtTarget)
	{
	}

	protected override Vector3 CalculateVelocity(Vector3 currentPosition)
	{
		return default(Vector3);
	}

	public virtual void Stop()
	{
	}

	public virtual void Pause()
	{
	}

	public virtual void Resume()
	{
	}

	protected override void Awake()
	{
	}

	public override void Update()
	{
	}

	public void UpdateActions()
	{
	}

	protected void UpdateAIMove()
	{
	}

	public virtual void DeadOnGround(string sAnim)
	{
	}
}
