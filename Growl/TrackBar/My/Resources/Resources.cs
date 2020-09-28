// Decompiled with JetBrains decompiler
// Type: TrackBar.My.Resources.Resources
// Assembly: TrackBar, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4906918C-FE0D-4418-9244-1FF2A5C025F4
// Assembly location: C:\Users\Nick\Downloads\TrackBar\TrackBar.dll

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace TrackBar.My.Resources
{
  [CompilerGenerated]
  [HideModuleName]
  [DebuggerNonUserCode]
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
  [StandardModule]
  internal sealed class Resources
  {
    private static ResourceManager resourceMan;
    private static CultureInfo resourceCulture;

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static ResourceManager ResourceManager
    {
      get
      {
        if (object.ReferenceEquals((object) TrackBar.My.Resources.Resources.resourceMan, (object) null))
          TrackBar.My.Resources.Resources.resourceMan = new ResourceManager("TrackBar.Resources", typeof (TrackBar.My.Resources.Resources).Assembly);
        return TrackBar.My.Resources.Resources.resourceMan;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo Culture
    {
      get
      {
        return TrackBar.My.Resources.Resources.resourceCulture;
      }
      set
      {
        TrackBar.My.Resources.Resources.resourceCulture = value;
      }
    }
  }
}
