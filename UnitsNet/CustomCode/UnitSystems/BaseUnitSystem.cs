using System;

namespace UnitsNet.UnitSystems
{
    /// <summary>
    /// Represents a unit system derived from the SI base units
    /// </summary>
    public class BaseUnitSystem : UnitSystem, IEquatable<BaseUnitSystem>
    {

        /// <summary>
        /// Construct using the original behavior of matching the BaseUnits definition for Units 
        /// </summary>
        /// <param name="baseUnits">The base units for this unit system</param>
        [Obsolete("This constructor relies on the presence of BaseUnits property for Units- which is likely to be removed")]
        public BaseUnitSystem(BaseUnits baseUnits) : base(baseUnits)
        {
            if (!baseUnits.IsFullyDefined)
            {
                throw new ArgumentException("A unit system must have all base units defined.", nameof(baseUnits));
            }
            BaseUnits = baseUnits;
        }

        /// <summary>
        /// Construct a BaseUnitSystem with default BaseUnits and a set of unit configurations (for each quantity)
        /// </summary>
        /// <param name="baseUnits">The base units for this unit system</param>
        /// <param name="systemInfos">The units configuration for this unit system</param>
        public BaseUnitSystem(BaseUnits baseUnits, UnitSystemInfo[] systemInfos) : base(systemInfos)
        {
            // TODO should we required that baseUnits are FullyDefined?
            if (!baseUnits.IsFullyDefined)
            {
                throw new ArgumentException("A unit system must have all base units defined.", nameof(baseUnits));
            }
            BaseUnits = baseUnits;
        }

        /// <summary>
        /// Construct a BaseUnitSystem with default BaseUnits and a lazy-loaded set of unit configurations (for each quantity)
        /// </summary>
        /// <param name="baseUnits">The base units for this unit system</param>
        /// <param name="systemInfos">The units configuration for this unit system (lazy-loaded)</param>
        public BaseUnitSystem(BaseUnits baseUnits, Lazy<UnitSystemInfo[]> systemInfos) : base(systemInfos)
        {
            // TODO should we required that baseUnits are FullyDefined?
            if (!baseUnits.IsFullyDefined)
            {
                throw new ArgumentException("A unit system must have all base units defined.", nameof(baseUnits));
            }
            BaseUnits = baseUnits;
        }

        /// <summary>
        ///     The base units of this unit system.
        /// </summary>
        public BaseUnits BaseUnits { get; }


        /// <inheritdoc />
        public bool Equals(BaseUnitSystem other)
        {
            if (other is null)
            {
                return false;
            }

            return BaseUnits.Equals(other.BaseUnits);
        }

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (obj is null || !(obj is BaseUnitSystem))
            {
                return false;
            }

            return Equals((BaseUnitSystem) obj);
        }

        /// <summary>
        ///     Checks if this instance is equal to another.
        /// </summary>
        /// <param name="left">The left instance.</param>
        /// <param name="right">The right instance.</param>
        /// <returns>True if equal, otherwise false.</returns>
        /// <seealso cref="Equals(BaseUnitSystem)" />
        public static bool operator ==(BaseUnitSystem left, BaseUnitSystem right)
        {
            return left is null ? right is null : left.Equals(right);
        }

        /// <summary>
        ///     Checks if this instance is equal to another.
        /// </summary>
        /// <param name="left">The left instance.</param>
        /// <param name="right">The right instance.</param>
        /// <returns>True if equal, otherwise false.</returns>
        /// <seealso cref="Equals(BaseUnitSystem)" />
        public static bool operator !=(BaseUnitSystem left, BaseUnitSystem right)
        {
            return !(left == right);
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            return new
            {
                BaseUnits
            }.GetHashCode();
        }
    }
}
