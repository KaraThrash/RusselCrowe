using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardList : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public  string GetCardInfo(CardUi cardui)
    {
        int caseSwitch = 1;

        int a = 0; int r = 0; int c = 0; int d = 0; int m = 0;  int j = 0;
        string n = "";string desc = "";string t = "";
        switch (caseSwitch)
        {
            case 1:
                a = 1;
                c = 1;
                n = "Basic Attack";

                break;
            case 2:
                m = 1;
                c = 1;
                n = "Basic Move";
                break;
            default:
               
                break;
        }

        cardui.cardname.text = n;
        cardui.type.text = t;
        cardui.attack.text = a.ToString();
        cardui.range.text = r.ToString();
        cardui.defense.text = d.ToString();
        cardui.cost.text = c.ToString();
        cardui.move.text = m.ToString();
        cardui.jump.text = j.ToString();
        cardui.cardtext.text = desc;

        return "";
    }

}
