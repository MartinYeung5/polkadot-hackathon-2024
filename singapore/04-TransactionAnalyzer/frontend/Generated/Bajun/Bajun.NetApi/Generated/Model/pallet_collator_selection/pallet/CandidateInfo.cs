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


namespace Bajun.NetApi.Generated.Model.pallet_collator_selection.pallet
{
    
    
    /// <summary>
    /// >> 512 - Composite[pallet_collator_selection.pallet.CandidateInfo]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class CandidateInfo : BaseType
    {
        
        /// <summary>
        /// >> who
        /// </summary>
        public Bajun.NetApi.Generated.Model.sp_core.crypto.AccountId32 Who { get; set; }
        /// <summary>
        /// >> deposit
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 Deposit { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "CandidateInfo";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Who.Encode());
            result.AddRange(Deposit.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Who = new Bajun.NetApi.Generated.Model.sp_core.crypto.AccountId32();
            Who.Decode(byteArray, ref p);
            Deposit = new Substrate.NetApi.Model.Types.Primitive.U128();
            Deposit.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            global::System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
