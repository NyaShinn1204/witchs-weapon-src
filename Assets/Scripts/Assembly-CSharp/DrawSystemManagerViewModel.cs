using System.Collections.Generic;
using Google.Protobuf.Collections;
using Lootmod;

public class DrawSystemManagerViewModel : DrawSystemManagerViewModelBase
{
	public RepeatedField<LootObject> OriginalLoots;

	public virtual P<int> DrawTypeProperty
	{
		get
		{
			return null;
		}
	}

	public virtual int DrawType
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual P<int> DrawResultProperty
	{
		get
		{
			return null;
		}
	}

	public virtual int DrawResult
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual P<int> RemainFreeGoldTimeProperty
	{
		get
		{
			return null;
		}
	}

	public virtual int RemainFreeGoldTime
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual P<int> RemainFreeRMBTimeProperty
	{
		get
		{
			return null;
		}
	}

	public virtual int RemainFreeRMBTime
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual P<bool> HaveFreeDrawProperty
	{
		get
		{
			return null;
		}
	}

	public virtual bool HaveFreeDraw
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public virtual P<int> GiftCouponNumProperty
	{
		get
		{
			return null;
		}
	}

	public virtual int GiftCouponNum
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual P<long> ActIDProperty
	{
		get
		{
			return null;
		}
	}

	public virtual long ActID
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public virtual ModelCollection<DrawResultData> DrawLoot
	{
		get
		{
			return null;
		}
	}

	public virtual ModelCollection<DrawResultData> ExtraWeapon
	{
		get
		{
			return null;
		}
	}

	public virtual CommandWithSenderAndArgument<DrawSystemManagerViewModel, DrawArgu> Draw
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSender<DrawSystemManagerViewModel> DrawFinish
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public DrawSystemManagerViewModel(DrawSystemManagerControllerBase controller, bool initialize = true)
		: base(null, false)
	{
	}

	public DrawSystemManagerViewModel()
		: base(null, false)
	{
	}

	protected override void WireCommands(Controller controller)
	{
	}

	public override void Write(ISerializerStream stream)
	{
	}

	public override void Read(ISerializerStream stream)
	{
	}

	public override void Unbind()
	{
	}

	protected override void FillProperties(List<ViewModelPropertyInfo> list)
	{
	}

	protected override void FillCommands(List<ViewModelCommandInfo> list)
	{
	}
}
