using System;
using UnityEngine.UIElements;

public class ClickManipulator : PointerManipulator
{
    private Action<VisualElement> _action;

    public ClickManipulator(Action<VisualElement> action)
    {
        _action = action;
    }

    protected override void RegisterCallbacksOnTarget()
    {
        target.RegisterCallback<ClickEvent>(OnPointerClick, TrickleDown.TrickleDown);
    }

    protected override void UnregisterCallbacksFromTarget()
    {
        target.UnregisterCallback<ClickEvent>(OnPointerClick, TrickleDown.TrickleDown);
    }

    private void OnPointerClick(ClickEvent evt)
    {
        _action?.Invoke(target);
    }
}