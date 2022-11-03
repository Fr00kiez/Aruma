using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SistemMedali : MonoBehaviour
{
    public GameObject medali1B, medali2B, medali1J, medali2J;
   int dptmedal1B, dptmedal2B, dptmedal1J, dptmedal2J;

   void Start()
   {
    dptmedal1B = PlayerPrefs.GetInt ("Medal1Dpt");
    dptmedal2B = PlayerPrefs.GetInt ("Medal2Dpt");
    dptmedal1J = PlayerPrefs.GetInt ("Medal3Dpt");
    dptmedal2J = PlayerPrefs.GetInt ("Medal4Dpt");

    if (dptmedal1B == 1)
    medali1B.SetActive(true);
    else
    medali1B.SetActive(false);

    if (dptmedal2B == 1)
    medali2B.SetActive(true);
    else
    medali2B.SetActive(false);

    if (dptmedal1J == 1)
    medali1J.SetActive(true);
    else
    medali1J.SetActive(false);

    if (dptmedal2J == 1)
    medali2J.SetActive(true);
    else
    medali2J.SetActive(false);
   }
}
