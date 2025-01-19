using System.Collections.Generic;
using Mono.Cecil.Cil;
using Mono.Cecil.Metadata;
using Mono.Cecil.PE;
using Mono.Collections.Generic;

namespace Mono.Cecil
{
	internal sealed class MetadataReader : ByteBuffer
	{
		internal readonly Image image;

		internal readonly ModuleDefinition module;

		internal readonly MetadataSystem metadata;

		internal IGenericContext context;

		internal CodeReader code;

		private uint Position
		{
			get
			{
				return 0u;
			}
			set
			{
			}
		}

		public MetadataReader(ModuleDefinition module)
			: base(null)
		{
		}

		private int GetCodedIndexSize(CodedIndex index)
		{
			return 0;
		}

		private uint ReadByIndexSize(int size)
		{
			return 0u;
		}

		private byte[] ReadBlob()
		{
			return null;
		}

		private byte[] ReadBlob(uint signature)
		{
			return null;
		}

		private uint ReadBlobIndex()
		{
			return 0u;
		}

		private string ReadString()
		{
			return null;
		}

		private uint ReadStringIndex()
		{
			return 0u;
		}

		private uint ReadTableIndex(Table table)
		{
			return 0u;
		}

		private MetadataToken ReadMetadataToken(CodedIndex index)
		{
			return default(MetadataToken);
		}

		private int MoveTo(Table table)
		{
			return 0;
		}

		private bool MoveTo(Table table, uint row)
		{
			return false;
		}

		public AssemblyNameDefinition ReadAssemblyNameDefinition()
		{
			return null;
		}

		public ModuleDefinition Populate(ModuleDefinition module)
		{
			return null;
		}

		private void InitializeAssemblyReferences()
		{
		}

		public Collection<AssemblyNameReference> ReadAssemblyReferences()
		{
			return null;
		}

		public Collection<ModuleDefinition> ReadModules()
		{
			return null;
		}

		private string GetModuleFileName(string name)
		{
			return null;
		}

		private void InitializeModuleReferences()
		{
		}

		public Collection<ModuleReference> ReadModuleReferences()
		{
			return null;
		}

		public bool HasFileResource()
		{
			return false;
		}

		public Collection<Resource> ReadResources()
		{
			return null;
		}

		private Row<FileAttributes, string, uint> ReadFileRecord(uint rid)
		{
			return null;
		}

		private void PopulateVersionAndFlags(AssemblyNameReference name)
		{
		}

		private void PopulateNameAndCulture(AssemblyNameReference name)
		{
		}

		public TypeDefinitionCollection ReadTypes()
		{
			return null;
		}

		private void CompleteTypes()
		{
		}

		private void InitializeTypeDefinitions()
		{
		}

		private static bool IsNested(TypeAttributes attributes)
		{
			return false;
		}

		public bool HasNestedTypes(TypeDefinition type)
		{
			return false;
		}

		public Collection<TypeDefinition> ReadNestedTypes(TypeDefinition type)
		{
			return null;
		}

		private void InitializeNestedTypes()
		{
		}

		private void AddNestedMapping(uint declaring, uint nested)
		{
		}

		private static TValue[] AddMapping<TKey, TValue>(Dictionary<TKey, TValue[]> cache, TKey key, TValue value)
		{
			return null;
		}

		private TypeDefinition ReadType(uint rid)
		{
			return null;
		}

		private TypeDefinition GetNestedTypeDeclaringType(TypeDefinition type)
		{
			return null;
		}

		private Range ReadFieldsRange(uint type_index)
		{
			return default(Range);
		}

		private Range ReadMethodsRange(uint type_index)
		{
			return default(Range);
		}

		private Range ReadListRange(uint current_index, Table current, Table target)
		{
			return default(Range);
		}

		public Row<short, int> ReadTypeLayout(TypeDefinition type)
		{
			return null;
		}

		private void InitializeTypeLayouts()
		{
		}

		public TypeReference GetTypeDefOrRef(MetadataToken token)
		{
			return null;
		}

		public TypeDefinition GetTypeDefinition(uint rid)
		{
			return null;
		}

		private TypeDefinition ReadTypeDefinition(uint rid)
		{
			return null;
		}

		private void InitializeTypeReferences()
		{
		}

