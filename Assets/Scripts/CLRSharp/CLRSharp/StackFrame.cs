using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Mono.Cecil.Cil;

namespace CLRSharp
{
	public class StackFrame
	{
		public class MyCalcStack : Stack<object>
		{
			private Queue<VBox> unused;

			public void Push(VBox box)
			{
			}

			public new object Pop()
			{
				return null;
			}

			public void ClearVBox()
			{
			}
		}

		public class MySlotVar : List<object>
		{
			public void Add(VBox box)
			{
			}

			public void ClearVBox()
			{
			}
		}

		public enum RefType
		{
			loc = 0,
			arg = 1,
			field = 2,
			Array = 3
		}

		public class RefObj
		{
			public StackFrame frame;

			public int pos;

			public RefType type;

			public IField _field;

			public object _this;

			public Array _array;

			public RefObj(StackFrame frame, int pos, RefType type)
			{
			}

			public RefObj(IField field, object _this)
			{
			}

			public RefObj(Array array, int index)
			{
			}

			public void Set(object obj)
			{
			}

			public object Get()
			{
				return null;
			}
		}

		[CompilerGenerated]
		private string _003CName_003Ek__BackingField;

		private Instruction _posold;

		public int _codepos;

		public MyCalcStack stackCalc;

		public MySlotVar slotVar;

		public object[] _params;

		private CodeBody _body;

		private string Name
		{
			[CompilerGenerated]
			set
			{
				_003CName_003Ek__BackingField = value;
			}
		}

		public bool IsStatic { get; private set; }

		public StackFrame(string name, bool isStatic)
		{
		}

		public void SetCodePos(int offset)
		{
		}

		public Instruction GetCode()
		{
			return null;
		}

		public void SetParams(object[] _p)
		{
		}

		public void Init(CodeBody body)
		{
		}

		public object Return()
		{
			return null;
		}

		private void FillArray(object array, byte[] bytes)
		{
		}

		public void Call(ThreadContext context, IMethod _clrmethod, bool bVisual)
		{
		}

		public void Nop()
		{
		}

		public void Dup()
		{
		}

		public void Pop()
		{
		}

		public void Ret()
		{
		}

		public void Box(ICLRType type)
		{
		}

		public void Unbox()
		{
		}

		public void Unbox_Any()
		{
		}

		public void Br(int addr_index)
		{
		}

		public void Leave(int addr_index)
		{
		}

		public void Brtrue(int addr_index)
		{
		}

		public void Brfalse(int addr_index)
		{
		}

		public void Beq(int addr_index)
		{
		}

		public void Bne_Un(int addr_index)
		{
		}

		public void Bge(int addr_index)
		{
		}

		public void Bge_Un(int addr_index)
		{
		}

		public void Bgt(int addr_index)
		{
		}

		public void Bgt_Un(int addr_index)
		{
		}

		public void Ble(int addr_index)
		{
		}

		public void Ble_Un(int addr_index)
		{
		}

		public void Blt(int addr_index)
		{
		}

		public void Blt_Un(int addr_index)
		{
		}

		public void Ldc_I4(int v)
		{
		}

		public void Ldc_I8(long v)
		{
		}

		public void Ldc_R4(float v)
		{
		}

		public void Ldc_R8(double v)
		{
		}

		public void Stloc(int pos)
		{
		}

		public void Ldloc(int pos)
		{
		}

		public void Ldloca(int pos)
		{
		}

		public void Ldstr(string text)
		{
		}

		public void Ldarg(int pos)
		{
		}

		public void Ldarga(int pos)
		{
		}

		public void Ceq()
		{
		}

		public void Cgt()
		{
		}

		public void Cgt_Un()
		{
		}

		public void Clt()
		{
		}

		public void Clt_Un()
		{
		}

		public void Ckfinite()
		{
		}

		public void Add()
		{
		}

		public VBox GetVBox(object obj)
		{
			return null;
		}

