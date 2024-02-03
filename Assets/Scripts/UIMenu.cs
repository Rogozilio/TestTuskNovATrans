using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class UIMenu : MonoBehaviour
{
    public UIDocument UIDocument;

    private VisualElement _root;

    private void Awake()
    {
        _root = UIDocument.rootVisualElement;
        
        _root.Q("Start").AddManipulator(new ClickManipulator((target) =>
        {
            SceneManager.LoadScene("Main");
        }));
        _root.Q("Exit").AddManipulator(new ClickManipulator((target) =>
        {
            Application.Quit();
        }));
    }
}
