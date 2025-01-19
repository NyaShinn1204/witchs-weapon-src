using System;
using System.Collections.Generic;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.DialogueTrees
{
	[GraphInfo]
	public class DialogueTree : Graph
	{
		[Serializable]
		private struct DerivedSerializationData
		{
			public List<ActorParameter> actorParameters;
		}

		[Serializable]
		public class ActorParameter
		{
			[SerializeField]
			private string _keyName;

			[SerializeField]
			private string _id;

			[SerializeField]
			private UnityEngine.Object _actorObject;

			[NonSerialized]
			private IDialogueActor _actor;

			public string name
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public string ID
			{
				get
				{
					return null;
				}
			}

			public IDialogueActor actor
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public ActorParameter()
			{
			}

			public ActorParameter(string name)
			{
			}

			public ActorParameter(string name, IDialogueActor actor)
			{
			}

			public override string ToString()
			{
				return null;
			}
		}

		public const string INSTIGATOR_NAME = "INSTIGATOR";

		[SerializeField]
		private List<ActorParameter> _actorParameters;

		private DTNode currentNode;

		public static DialogueTree currentDialogue { get; private set; }

		public static DialogueTree previousDialogue { get; private set; }

		public override Type baseNodeType
		{
			get
			{
				return null;
			}
		}

		public override bool requiresAgent
		{
			get
			{
				return false;
			}
		}

		public override bool requiresPrimeNode
		{
			get
			{
				return false;
			}
		}

		public override bool autoSort
		{
			get
			{
				return false;
			}
		}

		public override bool useLocalBlackboard
		{
			get
			{
				return false;
			}
		}

		public List<ActorParameter> actorParameters
		{
			get
			{
				return null;
			}
		}

		public List<string> definedActorParameterNames
		{
			get
			{
				return null;
			}
		}

		public static event Action<DialogueTree> OnDialogueStarted
		{
			add
			{
			}
			remove
			{
			}
		}

		public static event Action<DialogueTree> OnDialoguePaused
		{
			add
			{
			}
			remove
			{
			}
		}

		public static event Action<DialogueTree> OnDialogueFinished
		{
			add
			{
			}
			remove
			{
			}
		}

		public static event Action<SubtitlesRequestInfo> OnSubtitlesRequest
		{
			add
			{
			}
			remove
			{
			}
		}

		public static event Action<MultipleChoiceRequestInfo> OnMultipleChoiceRequest
		{
			add
			{
			}
			remove
			{
			}
		}

		public override object OnDerivedDataSerialization()
		{
			return null;
		}

		public override void OnDerivedDataDeserialization(object data)
		{
		}

		public ActorParameter GetParameterByID(string id)
		{
			return null;
		}

		public ActorParameter GetParameterByName(string paramName)
		{
			return null;
		}

		public IDialogueActor GetActorReferenceByID(string id)
		{
			return null;
		}

		public IDialogueActor GetActorReferenceByName(string paramName)
		{
			return null;
		}

		public void SetActorReference(string paramName, IDialogueActor actor)
		{
		}

		public void SetActorReferences(Dictionary<string, IDialogueActor> actors)
		{
		}

		public void Continue(int index = 0)
		{
		}

		public void EnterNode(DTNode node)
		{
		}

		public static void RequestSubtitles(SubtitlesRequestInfo info)
		{
		}

		public static void RequestMultipleChoices(MultipleChoiceRequestInfo info)
		{
		}

		protected override void OnGraphStarted()
		{
		}

		protected override void OnGraphUnpaused()
		{
		}

		protected override void OnGraphStoped()
		{
		}

		protected override void OnGraphPaused()
		{
		}
	}
}
