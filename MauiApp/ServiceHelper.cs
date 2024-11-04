namespace MobileCounter;

public static class ServiceHelper
{
    public static TService GetService<TService>() => Current.GetService<TService>();

    public static IServiceProvider Current =>
#if ANDROID
        IPlatformApplication.Current.Services;
#elif IOS
        IPlatformApplication.Current.Services;
#else
         null;
#endif
}