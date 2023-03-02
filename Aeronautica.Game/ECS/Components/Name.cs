using Svelto.ECS;

namespace Aeronautica.Game.ECS.Components;

public struct Name : IEntityComponent
{
    /// <summary>
    /// Name of the entity
    /// </summary>
    public string Value;
}