/*
 * Author: Lim Kai Koon
 * Date: 30/6/24
 * Description: 
 * Options menu for music and sfx
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Options : MonoBehaviour
{
    //Set sliders for music and sfx
    public Slider _musicSlider, _sfxSlider;

    //Turn on/off music
    public void ToggleMusic()
    {
        AudioManager.instance.ToggleMusic();
    }

    //Turn on/off sfx
    public void ToggleSFX()
    {
        AudioManager.instance.ToggleSFX();
    }

    //Increase/decrease music volume
    public void MusicVolume()
    {
        AudioManager.instance.MusicVolume(_musicSlider.value);
    }

    //Increase/decrease sfx volume
    public void SFXVolume()
    {
        AudioManager.instance.SFXVolume(_sfxSlider.value);
    }
}
