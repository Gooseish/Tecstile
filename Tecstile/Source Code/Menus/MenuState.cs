using System;
using System.Collections.Generic;

namespace Tecstile.Source_Code.Menus;

public class MenuState
{
    public bool menuOpen;
    public bool exitCalling;
    public List<MenuBase> menus;
    public MenuState()
    {
        
    }
}
