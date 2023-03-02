using Svelto.ECS;

namespace Aeronautica.Game.ECS.Components;

public struct Speed : IEntityComponent
{
    /// <summary>
    /// Current Speed
    /// </summary>
    public int CurrentSpeed;

    /// <summary>
    /// Maximum Speed before the aircraft Spins
    /// </summary>
    public int MaxSpeed;
    
    /// <summary>
    /// Minimum Speed before the aircraft Spins
    /// </summary>
    public int MinSpeed;
}