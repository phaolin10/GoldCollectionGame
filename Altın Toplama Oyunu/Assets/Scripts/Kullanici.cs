using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class Kullanici : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {



    }

    private int altinMiktari;
    private Vector3 konumVektörü;
    private Vector3 hedef;
    private int harcananAltin;
    private int toplananAltin;
    private string adım;

    public Kullanici(Vector3 kullaniciVektör)
    {
        this.altinMiktari = 200;
        this.KonumVektörü = kullaniciVektör;
    }
    public Vector3 KonumVektörü
    {
        get { return konumVektörü; }
        set { konumVektörü = value; }
    }
    public Vector3 GetKonumVektörü()
    {
        return this.konumVektörü;
    }
    public Vector3 Hedef
    {
        get { return hedef; }
        set { hedef = value; }
    }
    public Vector3 GetHedef()
    {
        return this.hedef;
    }
    public int AltinMiktari
    {
        get { return altinMiktari; }
        set { this.altinMiktari = value; }

    }
    public int GetAltinMiktari()
    {
        return this.altinMiktari;
    }
    public int ToplananAltin
    {
        get { return toplananAltin; }
        set { this.toplananAltin = value; }
    }
    public int GetToplananAltin()
    {
        return this.toplananAltin;
    }
    public int HarcananAltin
    {
        get { return harcananAltin; }
        set { this.harcananAltin = value; }
    }
    public int GetHarcananAltin()
    {
        return this.harcananAltin;
    }
     public string Adım
    {
        get { return adım; }
        set { this.adım = value; }
    }
    public string GetAdım()
    {
        return this.adım;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("altın"))
        {
            Destroy(collision.gameObject);
            Debug.Log("altınsildi" + collision.gameObject.name);
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
