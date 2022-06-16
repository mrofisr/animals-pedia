using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovementSceneScript : MonoBehaviour
{
   public void Mulai(){
      SceneManager.LoadScene("MenuScene");
      Debug.Log("Mulai");
   }
   public void About(){
      SceneManager.LoadScene("AboutScene");
      Debug.Log("About");
   }
   public void Kembali(){
      SceneManager.LoadScene("MainMenuScene");
      Debug.Log("Kembali");
   }
   public void Rhino(){
      SceneManager.LoadScene("RhinoScene");
      GameObject.FindGameObjectWithTag("BackgroundMusic").GetComponent<BackgroundMusic>().StopMusic();
      Debug.Log("Rhino");
   }
   public void Spider(){
      SceneManager.LoadScene("SpiderScene");
      GameObject.FindGameObjectWithTag("BackgroundMusic").GetComponent<BackgroundMusic>().StopMusic();
      Debug.Log("Spider");
   }
   public void Tiger(){
      SceneManager.LoadScene("TigerScene");
      GameObject.FindGameObjectWithTag("BackgroundMusic").GetComponent<BackgroundMusic>().StopMusic();
      Debug.Log("Tiger");
   }
   public void Wolf(){
      SceneManager.LoadScene("WolfScene");
      GameObject.FindGameObjectWithTag("BackgroundMusic").GetComponent<BackgroundMusic>().StopMusic();
      Debug.Log("Wolf");
   }
   public void Keluar(){
      Application.Quit();
      Debug.Log("Keluar");
   }
}
