using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class spriteChanger : MonoBehaviour
{
    public Sprite defolt;
    public Sprite defoltx;
    public Image scripr;
    public Image expresion;
    public Sprite first;
    public Sprite second;
    public Sprite thired;
    public Sprite forth;
    public Sprite firstx;
    public Sprite secondx;
    public Sprite thiredx;
    public Sprite forthx;
    public GameObject dailogue,Button;


    private void Start()
    {
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(Button);
    }
    public void Change()
    {
        if (scripr.sprite == defolt)
        {
            scripr.sprite = first;
        }
       else if (scripr.sprite == first)
        {
            scripr.sprite = second;
        }
       
       else if (scripr.sprite == second)
        {
            scripr.sprite = thired;
        }
      else  if (scripr.sprite == thired)
        {
            scripr.sprite = forth;
         
        }
        if (expresion.sprite ==defoltx)
        {
            expresion.sprite = firstx;
        }
       
     else  if (expresion.sprite == firstx)
        {
            expresion.sprite = secondx;
        }

      else  if (expresion.sprite == secondx)
        {
            expresion.sprite = thiredx;
        }
      else  if (expresion.sprite == thiredx)
        {
            expresion.sprite = forthx;
        }
        else
        {
            Destroy(dailogue);
        }
        
    }
}
