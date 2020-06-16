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


    }
}
