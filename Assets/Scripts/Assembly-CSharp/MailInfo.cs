using System.Collections.Generic;
using System.ComponentModel;
using Lootmod;

public class MailInfo : INotifyPropertyChanged
{
	private string _MailID;

	private string _Title;

	private string _From;

	private string _Content;

	private bool _HaveAttach;

	private string _ReceiveTime;

	private string _AttachID;

	private List<DrawResultData> _Attachs;

	public virtual string MailID
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual string Title
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual string From
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual string Content
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual bool HaveAttach
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public virtual string ReceiveTime
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual string AttachID
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual List<DrawResultData> Attachs
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public long MailTempletID { get; set; }

	public event PropertyChangedEventHandler PropertyChanged
	{
		add
		{
		}
		remove
		{
		}
	}

	public MailInfo(string id, string title, string from, string content, bool haveAttach, string receiveTime, string attachID, List<LootObject> loots, long MailTempletID)
	{
	}

	protected virtual void OnPropertyChanged(string propertyName)
	{
	}
}
