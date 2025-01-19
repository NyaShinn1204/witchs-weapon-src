using System.Collections.Generic;
using Lootmod;
using Mailmod;

namespace WaterBell.ProjX.Data.Entity
{
	public class ObservableSingleMail : PropertyChangeedObservable
	{
		private string _MailID;

		private string _Title;

		private string _From;

		private string _Content;

		private bool _HaveAttach;

		private string _ReceiveTime;

		private string _Status;

		private string _AttachID;

		private bool _Readed;

		private List<LootObject> loots;

		private LootList lootList;

		public long MailTempletID { get; set; }

		public LootList LootList
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string MailContentID
		{
			get
			{
				return null;
			}
		}

		public string Title
		{
			get
			{
				return null;
			}
		}

		public string From
		{
			get
			{
				return null;
			}
		}

		public string Content
		{
			get
			{
				return null;
			}
		}

		public bool HaveAttach
		{
			get
			{
				return false;
			}
		}

		public string ReceiveTime
		{
			get
			{
				return null;
			}
		}

		public string Status
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string AttachID
		{
			get
			{
				return null;
			}
		}

		public bool Readed
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public List<LootObject> Loots
		{
			get
			{
				return null;
			}
		}

		public ObservableSingleMail()
		{
		}

		public ObservableSingleMail(MailDetail content)
		{
		}

		public void Update(MailDetail content)
		{
		}
	}
}
