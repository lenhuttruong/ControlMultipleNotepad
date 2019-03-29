using System;
using KAutoHelper;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlMultipleNotepad
{
    class User
    {
        private Process _process;
        private IntPtr _handle;
        private Object _setting;

        public Process process { get => _process; set => _process = value; }
        public IntPtr handle { get => _handle; set => _handle = value; }
        public Object setting { get => _setting; set => _setting = value; }

        public User(Process process, Object setting)
        {
            this._process = process;
            this._handle = process.MainWindowHandle;
            this._setting = setting;
        }

        public void TypeText(String text)
        {
            IntPtr childHandle;
            childHandle = AutoControl.FindWindowExFromParent(this._handle, null, "Edit");
            AutoControl.SendText(childHandle, text);
        }
    }
}
