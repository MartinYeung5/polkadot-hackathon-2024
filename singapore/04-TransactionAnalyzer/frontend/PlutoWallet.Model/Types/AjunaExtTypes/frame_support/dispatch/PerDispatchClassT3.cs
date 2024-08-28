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


namespace Substrate.NetApi.Generated.Model.frame_support.dispatch
{
    
    
    /// <summary>
    /// >> 529 - Composite[frame_support.dispatch.PerDispatchClassT3]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class PerDispatchClassT3 : BaseType
    {
        
        /// <summary>
        /// >> normal
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 Normal { get; set; }
        /// <summary>
        /// >> operational
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 Operational { get; set; }
        /// <summary>
        /// >> mandatory
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 Mandatory { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "PerDispatchClassT3";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Normal.Encode());
            result.AddRange(Operational.Encode());
            result.AddRange(Mandatory.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Normal = new Substrate.NetApi.Model.Types.Primitive.U32();
            Normal.Decode(byteArray, ref p);
            Operational = new Substrate.NetApi.Model.Types.Primitive.U32();
            Operational.Decode(byteArray, ref p);
            Mandatory = new Substrate.NetApi.Model.Types.Primitive.U32();
            Mandatory.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
