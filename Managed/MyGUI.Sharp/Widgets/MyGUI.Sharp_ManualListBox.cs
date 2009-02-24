using System;
using System.Runtime.InteropServices;

namespace MyGUI.Sharp
{

    public partial class ListBox
    {

        #region Method GetItemDataAt

        [DllImport("MyGUI.Export.dll", CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.IUnknown)]
        private static extern object ExportListBox_GetItemDataAt_index(IntPtr _widget,
             uint _index);

        public object GetItemDataAt(
            uint _index)
        {
            return ExportListBox_GetItemDataAt_index(mNative,
                _index);
        }

        #endregion

    }

}
