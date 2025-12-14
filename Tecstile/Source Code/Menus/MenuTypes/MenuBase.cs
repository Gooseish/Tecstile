using System;

namespace Tecstile.Menus;

public abstract class MenuBase
{
    public MenuType type;
}
public enum MenuType
{
    Title, NewGame, LoadGame, Settings
}
