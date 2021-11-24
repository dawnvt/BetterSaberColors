using BetterSaberColors.Installers;
using Hive.Versioning;
using IPA;
using SiraUtil.Zenject;
using Zenject;
using IPALogger = IPA.Logging.Logger;
using IPA.Config.Stores;
using IPA.Loader;
using JetBrains.Annotations;
using Config = IPA.Config.Config;

namespace BetterSaberColors
{
    [Plugin(RuntimeOptions.DynamicInit)]
    public class Plugin
    {
        //private PluginConfig _config;

        [Init]
        public void Init(Zenjector zenjector, /*Config config,*/ IPALogger logger, PluginMetadata pluginMetadata)
        {
            //_config = config.Generated<PluginConfig>();

            zenjector.OnMenu<BSCMenuInstaller>()
                .WithParameters(logger, /*_config,*/ new UBinder<Plugin, PluginMetadata>(pluginMetadata));
        }
    }
}
