using System;

namespace Tecstile.Menus;

public interface INodeAddMenu
{
    public MenuType menuToOpen{get;set;}
    public bool openMenuCondition{get;}
}
