using Microsoft.VisualBasic.ApplicationServices;

namespace T3.Core.SystemUi;

internal static class CoreUi
{
    private static ICoreSystemUiService _instance;
    public static ICoreSystemUiService Instance
    {
        get => _instance;
        set
        {
            if (_instance != null)
                throw new CantStartSingleInstanceException($"{typeof(CoreUi)}'s {nameof(Instance)} already set to {_instance.GetType()}");
            
            _instance = value;
        }
    }
}