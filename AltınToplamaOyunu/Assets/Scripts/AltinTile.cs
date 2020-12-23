using System;
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
        if (other.transform.gameObject.name == this.transform.gameObject.name)
        {
            
            Debug.Log("silinen" + other.gameObject.name);


            Vector3 silinecekVektör = new Vector3(other.gameObject.transform.position.x, other.gameObject.transform.position.y, 0);
            MainScript.altinVektör.Remove(silinecekVektör);
            if (this.altinMiktari == 5)
            {
                Destroy(other.gameObject);
                Debug.Log("altinoluşturdu");
                MainScript.altinVektör5.Remove(silinecekVektör);
                MainScript._instance.TekrarOlustur5();
            }
            else if (this.altinMiktari == 10)
            {
                Destroy(other.gameObject);
                Debug.Log("altinoluşturdu");
                MainScript.altinVektör10.Remove(silinecekVektör);
                MainScript._instance.TekrarOlustur10();
            }
            else if(this.altinMiktari==20)
            {
                Destroy(other.gameObject);
                Debug.Log("altinoluşturuldu");
                MainScript.gizliAltinVektör.Remove(silinecekVektör);
                MainScript._instance.TekrarOlusturGizli();
            }
           
        }
      
        if (other.CompareTag("oyuncu"))
        {
            Vector3 silinecekVektör = new Vector3(other.gameObject.transform.position.x, other.gameObject.transform.position.y, 0);
           // MainScript._instance.altinTiles[Convert.ToInt32(silinecekVektör.x), Convert.ToInt32(silinecekVektör.y)] = null;
            if (this.altinMiktari == 5)
            {
                MainScript.altinVektör5.Remove(silinecekVektör);
            }
            else if (this.altinMiktari == 10)
            {
                MainScript.altinVektör10.Remove(silinecekVektör);

            }
            else if (this.AltinMiktari == 20)
            {
                MainScript.açılanVektör.Remove(silinecekVektör);
                MainScript.altinVektör.Remove(silinecekVektör);
            }

            Debug.Log("asdfas" + other.transform.gameObject.name);
            Destroy(this.gameObject);
            Debug.Log("bbbbb" + this.gameObject.name);
        }

    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("oyuncu"))
        {
            if (this.gizliMi == true)
            {
                try
                {
                    this.GetComponent<SpriteRenderer>().enabled = true;
                    Vector3 vektör = new Vector3(this.transform.position.x, this.transform.position.y, 0);
                    MainScript.açılanVektör.Add(vektör);
                    MainScript.altinVektör.Add(vektör);
                    MainScript.gizliAltinVektör.Remove(vektör);

                }
                catch
                {

                }
            }

        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
