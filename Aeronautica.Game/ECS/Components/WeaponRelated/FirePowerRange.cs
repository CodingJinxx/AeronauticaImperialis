using Svelto.ECS;

namespace Aeronautica.Game.ECS.Components.WeaponRelated;

public struct FirePowerRange : IEntityComponent
{
    /// <summary>
    /// How many dice are used on Short Range
    /// </summary>
    public int Short;
    /// <summary>
    /// How many dice are used on Medium Range
    /// </summary>
    public int Medium;
    /// <summary>
    /// How many dice are used on Long Range
    /// </summary>
    public int Long;
}