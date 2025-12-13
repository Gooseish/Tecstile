using System;

namespace Tecstile.Source_Code.Menus;

public abstract class MenuBase
{
    public MenuType type;
}
public enum MenuType
{
    Title, NewGame, LoadGame, Settings
}