		public void Sub()
		{
		}

		public void Mul()
		{
		}

		public void Div()
		{
		}

		public void Div_Un()
		{
		}

		public void Rem()
		{
		}

		public void Rem_Un()
		{
		}

		public void Neg()
		{
		}

		public void Conv_I1()
		{
		}

		public void Conv_U1()
		{
		}

		public void Conv_I2()
		{
		}

		public void Conv_U2()
		{
		}

		public void Conv_I4()
		{
		}

		public void Conv_U4()
		{
		}

		public void Conv_I8()
		{
		}

		public void Conv_U8()
		{
		}

		public void Conv_I()
		{
		}

		public void Conv_U()
		{
		}

		public void Conv_R4()
		{
		}

		public void Conv_R8()
		{
		}

		public void Conv_R_Un()
		{
		}

		public void NewArr(ThreadContext context, Type type)
		{
		}

		public void LdLen()
		{
		}

		public void Ldelema(object obj)
		{
		}

		public void Ldelem_I1()
		{
		}

		public void Ldelem_U1()
		{
		}

		public void Ldelem_I2()
		{
		}

		public void Ldelem_U2()
		{
		}

		public void Ldelem_I4()
		{
		}

		public void Ldelem_U4()
		{
		}

		public void Ldelem_I8()
		{
		}

		public void Ldelem_I()
		{
		}

		public void Ldelem_R4()
		{
		}

		public void Ldelem_R8()
		{
		}

		public void Ldelem_Ref()
		{
		}

		public void Ldelem_Any(object obj)
		{
		}

		public void Stelem_I()
		{
		}

		public void Stelem_I1()
		{
		}

		public void Stelem_I2()
		{
		}

		public void Stelem_I4()
		{
		}

		public void Stelem_I8()
		{
		}

		public void Stelem_R4()
		{
		}

		public void Stelem_R8()
		{
		}

		public void Stelem_Ref()
		{
		}

		public void Stelem_Any()
		{
		}

		public void NewObj(ThreadContext context, IMethod _clrmethod)
		{
		}

		public void Ldfld(ThreadContext context, IField field)
		{
		}

		public void Ldflda(ThreadContext context, IField field)
		{
		}

		public void Ldsfld(ThreadContext context, IField field)
		{
		}

		public void Ldsflda(ThreadContext context, IField field)
		{
		}

		public void Stfld(ThreadContext context, IField field)
		{
		}

		public void Stsfld(ThreadContext context, IField field)
		{
		}

		public void Constrained(ThreadContext context, ICLRType obj)
		{
		}

		public void Isinst(ThreadContext context, ICLRType _type)
		{
		}

		public void Ldtoken(ThreadContext context, object token)
		{
		}

		public void Conv_Ovf_I1()
		{
		}

		public void Conv_Ovf_U1()
		{
		}

		public void Conv_Ovf_I2()
		{
		}

		public void Conv_Ovf_U2()
		{
		}

		public void Conv_Ovf_I4()
		{
		}

		public void Conv_Ovf_U4()
		{
		}

		public void Conv_Ovf_I8()
		{
		}

		public void Conv_Ovf_U8()
		{
		}

		public void Conv_Ovf_I()
		{
		}

		public void Conv_Ovf_U()
		{
		}

		public void Conv_Ovf_I1_Un()
		{
		}

		public void Conv_Ovf_U1_Un()
		{
		}

		public void Conv_Ovf_I2_Un()
		{
		}

		public void Conv_Ovf_U2_Un()
		{
		}

		public void Conv_Ovf_I4_Un()
		{
		}

		public void Conv_Ovf_U4_Un()
		{
		}

		public void Conv_Ovf_I8_Un()
		{
		}

		public void Conv_Ovf_U8_Un()
		{
		}

		public void Conv_Ovf_I_Un()
		{
		}

		public void Conv_Ovf_U_Un()
		{
		}

		public void Ldftn(ThreadContext context, IMethod method)
		{
		}

