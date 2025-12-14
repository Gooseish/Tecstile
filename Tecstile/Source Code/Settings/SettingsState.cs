using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Input;
using Tecstile.Input;

namespace Tecstile.Settings;

public struct SettingsState
{
    public Dictionary<CommandName, Keys> KeyboardMap;
    public SettingsState()
    {
        KeyboardMap = new Dictionary<CommandName, Keys>{};
    }
}
