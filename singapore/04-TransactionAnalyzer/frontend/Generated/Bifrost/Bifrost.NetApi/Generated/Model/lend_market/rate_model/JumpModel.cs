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


namespace Bifrost.NetApi.Generated.Model.lend_market.rate_model
{
    
    
    /// <summary>
    /// >> 418 - Composite[lend_market.rate_model.JumpModel]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class JumpModel : BaseType
    {
        
        /// <summary>
        /// >> base_rate
        /// </summary>
        public Bifrost.NetApi.Generated.Model.sp_arithmetic.fixed_point.FixedU128 BaseRate { get; set; }
        /// <summary>
        /// >> jump_rate
        /// </summary>
        public Bifrost.NetApi.Generated.Model.sp_arithmetic.fixed_point.FixedU128 JumpRate { get; set; }
        /// <summary>
        /// >> full_rate
        /// </summary>
        public Bifrost.NetApi.Generated.Model.sp_arithmetic.fixed_point.FixedU128 FullRate { get; set; }
        /// <summary>
        /// >> jump_utilization
        /// </summary>
        public Bifrost.NetApi.Generated.Model.sp_arithmetic.per_things.Permill JumpUtilization { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "JumpModel";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(BaseRate.Encode());
            result.AddRange(JumpRate.Encode());
            result.AddRange(FullRate.Encode());
            result.AddRange(JumpUtilization.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            BaseRate = new Bifrost.NetApi.Generated.Model.sp_arithmetic.fixed_point.FixedU128();
            BaseRate.Decode(byteArray, ref p);
            JumpRate = new Bifrost.NetApi.Generated.Model.sp_arithmetic.fixed_point.FixedU128();
            JumpRate.Decode(byteArray, ref p);
            FullRate = new Bifrost.NetApi.Generated.Model.sp_arithmetic.fixed_point.FixedU128();
            FullRate.Decode(byteArray, ref p);
            JumpUtilization = new Bifrost.NetApi.Generated.Model.sp_arithmetic.per_things.Permill();
            JumpUtilization.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            global::System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
