using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Input;
using Tecstile.Source_Code.Input;

namespace Tecstile.Source_Code.Settings;

public struct SettingsState
{
    public Dictionary<CommandName, Keys> KeyboardMap;
    public SettingsState()
    {
        KeyboardMap = new Dictionary<CommandName, Keys>{};
    }
}
