using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnuklesSound : MonoBehaviour {

    private SoundManager soundManager;
    // Use this for initialization

    private void Awake()
    {
        soundManager = FindObjectOfType<SoundManager>();
    }

    void Start()
    {
        soundManager.Play("2knuckles");
        soundManager.Play("DoYouKnowTheWay");
        soundManager.Play("HeDoesntKnowTheWay");
        soundManager.Play("WhereIsEveryone");
    }

    public void KnucklesClicked()
    {
        Debug.Log("Mouse Izq presionado");
        
    }
}
