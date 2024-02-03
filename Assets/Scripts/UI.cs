using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
using Zenject;

public class UI
{
    private VisualElement _root;
    private VisualElement _elements;

    private Action _actionClickReductor;
    private Action _actionClickAxis;
    private Action _actionClickCap1;
    private Action _actionClickCap2;
    private Action _actionClickCrownGear;
    private Action _actionClickFasteners;
    private Action _actionClickPlanetaryCarrier1;
    private Action _actionClickPlanetaryCarrier2;
    private Action _actionClickPlanetaryGears;
    private Action _actionClickSleeve;
    private Action _actionClickSunGear;

    public Action SetActionClickReductor
    {
        set => _actionClickReductor = value;
    }

    public Action SetActionClickAxis
    {
        set => _actionClickAxis = value;
    }

    public Action SetActionClickCap1
    {
        set => _actionClickCap1 = value;
    }

    public Action SetActionClickCap2
    {
        set => _actionClickCap2 = value;
    }

    public Action SetActionClickCrownGear
    {
        set => _actionClickCrownGear = value;
    }

    public Action SetActionClickFasteners
    {
        set => _actionClickFasteners = value;
    }

    public Action SetActionClickPlanetaryCarrier1
    {
        set => _actionClickPlanetaryCarrier1 = value;
    }

    public Action SetActionClickPlanetaryCarrier2
    {
        set => _actionClickPlanetaryCarrier2 = value;
    }

    public Action SetActionClickPlanetaryGears
    {
        set => _actionClickPlanetaryGears = value;
    }

    public Action SetActionClickSleeve
    {
        set => _actionClickSleeve = value;
    }

    public Action SetActionClickSunGear
    {
        set => _actionClickSunGear = value;
    }

    public UI(UIDocument uiDocument)
    {
        _root = uiDocument.rootVisualElement;

        _elements = _root.Q("Elements");
        _root.Q("BackMenu").AddManipulator(new ClickManipulator((target) =>
        {
            SceneManager.LoadScene("Menu");
            Debug.Log("asdasd");
        }));
        _root.Q("Reductor").AddManipulator(new ClickManipulator((target) =>
        {
            _actionClickReductor?.Invoke();
            ToggleShowOrHideElements();
            target.ToggleInClassList("ActiveReductor");
        }));
        _root.Q("Axis").AddManipulator(new ClickManipulator((target) =>
        {
            _actionClickAxis?.Invoke();
            ToggleActiveOrDeactiveElements(target);
        }));
        _root.Q("Cap1").AddManipulator(new ClickManipulator((target) =>
        {
            _actionClickCap1?.Invoke();
            ToggleActiveOrDeactiveElements(target);
        }));
        _root.Q("Cap2").AddManipulator(new ClickManipulator((target) =>
        {
            _actionClickCap2?.Invoke();
            ToggleActiveOrDeactiveElements(target);
        }));
        _root.Q("CrownGear").AddManipulator(new ClickManipulator((target) =>
        {
            _actionClickCrownGear?.Invoke();
            ToggleActiveOrDeactiveElements(target);
        }));
        _root.Q("Fasteners").AddManipulator(new ClickManipulator((target) =>
        {
            _actionClickFasteners?.Invoke();
            ToggleActiveOrDeactiveElements(target);
        }));
        _root.Q("PlanetaryCarrier1").AddManipulator(new ClickManipulator((target) =>
        {
            _actionClickPlanetaryCarrier1?.Invoke();
            ToggleActiveOrDeactiveElements(target);
        }));
        _root.Q("PlanetaryCarrier2").AddManipulator(new ClickManipulator((target) =>
        {
            _actionClickPlanetaryCarrier2?.Invoke();
            ToggleActiveOrDeactiveElements(target);
        }));
        _root.Q("PlanetaryGears").AddManipulator(new ClickManipulator((target) =>
        {
            _actionClickPlanetaryGears?.Invoke();
            ToggleActiveOrDeactiveElements(target);
        }));
        _root.Q("Sleeve").AddManipulator(new ClickManipulator((target) =>
        {
            _actionClickSleeve?.Invoke();
            ToggleActiveOrDeactiveElements(target);
        }));
        _root.Q("SunGear").AddManipulator(new ClickManipulator((target) =>
        {
            _actionClickSunGear?.Invoke();
            ToggleActiveOrDeactiveElements(target);
        }));
    }

    private void ToggleShowOrHideElements()
    {
        _elements.ToggleInClassList("ShowListElements");
        _elements.ToggleInClassList("HideListElements");
        _root.Q(null, "ActiveButton")?.RemoveFromClassList("ActiveButton");
    }

    private void ToggleActiveOrDeactiveElements(VisualElement element)
    {
        var prevActiveElement = _root.Q(null, "ActiveButton");
        if (prevActiveElement != element)
        {
            prevActiveElement?.RemoveFromClassList("ActiveButton");
        }

        element.ToggleInClassList("ActiveButton");
    }
}