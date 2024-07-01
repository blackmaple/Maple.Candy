
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MonoCollectorDataV2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maple.Candy
{
    
    
    /// <summary>
    /// ["Assembly-CSharp.dll".""."ItemState"]
    /// </summary>
    public enum ItemState : System.Int32
    { 

        
        None = 0x00000000,

        Exist = 0x00000001,

        Flying = 0x00000002,

        Destroy = 0x00000003,

        AttachBelow = 0x00000004,

    }


}