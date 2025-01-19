using System.Collections.Generic;

namespace Pathfinding.ClipperLib
{
	public class Clipper : ClipperBase
	{
		public const int ioReverseSolution = 1;

		public const int ioStrictlySimple = 2;

		public const int ioPreserveCollinear = 4;

		private List<OutRec> m_PolyOuts;

		private ClipType m_ClipType;

		private Scanbeam m_Scanbeam;

		private TEdge m_ActiveEdges;

		private TEdge m_SortedEdges;

		private IntersectNode m_IntersectNodes;

		private bool m_ExecuteLocked;

		private PolyFillType m_ClipFillType;

		private PolyFillType m_SubjFillType;

		private List<Join> m_Joins;

		private List<Join> m_GhostJoins;

		private bool m_UsingPolyTree;

		public bool ReverseSolution { get; set; }

		public bool StrictlySimple { get; set; }

		public Clipper(int InitOptions = 0)
		{
		}

		public override void Clear()
		{
		}

		protected override void Reset()
		{
		}

		private void InsertScanbeam(long Y)
		{
		}

		public bool Execute(ClipType clipType, List<List<IntPoint>> solution, PolyFillType subjFillType, PolyFillType clipFillType)
		{
			return false;
		}

		public bool Execute(ClipType clipType, PolyTree polytree, PolyFillType subjFillType, PolyFillType clipFillType)
		{
			return false;
		}

		internal void FixHoleLinkage(OutRec outRec)
		{
		}

		private bool ExecuteInternal()
		{
			return false;
		}

		private long PopScanbeam()
		{
			return 0L;
		}

		private void DisposeAllPolyPts()
		{
		}

		private void DisposeOutRec(int index)
		{
		}

		private void DisposeOutPts(OutPt pp)
		{
		}

		private void AddJoin(OutPt Op1, OutPt Op2, IntPoint OffPt)
		{
		}

		private void AddGhostJoin(OutPt Op, IntPoint OffPt)
		{
		}

		private void InsertLocalMinimaIntoAEL(long botY)
		{
		}

		private void InsertEdgeIntoAEL(TEdge edge, TEdge startEdge)
		{
		}

		private bool E2InsertsBeforeE1(TEdge e1, TEdge e2)
		{
			return false;
		}

		private bool IsEvenOddFillType(TEdge edge)
		{
			return false;
		}

		private bool IsEvenOddAltFillType(TEdge edge)
		{
			return false;
		}

		private bool IsContributing(TEdge edge)
		{
			return false;
		}

		private void SetWindingCount(TEdge edge)
		{
		}

		private void AddEdgeToSEL(TEdge edge)
		{
		}

		private void CopyAELToSEL()
		{
		}

		private void SwapPositionsInAEL(TEdge edge1, TEdge edge2)
		{
		}

		private void SwapPositionsInSEL(TEdge edge1, TEdge edge2)
		{
		}

		private void AddLocalMaxPoly(TEdge e1, TEdge e2, IntPoint pt)
		{
		}

		private OutPt AddLocalMinPoly(TEdge e1, TEdge e2, IntPoint pt)
		{
			return null;
		}

		private OutRec CreateOutRec()
		{
			return null;
		}

		private OutPt AddOutPt(TEdge e, IntPoint pt)
		{
			return null;
		}

		private bool HorzSegmentsOverlap(IntPoint Pt1a, IntPoint Pt1b, IntPoint Pt2a, IntPoint Pt2b)
		{
			return false;
		}

		private void SetHoleState(TEdge e, OutRec outRec)
		{
		}

		private double GetDx(IntPoint pt1, IntPoint pt2)
		{
			return 0.0;
		}

		private bool FirstIsBottomPt(OutPt btmPt1, OutPt btmPt2)
		{
			return false;
		}

		private OutPt GetBottomPt(OutPt pp)
		{
			return null;
		}

		private OutRec GetLowermostRec(OutRec outRec1, OutRec outRec2)
		{
			return null;
		}

		private bool Param1RightOfParam2(OutRec outRec1, OutRec outRec2)
		{
			return false;
		}

		private OutRec GetOutRec(int idx)
		{
			return null;
		}

		private void AppendPolygon(TEdge e1, TEdge e2)
		{
		}

