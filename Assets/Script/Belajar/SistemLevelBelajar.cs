using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SistemLevelBelajar : MonoBehaviour
{
   public Button lvl2Belajar, lvl3Belajar, lvl4Belajar, lvl5Belajar;
   //TRY
   public Button lvl1Juara, lvl2Juara, lvl3Juara, lvl4Juara, lvl5Juara;
    int levelPassed;
 
    // Start is called before the first frame update
    void Start()
    {
        levelPassed = PlayerPrefs.GetInt  ("LevelPassed");
        lvl2Belajar.interactable = false;
        lvl3Belajar.interactable = false;
        lvl4Belajar.interactable = false;
        lvl5Belajar.interactable = false;
        lvl1Juara.interactable = false;
        lvl2Juara.interactable = false;
        lvl3Juara.interactable = false;
        lvl4Juara.interactable = false;
        lvl5Juara.interactable = false;

        switch (levelPassed)
        {
            case 1:
            
            lvl2Belajar.interactable = true;
            break;
            //Keknya kalau levelnya masih kekunci gak perlu di true
            case 2:
            lvl2Belajar.interactable = true;
            lvl3Belajar.interactable = true;
            break;
            case 3:
            lvl2Belajar.interactable = true;
            lvl3Belajar.interactable = true;
            lvl4Belajar.interactable = true;
            break;
            case 4:
            lvl2Belajar.interactable = true;
            lvl3Belajar.interactable = true;
            lvl4Belajar.interactable = true;
            lvl5Belajar.interactable = true;
            break;
            case 5:
                lvl1Juara.interactable = true;
            lvl2Belajar.interactable = true;
                lvl2Juara.interactable = false;
            lvl3Belajar.interactable = true;
                lvl3Juara.interactable = false;
            lvl4Belajar.interactable = true;
                lvl4Juara.interactable = false;
            lvl5Belajar.interactable = true;
                lvl5Juara.interactable = false;
            break;
            case 6:
                lvl1Juara.interactable = true;
            lvl2Belajar.interactable = true;
                lvl2Juara.interactable = true;
            lvl3Belajar.interactable = true;
                lvl3Juara.interactable = false;
            lvl4Belajar.interactable = true;
                lvl4Juara.interactable = false;
            lvl5Belajar.interactable = true;
                lvl5Juara.interactable = false;
            break;
            case 7:
                lvl1Juara.interactable = true;
            lvl2Belajar.interactable = true;
                lvl2Juara.interactable = true;
            lvl3Belajar.interactable = true;
                lvl3Juara.interactable = true;
            lvl4Belajar.interactable = true;
                lvl4Juara.interactable = false;
            lvl5Belajar.interactable = true;
                lvl5Juara.interactable = false;
            break;
            case 8:
                lvl1Juara.interactable = true;
            lvl2Belajar.interactable = true;
                lvl2Juara.interactable = true;
            lvl3Belajar.interactable = true;
                lvl3Juara.interactable = true;
            lvl4Belajar.interactable = true;
                lvl4Juara.interactable = true;
            lvl5Belajar.interactable = true;
                lvl5Juara.interactable = false;
            break;
            case 9:
                lvl1Juara.interactable = true;
            lvl2Belajar.interactable = true;
                lvl2Juara.interactable = true;
            lvl3Belajar.interactable = true;
                lvl3Juara.interactable = true;
            lvl4Belajar.interactable = true;
                lvl4Juara.interactable = true;
            lvl5Belajar.interactable = true;
                lvl5Juara.interactable = true;
            break;
            
        }
    }

    public void levelToLoad (int level)
    {
        SceneManager.LoadScene (level);
    }
}
