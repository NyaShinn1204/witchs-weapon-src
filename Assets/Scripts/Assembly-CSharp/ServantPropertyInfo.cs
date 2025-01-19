using System.ComponentModel;
using System.Runtime.InteropServices;
using WaterBell.ProjX.Data.Entity;

public class ServantPropertyInfo : INotifyPropertyChanged
{
	[StructLayout(LayoutKind.Sequential, Size = 20)]
	private struct Basic5Attr
	{
		public int hp;

		public int patk;

		public int pdef;

		public int matk;

		public int mdef;
	}

	private enum CalcPattern
	{
		None = 0,
		MySvCSForTotoalCS = 1,
		MySvCSForOnlyWeapon = 2,
		MySvStaticAttr = 3,
		MySvCombatAttr = 4,
		MySvCSForSvView = 5,
		MySvCombatCS = 6,
		SysRestrictedSvCS = 7,
		McnySvCombatAttr = 8,
		McnySvCombatCS = 9,
		McnyCustomSvCS = 10,
		GuildSvStaticAttr = 11,
		GuildSvCS = 12
	}

	private int _SSVHP;

	private int _SSVPATK;

	private int _SSVPDEF;

	private int _SSVMATK;

	private int _SSVMDEF;

	private int _SSVPCV;

	private int _SSVMCV;

	private int _SSVPCMV;

	private int _SSVMCMV;

	private int _SSVHV;

	private int _SSVDV;

	private int _SSVIPDV;

	private int _SSVIMDV;

	private int _EnergyRestoreTime;

	private int _EnergyRestoreInjured;

	private int _EnergyRestoreAttacked;

	private int _EnergyRestoreKillingTime;

	private int _SVCS;

	private double[] attrValues;

	public virtual int SSVHP
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual int SSVPATK
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual int SSVPDEF
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual int SSVMATK
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual int SSVMDEF
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual int SSVPCV
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual int SSVMCV
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual int SSVPCMV
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual int SSVMCMV
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual int SSVHV
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual int SSVDV
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual int SSVIPDV
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual int SSVIMDV
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual int EnergyRestoreTime
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual int EnergyRestoreInjured
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual int EnergyRestoreAttacked
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual int EnergyRestoreKillingTime
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual int SVCS
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public event PropertyChangedEventHandler PropertyChanged
	{
		add
		{
		}
		remove
		{
		}
	}

	public ServantPropertyInfo(long _sid, int _servantLv, int _servantRank, int _servantStar, int _favorLv, int _spellActive, int _spellPassive, long _equip1, long _equip2, long _equip3, long _equip4, long _equip5, long _equip6, long _wid, int _weaponLv, int _wpPromoteLv)
	{
	}

	public ServantPropertyInfo()
	{
	}

	protected virtual void OnPropertyChanged(string propertyName)
	{
	}

	private void Init(CalcPattern pattern, long servantID, long weaponID)
	{
	}

	private void Init2(CalcPattern pattern, long servantID, long rid)
	{
	}

	private void Init3(CalcPattern pattern, long servantID, long challengeID)
	{
	}

	private void Init4(CalcPattern pattern, MiniServant sv, long _wid, int _wpPromoteLv)
	{
	}

	public ServantPropertyInfo BuildMySvStaticAttr(long servantID)
	{
		return null;
	}

	public ServantPropertyInfo BuildMySvCSForSvView(long servantID)
	{
		return null;
	}

	public ServantPropertyInfo BuildMySvCombatAttr(long servantID)
	{
		return null;
	}

	public ServantPropertyInfo BuildMySvCombatCS(long servantID, long weaponID)
	{
		return null;
	}

	public ServantPropertyInfo BuildMySvCSForTotalCS(long servantID)
	{
		return null;
	}

	public ServantPropertyInfo BuildMySvCSForOnlyWeapon(long servantID, long weaponID)
	{
		return null;
	}

	public ServantPropertyInfo BuildMcnySvCombatAttr(long servantID)
	{
		return null;
	}

	public ServantPropertyInfo BuildMcnySvCS(long servantID)
	{
		return null;
	}

	public ServantPropertyInfo BuildMcnySvCS(MiniServant sv, long _wid, int _wpPromoteLv)
	{
		return null;
	}

	public ServantPropertyInfo BuildGuildSvStaticAttr(long servantID, long rid)
	{
		return null;
	}

	public ServantPropertyInfo BuildGuildSvCS(long servantID, long rid)
	{
		return null;
	}

