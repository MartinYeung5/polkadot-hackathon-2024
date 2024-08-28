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


namespace Bifrost.NetApi.Generated.Model.bifrost_cross_in_out.pallet
{
    
    
    /// <summary>
    /// >> Call
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public enum Call
    {
        
        /// <summary>
        /// >> cross_in
        /// See [`Pallet::cross_in`].
        /// </summary>
        cross_in = 0,
        
        /// <summary>
        /// >> cross_out
        /// See [`Pallet::cross_out`].
        /// </summary>
        cross_out = 1,
        
        /// <summary>
        /// >> register_linked_account
        /// See [`Pallet::register_linked_account`].
        /// </summary>
        register_linked_account = 2,
        
        /// <summary>
        /// >> change_outer_linked_account
        /// See [`Pallet::change_outer_linked_account`].
        /// </summary>
        change_outer_linked_account = 3,
        
        /// <summary>
        /// >> register_currency_for_cross_in_out
        /// See [`Pallet::register_currency_for_cross_in_out`].
        /// </summary>
        register_currency_for_cross_in_out = 4,
        
        /// <summary>
        /// >> deregister_currency_for_cross_in_out
        /// See [`Pallet::deregister_currency_for_cross_in_out`].
        /// </summary>
        deregister_currency_for_cross_in_out = 5,
        
        /// <summary>
        /// >> add_to_issue_whitelist
        /// See [`Pallet::add_to_issue_whitelist`].
        /// </summary>
        add_to_issue_whitelist = 6,
        
        /// <summary>
        /// >> remove_from_issue_whitelist
        /// See [`Pallet::remove_from_issue_whitelist`].
        /// </summary>
        remove_from_issue_whitelist = 7,
        
        /// <summary>
        /// >> add_to_register_whitelist
        /// See [`Pallet::add_to_register_whitelist`].
        /// </summary>
        add_to_register_whitelist = 8,
        
        /// <summary>
        /// >> remove_from_register_whitelist
        /// See [`Pallet::remove_from_register_whitelist`].
        /// </summary>
        remove_from_register_whitelist = 9,
        
        /// <summary>
        /// >> set_crossing_minimum_amount
        /// See [`Pallet::set_crossing_minimum_amount`].
        /// </summary>
        set_crossing_minimum_amount = 10,
    }
    
    /// <summary>
    /// >> 395 - Variant[bifrost_cross_in_out.pallet.Call]
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public sealed class EnumCall : BaseEnumExt<Call, BaseTuple<Bifrost.NetApi.Generated.Model.xcm.v2.multilocation.MultiLocation, Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>>>, BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>>, BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Bifrost.NetApi.Generated.Model.sp_core.crypto.AccountId32, Bifrost.NetApi.Generated.Model.xcm.v2.multilocation.MultiLocation>, BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Bifrost.NetApi.Generated.Model.xcm.v2.multilocation.MultiLocation, Bifrost.NetApi.Generated.Model.sp_core.crypto.AccountId32>, Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Bifrost.NetApi.Generated.Model.sp_core.crypto.AccountId32>, BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Bifrost.NetApi.Generated.Model.sp_core.crypto.AccountId32>, BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Bifrost.NetApi.Generated.Model.sp_core.crypto.AccountId32>, BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Bifrost.NetApi.Generated.Model.sp_core.crypto.AccountId32>, BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128>>
    {
    }
}
