using System;
using System.Collections.Generic;

namespace Tecstile.Source_Code.Input;

public struct InputState
{
    public Dictionary<CommandName, Command> commands;

    public InputState()
    {
        commands = new Dictionary<CommandName, Command>{};
        foreach(CommandName commandName in Enum.GetValues(typeof(CommandName)))
            commands[commandName] = new Command();
    }
}
