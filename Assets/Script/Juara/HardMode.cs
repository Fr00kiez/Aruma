using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HardMode : MonoBehaviour
{
   public TMP_Text pertanyaan, opsiA, opsiB, opsiC, opsiD;
   public GameObject KalahLayar,MenangLayar;
   //LEVEL SYSTEM
   int tampilanIndex, levelPassed;
   //Nambah Medali
   public string medaliYangDidapet = "Medal3Dpt";


  private void Start()
   {
    IniSoal();
    Musuh.nyawa = 3;
    Pemain.nyawa = 1;
    //test level locked
    tampilanIndex = SceneManager.GetActiveScene ().buildIndex;
    levelPassed = PlayerPrefs.GetInt ("LevelPassed");
    //MANGGIL MEDALI DAH JALAN
    int Dptmedali = PlayerPrefs.GetInt(medaliYangDidapet);
    PlayerPrefs.SetInt(medaliYangDidapet,1);
   }

   //LIST PERTANYAAN
   [System.Serializable]
public class SOAL
{
    [TextArea]
    public string pertanyaan;

    public string opsiA, opsiB, opsiC, opsiD;

    public int jawaban;
}
private int acak;
public List<SOAL> DaftarSoal;

   void IniSoal()
   {
    
    acak = Random.Range(0, DaftarSoal.Count);
    pertanyaan.text = DaftarSoal[acak].pertanyaan;

    opsiA.text = DaftarSoal[acak].opsiA;
    opsiB.text = DaftarSoal[acak].opsiB;
    opsiC.text = DaftarSoal[acak].opsiC;
    opsiD.text = DaftarSoal[acak].opsiD;
   }

   public void ButtonJawaban(int n)
   {
    if(n == DaftarSoal[acak].jawaban)
    {
        HasilJawab(true);
    } else
    {
        HasilJawab(false);
    }
   }

   void HasilJawab(bool benar)
   {
    if (benar)
    {
           Musuh.nyawa -= 1;
           DaftarSoal.RemoveAt(acak);
    } else 
    {
           Pemain.nyawa -= 1;
           DaftarSoal.RemoveAt(acak);
    }

    Status();
   }

   private void Status()
   {
    if (Musuh.nyawa == 0)
    {
        MenangLayar.gameObject.SetActive (true);
        //LOCKED LEVEL SYSTEM
        if (levelPassed < tampilanIndex)
        {
            PlayerPrefs.SetInt("LevelPassed", tampilanIndex);
        }
    } else
    {
        Menang();
    }
   }

   private void Menang()
   {
    if (Pemain.nyawa == 0)
    {
        KalahLayar.gameObject.SetActive (true);
    } else
    {
        IniSoal();
    }
   }
}
