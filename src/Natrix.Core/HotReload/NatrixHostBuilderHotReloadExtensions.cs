namespace Natrix.Core.HotReload;

public static class NatrixHostBuilderHotReloadExtensions
{
    public static NatrixHostBuilder UseDefaultHotReloadManager(this NatrixHostBuilder builder)
    {
        if (HotReloadManager.IsSupported)
        {
            builder.SetFeature<IHotReloadManager>(HotReloadManager.Default);
        }

        return builder;
    }
}