		private void ReversePolyPtLinks(OutPt pp)
		{
		}

		private static void SwapSides(TEdge edge1, TEdge edge2)
		{
		}

		private static void SwapPolyIndexes(TEdge edge1, TEdge edge2)
		{
		}

		private void IntersectEdges(TEdge e1, TEdge e2, IntPoint pt, bool protect = false)
		{
		}

		private void DeleteFromAEL(TEdge e)
		{
		}

		private void DeleteFromSEL(TEdge e)
		{
		}

		private void UpdateEdgeIntoAEL(ref TEdge e)
		{
		}

		private void ProcessHorizontals(bool isTopOfScanbeam)
		{
		}

		private void GetHorzDirection(TEdge HorzEdge, out Direction Dir, out long Left, out long Right)
		{
			Dir = default(Direction);
			Left = default(long);
			Right = default(long);
		}

		private void PrepareHorzJoins(TEdge horzEdge, bool isTopOfScanbeam)
		{
		}

		private void ProcessHorizontal(TEdge horzEdge, bool isTopOfScanbeam)
		{
		}

		private TEdge GetNextInAEL(TEdge e, Direction Direction)
		{
			return null;
		}

		private bool IsMaxima(TEdge e, double Y)
		{
			return false;
		}

		private bool IsIntermediate(TEdge e, double Y)
		{
			return false;
		}

		private TEdge GetMaximaPair(TEdge e)
		{
			return null;
		}

		private bool ProcessIntersections(long botY, long topY)
		{
			return false;
		}

		private void BuildIntersectList(long botY, long topY)
		{
		}

		private bool EdgesAdjacent(IntersectNode inode)
		{
			return false;
		}

		private bool FixupIntersectionOrder()
		{
			return false;
		}

		private void ProcessIntersectList()
		{
		}

		internal static long Round(double value)
		{
			return 0L;
		}

		private static long TopX(TEdge edge, long currentY)
		{
			return 0L;
		}

		private void InsertIntersectNode(TEdge e1, TEdge e2, IntPoint pt)
		{
		}

		private void SwapIntersectNodes(IntersectNode int1, IntersectNode int2)
		{
		}

		private bool IntersectPoint(TEdge edge1, TEdge edge2, out IntPoint ip)
		{
			ip = default(IntPoint);
			return false;
		}

		private void DisposeIntersectNodes()
		{
		}

		private void ProcessEdgesAtTopOfScanbeam(long topY)
		{
		}

		private void DoMaxima(TEdge e)
		{
		}

		public static bool Orientation(List<IntPoint> poly)
		{
			return false;
		}

		private int PointCount(OutPt pts)
		{
			return 0;
		}

		private void BuildResult(List<List<IntPoint>> polyg)
		{
		}

		private void BuildResult2(PolyTree polytree)
		{
		}

		private void FixupOutPolygon(OutRec outRec)
		{
		}

		private OutPt DupOutPt(OutPt outPt, bool InsertAfter)
		{
			return null;
		}

		private bool GetOverlap(long a1, long a2, long b1, long b2, out long Left, out long Right)
		{
			Left = default(long);
			Right = default(long);
			return false;
		}

		private bool JoinHorz(OutPt op1, OutPt op1b, OutPt op2, OutPt op2b, IntPoint Pt, bool DiscardLeft)
		{
			return false;
		}

		private bool JoinPoints(Join j, out OutPt p1, out OutPt p2)
		{
			p1 = null;
			p2 = null;
			return false;
		}

		private bool Poly2ContainsPoly1(OutPt outPt1, OutPt outPt2, bool UseFullRange)
		{
			return false;
		}

		private void FixupFirstLefts1(OutRec OldOutRec, OutRec NewOutRec)
		{
		}

		private void FixupFirstLefts2(OutRec OldOutRec, OutRec NewOutRec)
		{
		}

		private void JoinCommonEdges()
		{
		}

		private void UpdateOutPtIdxs(OutRec outrec)
		{
		}

		private void DoSimplePolygons()
		{
		}

		public static double Area(List<IntPoint> poly)
		{
			return 0.0;
		}

		private double Area(OutRec outRec)
		{
			return 0.0;
		}
	}
}
