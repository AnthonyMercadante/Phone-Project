using System.Collections.Generic;
using UnityEngine;
using com.zibra.liquid.Manipulators;
using com.zibra.liquid.DataStructures;

namespace com.zibra.liquid.SDFObjects
{
    /// <summary>
    ///     Base class for SDF classes.
    /// </summary>
    /// <remarks>
    ///     SDFs used to define shapes for colliders/manipulators.
    /// </remarks>
    [ExecuteInEditMode]
    [DisallowMultipleComponent]
    public abstract class SDFObject : MonoBehaviour
    {
#region Public Interface
        /// <summary>
        ///     Types of SDF objects.
        /// </summary>
        public enum SDFObjectType
        {
            Heightmap = -3,
            Group,
            Neural,
            Analytic,
        }

        /// <summary>
        ///     Whether to invert collider to only allow liquid inside.
        /// </summary>
        /// <remarks>
        ///     (Pro Version only) unsupported on Skinned Mesh SDFs.
        /// </remarks>
        [Tooltip("Inverts collider so liquid can only exist inside.")]
        public bool InvertSDF = false;

        /// <summary>
        ///     Offset for distance to SDF.
        /// </summary>
        /// <remarks>
        ///     Allows you to "shrink" or "expand" SDF.
        /// </remarks>
        [Tooltip("How far is the SDF surface from the object surface")]
        public float SurfaceDistance = 0.0f;

        /// <summary>
        ///     Calculates approximate VRAM usage by SDF.
        /// </summary>
        /// <returns>
        ///     Approximate VRAM usage in bytes.
        /// </returns>
        public abstract ulong GetVRAMFootprint(ZibraLiquidSolverParameters param);
#endregion
    }

    internal class SDFColliderCompare : Comparer<ZibraLiquidCollider>
    {
        // Compares manipulator type ID
        public override int Compare(ZibraLiquidCollider x, ZibraLiquidCollider y)
        {
            int result = x.GetManipulatorType().CompareTo(y.GetManipulatorType());
            if (result != 0)
            {
                return result;
            }
            return x.GetHashCode().CompareTo(y.GetHashCode());
        }
    }
}
