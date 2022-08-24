using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class scoreSystem : MonoBehaviour
{
    public TextMeshPro scoreText;
    public TextMeshPro acadimicText;
    public bool prayed;
    public int mony=50;
    public int academy = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = mony.ToString();
        acadimicText.text = academy.ToString();

    }
}
