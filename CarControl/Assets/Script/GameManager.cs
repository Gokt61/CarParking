using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    [Header("------ARABA AYARLARI-----")]
    public GameObject[] Arabalar;
    public GameObject[] ArabaCanvasGorselleri;
    public Sprite AracGeldiGorseli;
    public GameObject DurusNoktasi;
    public int KacArabaOlsun;
    int KalanAracSayisiDegeri;
    int AktifAracIndex = 0;
    public TextMeshProUGUI KalanAracSayisi;

    [Header("------PLATFORM AYARLARI")]
    public GameObject Platform_1;
    public GameObject Platform_2;

    public float[] DonusHizlari;

    void Start()
    {
        /*KalanAracSayisiDegeri = KacArabaOlsun;
        KalanAracSayisi.text = KalanAracSayisiDegeri.ToString();

        for (int i = 0; i < KacArabaOlsun; i++)
        {
            ArabaCanvasGorselleri[i].SetActive(true);
        }*/
    }

    public void YeniArabaGetir()
    {
        DurusNoktasi.SetActive(true);
        if (AktifAracIndex < KacArabaOlsun)
        {
            Arabalar[AktifAracIndex].SetActive(true);
        }
        /*ArabaCanvasGorselleri[AktifAracIndex-1].GetComponent<Image>().sprite = AracGeldiGorseli;
        KalanAracSayisiDegeri--;
        KalanAracSayisi.text = KalanAracSayisiDegeri.ToString();
        */
    }

    //public void YeniArabaGetirBasarisiz()
    //{
    //    DurusNoktasi.SetActive(true);
    //    if (AktifAracIndex < KacArabaOlsun)
    //    {
    //        Arabalar[AktifAracIndex].SetActive(true);
    //    }
    //}

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
