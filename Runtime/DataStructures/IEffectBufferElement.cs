﻿using Unity.Entities;

namespace WaynGroup.Mgm.Ability
{
    /// <summary>
    /// Interface to declare a new effect buffer to add to a runtime entity.
    /// </summary>
    /// <typeparam name="EFFECT"></typeparam>
    public interface IEffectBufferElement<EFFECT> : IBufferElementData where EFFECT : struct, IEffect
    {
        /// <summary>
        /// The index of the ability this effect is attached to.
        /// </summary>
        int AbilityIndex { get; set; }
        /// <summary>
        /// The effect.
        /// </summary>
        EFFECT Effect { get; set; }
    }

    /// <summary>
    /// Interface to declare a new effect buffer to add to a runtime entity.
    /// </summary>
    /// <typeparam name="COST"></typeparam>
    public interface IAbilityCostBufferElement<COST> : IBufferElementData where COST : struct, IAbilityCost
    {
        /// <summary>
        /// The index of the ability this effect is attached to.
        /// </summary>
        int AbilityIndex { get; set; }
        /// <summary>
        /// The effect.
        /// </summary>
        COST Cost { get; set; }
    }

}
