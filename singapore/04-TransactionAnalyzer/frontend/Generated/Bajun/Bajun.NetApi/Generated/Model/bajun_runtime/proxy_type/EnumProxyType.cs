//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Model.Types.Base;
using System.Collections.Generic;


namespace Bajun.NetApi.Generated.Model.bajun_runtime.proxy_type
{
    
    
    /// <summary>
    /// >> ProxyType
    /// </summary>
    public enum ProxyType
    {
        
        /// <summary>
        /// >> Any
        /// </summary>
        Any = 0,
        
        /// <summary>
        /// >> NonTransfer
        /// </summary>
        NonTransfer = 1,
        
        /// <summary>
        /// >> Governance
        /// </summary>
        Governance = 2,
        
        /// <summary>
        /// >> Staking
        /// </summary>
        Staking = 3,
        
        /// <summary>
        /// >> IdentityJudgement
        /// </summary>
        IdentityJudgement = 4,
        
        /// <summary>
        /// >> CancelProxy
        /// </summary>
        CancelProxy = 5,
    }
    
    /// <summary>
    /// >> 41 - Variant[bajun_runtime.proxy_type.ProxyType]
    /// </summary>
    public sealed class EnumProxyType : BaseEnum<ProxyType>
    {
    }
}
