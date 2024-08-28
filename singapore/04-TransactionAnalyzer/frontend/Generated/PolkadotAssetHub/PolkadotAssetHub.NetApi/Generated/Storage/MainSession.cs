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


namespace PolkadotAssetHub.NetApi.Generated.Storage
{
    
    
    /// <summary>
    /// >> SessionStorage
    /// </summary>
    public sealed class SessionStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        /// <summary>
        /// >> SessionStorage Constructor
        /// </summary>
        public SessionStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Session", "Validators"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Substrate.NetApi.Model.Types.Base.BaseVec<PolkadotAssetHub.NetApi.Generated.Model.sp_core.crypto.AccountId32>)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Session", "CurrentIndex"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Substrate.NetApi.Model.Types.Primitive.U32)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Session", "QueuedChanged"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Substrate.NetApi.Model.Types.Primitive.Bool)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Session", "QueuedKeys"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseTuple<PolkadotAssetHub.NetApi.Generated.Model.sp_core.crypto.AccountId32, PolkadotAssetHub.NetApi.Generated.Model.asset_hub_polkadot_runtime.SessionKeys>>)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Session", "DisabledValidators"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U32>)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Session", "NextKeys"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(PolkadotAssetHub.NetApi.Generated.Model.sp_core.crypto.AccountId32), typeof(PolkadotAssetHub.NetApi.Generated.Model.asset_hub_polkadot_runtime.SessionKeys)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Session", "KeyOwner"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<PolkadotAssetHub.NetApi.Generated.Model.sp_core.crypto.KeyTypeId, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>>), typeof(PolkadotAssetHub.NetApi.Generated.Model.sp_core.crypto.AccountId32)));
        }
        
        /// <summary>
        /// >> ValidatorsParams
        ///  The current set of validators.
        /// </summary>
        public static string ValidatorsParams()
        {
            return RequestGenerator.GetStorage("Session", "Validators", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> ValidatorsDefault
        /// Default value as hex string
        /// </summary>
        public static string ValidatorsDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> Validators
        ///  The current set of validators.
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Base.BaseVec<PolkadotAssetHub.NetApi.Generated.Model.sp_core.crypto.AccountId32>> Validators(string blockhash, CancellationToken token)
        {
            string parameters = SessionStorage.ValidatorsParams();
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Base.BaseVec<PolkadotAssetHub.NetApi.Generated.Model.sp_core.crypto.AccountId32>>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> CurrentIndexParams
        ///  Current index of the session.
        /// </summary>
        public static string CurrentIndexParams()
        {
            return RequestGenerator.GetStorage("Session", "CurrentIndex", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> CurrentIndexDefault
        /// Default value as hex string
        /// </summary>
        public static string CurrentIndexDefault()
        {
            return "0x00000000";
        }
        
        /// <summary>
        /// >> CurrentIndex
        ///  Current index of the session.
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Primitive.U32> CurrentIndex(string blockhash, CancellationToken token)
        {
            string parameters = SessionStorage.CurrentIndexParams();
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Primitive.U32>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> QueuedChangedParams
        ///  True if the underlying economic identities or weighting behind the validators
        ///  has changed in the queued validator set.
        /// </summary>
        public static string QueuedChangedParams()
        {
            return RequestGenerator.GetStorage("Session", "QueuedChanged", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> QueuedChangedDefault
        /// Default value as hex string
        /// </summary>
        public static string QueuedChangedDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> QueuedChanged
        ///  True if the underlying economic identities or weighting behind the validators
        ///  has changed in the queued validator set.
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Primitive.Bool> QueuedChanged(string blockhash, CancellationToken token)
        {
            string parameters = SessionStorage.QueuedChangedParams();
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Primitive.Bool>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> QueuedKeysParams
        ///  The queued keys for the next session. When the next session begins, these keys
        ///  will be used to determine the validator's session keys.
        /// </summary>
        public static string QueuedKeysParams()
        {
            return RequestGenerator.GetStorage("Session", "QueuedKeys", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> QueuedKeysDefault
        /// Default value as hex string
        /// </summary>
        public static string QueuedKeysDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> QueuedKeys
        ///  The queued keys for the next session. When the next session begins, these keys
        ///  will be used to determine the validator's session keys.
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseTuple<PolkadotAssetHub.NetApi.Generated.Model.sp_core.crypto.AccountId32, PolkadotAssetHub.NetApi.Generated.Model.asset_hub_polkadot_runtime.SessionKeys>>> QueuedKeys(string blockhash, CancellationToken token)
        {
            string parameters = SessionStorage.QueuedKeysParams();
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseTuple<PolkadotAssetHub.NetApi.Generated.Model.sp_core.crypto.AccountId32, PolkadotAssetHub.NetApi.Generated.Model.asset_hub_polkadot_runtime.SessionKeys>>>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> DisabledValidatorsParams
        ///  Indices of disabled validators.
        /// 
        ///  The vec is always kept sorted so that we can find whether a given validator is
        ///  disabled using binary search. It gets cleared when `on_session_ending` returns
        ///  a new set of identities.
        /// </summary>
        public static string DisabledValidatorsParams()
        {
            return RequestGenerator.GetStorage("Session", "DisabledValidators", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> DisabledValidatorsDefault
        /// Default value as hex string
        /// </summary>
        public static string DisabledValidatorsDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> DisabledValidators
        ///  Indices of disabled validators.
        /// 
        ///  The vec is always kept sorted so that we can find whether a given validator is
        ///  disabled using binary search. It gets cleared when `on_session_ending` returns
        ///  a new set of identities.
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U32>> DisabledValidators(string blockhash, CancellationToken token)
        {
            string parameters = SessionStorage.DisabledValidatorsParams();
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U32>>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> NextKeysParams
        ///  The next session keys for a validator.
        /// </summary>
        public static string NextKeysParams(PolkadotAssetHub.NetApi.Generated.Model.sp_core.crypto.AccountId32 key)
        {
            return RequestGenerator.GetStorage("Session", "NextKeys", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> NextKeysDefault
        /// Default value as hex string
        /// </summary>
        public static string NextKeysDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> NextKeys
        ///  The next session keys for a validator.
        /// </summary>
        public async Task<PolkadotAssetHub.NetApi.Generated.Model.asset_hub_polkadot_runtime.SessionKeys> NextKeys(PolkadotAssetHub.NetApi.Generated.Model.sp_core.crypto.AccountId32 key, string blockhash, CancellationToken token)
        {
            string parameters = SessionStorage.NextKeysParams(key);
            var result = await _client.GetStorageAsync<PolkadotAssetHub.NetApi.Generated.Model.asset_hub_polkadot_runtime.SessionKeys>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> KeyOwnerParams
        ///  The owner of a key. The key is the `KeyTypeId` + the encoded key.
        /// </summary>
        public static string KeyOwnerParams(Substrate.NetApi.Model.Types.Base.BaseTuple<PolkadotAssetHub.NetApi.Generated.Model.sp_core.crypto.KeyTypeId, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>> key)
        {
            return RequestGenerator.GetStorage("Session", "KeyOwner", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> KeyOwnerDefault
        /// Default value as hex string
        /// </summary>
        public static string KeyOwnerDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> KeyOwner
        ///  The owner of a key. The key is the `KeyTypeId` + the encoded key.
        /// </summary>
        public async Task<PolkadotAssetHub.NetApi.Generated.Model.sp_core.crypto.AccountId32> KeyOwner(Substrate.NetApi.Model.Types.Base.BaseTuple<PolkadotAssetHub.NetApi.Generated.Model.sp_core.crypto.KeyTypeId, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>> key, string blockhash, CancellationToken token)
        {
            string parameters = SessionStorage.KeyOwnerParams(key);
            var result = await _client.GetStorageAsync<PolkadotAssetHub.NetApi.Generated.Model.sp_core.crypto.AccountId32>(parameters, blockhash, token);
            return result;
        }
    }
    
    /// <summary>
    /// >> SessionCalls
    /// </summary>
    public sealed class SessionCalls
    {
        
        /// <summary>
        /// >> set_keys
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method SetKeys(PolkadotAssetHub.NetApi.Generated.Model.asset_hub_polkadot_runtime.SessionKeys keys, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8> proof)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(keys.Encode());
            byteArray.AddRange(proof.Encode());
            return new Method(22, "Session", 0, "set_keys", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> purge_keys
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method PurgeKeys()
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            return new Method(22, "Session", 1, "purge_keys", byteArray.ToArray());
        }
    }
    
    /// <summary>
    /// >> SessionConstants
    /// </summary>
    public sealed class SessionConstants
    {
    }
    
    /// <summary>
    /// >> SessionErrors
    /// </summary>
    public enum SessionErrors
    {
        
        /// <summary>
        /// >> InvalidProof
        /// Invalid ownership proof.
        /// </summary>
        InvalidProof,
        
        /// <summary>
        /// >> NoAssociatedValidatorId
        /// No associated validator ID for account.
        /// </summary>
        NoAssociatedValidatorId,
        
        /// <summary>
        /// >> DuplicatedKey
        /// Registered duplicate key.
        /// </summary>
        DuplicatedKey,
        
        /// <summary>
        /// >> NoKeys
        /// No keys are associated with this account.
        /// </summary>
        NoKeys,
        
        /// <summary>
        /// >> NoAccount
        /// Key setting account is not live, so it's impossible to associate keys.
        /// </summary>
        NoAccount,
    }
}
