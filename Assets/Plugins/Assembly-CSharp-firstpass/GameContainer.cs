using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;

public class GameContainer : IGameContainer
{
	private TypeInstanceCollection _instances;

	private TypeMappingCollection _mappings;

	private static Dictionary<Type, MemberInfo[]> _fashMemberInfo;

	private static Dictionary<MemberInfo, InjectAttribute> _fashInjectAttribute;

	private TypeRelationCollection _relationshipMappings;

	public TypeMappingCollection Mappings
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public TypeInstanceCollection Instances
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public TypeRelationCollection RelationshipMappings
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[DebuggerHidden]
	public IEnumerable<TType> ResolveAll<TType>()
	{
		return null;
	}

	[DebuggerHidden]
	public IEnumerable<object> ResolveAll(Type type)
	{
		return null;
	}

	public void Clear()
	{
	}

	public void Inject(object obj)
	{
	}

	private MemberInfo[] GetMemberInfoFast(Type sType)
	{
		return null;
	}

	private InjectAttribute GetInjectAttributeFast(MemberInfo sMemberInfo)
	{
		return null;
	}

	public void Register<TSource, TTarget>(string name = null)
	{
	}

	public void Register(Type source, Type target, string name = null)
	{
	}

	public void RegisterInstance(Type baseType, object instance = null, bool injectNow = true)
	{
	}

	public virtual void RegisterInstance(Type baseType, object instance = null, string name = null, bool injectNow = true)
	{
	}

	public void RegisterInstance<TBase>(TBase instance) where TBase : class
	{
	}

	public void RegisterInstance<TBase>(TBase instance, bool injectNow) where TBase : class
	{
	}

	public void RegisterInstance<TBase>(TBase instance, string name, bool injectNow = true) where TBase : class
	{
	}

	public T Resolve<T>(string name = null, bool requireInstance = false, params object[] args) where T : class
	{
		return null;
	}

	public object Resolve(Type baseType, string name = null, bool requireInstance = false, params object[] constructorArgs)
	{
		return null;
	}

	public object CreateInstance(Type type, params object[] constructorArgs)
	{
		return null;
	}

	public TBase ResolveRelation<TBase>(Type tfor, params object[] args)
	{
		return default(TBase);
	}

	public void InjectAll()
	{
	}

	public void RegisterRelation<TFor, TBase, TConcrete>()
	{
	}

	public object ResolveRelation(Type tfor, Type tbase, params object[] args)
	{
		return null;
	}

	public TBase ResolveRelation<TFor, TBase>(params object[] arg)
	{
		return default(TBase);
	}
}
