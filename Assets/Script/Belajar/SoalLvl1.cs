using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "soal")]
public class SoalLvl1 : ScriptableObject
{
    public string pertanyaan;

    public string opsiA, opsiB, opsiC, opsiD;

    public int jawaban;
}