		public void Ldvirtftn(ThreadContext context, IMethod method)
		{
		}

		public void Starg(ThreadContext context, int p)
		{
		}

		public void Calli(ThreadContext context, object obj)
		{
		}

		public void Break(ThreadContext context, object obj)
		{
		}

		public void Ldnull()
		{
		}

		public void Jmp(ThreadContext context, object obj)
		{
		}

		public void Switch(ThreadContext context, int[] index)
		{
		}

		public void Ldind_I1()
		{
		}

		public void Ldind_U1()
		{
		}

		public void Ldind_I2()
		{
		}

		public void Ldind_U2()
		{
		}

		public void Ldind_I4()
		{
		}

		public void Ldind_U4()
		{
		}

		public void Ldind_I8()
		{
		}

		public void Ldind_I()
		{
		}

		public void Ldind_R4()
		{
		}

		public void Ldind_R8()
		{
		}

		public void Ldind_Ref()
		{
		}

		public void Stind_Ref(ThreadContext context, object obj)
		{
		}

		public void Stind_I1(ThreadContext context, object obj)
		{
		}

		public void Stind_I2(ThreadContext context, object obj)
		{
		}

		public void Stind_I4(ThreadContext context, object obj)
		{
		}

		public void Stind_I8(ThreadContext context, object obj)
		{
		}

		public void Stind_R4(ThreadContext context, object obj)
		{
		}

		public void Stind_R8(ThreadContext context, object obj)
		{
		}

		public void And()
		{
		}

		public void Or()
		{
		}

		public void Xor()
		{
		}

		public void Shl(ThreadContext context, object obj)
		{
		}

		public void Shr(ThreadContext context, object obj)
		{
		}

		public void Shr_Un(ThreadContext context, object obj)
		{
		}

		public void Not()
		{
		}

		public void Cpobj(ThreadContext context, object obj)
		{
		}

		public void Ldobj(ThreadContext context, object obj)
		{
		}

		public void Castclass(ThreadContext context, ICLRType _type)
		{
		}

		public void Throw(ThreadContext context, object obj)
		{
		}

		public void Stobj(ThreadContext context, object obj)
		{
		}

		public void Refanyval(ThreadContext context, object obj)
		{
		}

		public void Mkrefany(ThreadContext context, object obj)
		{
		}

		public void Add_Ovf(ThreadContext context, object obj)
		{
		}

		public void Add_Ovf_Un(ThreadContext context, object obj)
		{
		}

		public void Mul_Ovf(ThreadContext context, object obj)
		{
		}

		public void Mul_Ovf_Un(ThreadContext context, object obj)
		{
		}

		public void Sub_Ovf(ThreadContext context, object obj)
		{
		}

		public void Sub_Ovf_Un(ThreadContext context, object obj)
		{
		}

		public void Endfinally(ThreadContext context, object obj)
		{
		}

		public void Stind_I(ThreadContext context, object obj)
		{
		}

		public void Arglist(ThreadContext context, object obj)
		{
		}

		public void Localloc(ThreadContext context, object obj)
		{
		}

		public void Endfilter(ThreadContext context, object obj)
		{
		}

		public void Unaligned(ThreadContext context, object obj)
		{
		}

		public void Volatile()
		{
		}

		public void Tail(ThreadContext context, object obj)
		{
		}

		public void Initobj(ThreadContext context, ICLRType _type)
		{
		}

		public void Cpblk(ThreadContext context, object obj)
		{
		}

		public void Initblk(ThreadContext context, object obj)
		{
		}

		public void No(ThreadContext context, object obj)
		{
		}

		public void Rethrow(ThreadContext context, object obj)
		{
		}

		public void Sizeof(ThreadContext context, object obj)
		{
		}

		public void Refanytype(ThreadContext context, object obj)
		{
		}

		public void Readonly(ThreadContext context, object obj)
		{
		}
	}
}
