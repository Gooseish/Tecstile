using System;

namespace Tecstile.Source_Code.Menus;

public interface INodeCallback
{
    public Action callback{get;set;}
    public bool callbackCondition{get;set;}
}
