using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMaster : MonoBehaviour
{
    //UI Objects
    public GameObject _FishCompendium;
    public GameObject _FishDataSheet;

    public bool isGamePaused = false;

    

    void Start()
    {
       

        _FishCompendium = GameObject.FindGameObjectWithTag("FishCompendium");
        _FishDataSheet = GameObject.FindGameObjectWithTag("FishDataSheet");

        _FishCompendium.SetActive(false);
        _FishDataSheet.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (isGamePaused)
            {
                DeactivateCompendium();
            }
            else
            {
                AccessCompendium();
            }

        }
    }

    //Compendium
    public void AccessCompendium()
    {
        isGamePaused = true;
        _FishCompendium.SetActive(true);
        

    }

    public void DeactivateCompendium()
    {
        isGamePaused = false;
        _FishCompendium.SetActive(false);
        
    }

    //Datasheet
    public void AccessFishDatasheet()
    {
        isGamePaused = true;
        _FishCompendium.SetActive(false);
        _FishDataSheet.SetActive(true);
    }
}
