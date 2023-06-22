

namespace BusinessClock.IntegrationTests;

public class DemoTests
{
    [Fact]
    public void CanAddTwoNumbers()
    {
        //Given
        int a = 10, b = 20, answer;
        //when
        answer = a + b; // System under test (SUT)
        //then
        if(answer != 30)
        {
            throw new Exception();
        }
    }
}
