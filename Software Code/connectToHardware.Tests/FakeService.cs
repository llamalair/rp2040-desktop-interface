// purely for testing only 
// as the realservice connects to the hardware it will be hard for us to test that 


using connectToHardware.Tests;
using connectToHardware.MVVM;


namespace connectToHardware.Tests
{
    public class FakeService : IService
    {
        public string LedOn()
        {
            return "ON";
        }
        public string LedOff()
        {
            return "OFF";
        }
        public string ReadMe()
        {
            return "ON";
        }
    }
}
