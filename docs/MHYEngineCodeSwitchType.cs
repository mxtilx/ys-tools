namespace UnityEngine
{
    public enum MHYEngineCodeSwitchType
    {
        DISABLE_IOS_IGNORE_UI_IMMEDIATE_SKINNING = 25000,
        DISABLE_ANDROID_INVALIDATEATTACHMENTS_NEW_MODE = 26000,
        DISABLE_ANDROID_DEPTH_RESOLVE = 27000,
        DISABLE_ADRENO_BUGGY_IVALIDATEFRAMEBUFFER = 27001,
        DISABLE_PERMATERIAL_PROPERTY_UNSHARE_FIX = 27002,
        DISABLE_ADRENO_VRS_FOR_TREES = 28000,
        DISABLE_ANDROID_VERTEX_BUFFER_SPLIT = 28001,
        DISABLE_TEXTURESTREAMING_PERSISTENTMIP_FIX = 28002,
        DISABLE_PARTICLE_BOUNDING_CALCULATION_FIX = 28003,
        DISABLE_IOS_TERRAIN_VTF_DIRTY_SYNC_FIX = 28004,
        DISABLE_MOBIOLE_COLORGRADINGMASK_DONTSTOREDEPTH_FIX = 30000,
        DISABLE_HIZCULLING_AABBEXTERNT_SCALE = 30001,
        DISABLE_SCREENSHADOWMASK_RESET_ON_MOBILE = 30002,
        DISABLE_SSAOHQ_USE_HALF_NORMAL = 32000,
        DISABLE_SHADER_DELETE_FIX = 32001,
        DISABLE_RESET_DELAY_RIGIDBODY_OPTIMIZATION = 33000,
        DISABLE_WIN_DISPLAY_SIZE_CHANGE_FIX = 33001,
        DISABLE_DELAY_SELECT_OS_FONT = 33002,
    }
}