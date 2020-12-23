using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using YuguLibrary.Controllers;

public class UIController : MonoBehaviour
{

    public UIManager uiManager;
    public EventSystem uiEventHandler;

    void Awake()
    {
        SetActiveUIManager(new UIManager());
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SetActiveUIManager(UIManager uiManager)
    {
        this.uiManager = uiManager;
    }


}
