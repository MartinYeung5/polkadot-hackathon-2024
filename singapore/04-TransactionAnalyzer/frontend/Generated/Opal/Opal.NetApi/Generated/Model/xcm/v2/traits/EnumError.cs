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


namespace Opal.NetApi.Generated.Model.xcm.v2.traits
{
    
    
    /// <summary>
    /// >> Error
    /// </summary>
    public enum Error
    {
        
        /// <summary>
        /// >> Overflow
        /// </summary>
        Overflow = 0,
        
        /// <summary>
        /// >> Unimplemented
        /// </summary>
        Unimplemented = 1,
        
        /// <summary>
        /// >> UntrustedReserveLocation
        /// </summary>
        UntrustedReserveLocation = 2,
        
        /// <summary>
        /// >> UntrustedTeleportLocation
        /// </summary>
        UntrustedTeleportLocation = 3,
        
        /// <summary>
        /// >> MultiLocationFull
        /// </summary>
        MultiLocationFull = 4,
        
        /// <summary>
        /// >> MultiLocationNotInvertible
        /// </summary>
        MultiLocationNotInvertible = 5,
        
        /// <summary>
        /// >> BadOrigin
        /// </summary>
        BadOrigin = 6,
        
        /// <summary>
        /// >> InvalidLocation
        /// </summary>
        InvalidLocation = 7,
        
        /// <summary>
        /// >> AssetNotFound
        /// </summary>
        AssetNotFound = 8,
        
        /// <summary>
        /// >> FailedToTransactAsset
        /// </summary>
        FailedToTransactAsset = 9,
        
        /// <summary>
        /// >> NotWithdrawable
        /// </summary>
        NotWithdrawable = 10,
        
        /// <summary>
        /// >> LocationCannotHold
        /// </summary>
        LocationCannotHold = 11,
        
        /// <summary>
        /// >> ExceedsMaxMessageSize
        /// </summary>
        ExceedsMaxMessageSize = 12,
        
        /// <summary>
        /// >> DestinationUnsupported
        /// </summary>
        DestinationUnsupported = 13,
        
        /// <summary>
        /// >> Transport
        /// </summary>
        Transport = 14,
        
        /// <summary>
        /// >> Unroutable
        /// </summary>
        Unroutable = 15,
        
        /// <summary>
        /// >> UnknownClaim
        /// </summary>
        UnknownClaim = 16,
        
        /// <summary>
        /// >> FailedToDecode
        /// </summary>
        FailedToDecode = 17,
        
        /// <summary>
        /// >> MaxWeightInvalid
        /// </summary>
        MaxWeightInvalid = 18,
        
        /// <summary>
        /// >> NotHoldingFees
        /// </summary>
        NotHoldingFees = 19,
        
        /// <summary>
        /// >> TooExpensive
        /// </summary>
        TooExpensive = 20,
        
        /// <summary>
        /// >> Trap
        /// </summary>
        Trap = 21,
        
        /// <summary>
        /// >> UnhandledXcmVersion
        /// </summary>
        UnhandledXcmVersion = 22,
        
        /// <summary>
        /// >> WeightLimitReached
        /// </summary>
        WeightLimitReached = 23,
        
        /// <summary>
        /// >> Barrier
        /// </summary>
        Barrier = 24,
        
        /// <summary>
        /// >> WeightNotComputable
        /// </summary>
        WeightNotComputable = 25,
    }
    
    /// <summary>
    /// >> 230 - Variant[xcm.v2.traits.Error]
    /// </summary>
    public sealed class EnumError : BaseEnumExt<Error, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, Substrate.NetApi.Model.Types.Primitive.U64, BaseVoid, Substrate.NetApi.Model.Types.Primitive.U64, BaseVoid, BaseVoid>
    {
    }
}
