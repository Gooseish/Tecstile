using System;
using System.Collections.Generic;

namespace Tecstile.Source_Code.Menus;

public class MenuState
{
    public bool exitCalling;
    public List<MenuBase> menus;
    public MenuBase activeMenu
    {
        get {return menus[menus.Count];}
    }
    public MenuState()
    {
        menus = new List<MenuBase>{};
    }
}
