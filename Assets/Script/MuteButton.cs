using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MuteButton : MonoBehaviour
{
    [SerializeField] Image SoundIconOn;
    [SerializeField] Image SoundIconOff;
    private bool isMuted = false;
    private void Start(){
        if(!PlayerPrefs.HasKey("isMuted")){
            PlayerPrefs.SetInt("isMuted", 0);
            Load();
        }else{
            Load();
        }
        UpdateIcon();
    }
    public void OnBtnMutePressed()
    {
        if (isMuted)
        {
            isMuted = false;
            GameObject.FindGameObjectWithTag("BackgroundMusic").GetComponent<BackgroundMusic>().PlayMusic();
        }
        else
        {
            isMuted = true;
            GameObject.FindGameObjectWithTag("BackgroundMusic").GetComponent<BackgroundMusic>().StopMusic();
        }
        Save();
        UpdateIcon();
    }
    private void UpdateIcon(){
        if (isMuted)
        {
            SoundIconOn.enabled = false;
            SoundIconOff.enabled = true;
        }
        else
        {
            SoundIconOn.enabled = true; 
            SoundIconOff.enabled = false;
        }
    }
    private void Load(){
        isMuted = PlayerPrefs.GetInt("isMuted", 0) == 1;
    }
    private void Save(){
        PlayerPrefs.SetInt("isMuted", isMuted ? 1 : 0);
    }
}
