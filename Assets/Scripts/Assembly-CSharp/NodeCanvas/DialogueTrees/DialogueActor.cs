using UnityEngine;

namespace NodeCanvas.DialogueTrees
{
	public class DialogueActor : MonoBehaviour, IDialogueActor
	{
		[SerializeField]
		protected string _name;

		[SerializeField]
		protected Texture2D _portrait;

		[SerializeField]
		protected Color _dialogueColor;

		[SerializeField]
		protected Vector3 _dialogueOffset;

		private Sprite _portraitSprite;

		public new string name
		{
			get
			{
				return null;
			}
		}

		public Texture2D portrait
		{
			get
			{
				return null;
			}
		}

		public Sprite portraitSprite
		{
			get
			{
				return null;
			}
		}

		public Color dialogueColor
		{
			get
			{
				return default(Color);
			}
		}

		public Vector3 dialoguePosition
		{
			get
			{
				return default(Vector3);
			}
		}

		Transform IDialogueActor.get_transform()
		{
			return null;
		}
	}
}
