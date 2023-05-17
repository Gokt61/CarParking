using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("------ARABA AYARLARI-----")]
    public GameObject[] Arabalar;
    public GameObject DurusNoktasi;
    public int KacArabaOlsun;
    int AktifAracIndex = 0;

    [Header("------PLATFORM AYARLARI")]
    public GameObject Platform_1;
    public GameObject Platform_2;

    public float[] DonusHizlari;

    void Start()
    {
        /*for (int i = 0; i < KacArabaOlsun; i++)
        {
        }*/

    }

    public void YeniArabaGetir()
    {
        DurusNoktasi.SetActive(true);
        if (AktifAracIndex < KacArabaOlsun)
        {
            Arabalar[AktifAracIndex].SetActive(true);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            Arabalar[AktifAracIndex].GetComponent<Araba>().ilerle = true;
            AktifAracIndex++;
        }

        Platform_1.transform.Rotate(new Vector3(0, 0, DonusHizlari[0]),Space.Self);
    }
}
