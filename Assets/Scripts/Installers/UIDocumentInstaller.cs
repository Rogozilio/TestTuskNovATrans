using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UIElements;
using Zenject;

public class UIInstaller : MonoInstaller
{
    public GameObject reductor;
    public PanelSettings panelSettings;
    public VisualTreeAsset sourceAsset;
    public override void InstallBindings()
    {
        var uiDocument = Container.InstantiateComponent<UIDocument>(reductor);
        uiDocument.panelSettings = panelSettings;
        uiDocument.visualTreeAsset = sourceAsset;

        Container.Bind<UI>().AsSingle().WithArguments(uiDocument).NonLazy();
    }
}