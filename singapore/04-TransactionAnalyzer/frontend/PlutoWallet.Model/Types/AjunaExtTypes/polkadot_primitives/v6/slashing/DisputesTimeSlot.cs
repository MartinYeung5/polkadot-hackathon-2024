//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Attributes;
using Substrate.NetApi.Model.Types.Base;
using Substrate.NetApi.Model.Types.Metadata.V14;
using System.Collections.Generic;


namespace Substrate.NetApi.Generated.Model.polkadot_primitives.v6.slashing
{
    
    
    /// <summary>
    /// >> 373 - Composite[polkadot_primitives.v6.slashing.DisputesTimeSlot]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class DisputesTimeSlot : BaseType
    {
        
        /// <summary>
        /// >> session_index
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 SessionIndex { get; set; }
        /// <summary>
        /// >> candidate_hash
        /// </summary>
        public Substrate.NetApi.Generated.Model.polkadot_core_primitives.CandidateHash CandidateHash { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "DisputesTimeSlot";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(SessionIndex.Encode());
            result.AddRange(CandidateHash.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            SessionIndex = new Substrate.NetApi.Model.Types.Primitive.U32();
            SessionIndex.Decode(byteArray, ref p);
            CandidateHash = new Substrate.NetApi.Generated.Model.polkadot_core_primitives.CandidateHash();
            CandidateHash.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
