using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Musuh : MonoBehaviour
{
    public GameObject hati1, hati2, hati3;
    public static int nyawa;
    // Start is called before the first frame update
    void Start()
    {
        hati1.gameObject.SetActive (true);
        hati2.gameObject.SetActive (true);
        hati3.gameObject.SetActive (true);
    }

    // Update is called once per frame
    void Update()
    {
        if (nyawa >3)
        nyawa = 3;
        switch (nyawa)
        {
            case 3:
                hati1.gameObject.SetActive (true);
                hati2.gameObject.SetActive (true);
                hati3.gameObject.SetActive (true);
                break;
            case 2:
                hati1.gameObject.SetActive (true);
                hati2.gameObject.SetActive (true);
                hati3.gameObject.SetActive (false);
                break;
            case 1:
                hati1.gameObject.SetActive (true);
                hati2.gameObject.SetActive (false);
                hati3.gameObject.SetActive (false);
                break;
            case 0:
                hati1.gameObject.SetActive (false);
                hati2.gameObject.SetActive (false);
                hati3.gameObject.SetActive (false);
                break;
        }
    }
}
