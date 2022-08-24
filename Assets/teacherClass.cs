using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class teacherClass : MonoBehaviour
{
    public GameObject a, b, c,d;
    public Sprite defolt;
    public Sprite defoltx;
    public Image scripr;
    public Image expresion;
    public Sprite first;
    public Sprite second;
    public Sprite thired;
    public Sprite forth;
    public Sprite fifth;
    public Sprite sexth;
    public Sprite seventh;
    public Sprite eith;
    public Sprite ninth;
   
    public Sprite firstx;
    public Sprite secondx;
    public Sprite thiredx;
    public Sprite forthx;
    public Sprite fifthx;
    public Sprite sexthx;
    public Sprite seventhx;
    public Sprite eithx;
    public Sprite ninthx;
    public GameObject toDestroy;
 

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
        else if (scripr.sprite == thired)
        {
            scripr.sprite = forth;

        }
        else if (scripr.sprite == forth)
        {
            scripr.sprite = fifth;

        }
        else if (scripr.sprite == fifth)
        {
            scripr.sprite = sexth;

        }
       
        else if (scripr.sprite == sexth)
        {
            scripr.sprite = seventh;

        }
        else if (scripr.sprite == seventh)
        {

            scripr.sprite = seventh;
        }
        else
        {
            Destroy(toDestroy);
        }



        if (expresion.sprite == defoltx)
        {
            expresion.sprite = firstx;
        }

        else if (expresion.sprite == firstx)
        {
            expresion.sprite = secondx;
        }

        else if (expresion.sprite == secondx)
        {
            expresion.sprite = thiredx;
        }
        else if (expresion.sprite == thiredx)
        {
            expresion.sprite = forthx;
        }
        else if (expresion.sprite == forthx)
        {
            scripr.sprite = fifthx;

        }
        else if (expresion.sprite == fifthx)
        {
            scripr.sprite = sexthx;

        }
        else if (expresion.sprite == sexthx)
        {
            scripr.sprite = sexth;
        }

        else if (expresion.sprite == sexthx)
        {
            scripr.sprite = seventh;

        }
        else if (expresion.sprite == seventhx)
                {

            expresion.sprite = seventhx;
        }
        else if(scripr.sprite==eith|| scripr.sprite == ninth)
        {
            Destroy(toDestroy);
        }
        else
        {
            Destroy(toDestroy);
        }
       
        

    }
    public void rightAnswer()
    {
        scripr.sprite = eith;
       expresion.sprite = eithx;
        a.SetActive(false);
        b.SetActive(false);
        c.SetActive(false);
        d.SetActive(false);
        SceneManager.LoadScene("MyScene");
    }
    public void wrongAnswer()
    {
        scripr.sprite = ninth;
        expresion.sprite = ninthx;
        a.SetActive(false);
        b.SetActive(false);
        c.SetActive(false);
        d.SetActive(false);
        SceneManager.LoadScene("MyScene");

    }
    private void Update()
    {
        if (scripr.sprite == seventh)
        {
            a.SetActive(true);
           b.SetActive(true);
            c.SetActive(true);
            d.SetActive(true);
        }
    }
    
}
