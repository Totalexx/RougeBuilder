using System.Collections.Generic;
using RougeBuilder.Component;
using RougeBuilder.Component.Impl;

namespace RougeBuilder.Model.Impl.Map;

public class Map : AbstractEntity
{
    protected override IEnumerable<AbstractComponent> InitializeComponents()
    {
        return new AbstractComponent[]
        {
            new MapMarker(),
            new EntityCollector<Tile>()
        };
    }
}