using System;
using System.Data;
using System.Runtime.CompilerServices;
using Tecstile.Graphics;
using Tecstile.Input;
using Tecstile.Clock;
using Tecstile.Menus;
using Tecstile.Scene;
using Tecstile.Settings;
using Tecstile.Audio;
using Tecstile.Data;

namespace Tecstile;

public static class Global
{
    public static ClockManager clock;
    public static SettingsManager settings;
    public static MenuManager menu;
    public static SceneManager scene;
    public static InputManager input;
    public static AudioContentManager audioContent;
    public static DataContentManager dataContent;
    public static GraphicalContentManager graphicalContent;

    static Global()
    {
        clock = new ClockManager();
        settings = new SettingsManager();
        menu = new MenuManager();
        scene = new SceneManager();
        input = new InputManager();
        audioContent = new AudioContentManager();
        dataContent = new DataContentManager();
        graphicalContent = new GraphicalContentManager();
    }
}
