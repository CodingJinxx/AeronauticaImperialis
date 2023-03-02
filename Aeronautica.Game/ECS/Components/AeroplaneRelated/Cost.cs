using Svelto.ECS;

namespace Aeronautica.Game.ECS.Components;

public struct Cost : IEntityComponent
{
    /// <summary>
    /// How many Points it costs to buy
    /// </summary>
    public int Points;
}