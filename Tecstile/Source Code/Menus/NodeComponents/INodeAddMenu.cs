using System;

namespace Tecstile.Source_Code.Menus;

public interface INodeAddMenu
{
    public MenuType menuToOpen{get;set;}
    public bool openMenuCondition{get;}
}
