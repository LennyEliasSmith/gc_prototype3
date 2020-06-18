using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class dataSheet : MonoBehaviour
{
    public Image spriteR;
    public TextMeshProUGUI fishName;
    public TextMeshProUGUI data;

    public string cellName1;
    public string cellData1;
    public Sprite cellSprite1;

    public string cellName2;
    public string cellData2;
    public Sprite cellSprite2;

    public string cellName3;
    public string cellData3;
    public Sprite cellSprite3;

    public string cellName4;
    public string cellData4;
    public Sprite cellSprite4;

    public string cellName5;
    public string cellData5;
    public Sprite cellSprite5;

    public string cellName6;
    public string cellData6;
    public Sprite cellSprite6;


    // Start is called before the first frame update
    void Start()
    {
        

        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Fish1")){

            fishName.text = cellName1.ToString();
            data.text = cellData1.ToString();
            spriteR.sprite = cellSprite1;

        }

        if (GameObject.FindGameObjectWithTag("Fish2"))
        {

            fishName.text = cellName2.ToString();
            data.text = cellData2.ToString();
            spriteR.sprite = cellSprite2;

        }

        if (GameObject.FindGameObjectWithTag("Fish3"))
        {

            fishName.text = cellName3.ToString();
            data.text = cellData3.ToString();
            spriteR.sprite = cellSprite3;

        }

        if (GameObject.FindGameObjectWithTag("Fish4"))
        {

            fishName.text = cellName4.ToString();
            data.text = cellData4.ToString();
            spriteR.sprite = cellSprite4;

        }

        if (GameObject.FindGameObjectWithTag("Fish5"))
        {

            fishName.text = cellName5.ToString();
            data.text = cellData5.ToString();
            spriteR.sprite = cellSprite5;

        }

        if (GameObject.FindGameObjectWithTag("Fish6"))
        {

            fishName.text = cellName6.ToString();
            data.text = cellData6.ToString();
            spriteR.sprite = cellSprite6;

        }


    }
}
