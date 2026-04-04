// you ussually have a test file for each real file you have
// and inside the test file you write individual unit test for each method in the file 

using Xunit;
using connectToHardware.ViewModel;

namespace connectToHardware.Tests
{
    
    public class MainWindowViewModelTests
    {

        [Fact]
        // MethodName_Condition_ExpectedResult -- namign convention 
        public void OnCommand_WhenStatusIsOff_SetsStatusToOn()

        {
            FakeService fakeservice = new FakeService();
            MainWindowViewModel vm = new MainWindowViewModel(fakeservice);

            vm.OnCommand.Execute(null); // essentailly the same as turnon 

            Assert.Equal("ON", vm.RealStatus);

        }


        // [Fact] - when OffCommand_WhenStatusIsOn_SetsStatusToOff()
        // [Fact] - when OnCommand_WhenStatusIsOn_ErrorMessage+Count()
        // [Fact] - when OffCommand_WhenStatusIsOff_ErrorMessage+Count()
    }


}
