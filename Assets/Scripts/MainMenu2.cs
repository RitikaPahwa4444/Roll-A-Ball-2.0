using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;



public class MainMenu2 : MonoBehaviour
{
    

    public void PlayGame(){
       
    SceneManager.LoadScene(1);
   }

   
    public void FixedUpdate(){
  if (Application.platform == RuntimePlatform.Android)
  {
   if (Input.GetKey(KeyCode.Escape))
   {
    Application.Quit();
   }
  }
 }
   public void About(){
    SceneManager.LoadScene(2);
   
   }
}
