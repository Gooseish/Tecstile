using System;


namespace Tecstile.Source_Code.Clock;

public class ClockManager
{
    public ClockState state;
    public ClockManager()
    {
        state = new ClockState();
    }
}
