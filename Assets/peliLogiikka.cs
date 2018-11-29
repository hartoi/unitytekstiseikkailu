using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class peliLogiikka : MonoBehaviour
{
    [SerializeField] Text tekstiKenttä;
    [SerializeField] Tila alku;
    Tila nykyinen;
    void Start()
    {
        nykyinen = alku;
        tekstiKenttä.text = nykyinen.maintext;
        Debug.Log("Peli alkoi");
    }
    void Update()
    {
        if (Input.GetKeyDown("1")) {
            nykyinen = nykyinen.siirtymäTilat[0];
        }
        if (Input.GetKeyDown("2")) {
            nykyinen = nykyinen.siirtymäTilat[1];
        }
        if (Input.GetKeyDown("3")) {
            nykyinen = nykyinen.siirtymäTilat[2];
        }
        tekstiKenttä.text = nykyinen.maintext;
    }
}