	public ServantPropertyInfo BuildSysRestrictedSvCS(long servantID, long challengeID)
	{
		return null;
	}

	private void CalcSvBasicAttr(MiniServant sv)
	{
	}

	private void CalcSvCombatAttr(MiniServant sv)
	{
	}

	private bool IsModeAndInstancePrepared()
	{
		return false;
	}

	private void CalcSvImageAttr(MiniServant sv, Basic5Attr currAttr, ref Basic5Attr addAttr)
	{
	}

	private void CalcSvActivityCampAttr(MiniServant sv, Basic5Attr currAttr, ref Basic5Attr addAttr)
	{
	}

	private double CalcSpellCS(MiniServant sv)
	{
		return 0.0;
	}

	private void CalcSpecifiedWeaponCS(ObservableSingleServant svInfo, ObservableServantWeapon wp, ref double WPCS, ref double SWPM)
	{
	}

	private void CalcSpecifiedMercenaryWeaponCS(MercenaryServant mcnySvInfo, ObservableServantWeapon wp, ref double WPCS, ref double SWPM)
	{
	}

	private void CalcSpecifiedRestrictedWeaponCS(TypeCsvChallenge csv, ObservableServantWeapon wp, ref double WPCS, ref double SWPM)
	{
	}

	private void CalcSpecifiedMcnyCustomWeaponCS(MiniServant sv, long weaponID, int weaponPromoteLv, ref double WPCS, ref double SWPM)
	{
	}

	private void CalcUnspecifiedWeaponCS(ObservableSingleServant svInfo, ref double WPCS, ref double SWPM, TypeCsvServantRankInfo rankCsv)
	{
	}

	private void CaculateOnlyWeaponCombatScore()
	{
	}

	private double CalcSvAttrCS()
	{
		return 0.0;
	}

	private void DoWeaponCSPromote(double baseCS, double SWPM, TypeCsvServantRankInfo rankCsv)
	{
	}

	private MiniServant GetMiniServantFromChallengeCsvData(long challengeID, long servantID, TypeCsvChallenge csv)
	{
		return null;
	}

	private long GetWeaponIDFromChallengeCsvData(long servantID, TypeCsvChallenge csv)
	{
		return 0L;
	}

	private double getRestrictWeaponCSInfo(ObservableServantWeapon weapon, TypeCsvChallenge typeCsvChallenge, double[] attrValues)
	{
		return 0.0;
	}

	private double getWeaponCSInfo(ObservableServantWeapon weapon, ObservableSingleServant info, double[] attrValues)
	{
		return 0.0;
	}

	private double getMercenaryWeaponCSInfo(ObservableServantWeapon weapon, MercenaryServant info, double[] attrValues)
	{
		return 0.0;
	}

	private double getServantCfgWeaponCSInfo(long _sid, int _servantLv, long _wid, int _weaponLv, int _wpPromoteLv)
	{
		return 0.0;
	}

	private double getSWPM(int wpPromoteLv)
	{
		return 0.0;
	}

	public static double GetWeaponPhysicalATK(long svID, long WeaponCardID, int WeaponLevelArgu = -1)
	{
		return 0.0;
	}

	public static double GetMercenaryWeaponPhysicalATK(MercenaryServant info)
	{
		return 0.0;
	}

	public static double GetRestrictServantWeaponPhysicalATK(ObservableServantWeapon observableServantWeapon, TypeCsvChallenge typeCsvChallenge)
	{
		return 0.0;
	}

	public static double GetWeaponMagicalATK(long svID, long WeaponCardID, int WeaponLevelArgu = -1)
	{
		return 0.0;
	}

	public static double GetMercenaryWeaponMagicalATK(MercenaryServant info)
	{
		return 0.0;
	}

	public static double GetRestrictServantWeaponMagicalATK(ObservableServantWeapon observableServantWeapon, TypeCsvChallenge typeCsvChallenge)
	{
		return 0.0;
	}

	private double GetRestrictServantCfgWeaponPhysicalATK(long _sid, long _wid, int _weaponLv, int _weaponPromoteLv)
	{
		return 0.0;
	}

	private double GetRestrictServantCfgWeaponMagicalATK(long _sid, long _wid, int _weaponLv, int _weaponPromoteLv)
	{
		return 0.0;
	}

	private int GetImageProprety(long _sid, int _imageSerial)
	{
		return 0;
	}

	private Basic5Attr GetBasic5AttrFromCurrentSvAttr()
	{
		return default(Basic5Attr);
	}

	private void CombimeBasic5Attr(Basic5Attr attr)
	{
	}
}
