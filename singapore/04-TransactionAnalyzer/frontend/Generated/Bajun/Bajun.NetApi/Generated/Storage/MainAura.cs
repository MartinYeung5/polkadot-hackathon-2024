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


namespace Bajun.NetApi.Generated.Storage
{
    
    
    /// <summary>
    /// >> AuraStorage
    /// </summary>
    public sealed class AuraStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        /// <summary>
        /// >> AuraStorage Constructor
        /// </summary>
        public AuraStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Aura", "Authorities"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Bajun.NetApi.Generated.Model.bounded_collections.bounded_vec.BoundedVecT38)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Aura", "CurrentSlot"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Bajun.NetApi.Generated.Model.sp_consensus_slots.Slot)));
        }
        
        /// <summary>
        /// >> AuthoritiesParams
        ///  The current authority set.
        /// </summary>
        public static string AuthoritiesParams()
        {
            return RequestGenerator.GetStorage("Aura", "Authorities", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> AuthoritiesDefault
        /// Default value as hex string
        /// </summary>
        public static string AuthoritiesDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> Authorities
        ///  The current authority set.
        /// </summary>
        public async Task<Bajun.NetApi.Generated.Model.bounded_collections.bounded_vec.BoundedVecT38> Authorities(string blockhash, CancellationToken token)
        {
            string parameters = AuraStorage.AuthoritiesParams();
            var result = await _client.GetStorageAsync<Bajun.NetApi.Generated.Model.bounded_collections.bounded_vec.BoundedVecT38>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> CurrentSlotParams
        ///  The current slot of this block.
        /// 
        ///  This will be set in `on_initialize`.
        /// </summary>
        public static string CurrentSlotParams()
        {
            return RequestGenerator.GetStorage("Aura", "CurrentSlot", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> CurrentSlotDefault
        /// Default value as hex string
        /// </summary>
        public static string CurrentSlotDefault()
        {
            return "0x0000000000000000";
        }
        
        /// <summary>
        /// >> CurrentSlot
        ///  The current slot of this block.
        /// 
        ///  This will be set in `on_initialize`.
        /// </summary>
        public async Task<Bajun.NetApi.Generated.Model.sp_consensus_slots.Slot> CurrentSlot(string blockhash, CancellationToken token)
        {
            string parameters = AuraStorage.CurrentSlotParams();
            var result = await _client.GetStorageAsync<Bajun.NetApi.Generated.Model.sp_consensus_slots.Slot>(parameters, blockhash, token);
            return result;
        }
    }
    
    /// <summary>
    /// >> AuraCalls
    /// </summary>
    public sealed class AuraCalls
    {
    }
    
    /// <summary>
    /// >> AuraConstants
    /// </summary>
    public sealed class AuraConstants
    {
        
        /// <summary>
        /// >> SlotDuration
        ///  The slot duration Aura should run with, expressed in milliseconds.
        ///  The effective value of this type should not change while the chain is running.
        /// 
        ///  For backwards compatibility either use [`MinimumPeriodTimesTwo`] or a const.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U64 SlotDuration()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U64();
            result.Create("0x7017000000000000");
            return result;
        }
    }
}
