// Decompiled with JetBrains decompiler
// Type: TrackBar.Dotnetrix.Controls.TrackBarDrawItemEventArgs
// Assembly: TrackBar, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4906918C-FE0D-4418-9244-1FF2A5C025F4
// Assembly location: C:\Users\Nick\Downloads\TrackBar\TrackBar.dll

using System;
using System.Drawing;

namespace TrackBar.Dotnetrix.Controls
{
  public class TrackBarDrawItemEventArgs : EventArgs
  {
    private Graphics m_Graphics;
    private Rectangle m_Bounds;
    private TrackBarItemState m_State;

    public TrackBarDrawItemEventArgs(Graphics graphics, Rectangle bounds, TrackBarItemState state)
    {
      this.m_Graphics = graphics;
      this.m_Bounds = bounds;
      this.m_State = state;
    }

    public Graphics Graphics
    {
      get
      {
        return this.m_Graphics;
      }
    }

    public Rectangle Bounds
    {
      get
      {
        return this.m_Bounds;
      }
    }

    public TrackBarItemState State
    {
      get
      {
        return this.m_State;
      }
    }
  }
}
