/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SistemLevelJuara : MonoBehaviour
{
    public Button lvl2Juara, lvl3Juara, lvl4Juara, lvl5Juara;
    int levelPassed;
 
    // Start is called before the first frame update
    void Start()
    {
        levelPassed = PlayerPrefs.GetInt  ("LevelPassed");
        lvl2Juara.interactable = false;
        lvl3Juara.interactable = false;
        lvl4Juara.interactable = false;
        lvl5Juara.interactable = false;

        switch (levelPassed)
        {
            case 1:
            lvl2Juara.interactable = true;
            break;
            //Keknya kalau levelnya masih kekunci gak perlu di true
            case 2:
            lvl2Juara.interactable = true;
            lvl3Juara.interactable = true;
            break;
            case 3:
            lvl2Juara.interactable = true;
            lvl3Juara.interactable = true;
            lvl4Juara.interactable = true;
            break;
            case 4:
            lvl2Juara.interactable = true;
            lvl3Juara.interactable = true;
            lvl4Juara.interactable = true;
            lvl5Juara.interactable = true;
            break;
        }
    }

    public void levelToLoad (int level)
    {
        SceneManager.LoadScene (level);
    }

    //Ini buat reset kalau mau diulang lagi
    public void resetPlayerPrefs()
    {
        lvl2Juara.interactable = false;
            lvl3Juara.interactable = false;
            lvl4Juara.interactable = false;
            lvl5Juara.interactable = false;
        PlayerPrefs.DeleteAll();
    }
}
*/