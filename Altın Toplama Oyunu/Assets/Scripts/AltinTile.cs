using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class AltinTile : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    private int altinMiktari;
    private Vector3 konum;
    private Boolean gizliMi;

    public AltinTile(Vector3 konum, Boolean gizliMi, int altinMiktari)
    {
        this.konum = konum;
        this.gizliMi = gizliMi;
        this.altinMiktari = altinMiktari;
    }

    public Vector3 Konum
    {
        get { return konum; }
        set { konum = value; }
    }

    public Boolean GizliMi
    {
        get { return gizliMi; }
        set { gizliMi = value; }
    }
    public int AltinMiktari
    {
        get { return altinMiktari; }
        set { altinMiktari = value; }
    }
    public Vector3 GetKonum()
    {
        return this.konum;
    }
    public Boolean GetGizliMi()
    {
        return this.gizliMi;
    }
    public int GetAltinMiktari()
    {
        return this.altinMiktari;
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.gameObject.name == this.transform.gameObject.name && other.CompareTag("altın"))
        {

            Debug.Log("silinen" + other.gameObject.name);
            Destroy(other.gameObject);

            Vector3 silinecekVektör = new Vector3(other.gameObject.transform.position.x,other.gameObject.transform.position.y,0) ;
            MainScript.altinVektör.Remove(silinecekVektör);
            if (this.altinMiktari == 5)
            {
                MainScript._instance.TekrarOlustur5();
                Debug.Log("altinoluşturdu");
                MainScript.altinVektör5.Remove(silinecekVektör);
                MainScript._instance.altinTiles[Convert.ToInt32(silinecekVektör.x), Convert.ToInt32(silinecekVektör.y)] = null;
            }
            else if (this.altinMiktari == 10)
            {
                MainScript._instance.TekrarOlustur10();
                Debug.Log("altinoluşturdu");
                MainScript.altinVektör10.Remove(silinecekVektör);
                MainScript._instance.altinTiles[Convert.ToInt32(silinecekVektör.x),Convert.ToInt32( silinecekVektör.y)] = null;
            }

        }
        if (other.transform.gameObject.name == this.transform.gameObject.name && other.CompareTag("gizliAltin"))
        {

            Debug.Log("silinen" + other.gameObject.name);
            Destroy(other.gameObject);

            Vector3 silinecekVektör = new Vector3(other.gameObject.transform.position.x, other.gameObject.transform.position.y, 0);
            MainScript.altinVektör.Remove(silinecekVektör);
            if (this.altinMiktari == 5)
            {

                MainScript.altinVektör5.Remove(silinecekVektör);
                MainScript._instance.altinTiles[Convert.ToInt32(silinecekVektör.x), Convert.ToInt32(silinecekVektör.y)] = null;
            }
            else if (this.altinMiktari == 10)
            {
                MainScript.altinVektör10.Remove(silinecekVektör);
                MainScript._instance.altinTiles[Convert.ToInt32(silinecekVektör.x), Convert.ToInt32(silinecekVektör.y)] = null;
            }
            MainScript.calistiMi = true;

        }
        if (other.CompareTag("oyuncu"))
        {
            Debug.Log("asdfas" + other.transform.gameObject.name);
            Destroy(this.gameObject);
            Debug.Log("bbbbb" + this.gameObject.name);
            MainScript.altinKareSayisi--;
         //   MainScript.dene = false;
        }
      //  yield return new WaitForSeconds(3);

    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.CompareTag("oyuncu"))
        {
            this.gameObject.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
