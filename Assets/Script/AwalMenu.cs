using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AwalMenu : MonoBehaviour
{
   public void Keluar(){
       Application.Quit();
       Debug.Log("Permainan ditutup");
   }
   
}
