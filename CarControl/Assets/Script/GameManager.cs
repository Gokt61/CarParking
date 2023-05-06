using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Araba;

    [Header("------PLATFORM AYARLARI")]
    public GameObject Platform_1;
    public GameObject Platform_2;

    public float[] DonusHizlari;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            Araba.GetComponent<Araba>().ilerle = true;
        }

        Platform_1.transform.Rotate(new Vector3(0, 0, DonusHizlari[0]),Space.Self);
    }
}
