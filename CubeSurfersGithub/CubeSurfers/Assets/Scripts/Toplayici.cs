using Unity.VisualScripting;
using UnityEngine;

public class Toplayici : MonoBehaviour
{
    GameObject AnaKup;
    int Yukseklik;
    void Start()
    {
        AnaKup = GameObject.Find("Kup");
    }

    void Update()
    {
        AnaKup.transform.position = new Vector3 (transform.position.x,Yukseklik + 1 ,transform.position.z);
        this.transform.localPosition = new Vector3(0, -Yukseklik, 0);
    }
    public void YukseklikAzalt()
    {
        Yukseklik--;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Topla"&& other.gameObject.GetComponent<ToplanabilirKup>().GetToplandiMi()== false)
        {
            Yukseklik += 1;
            other.gameObject.GetComponent<ToplanabilirKup>().ToplandiYap();
            other.gameObject.GetComponent<ToplanabilirKup>().IndexAyarla(Yukseklik);
            other.gameObject.transform.parent = AnaKup.transform;
        }
    }
    
}
