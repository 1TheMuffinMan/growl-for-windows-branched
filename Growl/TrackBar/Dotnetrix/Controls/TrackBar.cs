// Decompiled with JetBrains decompiler
// Type: TrackBar.Dotnetrix.Controls.TrackBar
// Assembly: TrackBar, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4906918C-FE0D-4418-9244-1FF2A5C025F4
// Assembly location: C:\Users\Nick\Downloads\TrackBar\TrackBar.dll

using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Windows.Forms;

namespace TrackBar.Dotnetrix.Controls
{
  [ToolboxBitmap(typeof (System.Windows.Forms.TrackBar))]
  public class TrackBar : System.Windows.Forms.TrackBar
  {
    private TrackBarOwnerDrawParts m_OwnerDrawParts;
    private Rectangle ChannelBounds;
    private Rectangle ThumbBounds;
    private int ThumbState;

    public TrackBar()
    {
      this.m_OwnerDrawParts = TrackBarOwnerDrawParts.None;
      this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
    }

    public event TrackBarDrawItemEventHandler DrawThumb;

    public event TrackBarDrawItemEventHandler DrawChannel;

    public event TrackBarDrawItemEventHandler DrawTicks;

    [DefaultValue(typeof (TrackBarOwnerDrawParts), "None")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    [Editor(typeof (TrackDrawModeEditor), typeof (UITypeEditor))]
    [Description("Gets/sets the trackbar parts that will be OwnerDrawn.")]
    public TrackBarOwnerDrawParts OwnerDrawParts
    {
      get
      {
        return this.m_OwnerDrawParts;
      }
      set
      {
        this.m_OwnerDrawParts = value;
      }
    }

    [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
    protected override void WndProc(ref Message m)
    {
      IntPtr num1;
      if (m.Msg == 20)
      {
        ref Message local = ref m;
        num1 = new IntPtr(1);
        IntPtr num2 = num1;
        local.Result = num2;
      }
      base.WndProc(ref m);
      if (m.Msg != 8270)
        return;
      NativeMethods.NMHDR structure1 = (NativeMethods.NMHDR) Marshal.PtrToStructure(m.LParam, typeof (NativeMethods.NMHDR));
      if (structure1.code != -12)
        return;
      Marshal.StructureToPtr((object) structure1, m.LParam, false);
      NativeMethods.NMCUSTOMDRAW structure2 = (NativeMethods.NMCUSTOMDRAW) Marshal.PtrToStructure(m.LParam, typeof (NativeMethods.NMCUSTOMDRAW));
      if (structure2.dwDrawStage == NativeMethods.CustomDrawDrawStage.CDDS_PREPAINT)
      {
        Graphics graphics = Graphics.FromHdc(structure2.hdc);
        PaintEventArgs e = new PaintEventArgs(graphics, this.Bounds);
        e.Graphics.TranslateTransform((float) checked (-this.Left), (float) checked (-this.Top));
        this.InvokePaintBackground(this.Parent, e);
        this.InvokePaint(this.Parent, e);
        SolidBrush solidBrush = new SolidBrush(this.BackColor);
        e.Graphics.FillRectangle((Brush) solidBrush, this.Bounds);
        solidBrush.Dispose();
        e.Graphics.ResetTransform();
        e.Dispose();
        graphics.Dispose();
        ref Message local = ref m;
        num1 = new IntPtr(48);
        IntPtr num2 = num1;
        local.Result = num2;
      }
      else if (structure2.dwDrawStage == NativeMethods.CustomDrawDrawStage.CDDS_POSTPAINT)
      {
        this.OnDrawTicks(structure2.hdc);
        this.OnDrawChannel(structure2.hdc);
        this.OnDrawThumb(structure2.hdc);
      }
      else
      {
        if (structure2.dwDrawStage != NativeMethods.CustomDrawDrawStage.CDDS_ITEMPREPAINT)
          return;
        if (structure2.dwItemSpec.ToInt32() == 2)
        {
          this.ThumbBounds = structure2.rc.ToRectangle();
          this.ThumbState = !this.Enabled ? 5 : (structure2.uItemState != NativeMethods.CustomDrawItemState.CDIS_SELECTED ? 1 : 3);
          this.OnDrawThumb(structure2.hdc);
        }
        else if (structure2.dwItemSpec.ToInt32() == 3)
        {
          this.ChannelBounds = structure2.rc.ToRectangle();
          this.OnDrawChannel(structure2.hdc);
        }
        else if (structure2.dwItemSpec.ToInt32() == 1)
          this.OnDrawTicks(structure2.hdc);
        ref Message local = ref m;
        num1 = new IntPtr(4);
        IntPtr num2 = num1;
        local.Result = num2;
      }
    }

    protected override void OnMouseMove(MouseEventArgs e)
    {
      base.OnMouseMove(e);
      if (e.Button != MouseButtons.None || !this.ThumbBounds.Contains(e.X, e.Y))
        return;
      this.ThumbState = 2;
      this.Invalidate(new Region(this.ThumbBounds));
    }

    public TrackBarDrawItemEventHandler DrawTicksEvent;
    protected virtual void OnDrawTicks(IntPtr hdc)
    {
      Graphics graphics = Graphics.FromHdc(hdc);
      if ((this.OwnerDrawParts & TrackBarOwnerDrawParts.Ticks) == TrackBarOwnerDrawParts.Ticks && !this.DesignMode)
      {
        Rectangle bounds = this.Orientation != Orientation.Horizontal ? new Rectangle(checked (this.ThumbBounds.Left - unchecked (this.ThumbBounds.Height / 2)), checked (this.ChannelBounds.Top + 6), checked (this.ThumbBounds.Width + 10), checked (this.ChannelBounds.Height - this.ThumbBounds.Height)) : new Rectangle(checked (this.ChannelBounds.Left + unchecked (this.ThumbBounds.Width / 2)), checked (this.ThumbBounds.Top - 6), checked (this.ChannelBounds.Width - this.ThumbBounds.Width), checked (this.ThumbBounds.Height + 10));
        TrackBarDrawItemEventArgs e = new TrackBarDrawItemEventArgs(graphics, bounds, (TrackBarItemState) this.ThumbState);
        TrackBarDrawItemEventHandler drawTicksEvent = this.DrawTicksEvent;
        if (drawTicksEvent != null)
          drawTicksEvent((object) this, e);
      }
      else
      {
        if (this.TickStyle == TickStyle.None || this.ThumbBounds.Equals((object) Rectangle.Empty))
          return;
        Color color = Color.Black;
        if (TrackBar.VisualStylesEnabled)
        {
          IntPtr hTheme = NativeMethods.OpenThemeData(this.Handle, "TRACKBAR");
          if (!hTheme.Equals((object) IntPtr.Zero))
          {
            int pColor = 0;
            if (NativeMethods.GetThemeColor(hTheme, 9, this.ThumbState, 204, ref pColor) == 0)
              color = ColorTranslator.FromWin32(pColor);
            NativeMethods.CloseThemeData(hTheme);
          }
        }
        if (this.Orientation == Orientation.Horizontal)
          this.DrawHorizontalTicks(graphics, color);
        else
          this.DrawVerticalTicks(graphics, color);
      }
      graphics.Dispose();
    }
    public event TrackBarDrawItemEventHandler DrawChannelEvent;
        protected virtual void OnDrawChannel(IntPtr hdc)
    {
      Graphics graphics = Graphics.FromHdc(hdc);
      if ((this.OwnerDrawParts & TrackBarOwnerDrawParts.Channel) == TrackBarOwnerDrawParts.Channel && !this.DesignMode)
      {
        TrackBarDrawItemEventArgs e = new TrackBarDrawItemEventArgs(graphics, this.ChannelBounds, (TrackBarItemState) this.ThumbState);
        TrackBarDrawItemEventHandler drawChannelEvent = this.DrawChannelEvent;
        if (drawChannelEvent != null)
          drawChannelEvent((object) this, e);
      }
      else
      {
        if (this.ChannelBounds.Equals((object) Rectangle.Empty))
          return;
        if (TrackBar.VisualStylesEnabled)
        {
          IntPtr hTheme = NativeMethods.OpenThemeData(this.Handle, "TRACKBAR");
          if (!hTheme.Equals((object) IntPtr.Zero))
          {
            NativeMethods.RECT rect = new NativeMethods.RECT(this.ChannelBounds);
            bool flag = NativeMethods.DrawThemeBackground(hTheme, hdc, 1, 1, ref rect, ref rect) == 0;
            NativeMethods.CloseThemeData(hTheme);
            if (flag)
              return;
          }
        }
        ControlPaint.DrawBorder3D(graphics, this.ChannelBounds, Border3DStyle.Sunken);
      }
      graphics.Dispose();
    }

    public event TrackBarDrawItemEventHandler DrawThumbEvent;
    
    protected virtual void OnDrawThumb(IntPtr hdc)
    {
      Graphics graphics = Graphics.FromHdc(hdc);
      graphics.Clip = new Region(this.ThumbBounds);
      if ((this.OwnerDrawParts & TrackBarOwnerDrawParts.Thumb) == TrackBarOwnerDrawParts.Thumb && !this.DesignMode)
      {
        TrackBarDrawItemEventArgs e = new TrackBarDrawItemEventArgs(graphics, this.ThumbBounds, (TrackBarItemState) this.ThumbState);
        TrackBarDrawItemEventHandler drawThumbEvent = this.DrawThumbEvent;
        if (drawThumbEvent != null)
          drawThumbEvent((object) this, e);
      }
      else
      {
        if (this.ThumbBounds.Equals((object) Rectangle.Empty))
          return;
        int iPartId = 0;
        switch (this.TickStyle)
        {
          case TickStyle.None:
          case TickStyle.BottomRight:
            iPartId = this.Orientation != Orientation.Horizontal ? 8 : 4;
            break;
          case TickStyle.TopLeft:
            iPartId = this.Orientation != Orientation.Horizontal ? 7 : 5;
            break;
          case TickStyle.Both:
            iPartId = this.Orientation != Orientation.Horizontal ? 6 : 3;
            break;
        }
        if (TrackBar.VisualStylesEnabled)
        {
          IntPtr hTheme = NativeMethods.OpenThemeData(this.Handle, "TRACKBAR");
          if (!hTheme.Equals((object) IntPtr.Zero))
          {
            NativeMethods.RECT rect = new NativeMethods.RECT(this.ThumbBounds);
            bool flag = NativeMethods.DrawThemeBackground(hTheme, hdc, iPartId, this.ThumbState, ref rect, ref rect) == 0;
            NativeMethods.CloseThemeData(hTheme);
            if (flag)
            {
              graphics.ResetClip();
              graphics.Dispose();
              return;
            }
          }
        }
        switch (iPartId)
        {
          case 4:
            this.DrawPointerDown(graphics);
            break;
          case 5:
            this.DrawPointerUp(graphics);
            break;
          case 7:
            this.DrawPointerLeft(graphics);
            break;
          case 8:
            this.DrawPointerRight(graphics);
            break;
          default:
            if (this.ThumbState == 3 || !this.Enabled)
              ControlPaint.DrawButton(graphics, this.ThumbBounds, ButtonState.All);
            else
              graphics.FillRectangle(SystemBrushes.Control, this.ThumbBounds);
            ControlPaint.DrawBorder3D(graphics, this.ThumbBounds, Border3DStyle.Raised);
            break;
        }
      }
      graphics.ResetClip();
      graphics.Dispose();
    }

    private void DrawPointerDown(Graphics g)
    {
      Point[] points = new Point[6];
      points[0] = new Point(checked (this.ThumbBounds.Left + unchecked (this.ThumbBounds.Width / 2)), checked (this.ThumbBounds.Bottom - 1));
      points[1] = new Point(this.ThumbBounds.Left, checked (this.ThumbBounds.Bottom - unchecked (this.ThumbBounds.Width / 2) - 1));
      points[2] = this.ThumbBounds.Location;
      points[3] = new Point(checked (this.ThumbBounds.Right - 1), this.ThumbBounds.Top);
      points[4] = new Point(checked (this.ThumbBounds.Right - 1), checked (this.ThumbBounds.Bottom - unchecked (this.ThumbBounds.Width / 2) - 1));
      points[5] = points[0];
      GraphicsPath path = new GraphicsPath();
      path.AddLines(points);
      Region region = new Region(path);
      g.Clip = region;
      if (this.ThumbState == 3 || !this.Enabled)
        ControlPaint.DrawButton(g, this.ThumbBounds, ButtonState.All);
      else
        g.Clear(SystemColors.Control);
      g.ResetClip();
      region.Dispose();
      path.Dispose();
      g.DrawLines(SystemPens.ControlLightLight, new Point[4]
      {
        points[0],
        points[1],
        points[2],
        points[3]
      });
      g.DrawLines(SystemPens.ControlDarkDark, new Point[3]
      {
        points[3],
        points[4],
        points[5]
      });
      points[0].Offset(0, -1);
      points[1].Offset(1, 0);
      points[2].Offset(1, 1);
      points[3].Offset(-1, 1);
      points[4].Offset(-1, 0);
      points[5] = points[0];
      g.DrawLines(SystemPens.ControlLight, new Point[4]
      {
        points[0],
        points[1],
        points[2],
        points[3]
      });
      g.DrawLines(SystemPens.ControlDark, new Point[3]
      {
        points[3],
        points[4],
        points[5]
      });
    }

    private void DrawPointerUp(Graphics g)
    {
      Point[] points = new Point[6];
      points[0] = new Point(this.ThumbBounds.Left, checked (this.ThumbBounds.Bottom - 1));
      points[1] = new Point(this.ThumbBounds.Left, checked (this.ThumbBounds.Top + unchecked (this.ThumbBounds.Width / 2)));
      points[2] = new Point(checked (this.ThumbBounds.Left + unchecked (this.ThumbBounds.Width / 2)), this.ThumbBounds.Top);
      points[3] = new Point(checked (this.ThumbBounds.Right - 1), checked (this.ThumbBounds.Top + unchecked (this.ThumbBounds.Width / 2)));
      points[4] = new Point(checked (this.ThumbBounds.Right - 1), checked (this.ThumbBounds.Bottom - 1));
      points[5] = points[0];
      GraphicsPath path = new GraphicsPath();
      path.AddLines(points);
      Region region = new Region(path);
      g.Clip = region;
      if (this.ThumbState == 3 || !this.Enabled)
        ControlPaint.DrawButton(g, this.ThumbBounds, ButtonState.All);
      else
        g.Clear(SystemColors.Control);
      g.ResetClip();
      region.Dispose();
      path.Dispose();
      g.DrawLines(SystemPens.ControlLightLight, new Point[3]
      {
        points[0],
        points[1],
        points[2]
      });
      g.DrawLines(SystemPens.ControlDarkDark, new Point[4]
      {
        points[2],
        points[3],
        points[4],
        points[5]
      });
      points[0].Offset(1, -1);
      points[1].Offset(1, 0);
      points[2].Offset(0, 1);
      points[3].Offset(-1, 0);
      points[4].Offset(-1, -1);
      points[5] = points[0];
      g.DrawLines(SystemPens.ControlLight, new Point[3]
      {
        points[0],
        points[1],
        points[2]
      });
      g.DrawLines(SystemPens.ControlDark, new Point[4]
      {
        points[2],
        points[3],
        points[4],
        points[5]
      });
    }

    private void DrawPointerLeft(Graphics g)
    {
      Point[] points = new Point[6];
      points[0] = new Point(this.ThumbBounds.Left, checked (this.ThumbBounds.Top + unchecked (this.ThumbBounds.Height / 2)));
      points[1] = new Point(checked (this.ThumbBounds.Left + unchecked (this.ThumbBounds.Height / 2)), this.ThumbBounds.Top);
      points[2] = new Point(checked (this.ThumbBounds.Right - 1), this.ThumbBounds.Top);
      points[3] = new Point(checked (this.ThumbBounds.Right - 1), checked (this.ThumbBounds.Bottom - 1));
      points[4] = new Point(checked (this.ThumbBounds.Left + unchecked (this.ThumbBounds.Height / 2)), checked (this.ThumbBounds.Bottom - 1));
      points[5] = points[0];
      GraphicsPath path = new GraphicsPath();
      path.AddLines(points);
      Region region = new Region(path);
      g.Clip = region;
      if (this.ThumbState == 3 || !this.Enabled)
        ControlPaint.DrawButton(g, this.ThumbBounds, ButtonState.All);
      else
        g.Clear(SystemColors.Control);
      g.ResetClip();
      region.Dispose();
      path.Dispose();
      g.DrawLines(SystemPens.ControlLightLight, new Point[3]
      {
        points[0],
        points[1],
        points[2]
      });
      g.DrawLines(SystemPens.ControlDarkDark, new Point[4]
      {
        points[2],
        points[3],
        points[4],
        points[5]
      });
      points[0].Offset(1, 0);
      points[1].Offset(0, 1);
      points[2].Offset(-1, 1);
      points[3].Offset(-1, -1);
      points[4].Offset(0, -1);
      points[5] = points[0];
      g.DrawLines(SystemPens.ControlLight, new Point[3]
      {
        points[0],
        points[1],
        points[2]
      });
      g.DrawLines(SystemPens.ControlDark, new Point[4]
      {
        points[2],
        points[3],
        points[4],
        points[5]
      });
    }

    private void DrawPointerRight(Graphics g)
    {
      Point[] points = new Point[6];
      points[0] = new Point(this.ThumbBounds.Left, checked (this.ThumbBounds.Bottom - 1));
      points[1] = new Point(this.ThumbBounds.Left, this.ThumbBounds.Top);
      points[2] = new Point(checked (this.ThumbBounds.Right - unchecked (this.ThumbBounds.Height / 2) - 1), this.ThumbBounds.Top);
      points[3] = new Point(checked (this.ThumbBounds.Right - 1), checked (this.ThumbBounds.Top + unchecked (this.ThumbBounds.Height / 2)));
      points[4] = new Point(checked (this.ThumbBounds.Right - unchecked (this.ThumbBounds.Height / 2) - 1), checked (this.ThumbBounds.Bottom - 1));
      points[5] = points[0];
      GraphicsPath path = new GraphicsPath();
      path.AddLines(points);
      Region region = new Region(path);
      g.Clip = region;
      if (this.ThumbState == 3 || !this.Enabled)
        ControlPaint.DrawButton(g, this.ThumbBounds, ButtonState.All);
      else
        g.Clear(SystemColors.Control);
      g.ResetClip();
      region.Dispose();
      path.Dispose();
      g.DrawLines(SystemPens.ControlLightLight, new Point[4]
      {
        points[0],
        points[1],
        points[2],
        points[3]
      });
      g.DrawLines(SystemPens.ControlDarkDark, new Point[3]
      {
        points[3],
        points[4],
        points[5]
      });
      points[0].Offset(1, -1);
      points[1].Offset(1, 1);
      points[2].Offset(0, 1);
      points[3].Offset(-1, 0);
      points[4].Offset(0, -1);
      points[5] = points[0];
      g.DrawLines(SystemPens.ControlLight, new Point[4]
      {
        points[0],
        points[1],
        points[2],
        points[3]
      });
      g.DrawLines(SystemPens.ControlDark, new Point[3]
      {
        points[3],
        points[4],
        points[5]
      });
    }

    private void DrawHorizontalTicks(Graphics g, Color color)
    {
      int num1 = checked (unchecked (checked (this.Maximum - this.Minimum) / this.TickFrequency) - 1);
      Pen pen = new Pen(color);
      RectangleF rectangleF1 = new RectangleF((float) checked (this.ChannelBounds.Left + unchecked (this.ThumbBounds.Width / 2)), (float) checked (this.ThumbBounds.Top - 5), 0.0f, 3f);
      RectangleF rectangleF2 = new RectangleF((float) checked (this.ChannelBounds.Right - unchecked (this.ThumbBounds.Width / 2) - 1), (float) checked (this.ThumbBounds.Top - 5), 0.0f, 3f);
      float x = (rectangleF2.Right - rectangleF1.Left) / (float) checked (num1 + 1);
      if (this.TickStyle != TickStyle.BottomRight)
      {
        g.DrawLine(pen, rectangleF1.Left, rectangleF1.Top, rectangleF1.Right, rectangleF1.Bottom);
        g.DrawLine(pen, rectangleF2.Left, rectangleF2.Top, rectangleF2.Right, rectangleF2.Bottom);
        RectangleF rectangleF3 = rectangleF1;
        --rectangleF3.Height;
        rectangleF3.Offset(x, 1f);
        int num2 = checked (num1 - 1);
        int num3 = 0;
        while (num3 <= num2)
        {
          g.DrawLine(pen, rectangleF3.Left, rectangleF3.Top, rectangleF3.Right, rectangleF3.Bottom);
          rectangleF3.Offset(x, 0.0f);
          checked { ++num3; }
        }
      }
      rectangleF1.Offset(0.0f, (float) checked (this.ThumbBounds.Height + 6));
      rectangleF2.Offset(0.0f, (float) checked (this.ThumbBounds.Height + 6));
      if (this.TickStyle != TickStyle.TopLeft)
      {
        g.DrawLine(pen, rectangleF1.Left, rectangleF1.Top, rectangleF1.Right, rectangleF1.Bottom);
        g.DrawLine(pen, rectangleF2.Left, rectangleF2.Top, rectangleF2.Right, rectangleF2.Bottom);
        RectangleF rectangleF3 = rectangleF1;
        --rectangleF3.Height;
        rectangleF3.Offset(x, 0.0f);
        int num2 = checked (num1 - 1);
        int num3 = 0;
        while (num3 <= num2)
        {
          g.DrawLine(pen, rectangleF3.Left, rectangleF3.Top, rectangleF3.Right, rectangleF3.Bottom);
          rectangleF3.Offset(x, 0.0f);
          checked { ++num3; }
        }
      }
      pen.Dispose();
    }

    private void DrawVerticalTicks(Graphics g, Color color)
    {
      int num1 = checked (unchecked (checked (this.Maximum - this.Minimum) / this.TickFrequency) - 1);
      Pen pen = new Pen(color);
      RectangleF rectangleF1 = new RectangleF((float) checked (this.ThumbBounds.Left - 5), (float) checked (this.ChannelBounds.Bottom - unchecked (this.ThumbBounds.Height / 2) - 1), 3f, 0.0f);
      RectangleF rectangleF2 = new RectangleF((float) checked (this.ThumbBounds.Left - 5), (float) checked (this.ChannelBounds.Top + unchecked (this.ThumbBounds.Height / 2)), 3f, 0.0f);
      float y = (rectangleF2.Bottom - rectangleF1.Top) / (float) checked (num1 + 1);
      if (this.TickStyle != TickStyle.BottomRight)
      {
        g.DrawLine(pen, rectangleF1.Left, rectangleF1.Top, rectangleF1.Right, rectangleF1.Bottom);
        g.DrawLine(pen, rectangleF2.Left, rectangleF2.Top, rectangleF2.Right, rectangleF2.Bottom);
        RectangleF rectangleF3 = rectangleF1;
        --rectangleF3.Width;
        rectangleF3.Offset(1f, y);
        int num2 = checked (num1 - 1);
        int num3 = 0;
        while (num3 <= num2)
        {
          g.DrawLine(pen, rectangleF3.Left, rectangleF3.Top, rectangleF3.Right, rectangleF3.Bottom);
          rectangleF3.Offset(0.0f, y);
          checked { ++num3; }
        }
      }
      rectangleF1.Offset((float) checked (this.ThumbBounds.Width + 6), 0.0f);
      rectangleF2.Offset((float) checked (this.ThumbBounds.Width + 6), 0.0f);
      if (this.TickStyle != TickStyle.TopLeft)
      {
        g.DrawLine(pen, rectangleF1.Left, rectangleF1.Top, rectangleF1.Right, rectangleF1.Bottom);
        g.DrawLine(pen, rectangleF2.Left, rectangleF2.Top, rectangleF2.Right, rectangleF2.Bottom);
        RectangleF rectangleF3 = rectangleF1;
        --rectangleF3.Width;
        rectangleF3.Offset(0.0f, y);
        int num2 = checked (num1 - 1);
        int num3 = 0;
        while (num3 <= num2)
        {
          g.DrawLine(pen, rectangleF3.Left, rectangleF3.Top, rectangleF3.Right, rectangleF3.Bottom);
          rectangleF3.Offset(0.0f, y);
          checked { ++num3; }
        }
      }
      pen.Dispose();
    }

    private static bool VisualStylesEnabled
    {
      get
      {
        return Application.RenderWithVisualStyles;
      }
    }
  }
}
