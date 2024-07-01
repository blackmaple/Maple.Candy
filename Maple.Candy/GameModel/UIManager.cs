
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MonoCollectorDataV2;

namespace Maple.Candy
{


    /// <summary>
    /// class ["Assembly-CSharp.dll".""."UIManager"]
    /// [Singleton<UIManager>]=>[System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], 0x020001BCU)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], [], [85, 73, 77, 97, 110, 97, 103, 101, 114])]

    //  class static System.String MainScene
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"MainScene", "MAIN_SCENE", true)]

    //  class static UIManager m_Instance
    [MonoCollectorSearchFieldAttribute(typeof(UIManager.Ptr_UIManager), "m_Instance", "M_INSTANCE", true)]

    //  class static System.String MainPage
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"MainPage", "MAIN_PAGE", true)]

    // class 0x10 System.Collections.Generic.Stack<UIManager.UIPageTrack> pageTrackStack
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"pageTrackStack", "PAGE_TRACK_STACK")]

    // class 0x18 UIManager.UIPageTrack currentPage
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"currentPage", "CURRENT_PAGE")]

    // class 0x20 System.Collections.Generic.List<UIPanel> loadedPanelList
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"loadedPanelList", "LOADED_PANEL_LIST")]

    // class 0x28 System.Action<System.String> onSceneLoadedOnly
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"onSceneLoadedOnly", "ON_SCENE_LOADED_ONLY")]

    // class 0x30 UnityEngine.Texture2D pointerEnterCursorTexture
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"pointerEnterCursorTexture", "POINTER_ENTER_CURSOR_TEXTURE")]

    // class 0x38 UnityEngine.Texture2D pointerDefaultCursorTexture
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"pointerDefaultCursorTexture", "POINTER_DEFAULT_CURSOR_TEXTURE")]

    // class 0x40 UnityEngine.EventSystems.PointerEventData pointerEventData
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"pointerEventData", "POINTER_EVENT_DATA")]
    public partial class UIManager
    {
        //public const string Const_ImageName = "Assembly-CSharp.dll";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "UIManager";
        //public static byte[] Static_ClassName { get; } = [85, 73, 77, 97, 110, 97, 103, 101, 114];

        //public const uint Const_TypeToken = 0x020001BCU;




        /// <summary>
        /// class System.String pointerEnterCursorPath "Sprites/UI/v3/newloginwnd/PointerEnterCursor"
        /// </summary>
        /// public const nint POINTER_ENTER_CURSOR_PATH=>"Sprites/UI/v3/newloginwnd/PointerEnterCursor";

        /// <summary>
        /// class System.String pointerDefaultCursorPath "Sprites/UI/v3/newloginwnd/PointerDefaultCursor"
        /// </summary>
        /// public const nint POINTER_DEFAULT_CURSOR_PATH=>"Sprites/UI/v3/newloginwnd/PointerDefaultCursor";




        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_UIManager(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_UIManager(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_UIManager obj) => obj._ptr;
            public static implicit operator bool(Ptr_UIManager obj) => obj.Valid();

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

    /// <summary>
    /// ["Assembly-CSharp.dll".""."UIManager"]
    /// </summary>
    public partial class UIManager
    {



        /// <summary>
        /// static  System.Void .cctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".cctor")]
        /// static extern void .CCTOR ();


        /// <summary>
        ///   System.Void <Init>b__10_0(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode mode)
        /// </summary>
        /// <param name="scene">struct UnityEngine.SceneManagement.Scene</param>
        /// <param name="mode">enum UnityEngine.SceneManagement.LoadSceneMode</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("<Init>b__10_0")]
        ///  extern void <INIT>B__10_0 (UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode mode);


        /// <summary>
        ///   System.Void CloseAllLoadedPanel()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CloseAllLoadedPanel")]
        ///  extern void CLOSE_ALL_LOADED_PANEL ();


        /// <summary>
        ///   System.Void CloseWidget(System.String name, System.Object arg)
        /// </summary>
        /// <param name="name">class System.String</param>
        /// <param name="arg">class System.Object</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CloseWidget")]
        ///  extern void CLOSE_WIDGET (nint name, nint arg);


        /// <summary>
        ///   System.Void CloseWindow(System.String name, System.Object arg)
        /// </summary>
        /// <param name="name">class System.String</param>
        /// <param name="arg">class System.Object</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CloseWindow")]
        ///  extern void CLOSE_WINDOW (nint name, nint arg);


        /// <summary>
        ///   System.Void CreateIcon(System.Int32 itemID, UnityEngine.Transform iconParentTrans, System.Boolean defaultPlay)
        /// </summary>
        /// <param name="itemID">struct System.Int32</param>
        /// <param name="iconParentTrans">class UnityEngine.Transform</param>
        /// <param name="defaultPlay">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CreateIcon")]
        ///  extern void CREATE_ICON (System.Int32 itemID, nint iconParentTrans, System.Boolean defaultPlay);


        /// <summary>
        ///   System.Void EnterMainPage()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("EnterMainPage")]
        ///  extern void ENTER_MAIN_PAGE ();


        /// <summary>
        ///   System.Void FitChild(UnityEngine.RectTransform childTransform, UnityEngine.RectTransform parentTransform)
        /// </summary>
        /// <param name="childTransform">class UnityEngine.RectTransform</param>
        /// <param name="parentTransform">class UnityEngine.RectTransform</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FitChild")]
        ///  extern void FIT_CHILD (nint childTransform, nint parentTransform);


        /// <summary>
        /// static  UIManager get_Instance()
        /// </summary>
        /// <returns>class UIManager</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Instance")]
        /// static extern nint GET_INSTANCE ();


        /// <summary>
        ///   System.String GetCurrentOpenPageName()
        /// </summary>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetCurrentOpenPageName")]
        ///  extern nint GET_CURRENT_OPEN_PAGE_NAME ();


        /// <summary>
        ///   System.String GetShortUIName(System.String name)
        /// </summary>
        /// <param name="name">class System.String</param>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetShortUIName")]
        ///  extern nint GET_SHORT_UI_NAME (nint name);


        /// <summary>
        ///   UIPanel GetUI(System.String name)
        /// </summary>
        /// <param name="name">class System.String</param>
        /// <returns>abstract class UIPanel</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetUI")]
        ///  extern nint GET_UI (nint name);


        /// <summary>
        ///   System.Void GoBackPage()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GoBackPage")]
        ///  extern void GO_BACK_PAGE ();


        /// <summary>
        ///   System.Void Init()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Init")]
        ///  extern void INIT ();


        /// <summary>
        ///   T Load(System.String name, System.Type implType)
        /// </summary>
        /// <param name="name">class System.String</param>
        /// <param name="implType">abstract class System.Type</param>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Load")]
        ///  extern nint LOAD (nint name, nint implType);


        /// <summary>
        ///   System.Void LoadScene(System.String scene, System.Action onLoadComplete)
        /// </summary>
        /// <param name="scene">class System.String</param>
        /// <param name="onLoadComplete">class System.Action</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("LoadScene")]
        ///  extern void LOAD_SCENE (nint scene, nint onLoadComplete);


        /// <summary>
        ///   System.Void OnPointerEnterUI(UnityEngine.EventSystems.PointerEventData data)
        /// </summary>
        /// <param name="data">class UnityEngine.EventSystems.PointerEventData</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnPointerEnterUI")]
        ///  extern void ON_POINTER_ENTER_UI (nint data);


        /// <summary>
        ///   System.Void OnPointerExitUI(UnityEngine.EventSystems.PointerEventData data)
        /// </summary>
        /// <param name="data">class UnityEngine.EventSystems.PointerEventData</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnPointerExitUI")]
        ///  extern void ON_POINTER_EXIT_UI (nint data);


        /// <summary>
        ///   T Open(System.String name, System.Object arg, System.Type implType)
        /// </summary>
        /// <param name="name">class System.String</param>
        /// <param name="arg">class System.Object</param>
        /// <param name="implType">abstract class System.Type</param>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Open")]
        ///  extern nint OPEN (nint name, nint arg, nint implType);


        /// <summary>
        ///   System.Void OpenPage(System.String name, System.Object arg)
        /// </summary>
        /// <param name="name">class System.String</param>
        /// <param name="arg">class System.Object</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OpenPage")]
        ///  extern void OPEN_PAGE (nint name, nint arg);


        /// <summary>
        ///   System.Void OpenPageInScene(System.String scene, System.String page, System.Object arg, System.Type type)
        /// </summary>
        /// <param name="scene">class System.String</param>
        /// <param name="page">class System.String</param>
        /// <param name="arg">class System.Object</param>
        /// <param name="type">abstract class System.Type</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OpenPageInScene")]
        ///  extern void OPEN_PAGE_IN_SCENE (nint scene, nint page, nint arg, nint type);


        /// <summary>
        ///   System.Void OpenPageWorker(System.String page, System.Object arg, System.Type type)
        /// </summary>
        /// <param name="page">class System.String</param>
        /// <param name="arg">class System.Object</param>
        /// <param name="type">abstract class System.Type</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OpenPageWorker")]
        ///  extern void OPEN_PAGE_WORKER (nint page, nint arg, nint type);


        /// <summary>
        ///   UIWidget OpenWidget(System.String name, System.Object arg)
        /// </summary>
        /// <param name="name">class System.String</param>
        /// <param name="arg">class System.Object</param>
        /// <returns>abstract class UIWidget</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OpenWidget")]
        ///  extern nint OPEN_WIDGET (nint name, nint arg);


        /// <summary>
        ///   UIWindow OpenWindow(System.String name, System.Object arg)
        /// </summary>
        /// <param name="name">class System.String</param>
        /// <param name="arg">class System.Object</param>
        /// <returns>abstract class UIWindow</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OpenWindow")]
        ///  extern nint OPEN_WINDOW (nint name, nint arg);


        /// <summary>
        ///   System.Void SetDefaultCursor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetDefaultCursor")]
        ///  extern void SET_DEFAULT_CURSOR ();


        /// <summary>
        ///   System.Void SetOffsets(UnityEngine.RectTransform rectTransform, System.Single left, System.Single right, System.Single top, System.Single bottom)
        /// </summary>
        /// <param name="rectTransform">class UnityEngine.RectTransform</param>
        /// <param name="left">struct System.Single</param>
        /// <param name="right">struct System.Single</param>
        /// <param name="top">struct System.Single</param>
        /// <param name="bottom">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetOffsets")]
        ///  extern void SET_OFFSETS (nint rectTransform, System.Single left, System.Single right, System.Single top, System.Single bottom);


        /// <summary>
        ///   System.Void ShowTips(System.String str)
        /// </summary>
        /// <param name="str">class System.String</param>
        /// <returns>struct System.Void</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ShowTips")]
        extern void SHOW_TIPS(PMonoString str);


        /// <summary>
        ///   System.Boolean UiIsOpen(System.String name)
        /// </summary>
        /// <param name="name">class System.String</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("UiIsOpen")]
        ///  extern System.Boolean UI_IS_OPEN (nint name);



        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_UIManager))]
        ///  extern void .CTOR_00 ();


        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_UIManager))]
        ///  extern void .CTOR_01 ();


        /// public static partial class Search_UIManager
        /// {
        /// 
        ///     

        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// public static bool .CTOR_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// public static bool .CTOR_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor");
        ///     
        ///  
        /// 
        /// 
        /// }

    }


}