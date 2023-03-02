namespace Aeronautica.Game.ECS.Components.WeaponRelated;


/// <summary>
/// In Which Directions can the Weapon Fire?
/// </summary>
public struct FireArc
{
    /// <summary>
    /// Can the Weapon Fire Forward?
    /// </summary>
    public bool Front;
    /// <summary>
    /// Can the Weapon Fire Left?
    /// </summary>
    public bool Left;
    /// <summary>
    /// Can the Weapon Fire Right?
    /// </summary>
    public bool Right;
    /// <summary>
    /// Can the Weapon Fire Backwards?
    /// </summary>
    public bool Rear;
    /// <summary>
    /// Can the weapon ignore Height Point Reductions?
    /// </summary>
    public bool Up;
}