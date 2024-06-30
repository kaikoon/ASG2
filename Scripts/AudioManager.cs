/*
 * Author: Lim Kai Koon
 * Date: 30/6/24
 * Description: 
 * Used to manage audio for options menu
 */
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    public Sound[] musicSounds, sfxSounds;
    public AudioSource musicSource, sfxSource;

    //doesn't destroy itself after loading new scene
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    //Play bgm after loading in
    private void Start()
    {
        PlayMusic("BGM");
    }
    //Play music
    public void PlayMusic(string name)
    {
        Sound s = Array.Find(musicSounds, x => x.name == name);

        if (s == null)
        {
            //null check
            Debug.Log("Sound Not Found");
        }
        else
        {
            musicSource.clip = s.clip;
            musicSource.Play();
        }
    }

    //play sfx
    public void PlaySFX(string name)
    {
        Sound s = Array.Find(sfxSounds, x => x.name == name);

        if (s == null)
        {
            //null check
            Debug.Log("Sound Not Found");
        }
        else
        {
            sfxSource.PlayOneShot(s.clip);
        }
    }
    //mute music
    public void ToggleMusic()
    {
        musicSource.mute = !musicSource.mute;
    }
    //mute sfx
    public void ToggleSFX()
    {
        sfxSource.mute = !sfxSource.mute;
    }
    //get music volume values
    public void MusicVolume(float volume)
    {
        musicSource.volume = volume;
    }
    //get sfx volume values
    public void SFXVolume(float volume)
    {
        sfxSource.volume = volume;
    }
}
