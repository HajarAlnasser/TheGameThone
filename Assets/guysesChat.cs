using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class guysesChat : MonoBehaviour
{
    // Start is called before the first frame update
    public Sprite defolt;
    public Sprite defoltx;
    public Image scripr;
    public Image Daylogue;
    public Sprite waleedsExpresion;
    public Image expresion;
    public Sprite first;
   
    
    public Sprite firstx;
   

    public Sprite abdulrahmansDayloguesprits;
    public Sprite waleedsDailog;
    public Sprite waleedsScripts;
    public Sprite abdulrahmansScript;
    public Sprite abdulrahmansExpression;
    public GameObject dailogue,a,b;
    

    public void Change()
    {
        if (scripr.sprite == defolt)
        {
            scripr.sprite = first;
            expresion.sprite = firstx;
        }
        else if (scripr.sprite == first)
        {
            
            scripr.sprite = waleedsScripts;
            Daylogue.sprite = waleedsDailog;
            expresion.sprite = waleedsExpresion;
            a.SetActive(true);
            b.SetActive(true);

        }

        else if (expresion.sprite == waleedsExpresion)
        {
            scripr.sprite = abdulrahmansScript;
            Daylogue.sprite = abdulrahmansDayloguesprits;
            expresion.sprite = abdulrahmansExpression;
            a.SetActive (true);
            b.SetActive(true);

        }
        else if (scripr.sprite == abdulrahmansScript)
        {
            scripr.sprite = abdulrahmansScript;
            Daylogue.sprite = abdulrahmansDayloguesprits;
            expresion.sprite = abdulrahmansExpression;
            a.SetActive(true);
            a.SetActive(false);
        }



       

    }
    public void Yes()
    {
        Destroy(dailogue);
    }
    public void No()
    {
        Destroy(dailogue);
    }

}
