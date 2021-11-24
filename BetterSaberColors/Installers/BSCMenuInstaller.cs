using BetterSaberColors.UI;
using IPA.Loader;
using IPA.Logging;
using SiraUtil.Zenject;
using Zenject;

namespace BetterSaberColors.Installers
{
    internal class BSCMenuInstaller : Installer
    {
        private readonly Logger _logger;
        // private readonly PluginConfig _config;
        private readonly UBinder<SiraUtil.Plugin, PluginMetadata> _metadata;

        internal BSCMenuInstaller(Logger logger, /*PluginConfig config,*/ UBinder<SiraUtil.Plugin, PluginMetadata> metadata)
        {
            _logger = logger;
            //_config = config;
            _metadata = metadata;
        }
        
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<BSCSettingsViewController>().AsSingle();
            Container.BindInstance(_metadata).AsSingle();
            Container.BindInstance(_logger).AsSingle();
            //Container.BindInstance(_config).AsSingle();
        }
    }
}
