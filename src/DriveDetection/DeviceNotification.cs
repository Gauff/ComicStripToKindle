﻿using System;
using System.Runtime.InteropServices;

namespace ComicStripToKindle.DriveDetection
{
    public static class DeviceNotification
    {
        // device state change
        //private const int WM_DEVICECHANGE = 0x0219;

        //// logical volume(A disk has been inserted, such a usb key or external HDD)
        //private const int DBT_DEVTYP_VOLUME = 0x00000002;

        //// detected a new device
        //private const int DBT_DEVICEARRIVAL = 0x8000;

        //// preparing to remove
        //private const int DBT_DEVICEQUERYREMOVE = 0x8001;

        //// removed
        //private const int DBT_DEVICEREMOVECOMPLETE = 0x8004;
        //protected override void WndProc(ref Message message)
        //{
        //    base.WndProc(ref message);

        //    if ((message.Msg != WM_DEVICECHANGE) || (message.LParam == IntPtr.Zero))
        //        return;

        //    DEV_BROADCAST_VOLUME volume = (DEV_BROADCAST_VOLUME)Marshal.PtrToStructure(message.LParam, typeof(DEV_BROADCAST_VOLUME));

        //    if (volume.dbcv_devicetype == DBT_DEVTYP_VOLUME)
        //    {
        //        switch (message.WParam.ToInt32())
        //        {
        //            // New device inserted...
        //            case DBT_DEVICEARRIVAL:
        //                MessageBox.Show(
        //               string.Format("A storage device has been inserted; Drive :{0}", ToDriveName(volume.dbcv_unitmask)), "Detect USB");
        //                break;

        //            // Device Removed.
        //            case DBT_DEVICEREMOVECOMPLETE:
        //                MessageBox.Show("Storage has been removed.", "Detect USB");
        //                break;
        //        }
        //    }
        //}

        // Convert to the Drive name (”D:”, “F:”, etc)
        public static string ToDriveName(int mask)
        {
            int offset = 0;
            while ((offset < 26) && ((mask & 0x00000001) == 0))
            {
                mask = mask >> 1;
                offset++;
            }

            if (offset < 26)
                return String.Format("{0}:", Convert.ToChar(Convert.ToInt32('A') + offset));

            return "?";
        }

        // Contains information about a logical volume.
        [StructLayout(LayoutKind.Sequential)]
        public struct DEV_BROADCAST_VOLUME
        {
            public int dbcv_size;
            public int dbcv_devicetype;
            public int dbcv_reserved;
            public int dbcv_unitmask;
        }
    }
}
