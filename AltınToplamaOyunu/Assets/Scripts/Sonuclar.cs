using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sonuclar : MonoBehaviour
{
    // Start is called before the first frame update
    public static string morKasaAltin1 = MainScript.morKasaAltin.ToString();
    public static string kirmiziKasaAltin1 = MainScript.kirmiziKasaAltin.ToString();
    public static string maviKasaAltin1 = MainScript.maviKasaAltin.ToString();
    public static string yesilKasaAltin1 = MainScript.yesilKasaAltin.ToString();

    public static string kirmiziHarcanan1 = MainScript.kirmiziHarcanan.ToString();
    public static string maviHarcanan1 = MainScript.maviHarcanan.ToString();
    public static string yesilHarcanan1 = MainScript.yesilHarcanan.ToString();
    public static string morHarcanan1 = MainScript.morHarcanan.ToString();

    public static string kirmiziToplanan1 = MainScript.kirmiziToplanan.ToString();
    public static string maviToplanan1 = MainScript.maviToplanan.ToString();
    public static string yesilToplanan1 = MainScript.yesilToplanan.ToString();
    public static string morToplanan1 = MainScript.morToplanan.ToString();

    public static string kirmiziAdim1 = MainScript.kirmiziAdim.ToString();
    public static string maviAdim1 = MainScript.maviAdim.ToString();
    public static string yesilAdim1 = MainScript.yesilAdim.ToString();
    public static string morAdim1 = MainScript.morAdim.ToString();
    void Start()
    {
        Text txt = GameObject.Find("Canvas/kasadakiK").GetComponent<Text>();
        txt.text = kirmiziKasaAltin1;
        Text txt1 = GameObject.Find("Canvas/kasadakiMo").GetComponent<Text>();
        txt1.text = morKasaAltin1;
        Text txt2 = GameObject.Find("Canvas/kasadakiMa").GetComponent<Text>();
        txt2.text = maviKasaAltin1;
        Text txt3 = GameObject.Find("Canvas/kasadakiY").GetComponent<Text>();
        txt3.text = yesilKasaAltin1;

        Text txt4 = GameObject.Find("Canvas/harcananK").GetComponent<Text>();
        txt4.text = kirmiziHarcanan1;
        Text txt5 = GameObject.Find("Canvas/harcananMa").GetComponent<Text>();
        txt5.text = maviHarcanan1;
        Text txt6 = GameObject.Find("Canvas/harcananY").GetComponent<Text>();
        txt6.text = yesilHarcanan1;
        Text txt7 = GameObject.Find("Canvas/harcananMo").GetComponent<Text>();
        txt7.text = morHarcanan1;

        Text txt8 = GameObject.Find("Canvas/toplananK").GetComponent<Text>();
        txt8.text = kirmiziToplanan1;
        Text txt9 = GameObject.Find("Canvas/toplananMa").GetComponent<Text>();
        txt9.text = maviToplanan1;
        Text txt10 = GameObject.Find("Canvas/toplananY").GetComponent<Text>();
        txt10.text = yesilToplanan1;
        Text txt11 = GameObject.Find("Canvas/toplananMo").GetComponent<Text>();
        txt11.text = morToplanan1;

        Text txt12 = GameObject.Find("Canvas/adimK").GetComponent<Text>();
        txt12.text = kirmiziAdim1;
        Text txt13 = GameObject.Find("Canvas/adimMa").GetComponent<Text>();
        txt13.text = maviAdim1;
        Text txt14 = GameObject.Find("Canvas/adimY").GetComponent<Text>();
        txt14.text = yesilAdim1;
        Text txt15 = GameObject.Find("Canvas/adimMo").GetComponent<Text>();
        txt15.text = morAdim1;
    }

  
}
