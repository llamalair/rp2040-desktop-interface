
using System.IO.Ports;


namespace connectToHardware.MVVM
{
    public interface IService
    {
        string LedOn();
        string LedOff();
        string ReadMe();
    }

}
