using System;
using System.Data;
using Tecstile.Graphics;
using Tecstile.Input;
using Tecstile.Source_Code.Menus;
using Tecstile.Source_Code.Scene;

namespace Tecstile;

public static class Global
{
    public static MenuManager menu = new MenuManager();
    public static SceneManager scene = new SceneManager();
    public static InputHandler input = new InputHandler();
    public static Renderer renderer = new Renderer();
}
