using System;
using System.Data;
using System.Runtime.CompilerServices;
using Tecstile.Graphics;
using Tecstile.Input;
using Tecstile.Source_Code.Clock;
using Tecstile.Source_Code.Menus;
using Tecstile.Source_Code.Scene;
using Tecstile.Source_Code.Settings;

namespace Tecstile;

public static class Global
{
    public static ClockManager clock;
    public static SettingsManager settings;
    public static MenuManager menu;
    public static SceneManager scene;
    public static InputManager input;

    static Global()
    {
        clock = new ClockManager();
        settings = new SettingsManager();
        menu = new MenuManager();
        scene = new SceneManager();
        input = new InputManager();
    }
}
