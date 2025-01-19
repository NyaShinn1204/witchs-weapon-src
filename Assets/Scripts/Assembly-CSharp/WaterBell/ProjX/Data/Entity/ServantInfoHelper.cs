using System.Collections.Generic;
using System.Runtime.InteropServices;
using WaterBell.ProjX.View.Panel;

namespace WaterBell.ProjX.Data.Entity
{
	public class ServantInfoHelper
	{
		[StructLayout(LayoutKind.Auto, Size = 8)]
		public delegate void ItemIncreaseFresh(IntensifyLootItem loot, WeaponExpItemInfo weaponExpItemInfo);

		private static List<long> unLockList;

		private static List<long> lockList;

		private static long currentPreviewSV;

		public static long CurrentPreviewSV
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public static void ChangeWeaponExp(long itemID)
		{
		}

		public static int GetWeaponExpLimit(long weaponid, int level)
		{
			return 0;
		}

		public static int TryCancelWeaponExpFake(WeaponDevelopInfo info, WeaponExpItemInfo weaponExpItemInfo, int num)
		{
			return 0;
		}

		public static string TryAddWeaponExpFake(long servantCardID, int level, long exp, WeaponDevelopInfo info, WeaponExpItemInfo weaponExpItemInfo, int num, bool needWarning = false, ItemIncreaseFresh ItemIncreaseFreshMethod = null, IntensifyLootItem IntensifyLootItem = null)
		{
			return null;
		}

		public static int ChangeWeaponExpFake(WeaponDevelopInfo info, WeaponExpItemInfo weaponExpItemInfo, int num)
		{
			return 0;
		}

		public static int CheckSvWeaponExpNeedGold(WeaponDevelopInfo info, WeaponExpItemInfo weaponExpItemInfo, int num)
		{
			return 0;
		}

		public static string ChageServantExpFake(ExpDevelopInfo info, SvExpItemInfo item, int num)
		{
			return null;
		}

		public static string CanAddSpell(long svid, int spellIndex)
		{
			return null;
		}

		public static string CanAddSpellActive(ObservableSingleServant svid)
		{
			return null;
		}

		public static string CanAddSpellPassive1(ObservableSingleServant svid)
		{
			return null;
		}

		public static string CanAddSpellPassive2(ObservableSingleServant svid)
		{
			return null;
		}

		public static string CanAddSpellPassive3(ObservableSingleServant svid)
		{
			return null;
		}

		public static int GetServantEquipOrItemCurrentNum(long id)
		{
			return 0;
		}

		public static string CanRankUp(long servantID)
		{
			return null;
		}

		public static long GetEquipID(long servantID, int equipIndex)
		{
			return 0L;
		}

		private static string CanAddWeaponExp(long servantCardID, int level, long exp)
		{
			return null;
		}

		public static string CanComposeSvByWeapon(long CardID)
		{
			return null;
		}

		public static string isUnlockPromoteWeaponFunc(long CurrentWeaponCardID)
		{
			return null;
		}

		public static string CanPromoteWeaponSpell(long CurrentWeaponCardID)
		{
			return null;
		}

		public static string CanComposeWeapon(long CurrentWeaponCardID)
		{
			return null;
		}

		public static List<long> SortedUnLockServants()
		{
			return null;
		}

		public static List<long> SortedLockServants()
		{
			return null;
		}

		public static long GetPreUnLockServant(long current)
		{
			return 0L;
		}

		public static long GetNextUnLockServant(long current)
		{
			return 0L;
		}

		public static long GetNextLockServant()
		{
			return 0L;
		}

		public static long GetPreLockServant()
		{
			return 0L;
		}

		public static ServantPropertyInfo GetServantPropertyInfo(long servantID)
		{
			return null;
		}

		public static int GetServantCombatPower(long servantid, long weaponid)
		{
			return 0;
		}

		public static long FindMaxCombatPowerWeapon(long servantid)
		{
			return 0L;
		}

		public static QuerySVEquipInfo QuerySvEquipIndexInfo(long svID, int index)
		{
			return null;
		}

		public static string CheckCanCompose(long ID, Dictionary<long, int> ConsumeItemAndNum, bool isRecursionMode = true)
		{
			return null;
		}

		public static string CanAddServantStar(long ID)
		{
			return null;
		}

		public static string CanSwitchWeaponSkin(long svId, long weaponId, int index)
		{
			return null;
		}

		public static bool IsNewServant(long svId)
		{
			return false;
		}

		public static void SetServantNotNew(long svId)
		{
		}

		public static bool IsNewServantImage(long svId, int serial)
		{
			return false;
		}

		public static bool HaveNewServantImage(long svId)
		{
			return false;
		}

		public static void SetServantImageNotNew(long svId, int serial)
		{
		}

		public static string CanReceiveServantImageFav(long sv, int index)
		{
			return null;
		}

		public static bool HaveServantImageFavReward(long sv)
		{
			return false;
		}

		public static bool HaveServantImage(long sv)
		{
			return false;
		}

		public static string CanChangeServantImage(long sv, int index)
		{
			return null;
		}

		public static List<TypeCsvAchievement> GetServantFavorQuest(long id)
		{
			return null;
		}

		public static List<ObservableSingleServant> GetAllUnlockServant()
		{
			return null;
		}

		public static void AddFavor(long id, int favorExp)
		{
		}

		public static List<long> GetAllSvQuestID()
		{
			return null;
		}

		public static FavQuest getFavQuest(long svid)
		{
			return null;
		}

		public static bool CanReceiveFavQuest(long svid)
		{
			return false;
		}

		public static void UnlockWeaponFashion(long weaponID, int serial)
		{
		}

		public static bool CheckWeaponFashion(long weaponID, int serial)
		{
			return false;
		}

		public static void SetSvHaveNoNewImage(long id)
		{
		}
	}
}
