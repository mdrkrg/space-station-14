using Robust.Shared.GameStates;
using Robust.Shared.Prototypes;

namespace Content.Shared.Projectiles;

[RegisterComponent]
public sealed partial class SurfacePorousComponent : Component
{
    /// <summary>
    /// How hollow the entity is.
    /// That is, the chance of the entity being by passed by a projectile on hit.
    /// </summary>
    [DataField, ViewVariables(VVAccess.ReadWrite)]
    public float Porosity = 0.0f;
}
