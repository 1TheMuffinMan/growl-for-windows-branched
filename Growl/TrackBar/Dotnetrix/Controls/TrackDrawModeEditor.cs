// Decompiled with JetBrains decompiler
// Type: TrackBar.Dotnetrix.Controls.TrackDrawModeEditor
// Assembly: TrackBar, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4906918C-FE0D-4418-9244-1FF2A5C025F4
// Assembly location: C:\Users\Nick\Downloads\TrackBar\TrackBar.dll

using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing.Design;
using System.Runtime.CompilerServices;
using System.Security.Permissions;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace TrackBar.Dotnetrix.Controls
{
  [PermissionSet(SecurityAction.LinkDemand, Unrestricted = true)]
  [PermissionSet(SecurityAction.InheritanceDemand, Unrestricted = true)]
  public class TrackDrawModeEditor : UITypeEditor
  {
    public override UITypeEditorEditStyle GetEditStyle(
      ITypeDescriptorContext context)
    {
      return UITypeEditorEditStyle.DropDown;
    }

    public override object EditValue(
      ITypeDescriptorContext context,
      System.IServiceProvider provider,
      object value)
    {
      if (!(value is TrackBarOwnerDrawParts) || provider == null)
        return value;
      IWindowsFormsEditorService service = (IWindowsFormsEditorService) provider.GetService(typeof (IWindowsFormsEditorService));
      if (service == null)
        return value;
      CheckedListBox checkedListBox = new CheckedListBox();
      checkedListBox.BorderStyle = BorderStyle.None;
      checkedListBox.CheckOnClick = true;
      checkedListBox.Items.Add((object) "Ticks", (((TrackBar) context.Instance).OwnerDrawParts & TrackBarOwnerDrawParts.Ticks) == TrackBarOwnerDrawParts.Ticks);
      checkedListBox.Items.Add((object) "Thumb", (((TrackBar) context.Instance).OwnerDrawParts & TrackBarOwnerDrawParts.Thumb) == TrackBarOwnerDrawParts.Thumb);
      checkedListBox.Items.Add((object) "Channel", (((TrackBar) context.Instance).OwnerDrawParts & TrackBarOwnerDrawParts.Channel) == TrackBarOwnerDrawParts.Channel);
      service.DropDownControl((Control) checkedListBox);
      IEnumerator enumerator = null;
      TrackBarOwnerDrawParts barOwnerDrawParts = TrackBarOwnerDrawParts.None;
      try
      {
        enumerator = checkedListBox.CheckedItems.GetEnumerator();
        while (enumerator.MoveNext())
        {
          object objectValue = RuntimeHelpers.GetObjectValue(enumerator.Current);
          barOwnerDrawParts |= (TrackBarOwnerDrawParts) Enum.Parse(typeof (TrackBarOwnerDrawParts), objectValue.ToString());
        }
      }
      finally
      {
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      checkedListBox.Dispose();
      service.CloseDropDown();
      return (object) barOwnerDrawParts;
    }
  }
}
