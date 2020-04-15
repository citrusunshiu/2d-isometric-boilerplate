using System.Collections;
using System.Collections.Generic;
using Units;
using UnityEngine;
using YuguLibrary.Controllers;
using YuguLibrary.Enumerations;
using YuguLibrary.Models;
using YuguLibrary.Utilities;

public class PlayerController : MonoBehaviour
{
    public Player player;
    public Camera mainCamera;

    void Awake()
    {
        player = new Player(mainCamera);
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("pc started");
    }

    // Update is called once per frame
    void Update()
    {
        player.ReadInputs();
    }
}
