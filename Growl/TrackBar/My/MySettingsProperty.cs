// Decompiled with JetBrains decompiler
// Type: TrackBar.My.MySettingsProperty
// Assembly: TrackBar, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4906918C-FE0D-4418-9244-1FF2A5C025F4
// Assembly location: C:\Users\Nick\Downloads\TrackBar\TrackBar.dll

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace TrackBar.My
{
  [DebuggerNonUserCode]
  [StandardModule]
  [CompilerGenerated]
  [HideModuleName]
  internal sealed class MySettingsProperty
  {
    [HelpKeyword("My.Settings")]
    internal static MySettings Settings
    {
      get
      {
        return MySettings.Default;
      }
    }
  }
}
