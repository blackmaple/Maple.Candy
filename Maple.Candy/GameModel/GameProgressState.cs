
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
    /// ["Assembly-CSharp.dll".""."GameProgressState"]
    /// </summary>
    public enum GameProgressState : System.Int32
    { 

        
        None = 0x00000000,

        Load = 0x00000001,

        StartGame = 0x00000002,

        InGame = 0x00000003,

        GameOver = 0x00000004,

        EndGame = 0x00000005,

    }


}