		private TypeReference GetTypeReference(uint rid)
		{
			return null;
		}

		private TypeReference ReadTypeReference(uint rid)
		{
			return null;
		}

		private IMetadataScope GetTypeReferenceScope(MetadataToken scope)
		{
			return null;
		}

		private TypeReference GetTypeSpecification(uint rid)
		{
			return null;
		}

		private SignatureReader ReadSignature(uint signature)
		{
			return null;
		}

		public bool HasInterfaces(TypeDefinition type)
		{
			return false;
		}

		public Collection<TypeReference> ReadInterfaces(TypeDefinition type)
		{
			return null;
		}

		private void InitializeInterfaces()
		{
		}

		private void AddInterfaceMapping(uint type, MetadataToken @interface)
		{
		}

		public Collection<FieldDefinition> ReadFields(TypeDefinition type)
		{
			return null;
		}

		private void ReadField(uint field_rid, Collection<FieldDefinition> fields)
		{
		}

		private void InitializeFields()
		{
		}

		private TypeReference ReadFieldType(uint signature)
		{
			return null;
		}

		public int ReadFieldRVA(FieldDefinition field)
		{
			return 0;
		}

		private byte[] GetFieldInitializeValue(int size, uint rva)
		{
			return null;
		}

		private static int GetFieldTypeSize(TypeReference type)
		{
			return 0;
		}

		private void InitializeFieldRVAs()
		{
		}

		public int ReadFieldLayout(FieldDefinition field)
		{
			return 0;
		}

		private void InitializeFieldLayouts()
		{
		}

		public bool HasEvents(TypeDefinition type)
		{
			return false;
		}

		public Collection<EventDefinition> ReadEvents(TypeDefinition type)
		{
			return null;
		}

		private void ReadEvent(uint event_rid, Collection<EventDefinition> events)
		{
		}

		private void InitializeEvents()
		{
		}

		private Range ReadEventsRange(uint rid)
		{
			return default(Range);
		}

		public bool HasProperties(TypeDefinition type)
		{
			return false;
		}

		public Collection<PropertyDefinition> ReadProperties(TypeDefinition type)
		{
			return null;
		}

		private void ReadProperty(uint property_rid, Collection<PropertyDefinition> properties)
		{
		}

		private void InitializeProperties()
		{
		}

		private Range ReadPropertiesRange(uint rid)
		{
			return default(Range);
		}

		private MethodSemanticsAttributes ReadMethodSemantics(MethodDefinition method)
		{
			return default(MethodSemanticsAttributes);
		}

		private static EventDefinition GetEvent(TypeDefinition type, MetadataToken token)
		{
			return null;
		}

		private static PropertyDefinition GetProperty(TypeDefinition type, MetadataToken token)
		{
			return null;
		}

		private static TMember GetMember<TMember>(Collection<TMember> members, MetadataToken token) where TMember : IMemberDefinition
		{
			return default(TMember);
		}

		private void InitializeMethodSemantics()
		{
		}

		public PropertyDefinition ReadMethods(PropertyDefinition property)
		{
			return null;
		}

		public EventDefinition ReadMethods(EventDefinition @event)
		{
			return null;
		}

		private void ReadAllSemantics(TypeDefinition type)
		{
		}

		private Range ReadParametersRange(uint method_rid)
		{
			return default(Range);
		}

		public Collection<MethodDefinition> ReadMethods(TypeDefinition type)
		{
			return null;
		}

		private void ReadPointers<TMember>(Table ptr, Table table, Range range, Collection<TMember> members, Action<uint, Collection<TMember>> reader) where TMember : IMemberDefinition
		{
		}

		private static bool IsDeleted(IMemberDefinition member)
		{
			return false;
		}

		private void InitializeMethods()
		{
		}

		private void ReadMethod(uint method_rid, Collection<MethodDefinition> methods)
		{
		}

		private void ReadParameters(MethodDefinition method, Range param_range)
		{
		}

		private void ReadParameterPointers(MethodDefinition method, Range range)
		{
		}

		private void ReadParameter(uint param_rid, MethodDefinition method)
		{
		}

		private void ReadMethodSignature(uint signature, IMethodSignature method)
		{
		}

		public PInvokeInfo ReadPInvokeInfo(MethodDefinition method)
		{
			return null;
		}

