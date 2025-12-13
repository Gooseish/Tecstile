using System;
using System.Collections.Generic;
using Tecstile.Source_Code.Menus;

namespace Tecstile.Source_Code.Menus;

public class MenuTitle:
MenuBase,
IMenuNodeMap
{
    public MenuTitle()
    {
        nodeMapType = NodeMapType.Linear;
    }
    #region Interface Compliance
    public List<NodeBase> nodes{get;set;}
    public int activeNodeIndex{get;set;}
    public bool inspectActive{get;set;}
    public NodeMapType nodeMapType{get;set;}
    #endregion
}
