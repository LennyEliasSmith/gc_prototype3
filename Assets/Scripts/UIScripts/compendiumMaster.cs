using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class compendiumMaster : MonoBehaviour
{
     public GameObject[] _fishCells;

    public string cell1Data;
    public SpriteRenderer cell1Sprite;

    // Start is called before the first frame update
    void Start()
    {
        compendiumCell cell1 = new compendiumCell();
        cell1._cellSprite = cell1Sprite;
        cell1._cellName = "Baglas";
        cell1._cellData = cell1Data;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
