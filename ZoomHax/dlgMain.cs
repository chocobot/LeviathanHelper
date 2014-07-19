using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZoomHax
{
    public partial class dlgMain : Form
    {
        public dlgMain()
        {
            InitializeComponent();
        }

        private void btn_Activate_Click(object sender, EventArgs e)
        {

            SigScan ss = new SigScan(MemoryHandler.Instance.Process, new IntPtr(0x1000 + MemoryHandler.Instance.BaseAddress), 0xFF0000);
            IntPtr result = ss.FindPattern(SigScan.SigToByte("FF FF FF FF 55 55 55 41 DB 0F C9 40 92 0A 06 3F"), "xxxxxxxxxxxxxxxx", 16);

            uint esi = MemoryHandler.Instance.GetUInt32((uint) result.ToInt32()) + 0xF0;
            MemoryHandler.Instance.SetFloat(esi, (float)100.0);
        }

        private void btn_Deactivate_Click(object sender, EventArgs e)
        {
            SigScan ss = new SigScan(MemoryHandler.Instance.Process, new IntPtr(0x1000 + MemoryHandler.Instance.BaseAddress), 0xFF0000);
            IntPtr result = ss.FindPattern(SigScan.SigToByte("FF FF FF FF 55 55 55 41 DB 0F C9 40 92 0A 06 3F"), "xxxxxxxxxxxxxxxx", 16);

            uint esi = MemoryHandler.Instance.GetUInt32((uint)result.ToInt32()) + 0xF0;
            MemoryHandler.Instance.SetFloat(esi, (float)20.0);
        }


    }
}
