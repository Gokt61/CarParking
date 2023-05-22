using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Araba : MonoBehaviour
{
    public bool ilerle;
    bool DurusNoktasiDurumu = false;

    public GameObject[] Tekerizleri;
    public Transform parent;
    public GameManager _GameManager;

    void Start()
    {
        
    }

    void Update()
    {
        if (!DurusNoktasiDurumu)
        {
            transform.Translate(6f * Time.deltaTime * transform.forward);
        }
        if (ilerle)
        {
            transform.Translate(15f * Time.deltaTime * transform.forward);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("DurusNoktasi"))
        {
            DurusNoktasiDurumu = true;
            _GameManager.DurusNoktasi.SetActive(false);

        }
        else if (collision.gameObject.CompareTag("Parking"))
        {
            ilerle = false;
            Tekerizleri[0].SetActive(false);
            Tekerizleri[1].SetActive(false);
            transform.SetParent(parent);
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;

            _GameManager.YeniArabaGetir();
        }
        else if (collision.gameObject.CompareTag("OrtaGobek"))
        {
            Destroy(gameObject);
            //_GameManager.YeniArabaGetir();
            _GameManager.Kaybettin();
        }
        else if (collision.gameObject.CompareTag("Araba"))
        {
            Destroy(gameObject);
            //_GameManager.YeniArabaGetir();
            _GameManager.Kaybettin();
        }
        else if (collision.gameObject.CompareTag("Elmas"))
        {
            collision.gameObject.SetActive(false);
            _GameManager.ElmasSayisi++;
        }
    }
}