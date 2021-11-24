using System;
using System.ComponentModel;
using BeatSaberMarkupLanguage.Attributes;
using BeatSaberMarkupLanguage.Components.Settings;
using BeatSaberMarkupLanguage.GameplaySetup;
using IPA.Loader;
using SiraUtil.Zenject;
using UnityEngine;
using Zenject;

namespace BetterSaberColors.UI
{
    public class BSCSettingsViewController : IInitializable, IDisposable, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public BSCSettingsViewController()
        {
            
        }
        
        public void Initialize()
        {
            
        }

        public void Dispose()
        {
            
        }
    }
}
