namespace WaterBell.ProjX.Data.Entity
{
	public class ObservableServantWeapon : PropertyChangeedObservable
	{
		private long servantCardID;

		private long weaponCardID;

		private int weaponSpellPromoteLv;

		private bool isUnLock;

		private int wpSkins;

		private int wpCurSkin;

		public long WeaponCardID
		{
			get
			{
				return 0L;
			}
		}

		public long ServantCardID
		{
			get
			{
				return 0L;
			}
		}

		public bool IsUnLock
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int WaponSpellPromoteLv
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int WpSkins
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int WpCurSkin
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public ObservableServantWeapon()
		{
		}

		public ObservableServantWeapon(long id, long servantid, bool isUnLock, int spellPromoteLv, int wpSkins, int wpCurSkin)
		{
		}

		public void Update(bool isUnLock, int spellPromoteLv, int wpSkins, int wpCurSkin)
		{
		}
	}
}
