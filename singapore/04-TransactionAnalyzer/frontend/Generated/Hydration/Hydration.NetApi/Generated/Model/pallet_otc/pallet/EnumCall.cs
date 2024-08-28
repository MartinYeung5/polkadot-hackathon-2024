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


namespace Hydration.NetApi.Generated.Model.pallet_otc.pallet
{
    
    
    /// <summary>
    /// >> Call
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public enum Call
    {
        
        /// <summary>
        /// >> place_order
        /// See [`Pallet::place_order`].
        /// </summary>
        place_order = 0,
        
        /// <summary>
        /// >> partial_fill_order
        /// See [`Pallet::partial_fill_order`].
        /// </summary>
        partial_fill_order = 1,
        
        /// <summary>
        /// >> fill_order
        /// See [`Pallet::fill_order`].
        /// </summary>
        fill_order = 2,
        
        /// <summary>
        /// >> cancel_order
        /// See [`Pallet::cancel_order`].
        /// </summary>
        cancel_order = 3,
    }
    
    /// <summary>
    /// >> 370 - Variant[pallet_otc.pallet.Call]
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public sealed class EnumCall : BaseEnumExt<Call, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.Bool>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U128>, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32>
    {
    }
}
