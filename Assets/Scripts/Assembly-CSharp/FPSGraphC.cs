using System.Diagnostics;
using UnityEngine;

public class FPSGraphC : MonoBehaviour
{
	private Material mat;

	public Material androidMaterial;

	public bool audioFeedback;

	public float audioFeedbackVolume;

	public int graphMultiply;

	public Vector2 graphPosition;

	public int frameHistoryLength;

	public Color CpuColor;

	public Color RenderColor;

	public Color OtherColor;

	private readonly int[] numberBits;

	private readonly int[] fpsBits;

	private readonly int[] mbBits;

	private readonly float[] bNote;

	private readonly Color[] graphKeys;

	private AudioClip audioClip;

	private AudioSource audioSource;

	private Texture2D graphTexture;

	private int graphHeight;

	private int[,] textOverlayMask;

	private float[,] dtHistory;

	private int i;

	private int j;

	private int x;

	private int y;

	private float val;

	private Color color;

	private Color32 color32;

	private float maxFrame;

	private float yMulti;

	private static Color[] fpsColors;

	private static Color[] fpsColorsTo;

	private Color lineColor;

	private Color darkenedBack;

	private Color darkenedBackWhole;

	private Color32[] colorsWrite;

	private Rect graphSizeGUI;

	private Stopwatch stopWatch;

	private float lastElapsed;

	private float fps;

	private int graphSizeMin;

	private int xExtern;

	private int yExtern;

	private int startAt;

	private int yOffset;

	private int xLength;

	private float totalSeconds;

	private float renderSeconds;

	private float lateSeconds;

	private float dt;

	private int frameIter;

	private float eTotalSeconds;

	private float beforeRender;

	private float[] fpsVals;

	private float x1;

	private float x2;

	private float y1;

	private float y2;

	private float xOff;

	private float yOff;

	private int[] lineY;

	private int[] lineY2;

	private int[] keyOffX;

	private string[] splitMb;

	private int first;

	private int second;

	public void CreateLineMaterial()
	{
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void initAudio()
	{
	}

	private void addFPSAt(int startX, int startY)
	{
	}

	private void addNumberAt(int startX, int startY, int num, bool isLeading)
	{
	}

	private void addPeriodAt(int startX, int startY)
	{
	}

	private void Update()
	{
	}

	private void LateUpdate()
	{
	}

	private void OnPostRender()
	{
	}

	private void OnGUI()
	{
	}
}
