using Svelto.ECS;

namespace Aeronautica.Game.ECS.Components;

public struct Handling : IEntityComponent
{
    /// <summary>
    /// Which Value must be exceeded or met to pass Handling Check
    /// </summary>
    public int HandlingPassValue;
}