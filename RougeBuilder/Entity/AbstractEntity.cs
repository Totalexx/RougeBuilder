using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using RougeBuilder.Component;

namespace RougeBuilder.Model;

public abstract class AbstractEntity
{
    private readonly Dictionary<Type, AbstractComponent> _components = new();

    public T GetComponent<T>() where T : AbstractComponent
    {
        return (T)_components[typeof(T)];
    }
    
    public bool HasComponent<T>() where T : AbstractComponent
    {
        return _components.ContainsKey(typeof(T));
    }
    
    public ImmutableDictionary<Type, AbstractComponent> GetAllComponents()
    {
        return _components.ToImmutableDictionary();
    }
    
    protected void AddComponent(AbstractComponent component)
    {
        _components.Add(component.GetType(), component);
    }
}