//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Model.Types.Base;
using System.Collections.Generic;


namespace Hydration.NetApi.Generated.Model.pallet_liquidity_mining.pallet
{
    
    
    /// <summary>
    /// >> Event
    /// The `Event` enum of this pallet
    /// </summary>
    public enum Event
    {
        
        /// <summary>
        /// >> GlobalFarmAccRPZUpdated
        /// Global farm accumulated reward per share was updated.
        /// </summary>
        GlobalFarmAccRPZUpdated = 0,
        
        /// <summary>
        /// >> YieldFarmAccRPVSUpdated
        /// Yield farm accumulated reward per valued share was updated.
        /// </summary>
        YieldFarmAccRPVSUpdated = 1,
        
        /// <summary>
        /// >> AllRewardsDistributed
        /// Global farm has no more rewards to distribute in the moment.
        /// </summary>
        AllRewardsDistributed = 2,
    }
    
    /// <summary>
    /// >> 145 - Variant[pallet_liquidity_mining.pallet.Event]
    /// The `Event` enum of this pallet
    /// </summary>
    public sealed class EnumEvent : BaseEnumExt<Event, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Hydration.NetApi.Generated.Model.sp_arithmetic.fixed_point.FixedU128, Substrate.NetApi.Model.Types.Primitive.U128>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32, Hydration.NetApi.Generated.Model.sp_arithmetic.fixed_point.FixedU128, Substrate.NetApi.Model.Types.Primitive.U128>, Substrate.NetApi.Model.Types.Primitive.U32>
    {
    }
}