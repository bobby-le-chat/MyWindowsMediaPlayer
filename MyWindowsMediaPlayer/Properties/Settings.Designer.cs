﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.1
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyWindowsMediaPlayer.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("C:\\Users\\Admin\\Desktop\\projets\\Visual\\Src\\MyWindowsMediaPlayer\\MyWindowsMediaPlay" +
            "er\\Conf\\Library.xml")]
        public string LibPath {
            get {
                return ((string)(this["LibPath"]));
            }
            set {
                this["LibPath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("C:\\Users\\Admin\\Desktop\\projets\\Visual\\Src\\MyWindowsMediaPlayer\\MyWindowsMediaPlay" +
            "er\\Conf\\Library.Musics.xml")]
        public string MusicPath {
            get {
                return ((string)(this["MusicPath"]));
            }
            set {
                this["MusicPath"] = value;
            }
        }
    }
}
