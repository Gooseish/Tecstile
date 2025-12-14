using System;
using System.Collections.Generic;
using System.Linq;

namespace Tecstile.Menus;

public interface IMenuNodeMap
{
    public NodeBase activeNode {get {return nodes[activeNodeIndex];}}
    public bool inspectable {get {return nodes.Any(node => node is INodeInspectable);}}
    public bool inspectActive{get;set;}
    public List<NodeBase> nodes {get;}
    public int activeNodeIndex {get;set;}
    public NodeMapType nodeMapType{get;set;}
}
public enum NodeMapType
{
    Linear,
}
