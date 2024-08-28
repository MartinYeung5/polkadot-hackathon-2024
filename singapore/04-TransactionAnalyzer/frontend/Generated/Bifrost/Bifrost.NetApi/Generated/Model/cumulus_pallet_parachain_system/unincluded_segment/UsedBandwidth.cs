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


namespace Bifrost.NetApi.Generated.Model.cumulus_pallet_parachain_system.unincluded_segment
{
    
    
    /// <summary>
    /// >> 529 - Composite[cumulus_pallet_parachain_system.unincluded_segment.UsedBandwidth]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class UsedBandwidth : BaseType
    {
        
        /// <summary>
        /// >> ump_msg_count
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 UmpMsgCount { get; set; }
        /// <summary>
        /// >> ump_total_bytes
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 UmpTotalBytes { get; set; }
        /// <summary>
        /// >> hrmp_outgoing
        /// </summary>
        public Bifrost.NetApi.Generated.Types.Base.BTreeMapT6 HrmpOutgoing { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "UsedBandwidth";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(UmpMsgCount.Encode());
            result.AddRange(UmpTotalBytes.Encode());
            result.AddRange(HrmpOutgoing.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            UmpMsgCount = new Substrate.NetApi.Model.Types.Primitive.U32();
            UmpMsgCount.Decode(byteArray, ref p);
            UmpTotalBytes = new Substrate.NetApi.Model.Types.Primitive.U32();
            UmpTotalBytes.Decode(byteArray, ref p);
            HrmpOutgoing = new Bifrost.NetApi.Generated.Types.Base.BTreeMapT6();
            HrmpOutgoing.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            global::System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
