using Svelto.ECS;

namespace Aeronautica.Game.ECS.Components.WeaponRelated;

public struct Damage : IEntityComponent
{
    /// <summary>
    /// The value which must be passed in order to register a hit
    /// </summary>
    public int DamageThreshold;
}