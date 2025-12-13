using System;
using System.Collections.Generic;
using Tecstile.Source_Code.Menus;

namespace Tecstile.Source_Code.Menus;

public class MenuTitle:
MenuBase,
IMenuNodeMap
{
    #region Interface Compliance
    public List<NodeBase> nodes{get;set;}
    public int activeNodeIndex{get;set;}
    public bool inspectActive{get;set;}
    #endregion
}
