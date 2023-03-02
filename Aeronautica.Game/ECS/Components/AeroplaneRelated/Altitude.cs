using Svelto.ECS;

namespace Aeronautica.Game.ECS.Components;

public struct Altitude : IEntityComponent
{
    /// <summary>
    /// Maximum Altitude that can be reached
    /// </summary>
    public int MaxAltitude;
    
    /// <summary>
    /// Current Altitude
    /// </summary>
    public int CurrentAltitude;
}