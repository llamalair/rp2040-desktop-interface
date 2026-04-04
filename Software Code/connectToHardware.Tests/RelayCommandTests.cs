// first unit test using Xunit 
// Xunit is a free open source unit testing tool for C#
using Xunit;
using connectToHardware.MVVM;

namespace connectToHardware.Tests
{
    public class RelayCommandTests
    {
        // we use fact cause we want it to be always true else we would use theory 
        [Fact]
        // to test execute 

        // MethodName_Condition_ExpectedResult -- namign convention 
        public void Execute_CallsProvidedAction()
        {
            bool wasCalled = false;
            var command = new RelayCommand(() => wasCalled = true);

            command.Execute(null);

            Assert.True(wasCalled);
        }

        [Fact]
        // to test canexecute 
        public void CanExecute_AlwaysReturnsTrue()
        {
            var command = new RelayCommand(() => { });

            bool result = command.CanExecute(new object());

            Assert.True(result);
        }
    }
}