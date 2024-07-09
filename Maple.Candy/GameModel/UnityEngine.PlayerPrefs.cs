
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
    /// class ["UnityEngine.CoreModule.dll"."UnityEngine"."PlayerPrefs"]
    /// [System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 67, 111, 114, 101, 77, 111, 100, 117, 108, 101, 46, 100, 108, 108], 0x020000E0U)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 67, 111, 114, 101, 77, 111, 100, 117, 108, 101, 46, 100, 108, 108], [85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101], [80, 108, 97, 121, 101, 114, 80, 114, 101, 102, 115])]
    
    
    public partial class PlayerPrefs
    { 
        //public const string Const_ImageName = "UnityEngine.CoreModule.dll";
        //public static byte[] Static_ImageName { get; } = [85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 67, 111, 114, 101, 77, 111, 100, 117, 108, 101, 46, 100, 108, 108];

        //public const string Const_Namespace = "UnityEngine";
        //public static byte[] Static_Namespace { get; } = [85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101];

        //public const string Const_ClassName = "PlayerPrefs";
        //public static byte[] Static_ClassName { get; } = [80, 108, 97, 121, 101, 114, 80, 114, 101, 102, 115];

        //public const uint Const_TypeToken = 0x020000E0U;



        
            
        

        
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_PlayerPrefs(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_PlayerPrefs(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_PlayerPrefs obj) => obj._ptr;
            public static implicit operator bool(Ptr_PlayerPrefs obj)=> obj.Valid();
 
            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

        /// <summary>
        /// ["UnityEngine.CoreModule.dll"."UnityEngine"."PlayerPrefs"]
        /// </summary>
        public partial class PlayerPrefs
        { 

            
            
            /// <summary>
            /// static  System.Single GetFloat(System.String key, System.Single defaultValue)
            /// </summary>
            /// <param name="key">class System.String</param>
            /// <param name="defaultValue">struct System.Single</param>
            /// <returns>struct System.Single</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetFloat")]
            /// static extern System.Single GET_FLOAT (nint key, System.Single defaultValue);

            
            /// <summary>
            /// static  System.Boolean HasKey(System.String key)
            /// </summary>
            /// <param name="key">class System.String</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("HasKey")]
            /// static extern System.Boolean HAS_KEY (nint key);

            
            /// <summary>
            /// static  System.Void Save()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Save")]
            /// static extern void SAVE ();

            
            /// <summary>
            /// static  System.Void SetFloat(System.String key, System.Single value)
            /// </summary>
            /// <param name="key">class System.String</param>
            /// <param name="value">struct System.Single</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetFloat")]
            /// static extern void SET_FLOAT (nint key, System.Single value);

            
            /// <summary>
            /// static  System.Void SetInt(System.String key, System.Int32 value)
            /// </summary>
            /// <param name="key">class System.String</param>
            /// <param name="value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetInt")]
             static extern void SET_INT (nint key, System.Int32 value);

            
            /// <summary>
            /// static  System.Void SetString(System.String key, System.String value)
            /// </summary>
            /// <param name="key">class System.String</param>
            /// <param name="value">class System.String</param>
            /// <returns>struct System.Void</returns>
             [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetString")]
             static extern void SET_STRING (nint key, nint value);

            
            /// <summary>
            /// static  System.Boolean TrySetFloat(System.String key, System.Single value)
            /// </summary>
            /// <param name="key">class System.String</param>
            /// <param name="value">struct System.Single</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("TrySetFloat")]
            /// static extern System.Boolean TRY_SET_FLOAT (nint key, System.Single value);

            
            /// <summary>
            /// static  System.Boolean TrySetInt(System.String key, System.Int32 value)
            /// </summary>
            /// <param name="key">class System.String</param>
            /// <param name="value">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("TrySetInt")]
            /// static extern System.Boolean TRY_SET_INT (nint key, System.Int32 value);

            
            /// <summary>
            /// static  System.Boolean TrySetSetString(System.String key, System.String value)
            /// </summary>
            /// <param name="key">class System.String</param>
            /// <param name="value">class System.String</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("TrySetSetString")]
            /// static extern System.Boolean TRY_SET_SET_STRING (nint key, nint value);
            
            
            
            /// <summary>
            /// static  System.Int32 GetInt(System.String key, System.Int32 defaultValue)
            /// </summary>
            /// <param name="key">class System.String</param>
            /// <param name="defaultValue">struct System.Int32</param>
            /// <returns>struct System.Int32</returns>
             [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetInt", Search = typeof(Search_PlayerPrefs))]
             static extern System.Int32 GET_INT_00 (PMonoString key, System.Int32 defaultValue);

            
            /// <summary>
            /// static  System.Int32 GetInt(System.String key)
            /// </summary>
            /// <param name="key">class System.String</param>
            /// <returns>struct System.Int32</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetInt", Search = typeof(Search_PlayerPrefs))]
            /// static extern System.Int32 GET_INT_01 (nint key);

            
            /// <summary>
            /// static  System.String GetString(System.String key, System.String defaultValue)
            /// </summary>
            /// <param name="key">class System.String</param>
            /// <param name="defaultValue">class System.String</param>
            /// <returns>class System.String</returns>
             [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetString", Search = typeof(Search_PlayerPrefs))]
             static extern PMonoString GET_STRING_00 (PMonoString key, PMonoString defaultValue);

            
            /// <summary>
            /// static  System.String GetString(System.String key)
            /// </summary>
            /// <param name="key">class System.String</param>
            /// <returns>class System.String</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetString", Search = typeof(Search_PlayerPrefs))]
            /// static extern nint GET_STRING_01 (nint key);

            
             public static partial class Search_PlayerPrefs
             {
            /// 
            ///     
                    
                    /// <summary>
                    /// static  System.Int32 GetInt(System.String key, System.Int32 defaultValue)
                    /// </summary>
                      public static bool GET_INT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                          =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetInt", "System.String", "System.Int32");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  System.Int32 GetInt(System.String key)
                    /// </summary>
                    /// public static bool GET_INT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetInt", "System.String");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  System.String GetString(System.String key, System.String defaultValue)
                    /// </summary>
                      public static bool GET_STRING_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                          =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetString", "System.String", "System.String");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    /// static  System.String GetString(System.String key)
                    /// </summary>
                    /// public static bool GET_STRING_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetString", "System.String");
                    ///     
                    ///  
                    /// 
            /// 
             }

        }


}