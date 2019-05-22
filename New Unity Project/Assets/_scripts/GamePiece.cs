using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public struct piece
{
    public int hpmax,hpcurrent;
    public int team;
    public string name;
    public item rhand, lhand, boots, helmet, armor,extra;
}

public struct item
{
    public int hp, def, speed, jump, range, special;
}



public class GamePiece : MonoBehaviour
{
    // Start is called before the first frame update


    public item rhand, lhand, boots, helmet, armor, extra;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
