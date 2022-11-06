using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    public  interface IRecorder
    {
        
        string StartRecording();
        string StopRecording();
        string ScreenCapture();
        string AudioSource();
        string Mic();
        string VCamera();
        string Maximize();
        string Minimize();
        string Close();
    }
}
