// Decompiled with JetBrains decompiler
// Type: TrackBar.NativeMethods
// Assembly: TrackBar, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4906918C-FE0D-4418-9244-1FF2A5C025F4
// Assembly location: C:\Users\Nick\Downloads\TrackBar\TrackBar.dll

using System;
using System.Drawing;
using System.Globalization;
using System.Runtime.InteropServices;

namespace TrackBar
{
  internal class NativeMethods
  {
    public const int WM_ERASEBKGND = 20;
    public const int WM_USER = 1024;
    public const int WM_NOTIFY = 78;
    public const int WM_REFLECT = 8192;
    public const int NM_FIRST = 0;
    public const int NM_CUSTOMDRAW = -12;
    public const int TMT_COLOR = 204;
    public const int S_OK = 0;

    private NativeMethods()
    {
    }

    [DllImport("UxTheme.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern bool IsAppThemed();

    [DllImport("UxTheme.dll", CharSet = CharSet.Unicode)]
    public static extern IntPtr OpenThemeData(IntPtr hwnd, string pszClassList);

    [DllImport("UxTheme.dll")]
    public static extern int CloseThemeData(IntPtr hTheme);

    [DllImport("UxTheme.dll")]
    public static extern int DrawThemeBackground(
      IntPtr hTheme,
      IntPtr hdc,
      int iPartId,
      int iStateId,
      ref NativeMethods.RECT pRect,
      ref NativeMethods.RECT pClipRect);

    [DllImport("UxTheme.dll")]
    public static extern int GetThemeColor(
      IntPtr hTheme,
      int iPartId,
      int iStateId,
      int iPropId,
      ref int pColor);

    public struct DLLVERSIONINFO
    {
      public int cbSize;
      public int dwMajorVersion;
      public int dwMinorVersion;
      public int dwBuildNumber;
      public int dwPlatformID;
    }

    public struct NMHDR
    {
      public IntPtr HWND;
      public IntPtr idFrom;
      public int code;

      public new string ToString()
      {
        return string.Format((IFormatProvider) CultureInfo.InvariantCulture, "Hwnd: {0}, ControlID: {1}, Code: {2}", (object) this.HWND, (object) this.idFrom, (object) this.code);
      }
    }

    public struct NMCUSTOMDRAW
    {
      public NativeMethods.NMHDR hdr;
      public NativeMethods.CustomDrawDrawStage dwDrawStage;
      public IntPtr hdc;
      public NativeMethods.RECT rc;
      public IntPtr dwItemSpec;
      public NativeMethods.CustomDrawItemState uItemState;
      public IntPtr lItemlParam;
    }

    public struct RECT
    {
      public int Left;
      public int Top;
      public int Right;
      public int Bottom;

      public RECT(Rectangle rect)
        : this()
      {
        this.Left = rect.Left;
        this.Top = rect.Top;
        this.Right = rect.Right;
        this.Bottom = rect.Bottom;
      }

      public override string ToString()
      {
        return string.Format((IFormatProvider) CultureInfo.InvariantCulture, "{0}, {1}, {2}, {3}", (object) this.Left, (object) this.Top, (object) this.Right, (object) this.Bottom);
      }

      public Rectangle ToRectangle()
      {
        return Rectangle.FromLTRB(this.Left, this.Top, this.Right, this.Bottom);
      }
    }

    public enum CustomDrawDrawStage
    {
      CDDS_PREPAINT = 1,
      CDDS_POSTPAINT = 2,
      CDDS_PREERASE = 3,
      CDDS_POSTERASE = 4,
      CDDS_ITEM = 65536, // 0x00010000
      CDDS_ITEMPREPAINT = 65537, // 0x00010001
      CDDS_ITEMPOSTPAINT = 65538, // 0x00010002
      CDDS_ITEMPREERASE = 65539, // 0x00010003
      CDDS_ITEMPOSTERASE = 65540, // 0x00010004
      CDDS_SUBITEM = 131072, // 0x00020000
    }

    public enum CustomDrawItemState
    {
      CDIS_SELECTED = 1,
      CDIS_GRAYED = 2,
      CDIS_DISABLED = 4,
      CDIS_CHECKED = 8,
      CDIS_FOCUS = 16, // 0x00000010
      CDIS_DEFAULT = 32, // 0x00000020
      CDIS_HOT = 64, // 0x00000040
      CDIS_MARKED = 128, // 0x00000080
      CDIS_INDETERMINATE = 256, // 0x00000100
      CDIS_SHOWKEYBOARDCUES = 512, // 0x00000200
    }

    public enum CustomDrawReturnFlags
    {
      CDRF_DODEFAULT = 0,
      CDRF_NEWFONT = 2,
      CDRF_SKIPDEFAULT = 4,
      CDRF_NOTIFYPOSTPAINT = 16, // 0x00000010
      CDRF_NOTIFYITEMDRAW = 32, // 0x00000020
      CDRF_NOTIFYSUBITEMDRAW = 32, // 0x00000020
      CDRF_NOTIFYPOSTERASE = 64, // 0x00000040
    }

    public enum TrackBarCustomDrawPart
    {
      TBCD_TICS = 1,
      TBCD_THUMB = 2,
      TBCD_CHANNEL = 3,
    }

    public enum TrackBarParts
    {
      TKP_TRACK = 1,
      TKP_TRACKVERT = 2,
      TKP_THUMB = 3,
      TKP_THUMBBOTTOM = 4,
      TKP_THUMBTOP = 5,
      TKP_THUMBVERT = 6,
      TKP_THUMBLEFT = 7,
      TKP_THUMBRIGHT = 8,
      TKP_TICS = 9,
      TKP_TICSVERT = 10, // 0x0000000A
    }
  }
}
