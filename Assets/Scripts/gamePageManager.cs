using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamePageManager : MonoBehaviour
{
   public void boxGameRouting(){
         Debug.Log("play button clicked");
         UnityEngine.SceneManagement.SceneManager.LoadScene("boxGameIntro");

    }
   public void boxIntroRouting(){
         Debug.Log("play button clicked");
         UnityEngine.SceneManagement.SceneManager.LoadScene("boxGame");

    }
}
