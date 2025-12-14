using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Input;
using Tecstile.Input;

namespace Tecstile.Settings;

public class SettingsState
{
    public Dictionary<CommandName, Keys> keyboardMap;
    public int masterVolume;
    public int sfxVolume;
    public int musicVolume;
    public SettingsState()
    {
        keyboardMap = new Dictionary<CommandName, Keys>{};
    }
}
