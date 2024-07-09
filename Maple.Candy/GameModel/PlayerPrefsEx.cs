
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
    /// class ["Assembly-CSharp.dll".""."PlayerPrefsEx"]
    /// [System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], 0x02000233U)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], [], [80, 108, 97, 121, 101, 114, 80, 114, 101, 102, 115, 69, 120])]

    //  class static System.String keycode
       [MonoCollectorSearchFieldAttribute(typeof(PMonoString),"keycode", "KEYCODE", true)]

    public partial class PlayerPrefsEx
    {
        //public const string Const_ImageName = "Assembly-CSharp.dll";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "PlayerPrefsEx";
        //public static byte[] Static_ClassName { get; } = [80, 108, 97, 121, 101, 114, 80, 114, 101, 102, 115, 69, 120];

        //public const uint Const_TypeToken = 0x02000233U;








        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_PlayerPrefsEx(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_PlayerPrefsEx(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_PlayerPrefsEx obj) => obj._ptr;
            public static implicit operator bool(Ptr_PlayerPrefsEx obj) => obj.Valid();

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

    /// <summary>
    /// ["Assembly-CSharp.dll".""."PlayerPrefsEx"]
    /// </summary>
    public partial class PlayerPrefsEx
    {



        /// <summary>
        /// static  System.Void .cctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".cctor")]
        /// static extern void .CCTOR ();


        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor")]
        ///  extern void .CTOR ();


        /// <summary>
        /// static  System.Int32 GetInt(System.String key, System.Int32 defaultValue)
        /// </summary>
        /// <param name="key">class System.String</param>
        /// <param name="defaultValue">struct System.Int32</param>
        /// <returns>struct System.Int32</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetInt")]
        static extern System.Int32 GET_INT(PMonoString key, System.Int32 defaultValue);


        /// <summary>
        /// static  System.String GetString(System.String key, System.String defaultValue)
        /// </summary>
        /// <param name="key">class System.String</param>
        /// <param name="defaultValue">class System.String</param>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetString")]
        /// static extern nint GET_STRING (nint key, nint defaultValue);


        /// <summary>
        /// static  System.Boolean HasKey(System.String key)
        /// </summary>
        /// <param name="key">class System.String</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("HasKey")]
        /// static extern System.Boolean HAS_KEY (nint key);


        /// <summary>
        /// static  System.Void SetInt(System.String key, System.Int32 value)
        /// </summary>
        /// <param name="key">class System.String</param>
        /// <param name="value">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetInt")]
        static extern void SET_INT(PMonoString key, System.Int32 value);


        /// <summary>
        /// static  System.Void SetKey(System.String key)
        /// </summary>
        /// <param name="key">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetKey")]
        /// static extern void SET_KEY (nint key);


        /// <summary>
        /// static  System.Void SetString(System.String key, System.String value)
        /// </summary>
        /// <param name="key">class System.String</param>
        /// <param name="value">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetString")]
        /// static extern void SET_STRING (nint key, nint value);




        /// public static partial class Search_PlayerPrefsEx
        /// {
        /// 
        ///     
        /// 
        /// }

    }


}