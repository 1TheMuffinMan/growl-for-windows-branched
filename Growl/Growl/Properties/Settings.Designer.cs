﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Growl.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(Growl.UserSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool AutoStart {
            get {
                return ((bool)(this["AutoStart"]));
            }
            set {
                this["AutoStart"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(Growl.UserSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("670, 390")]
        public global::System.Drawing.Size FormSize {
            get {
                return ((global::System.Drawing.Size)(this["FormSize"]));
            }
            set {
                this["FormSize"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(Growl.UserSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("-1, -1")]
        public global::System.Drawing.Point FormLocation {
            get {
                return ((global::System.Drawing.Point)(this["FormLocation"]));
            }
            set {
                this["FormLocation"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(Growl.UserSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool AllowNetworkNotifications {
            get {
                return ((bool)(this["AllowNetworkNotifications"]));
            }
            set {
                this["AllowNetworkNotifications"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(Growl.UserSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool AllowForwarding {
            get {
                return ((bool)(this["AllowForwarding"]));
            }
            set {
                this["AllowForwarding"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(Growl.UserSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Standard")]
        public string DefaultDisplay {
            get {
                return ((string)(this["DefaultDisplay"]));
            }
            set {
                this["DefaultDisplay"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(Growl.UserSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("7")]
        public int HistoryDays {
            get {
                return ((int)(this["HistoryDays"]));
            }
            set {
                this["HistoryDays"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(Growl.UserSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Date")]
        public global::Growl.UI.HistoryGroupItemsBy HistorySortBy {
            get {
                return ((global::Growl.UI.HistoryGroupItemsBy)(this["HistorySortBy"]));
            }
            set {
                this["HistorySortBy"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(Growl.UserSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool EnableLogging {
            get {
                return ((bool)(this["EnableLogging"]));
            }
            set {
                this["EnableLogging"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(Growl.UserSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool RequireLocalPassword {
            get {
                return ((bool)(this["RequireLocalPassword"]));
            }
            set {
                this["RequireLocalPassword"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(Growl.UserSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string DefaultSound {
            get {
                return ((string)(this["DefaultSound"]));
            }
            set {
                this["DefaultSound"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(Growl.UserSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool CheckForIdle {
            get {
                return ((bool)(this["CheckForIdle"]));
            }
            set {
                this["CheckForIdle"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(Growl.UserSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("180")]
        public int IdleAfterSeconds {
            get {
                return ((int)(this["IdleAfterSeconds"]));
            }
            set {
                this["IdleAfterSeconds"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(Growl.UserSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("300")]
        public int SubscriptionTTL {
            get {
                return ((int)(this["SubscriptionTTL"]));
            }
            set {
                this["SubscriptionTTL"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(Growl.UserSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool AllowSubscriptions {
            get {
                return ((bool)(this["AllowSubscriptions"]));
            }
            set {
                this["AllowSubscriptions"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(Growl.UserSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Alt+X")]
        public string KeyboardShortcutCloseLast {
            get {
                return ((string)(this["KeyboardShortcutCloseLast"]));
            }
            set {
                this["KeyboardShortcutCloseLast"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(Growl.UserSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Alt+Shift+X")]
        public string KeyboardShortcutCloseAll {
            get {
                return ((string)(this["KeyboardShortcutCloseAll"]));
            }
            set {
                this["KeyboardShortcutCloseAll"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(Growl.UserSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool AllowWebNotifications {
            get {
                return ((bool)(this["AllowWebNotifications"]));
            }
            set {
                this["AllowWebNotifications"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(Growl.UserSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool EnableSubscriptions {
            get {
                return ((bool)(this["EnableSubscriptions"]));
            }
            set {
                this["EnableSubscriptions"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(Growl.UserSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool DisableLegacySupport {
            get {
                return ((bool)(this["DisableLegacySupport"]));
            }
            set {
                this["DisableLegacySupport"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(Growl.UserSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ManuallyEnableNewApplications {
            get {
                return ((bool)(this["ManuallyEnableNewApplications"]));
            }
            set {
                this["ManuallyEnableNewApplications"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(Growl.UserSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool AutomaticallyCheckForUpdates {
            get {
                return ((bool)(this["AutomaticallyCheckForUpdates"]));
            }
            set {
                this["AutomaticallyCheckForUpdates"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(Growl.UserSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string CultureCode {
            get {
                return ((string)(this["CultureCode"]));
            }
            set {
                this["CultureCode"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(Growl.UserSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool MuteAllSounds {
            get {
                return ((bool)(this["MuteAllSounds"]));
            }
            set {
                this["MuteAllSounds"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(Growl.UserSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool DisableBonjour {
            get {
                return ((bool)(this["DisableBonjour"]));
            }
            set {
                this["DisableBonjour"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(Growl.UserSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string MachineID {
            get {
                return ((string)(this["MachineID"]));
            }
            set {
                this["MachineID"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(Growl.UserSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool DisableMissedNotifications {
            get {
                return ((bool)(this["DisableMissedNotifications"]));
            }
            set {
                this["DisableMissedNotifications"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(Growl.UserSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("SHA256")]
        public string GNTPForwardHashType {
            get {
                return ((string)(this["GNTPForwardHashType"]));
            }
            set {
                this["GNTPForwardHashType"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(Growl.UserSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("AES")]
        public string GNTPForwardEncryptionAlgorithm {
            get {
                return ((string)(this["GNTPForwardEncryptionAlgorithm"]));
            }
            set {
                this["GNTPForwardEncryptionAlgorithm"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(Growl.UserSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("growl@growlforwindows.com")]
        public string EmailForwardFromAddress {
            get {
                return ((string)(this["EmailForwardFromAddress"]));
            }
            set {
                this["EmailForwardFromAddress"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(Growl.UserSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int SettingsVersion {
            get {
                return ((int)(this["SettingsVersion"]));
            }
            set {
                this["SettingsVersion"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(Growl.UserSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool RequireLANPassword {
            get {
                return ((bool)(this["RequireLANPassword"]));
            }
            set {
                this["RequireLANPassword"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(Growl.UserSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string TwitterConsumerKey {
            get {
                return ((string)(this["TwitterConsumerKey"]));
            }
            set {
                this["TwitterConsumerKey"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(Growl.UserSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string TwitterConsumerSecret {
            get {
                return ((string)(this["TwitterConsumerSecret"]));
            }
            set {
                this["TwitterConsumerSecret"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(Growl.UserSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string HistoryView {
            get {
                return ((string)(this["HistoryView"]));
            }
            set {
                this["HistoryView"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(Growl.UserSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string HistoryColumnWidths {
            get {
                return ((string)(this["HistoryColumnWidths"]));
            }
            set {
                this["HistoryColumnWidths"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(Growl.UserSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("8")]
        public int HistoryDaysToSave {
            get {
                return ((int)(this["HistoryDaysToSave"]));
            }
            set {
                this["HistoryDaysToSave"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(Growl.UserSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool AutoPauseFullscreen {
            get {
                return ((bool)(this["AutoPauseFullscreen"]));
            }
            set {
                this["AutoPauseFullscreen"] = value;
            }
        }
    }
}
