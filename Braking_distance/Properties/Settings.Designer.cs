﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Braking_distance.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.5.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source = 192.168.226.135;  Initial Catalog = db_add; User ID = sa; Password " +
            "= Colorado2020;")]
        public string ConnectionString {
            get {
                return ((string)(this["ConnectionString"]));
            }
            set {
                this["ConnectionString"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source = 192.168.226.135;  Initial Catalog = master; User ID = sa; Password " +
            "= Colorado2020;")]
        public string ConnectionString_2 {
            get {
                return ((string)(this["ConnectionString_2"]));
            }
            set {
                this["ConnectionString_2"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source = 192.168.226.135;  Initial Catalog = master; Trusted_Connection=True" +
            ";")]
        public string ConnectionString_3 {
            get {
                return ((string)(this["ConnectionString_3"]));
            }
            set {
                this["ConnectionString_3"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source = 192.168.226.135;  Initial Catalog = db_add; Trusted_Connection=True" +
            ";")]
        public string ConnectionString_4 {
            get {
                return ((string)(this["ConnectionString_4"]));
            }
            set {
                this["ConnectionString_4"] = value;
            }
        }
    }
}