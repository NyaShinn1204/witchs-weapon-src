using System;

[Serializable]
public class PropertiesVO
{
	public CryptionFloat HP;

	public PropertyValue DPCDmgPM;

	public PropertyValue DMHP;

	public PropertyValue DMHV;

	public PropertyValue BPATK;

	public PropertyValue APAP;

	public PropertyValue APAV;

	public PropertyValue BPDEF;

	public PropertyValue DPDP;

	public PropertyValue DPDV;

	public PropertyValue BMATK;

	public PropertyValue AMAP;

	public PropertyValue AMAV;

	public PropertyValue BMDEF;

	public PropertyValue DMDP;

	public PropertyValue DMDV;

	public PropertyValue BHP;

	public PropertyValue HPP;

	public PropertyValue HPV;

	public PropertyValue BPCR;

	public PropertyValue APCV;

	public PropertyValue BMCR;

	public PropertyValue AMCV;

	public PropertyValue BPCM;

	public PropertyValue APCMV;

	public PropertyValue BMCM;

	public PropertyValue AMCMV;

	public PropertyValue BHR;

	public PropertyValue AHV;

	public PropertyValue BDR;

	public PropertyValue DDV;

	public PropertyValue BIPDR;

	public PropertyValue AIPDV;

	public PropertyValue BIMDR;

	public PropertyValue AIMDV;

	public PropertyValue APDmgPM;

	public PropertyValue DPPDmgPM;

	public PropertyValue AMDmgPM;

	public PropertyValue DPMDmgPM;

	public PropertyValue AHealPM;

	public PropertyValue DPHealPM;

	public PropertyValue ACDmgM;

	public PropertyValue APDmgM;

	public PropertyValue AMDmgM;

	public PropertyValue ERTM;

	public PropertyValue ERKTM;

	public PropertyValue ERAM;

	public PropertyValue ERIM;

	public float PDM;

	public float MDM;

	public float PDEFM;

	public float MDEFM;

	public float HM;

	public float GetValue(int index)
	{
		return 0f;
	}

	public float GetValueByAll(int index, int tag)
	{
		return 0f;
	}

	public float GetInteralValue(int index, int condition)
	{
		return 0f;
	}

	public void SetValue(int index, float value, int condition)
	{
	}

	public PropertiesVO Clone()
	{
		return null;
	}
}
