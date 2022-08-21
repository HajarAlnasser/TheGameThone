using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class soundsMusic : MonoBehaviour
{

   // [SerializeField] private AudioClip WinSound, LoseSound;
  //  private AudioSource audio;
    private bool isSfx = true, isMusic = true;
    private Image sfxImage, musicImage;
    [SerializeField] GameObject musicBtn, sfxBtn, MusicSource, sfxSource;
    [SerializeField] Sprite[] icons;
    private bool[] arayBool = { false, true };

    // Start is called before the first frame update
    void Start()
    {
        sfxImage = sfxBtn.GetComponent<Image>();
        musicImage = musicBtn.GetComponent<Image>();
        //audio = sfxSource.GetComponent<AudioSource>();

        isSfx = arayBool[PlayerPrefs.GetInt("sfx")];
        isMusic = arayBool[PlayerPrefs.GetInt("music")];
        MuteSfx();
        MuteMusic();
    }

    //public void win()
    //{
    //    if (isSfx == true)
    //        GetComponent<AudioSource>().PlayOneShot(WinSound);

    //}
    //public void lose()
    //{
    //    if (isSfx == true)
    //        GetComponent<AudioSource>().PlayOneShot(LoseSound);

    //}



    public void MuteMusic()
    {

        if (isMusic == true)
        {
            musicImage.sprite = icons[0];
            PlayerPrefs.SetInt("music", 1);
            MusicSource.SetActive(true);
        }

        else if (isMusic == false)
        {
            musicImage.sprite = icons[1];
            PlayerPrefs.SetInt("music", 0);
            MusicSource.SetActive(false);
        }
        isMusic = !isMusic;
        PlayerPrefs.Save();


    }

    public void MuteSfx()
    {

        if (isSfx == true)
        {
            sfxImage.sprite = icons[2];
            sfxSource.SetActive(true);

            PlayerPrefs.SetInt("sfx", 1);

        }
        else if (isSfx == false)
        {
            sfxImage.sprite = icons[3];
            sfxSource.SetActive(false);
            PlayerPrefs.SetInt("sfx", 0);

        }
        isSfx = !isSfx;
        PlayerPrefs.Save();


    }

}
