//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi;
using Substrate.NetApi.Model.Extrinsics;
using Substrate.NetApi.Model.Meta;
using Substrate.NetApi.Model.Types;
using Substrate.NetApi.Model.Types.Base;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace Hydration.NetApi.Generated.Storage
{
    
    
    /// <summary>
    /// >> MultisigStorage
    /// </summary>
    public sealed class MultisigStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        /// <summary>
        /// >> MultisigStorage Constructor
        /// </summary>
        public MultisigStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Multisig", "Multisigs"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat,
                            Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Hydration.NetApi.Generated.Model.sp_core.crypto.AccountId32, Hydration.NetApi.Generated.Types.Base.Arr32U8>), typeof(Hydration.NetApi.Generated.Model.pallet_multisig.Multisig)));
        }
        
        /// <summary>
        /// >> MultisigsParams
        ///  The set of open multisig operations.
        /// </summary>
        public static string MultisigsParams(Substrate.NetApi.Model.Types.Base.BaseTuple<Hydration.NetApi.Generated.Model.sp_core.crypto.AccountId32, Hydration.NetApi.Generated.Types.Base.Arr32U8> key)
        {
            return RequestGenerator.GetStorage("Multisig", "Multisigs", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat,
                        Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, key.Value);
        }
        
        /// <summary>
        /// >> MultisigsDefault
        /// Default value as hex string
        /// </summary>
        public static string MultisigsDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> Multisigs
        ///  The set of open multisig operations.
        /// </summary>
        public async Task<Hydration.NetApi.Generated.Model.pallet_multisig.Multisig> Multisigs(Substrate.NetApi.Model.Types.Base.BaseTuple<Hydration.NetApi.Generated.Model.sp_core.crypto.AccountId32, Hydration.NetApi.Generated.Types.Base.Arr32U8> key, string blockhash, CancellationToken token)
        {
            string parameters = MultisigStorage.MultisigsParams(key);
            var result = await _client.GetStorageAsync<Hydration.NetApi.Generated.Model.pallet_multisig.Multisig>(parameters, blockhash, token);
            return result;
        }
    }
    
    /// <summary>
    /// >> MultisigCalls
    /// </summary>
    public sealed class MultisigCalls
    {
        
        /// <summary>
        /// >> as_multi_threshold_1
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method AsMultiThreshold1(Substrate.NetApi.Model.Types.Base.BaseVec<Hydration.NetApi.Generated.Model.sp_core.crypto.AccountId32> other_signatories, Hydration.NetApi.Generated.Model.hydradx_runtime.EnumRuntimeCall call)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(other_signatories.Encode());
            byteArray.AddRange(call.Encode());
            return new Method(31, "Multisig", 0, "as_multi_threshold_1", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> as_multi
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method AsMulti(Substrate.NetApi.Model.Types.Primitive.U16 threshold, Substrate.NetApi.Model.Types.Base.BaseVec<Hydration.NetApi.Generated.Model.sp_core.crypto.AccountId32> other_signatories, Substrate.NetApi.Model.Types.Base.BaseOpt<Hydration.NetApi.Generated.Model.pallet_multisig.Timepoint> maybe_timepoint, Hydration.NetApi.Generated.Model.hydradx_runtime.EnumRuntimeCall call, Hydration.NetApi.Generated.Model.sp_weights.weight_v2.Weight max_weight)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(threshold.Encode());
            byteArray.AddRange(other_signatories.Encode());
            byteArray.AddRange(maybe_timepoint.Encode());
            byteArray.AddRange(call.Encode());
            byteArray.AddRange(max_weight.Encode());
            return new Method(31, "Multisig", 1, "as_multi", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> approve_as_multi
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method ApproveAsMulti(Substrate.NetApi.Model.Types.Primitive.U16 threshold, Substrate.NetApi.Model.Types.Base.BaseVec<Hydration.NetApi.Generated.Model.sp_core.crypto.AccountId32> other_signatories, Substrate.NetApi.Model.Types.Base.BaseOpt<Hydration.NetApi.Generated.Model.pallet_multisig.Timepoint> maybe_timepoint, Hydration.NetApi.Generated.Types.Base.Arr32U8 call_hash, Hydration.NetApi.Generated.Model.sp_weights.weight_v2.Weight max_weight)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(threshold.Encode());
            byteArray.AddRange(other_signatories.Encode());
            byteArray.AddRange(maybe_timepoint.Encode());
            byteArray.AddRange(call_hash.Encode());
            byteArray.AddRange(max_weight.Encode());
            return new Method(31, "Multisig", 2, "approve_as_multi", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> cancel_as_multi
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method CancelAsMulti(Substrate.NetApi.Model.Types.Primitive.U16 threshold, Substrate.NetApi.Model.Types.Base.BaseVec<Hydration.NetApi.Generated.Model.sp_core.crypto.AccountId32> other_signatories, Hydration.NetApi.Generated.Model.pallet_multisig.Timepoint timepoint, Hydration.NetApi.Generated.Types.Base.Arr32U8 call_hash)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(threshold.Encode());
            byteArray.AddRange(other_signatories.Encode());
            byteArray.AddRange(timepoint.Encode());
            byteArray.AddRange(call_hash.Encode());
            return new Method(31, "Multisig", 3, "cancel_as_multi", byteArray.ToArray());
        }
    }
    
    /// <summary>
    /// >> MultisigConstants
    /// </summary>
    public sealed class MultisigConstants
    {
        
        /// <summary>
        /// >> DepositBase
        ///  The base amount of currency needed to reserve for creating a multisig execution or to
        ///  store a dispatch call for later.
        /// 
        ///  This is held for an additional storage item whose value size is
        ///  `4 + sizeof((BlockNumber, Balance, AccountId))` bytes and whose key size is
        ///  `32 + sizeof(AccountId)` bytes.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 DepositBase()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U128();
            result.Create("0x00A037CD4CB800000000000000000000");
            return result;
        }
        
        /// <summary>
        /// >> DepositFactor
        ///  The amount of currency needed per unit threshold when creating a multisig execution.
        /// 
        ///  This is held for adding 32 bytes more into a pre-existing storage value.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 DepositFactor()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U128();
            result.Create("0x00807584DF0000000000000000000000");
            return result;
        }
        
        /// <summary>
        /// >> MaxSignatories
        ///  The maximum amount of signatories allowed in the multisig.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 MaxSignatories()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U32();
            result.Create("0x64000000");
            return result;
        }
    }
    
    /// <summary>
    /// >> MultisigErrors
    /// </summary>
    public enum MultisigErrors
    {
        
        /// <summary>
        /// >> MinimumThreshold
        /// Threshold must be 2 or greater.
        /// </summary>
        MinimumThreshold,
        
        /// <summary>
        /// >> AlreadyApproved
        /// Call is already approved by this signatory.
        /// </summary>
        AlreadyApproved,
        
        /// <summary>
        /// >> NoApprovalsNeeded
        /// Call doesn't need any (more) approvals.
        /// </summary>
        NoApprovalsNeeded,
        
        /// <summary>
        /// >> TooFewSignatories
        /// There are too few signatories in the list.
        /// </summary>
        TooFewSignatories,
        
        /// <summary>
        /// >> TooManySignatories
        /// There are too many signatories in the list.
        /// </summary>
        TooManySignatories,
        
        /// <summary>
        /// >> SignatoriesOutOfOrder
        /// The signatories were provided out of order; they should be ordered.
        /// </summary>
        SignatoriesOutOfOrder,
        
        /// <summary>
        /// >> SenderInSignatories
        /// The sender was contained in the other signatories; it shouldn't be.
        /// </summary>
        SenderInSignatories,
        
        /// <summary>
        /// >> NotFound
        /// Multisig operation not found when attempting to cancel.
        /// </summary>
        NotFound,
        
        /// <summary>
        /// >> NotOwner
        /// Only the account that originally created the multisig is able to cancel it.
        /// </summary>
        NotOwner,
        
        /// <summary>
        /// >> NoTimepoint
        /// No timepoint was given, yet the multisig operation is already underway.
        /// </summary>
        NoTimepoint,
        
        /// <summary>
        /// >> WrongTimepoint
        /// A different timepoint was given to the multisig operation that is underway.
        /// </summary>
        WrongTimepoint,
        
        /// <summary>
        /// >> UnexpectedTimepoint
        /// A timepoint was given, yet no multisig operation is underway.
        /// </summary>
        UnexpectedTimepoint,
        
        /// <summary>
        /// >> MaxWeightTooLow
        /// The maximum weight information provided was too low.
        /// </summary>
        MaxWeightTooLow,
        
        /// <summary>
        /// >> AlreadyStored
        /// The data to be stored is already stored.
        /// </summary>
        AlreadyStored,
    }
}
