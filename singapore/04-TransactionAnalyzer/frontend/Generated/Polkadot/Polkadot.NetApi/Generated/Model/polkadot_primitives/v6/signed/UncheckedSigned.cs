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


namespace Polkadot.NetApi.Generated.Model.polkadot_primitives.v6.signed
{
    
    
    /// <summary>
    /// >> 333 - Composite[polkadot_primitives.v6.signed.UncheckedSigned]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class UncheckedSigned : BaseType
    {
        
        /// <summary>
        /// >> payload
        /// </summary>
        public Polkadot.NetApi.Generated.Model.polkadot_primitives.v6.AvailabilityBitfield Payload { get; set; }
        /// <summary>
        /// >> validator_index
        /// </summary>
        public Polkadot.NetApi.Generated.Model.polkadot_primitives.v6.ValidatorIndex ValidatorIndex { get; set; }
        /// <summary>
        /// >> signature
        /// </summary>
        public Polkadot.NetApi.Generated.Model.polkadot_primitives.v6.validator_app.Signature Signature { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "UncheckedSigned";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Payload.Encode());
            result.AddRange(ValidatorIndex.Encode());
            result.AddRange(Signature.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Payload = new Polkadot.NetApi.Generated.Model.polkadot_primitives.v6.AvailabilityBitfield();
            Payload.Decode(byteArray, ref p);
            ValidatorIndex = new Polkadot.NetApi.Generated.Model.polkadot_primitives.v6.ValidatorIndex();
            ValidatorIndex.Decode(byteArray, ref p);
            Signature = new Polkadot.NetApi.Generated.Model.polkadot_primitives.v6.validator_app.Signature();
            Signature.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            global::System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
