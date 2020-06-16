using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMaster : MonoBehaviour
{
    //UI Objects
    public GameObject _FishCompendium;
    public GameObject _FishDataSheet;

    public Transform FishMaster;

    public bool isGamePaused = false;
    public bool isCompendiumOpen = false;

    

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
        isCompendiumOpen = true;
        _FishCompendium.SetActive(true);
        

    }

    public void DeactivateCompendium()
    {
        isGamePaused = false;
        _FishCompendium.SetActive(false);
        
    }

    //Datasheet
    public void AccessFishDatasheet1()
    {
        FishMaster.gameObject.tag = "Fish1";
        isGamePaused = true;
        _FishCompendium.SetActive(false);
        _FishDataSheet.SetActive(true);

        
    }

    public void AccessFishDatasheet2()
    {
        FishMaster.gameObject.tag = "Fish2";
        isGamePaused = true;
        _FishCompendium.SetActive(false);
        _FishDataSheet.SetActive(true);


    }

    public void AccessFishDatasheet3()
    {
        FishMaster.gameObject.tag = "Fish3";
        isGamePaused = true;
        _FishCompendium.SetActive(false);
        _FishDataSheet.SetActive(true);


    }


}
