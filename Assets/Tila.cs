using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Luo uusi tila")]
public class Tila : ScriptableObject {
    [TextArea(15, 20)] [SerializeField]
    public string maintext;
    [SerializeField] public Tila[] 
        siirtymäTilat;
    public int[] esimLuku = { 100, 200, 300 };
}
