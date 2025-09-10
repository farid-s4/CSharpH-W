using System.Runtime.InteropServices;

namespace F1ScreenBindWpf;

public class ScreenShotServices
{
    [DllImport("Screenshot.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
    public static extern int CaptureScreenToPNG(string filename);
}