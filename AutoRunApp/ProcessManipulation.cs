using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoRunApp
{
    internal class ProcessManipulation
    {
        private Process _process;
        public ProcessManipulation(Process? process)
        {
            if (process != null)
            {
                _process = process;
            }
        }

        public bool StartProcess()
        {
            if (_process != null)
            {
                _process.Start();
                return true;
            }
            else
                return false;
        }

        public bool EndProcess()
        {
            if( _process != null)
            {
                _process.Close();
                return true;
            }
            else
                return false;
        }

        public bool CheckProcess()
        {
            if (_process != null && !_process.HasExited)
            {
                return true;
            }
            else
                return false;
        }
        
        public void RestartProcess()
        {
            if (_process != null && !_process.HasExited)
            {
                _process.Close();
                _process.Start();
            }
        }
    }
}
