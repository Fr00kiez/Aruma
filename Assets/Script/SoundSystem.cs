using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SoundSystem : MonoBehaviour
{
    /*public static SoundSystem Instance { get; set;}*/
    [SerializeField] private AudioSource _musicSource;
    [SerializeField] Image nyalaMus;
    [SerializeField] Image dedMus;
    private bool muted = false;

    void Start()
    {
        if(!PlayerPrefs.HasKey("muted"))
        {
            PlayerPrefs.SetInt("muted",0);
            Ambil();
        }

        else
        {
            Ambil();
        }

        UpdateTombol();
        AudioListener.pause = muted;
    }
    public void OnButtonPress()
    {
        if(muted == false )
        {
            muted = true;
            AudioListener.pause = true;
        }
        else
        {
            muted = false;
            AudioListener.pause = false;
        }

        Simpan();
        UpdateTombol();
    }

    private void Ambil()
    {
        muted = PlayerPrefs.GetInt("muted") == 1;
    }

    private void Simpan()
    {
        PlayerPrefs.SetInt("muted", muted ? 1 : 0);
    }

    private void UpdateTombol()
    {
        if(muted == false)
        {
            nyalaMus.enabled = true;
            dedMus.enabled = false;
        }

        else
        {
            dedMus.enabled = true;
            nyalaMus.enabled = false;
        }
    }

    /*private void Awake() 
    {
     DontDestroyOnLoad(this);
     if(Instance == null)
     {
        Instance = this;
     }   
     else
     {
        Destroy(gameObject);
     }
    }

    public void TogeMusic()
    {
        _musicSource.mute = !_musicSource.mute;
    }*/

}
