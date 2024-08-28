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


namespace Bajun.NetApi.Generated.Model.staging_xcm.v4.junction
{
    
    
    /// <summary>
    /// >> 75 - Array
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Array)]
    public sealed class Arr6EnumJunction : BaseType
    {
        
        /// <summary>
        /// >> Bajun.NetApi.Generated.Model.staging_xcm.v4.junction.EnumJunction[]
        /// </summary>
        public Bajun.NetApi.Generated.Model.staging_xcm.v4.junction.EnumJunction[] Value { get; set; }
        
        /// <inheritdoc/>
        public override int TypeSize
        {
            get
            {
                return 6;
            }
        }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return string.Format("[{0}; {1}]", new Bajun.NetApi.Generated.Model.staging_xcm.v4.junction.EnumJunction().TypeName(), this.TypeSize);
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            foreach (var v in Value){result.AddRange(v.Encode());};
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            var array = new Bajun.NetApi.Generated.Model.staging_xcm.v4.junction.EnumJunction[TypeSize];
            for (var i = 0; i < array.Length; i++) {var t = new Bajun.NetApi.Generated.Model.staging_xcm.v4.junction.EnumJunction();t.Decode(byteArray, ref p);array[i] = t;};
            var bytesLength = p - start;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
            Value = array;
        }
        
        /// <inheritdoc/>
        public void Create(Bajun.NetApi.Generated.Model.staging_xcm.v4.junction.EnumJunction[] array)
        {
            Value = array;
            Bytes = Encode();
        }
    }
}