		private void InitializePInvokes()
		{
		}

		public bool HasGenericParameters(IGenericParameterProvider provider)
		{
			return false;
		}

		public Collection<GenericParameter> ReadGenericParameters(IGenericParameterProvider provider)
		{
			return null;
		}

		private void InitializeGenericParameters()
		{
		}

		private Dictionary<MetadataToken, Range> InitializeRanges(Table table, Func<MetadataToken> get_next)
		{
			return null;
		}

		public bool HasGenericConstraints(GenericParameter generic_parameter)
		{
			return false;
		}

		public Collection<TypeReference> ReadGenericConstraints(GenericParameter generic_parameter)
		{
			return null;
		}

		private void InitializeGenericConstraints()
		{
		}

		private void AddGenericConstraintMapping(uint generic_parameter, MetadataToken constraint)
		{
		}

		public bool HasOverrides(MethodDefinition method)
		{
			return false;
		}

		public Collection<MethodReference> ReadOverrides(MethodDefinition method)
		{
			return null;
		}

		private void InitializeOverrides()
		{
		}

		private void AddOverrideMapping(uint method_rid, MetadataToken @override)
		{
		}

		public MethodBody ReadMethodBody(MethodDefinition method)
		{
			return null;
		}

		public CallSite ReadCallSite(MetadataToken token)
		{
			return null;
		}

		public VariableDefinitionCollection ReadVariables(MetadataToken local_var_token)
		{
			return null;
		}

		public IMetadataTokenProvider LookupToken(MetadataToken token)
		{
			return null;
		}

		public FieldDefinition GetFieldDefinition(uint rid)
		{
			return null;
		}

		private FieldDefinition LookupField(uint rid)
		{
			return null;
		}

		public MethodDefinition GetMethodDefinition(uint rid)
		{
			return null;
		}

		private MethodDefinition LookupMethod(uint rid)
		{
			return null;
		}

		private MethodSpecification GetMethodSpecification(uint rid)
		{
			return null;
		}

		private MethodSpecification ReadMethodSpecSignature(uint signature, MethodReference method)
		{
			return null;
		}

		private MemberReference GetMemberReference(uint rid)
		{
			return null;
		}

		private MemberReference ReadMemberReference(uint rid)
		{
			return null;
		}

		private MemberReference ReadTypeMemberReference(MetadataToken type, string name, uint signature)
		{
			return null;
		}

		private MemberReference ReadMemberReferenceSignature(uint signature, TypeReference declaring_type)
		{
			return null;
		}

		private MemberReference ReadMethodMemberReference(MetadataToken token, string name, uint signature)
		{
			return null;
		}

		private void InitializeMemberReferences()
		{
		}

		private void InitializeConstants()
		{
		}

		public object ReadConstant(IConstantProvider owner)
		{
			return null;
		}

		private static string ReadConstantString(byte[] blob)
		{
			return null;
		}

		private object ReadConstantPrimitive(ElementType type, uint signature)
		{
			return null;
		}

		private void InitializeCustomAttributes()
		{
		}

		public bool HasCustomAttributes(ICustomAttributeProvider owner)
		{
			return false;
		}

		public Collection<CustomAttribute> ReadCustomAttributes(ICustomAttributeProvider owner)
		{
			return null;
		}

		private void InitializeMarshalInfos()
		{
		}

		public bool HasMarshalInfo(IMarshalInfoProvider owner)
		{
			return false;
		}

		public MarshalInfo ReadMarshalInfo(IMarshalInfoProvider owner)
		{
			return null;
		}

		private void InitializeSecurityDeclarations()
		{
		}

		public bool HasSecurityDeclarations(ISecurityDeclarationProvider owner)
		{
			return false;
		}

		public Collection<SecurityDeclaration> ReadSecurityDeclarations(ISecurityDeclarationProvider owner)
		{
			return null;
		}

		public Collection<ExportedType> ReadExportedTypes()
		{
			return null;
		}

		private IMetadataScope GetExportedTypeScope(MetadataToken token)
		{
			return null;
		}

		private ModuleReference GetModuleReferenceFromFile(MetadataToken token)
		{
			return null;
		}

		private static void InitializeCollection(object o)
		{
		}
	}
}
