using System;
using System.Collections.Generic;

public interface IGameContainer
{
	TypeMappingCollection Mappings { get; set; }

	TypeInstanceCollection Instances { get; set; }

	TypeRelationCollection RelationshipMappings { get; set; }

	void Clear();

	void Inject(object obj);

	void InjectAll();

	void Register<TSource, TTarget>(string name = null);

	void RegisterRelation<TFor, TBase, TConcrete>();

	void RegisterInstance<TBase>(TBase @default, bool injectNow) where TBase : class;

	void RegisterInstance(Type type, object @default, bool injectNow);

	void RegisterInstance(Type baseType, object instance = null, string name = null, bool injectNow = true);

	void RegisterInstance<TBase>(TBase instance, string name, bool injectNow = true) where TBase : class;

	void RegisterInstance<TBase>(TBase instance) where TBase : class;

	T Resolve<T>(string name = null, bool requireInstance = false, params object[] args) where T : class;

	TBase ResolveRelation<TBase>(Type tfor, params object[] arg);

	TBase ResolveRelation<TFor, TBase>(params object[] arg);

	IEnumerable<TType> ResolveAll<TType>();

	void Register(Type source, Type target, string name = null);

	IEnumerable<object> ResolveAll(Type type);

	object Resolve(Type baseType, string name = null, bool requireInstance = false, params object[] constructorArgs);

	object ResolveRelation(Type tfor, Type tbase, params object[] arg);
}
