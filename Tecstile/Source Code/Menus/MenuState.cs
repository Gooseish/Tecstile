using System;
using System.Collections.Generic;

namespace Tecstile.Menus;

public class MenuState
{
    public List<MenuBase> menus;
    public MenuBase activeMenu
    {
        get {return menus[menus.Count - 1];}
    }
    public MenuState()
    {
        menus = new List<MenuBase>{};
    }
}
