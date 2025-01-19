using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Combatmod
{
	public sealed class AgentInfo : IMessage<AgentInfo>, IMessage, IEquatable<AgentInfo>, IDeepCloneable<AgentInfo>
	{
		private static readonly MessageParser<AgentInfo> _parser;

		public const int LevelFieldNumber = 1;

		private int level_;

		public const int IDFieldNumber = 2;

		private long iD_;

		public const int BeSelectedFieldNumber = 3;

		private int beSelected_;

		public const int CanMoveFieldNumber = 4;

		private int canMove_;

		public const int CanTurnFieldNumber = 5;

		private int canTurn_;

		public const int FollowMasterFieldNumber = 6;

		private int followMaster_;

		public const int CanChangeCurrentTargetFieldNumber = 7;

		private int canChangeCurrentTarget_;

		public const int FollowDistanceFieldNumber = 8;

		private int followDistance_;

		public const int TurnBoneFieldNumber = 9;

		private string turnBone_;

		public const int PrefabFieldNumber = 10;

		private string prefab_;

		public const int ShadowFieldNumber = 11;

		private int shadow_;

		public const int ColliderFieldNumber = 12;

		private int collider_;

		public const int ColliderRadiusFieldNumber = 13;

		private int colliderRadius_;

		public const int CollideTypeFieldNumber = 14;

		private int collideType_;

		public const int MobStateTagFieldNumber = 15;

		private int mobStateTag_;

		public const int BuffId1FieldNumber = 16;

		private long buffId1_;

		public const int BuffId2FieldNumber = 17;

		private long buffId2_;

		public const int BuffLayer1FieldNumber = 18;

		private int buffLayer1_;

		public const int BuffLayer2FieldNumber = 19;

		private int buffLayer2_;

		public const int InheritModeFieldNumber = 20;

		private int inheritMode_;

		public const int InheritTypeFieldNumber = 21;

		private string inheritType_;

		public const int SpawnTypeFieldNumber = 22;

		private int spawnType_;

		public const int SpawnArgu1FieldNumber = 23;

		private int spawnArgu1_;

		public const int SpawnArgu2FieldNumber = 24;

		private int spawnArgu2_;

		public const int SpawnArgu3FieldNumber = 25;

		private int spawnArgu3_;

		public const int SpawnArgu4FieldNumber = 26;

		private int spawnArgu4_;

		public const int SpawnDirectionFieldNumber = 27;

		private int spawnDirection_;

		public const int SpawnAngleFieldNumber = 28;

		private int spawnAngle_;

		public const int SpawnPositionAdjustTypeFieldNumber = 29;

		private int spawnPositionAdjustType_;

		public const int MovementTypeFieldNumber = 30;

		private int movementType_;

		public const int MaxPalstanceFieldNumber = 31;

		private int maxPalstance_;

		public const int MotionIdFieldNumber = 32;

		private string motionId_;

		public const int MotionArguFieldNumber = 33;

		private long motionArgu_;

		public const int TrackTypeFieldNumber = 34;

		private int trackType_;

		public const int SpeedFieldNumber = 35;

		private int speed_;

		public const int LifeTimeFieldNumber = 36;

		private int lifeTime_;

		public const int MaxDistanceFieldNumber = 37;

		private int maxDistance_;

		public const int HitDistanceFieldNumber = 38;

		private int hitDistance_;

		public const int DestroyByHitNumFieldNumber = 39;

		private int destroyByHitNum_;

		public const int DestroyByHitTimeFieldNumber = 40;

		private int destroyByHitTime_;

		public const int TargetTypeFieldNumber = 41;

		private int targetType_;

		public const int TargetArgu1FieldNumber = 42;

		private int targetArgu1_;

		public const int TargetArgu2FieldNumber = 43;

		private int targetArgu2_;

		public const int TargetArgu3FieldNumber = 44;

		private int targetArgu3_;

		public const int TargetArgu4FieldNumber = 45;

		private int targetArgu4_;

		public const int TargetArgu5FieldNumber = 46;

		private int targetArgu5_;

		public const int MovementWhileTargetDeadFieldNumber = 47;

		private int movementWhileTargetDead_;

		public const int DestroyByBlockFieldNumber = 48;

		private int destroyByBlock_;

		public const int DestroyPerformanceTypeFieldNumber = 49;

		private int destroyPerformanceType_;

		public const int SpellCastSpawnFieldNumber = 50;

		private long spellCastSpawn_;

		public const int SpellCastHitFieldNumber = 51;

		private long spellCastHit_;

		public const int SpellCastDeadFieldNumber = 52;

		private long spellCastDead_;

		public const int SpawnActionFieldNumber = 53;

		private string spawnAction_;

		public const int DeadActionFieldNumber = 54;

		private string deadAction_;

		public const int ScriptIdFieldNumber = 55;

		private string scriptId_;

		public const int ControllerPlayFieldNumber = 56;

		private string controllerPlay_;

		public const int ControllerNoplayFieldNumber = 57;

		private string controllerNoplay_;

		public const int PositionTypeFieldNumber = 58;

		private int positionType_;

		public const int CenterTypeFieldNumber = 59;

		private int centerType_;

		public const int RadiusFieldNumber = 60;

		private int radius_;

		public const int MinAngleFieldNumber = 61;

		private int minAngle_;

		public const int MaxAngleFieldNumber = 62;

		private int maxAngle_;

		public const int RightAngleFieldNumber = 63;

		private int rightAngle_;

		public const int OrientationTypeFieldNumber = 64;

		private int orientationType_;

		public const int OrientationAngleFieldNumber = 65;

		private int orientationAngle_;

		public const int CombatConstTypeFieldNumber = 66;

		private int combatConstType_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<AgentInfo> Parser
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public int Level
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public long ID
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public int BeSelected
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public int CanMove
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public int CanTurn
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public int FollowMaster
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public int CanChangeCurrentTarget
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public int FollowDistance
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public string TurnBone
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public string Prefab
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public int Shadow
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public int Collider
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public int ColliderRadius
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public int CollideType
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public int MobStateTag
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public long BuffId1
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public long BuffId2
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public int BuffLayer1
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public int BuffLayer2
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public int InheritMode
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public string InheritType
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public int SpawnType
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public int SpawnArgu1
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public int SpawnArgu2
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public int SpawnArgu3
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public int SpawnArgu4
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public int SpawnDirection
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public int SpawnAngle
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public int SpawnPositionAdjustType
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public int MovementType
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public int MaxPalstance
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public string MotionId
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public long MotionArgu
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public int TrackType
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public int Speed
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public int LifeTime
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public int MaxDistance
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public int HitDistance
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public int DestroyByHitNum
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public int DestroyByHitTime
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public int TargetType
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public int TargetArgu1
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public int TargetArgu2
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public int TargetArgu3
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public int TargetArgu4
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public int TargetArgu5
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public int MovementWhileTargetDead
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public int DestroyByBlock
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public int DestroyPerformanceType
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public long SpellCastSpawn
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public long SpellCastHit
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public long SpellCastDead
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public string SpawnAction
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public string DeadAction
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public string ScriptId
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public string ControllerPlay
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public string ControllerNoplay
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public int PositionType
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public int CenterType
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public int Radius
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public int MinAngle
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public int MaxAngle
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public int RightAngle
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public int OrientationType
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public int OrientationAngle
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public int CombatConstType
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public AgentInfo()
		{
		}

		[DebuggerNonUserCode]
		public AgentInfo(AgentInfo other)
		{
		}

		[DebuggerNonUserCode]
		public AgentInfo Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(AgentInfo other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(AgentInfo other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
