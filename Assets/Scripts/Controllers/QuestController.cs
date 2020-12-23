using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestController : MonoBehaviour
{
    public QuestManager questManager;

    void Awake()
    {
        SetQuestManager(new QuestManager());
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetQuestManager(QuestManager questManager)
    {
        this.questManager = questManager;
    }
}
