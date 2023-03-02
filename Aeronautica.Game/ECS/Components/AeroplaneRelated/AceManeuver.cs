using Svelto.ECS;

namespace Aeronautica.Game.ECS.Components;

public struct AceManeuver : IEntityComponent
{
    /// <summary>
    /// How many tuns can be completed in a turn
    /// </summary>
    public int MaxTurns;
}