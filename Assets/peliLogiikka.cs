using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class peliLogiikka : MonoBehaviour {
    [SerializeField] Text tekstiKenttä;
    [SerializeField] Tila alku;
    void Start () {
        tekstiKenttä.text = alku.maintext;
        Debug.Log("Peli alkoi"); }
	void Update () {
		if( Input.GetKeyDown("1") ) {
            tekstiKenttä.text = "Menit huoneeseen 1";        }
        if( Input.GetKeyDown("2")) {
            tekstiKenttä.text = "Menit huoneeseen 2"; }
        if (Input.GetKeyDown("3")) {
            tekstiKenttä.text = "Menit huoneeseen 3"; }
    }
}
