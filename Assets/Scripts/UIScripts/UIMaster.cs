using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIMaster : MonoBehaviour
{
    //UI Objects
    public GameObject _FishCompendium;
    public GameObject _FishDataSheet;
    public GameObject _pauseMenu;

    public Transform FishMaster;

    public bool isGamePaused = false;
    public bool isCompendiumOpen = false;

    

    void Start()
    {
       

        _FishCompendium = GameObject.FindGameObjectWithTag("FishCompendium");
        _FishDataSheet = GameObject.FindGameObjectWithTag("FishDataSheet");

        _FishCompendium.SetActive(false);
        _FishDataSheet.SetActive(false);
        _pauseMenu.SetActive(false);
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

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isGamePaused)
            {
                UnpauseGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    //General UI


    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
     public void Menu()
    {

        SceneManager.LoadScene(0);

    }

    public void QuitGame()
    {
        Application.Quit();

    }

    //Pausmenu
    public void PauseGame()
    {
        isGamePaused = true;
        _FishCompendium.SetActive(false);
        _FishDataSheet.SetActive(false);

        _pauseMenu.SetActive(true);

    }

    public void UnpauseGame()
    {
        isGamePaused = false;

        _pauseMenu.SetActive(false);
    }

    //Compendium
    public void AccessCompendium()
    {
        isGamePaused = true;
        isCompendiumOpen = true;
        _FishCompendium.SetActive(true);
        _FishDataSheet.SetActive(false);

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

    public void AccessFishDatasheet4()
    {
        FishMaster.gameObject.tag = "Fish4";
        isGamePaused = true;
        _FishCompendium.SetActive(false);
        _FishDataSheet.SetActive(true);


    }
    public void AccessFishDatasheet5()
    {
        FishMaster.gameObject.tag = "Fish5";
        isGamePaused = true;
        _FishCompendium.SetActive(false);
        _FishDataSheet.SetActive(true);


    }


}
