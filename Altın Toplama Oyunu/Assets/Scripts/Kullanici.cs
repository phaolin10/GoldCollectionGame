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
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("altın"))
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
