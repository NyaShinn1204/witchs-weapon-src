public class UserSettingData
{
	public enum ServiceGoBtn
	{
		cn = 0,
		kr = 1,
		jp = 2,
		tw = 3,
		en = 4
	}

	public enum UserType
	{
		cn = 0,
		kr = 1,
		jp = 2,
		tw = 3,
		en = 4
	}

	public bool ShowServiceText;

	public ServiceGoBtn GoBtnType;

	public UserType userType;
}
