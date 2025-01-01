using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject Hedef;
    public Vector3 mesafe;
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    private void LateUpdate()
    {
       this.transform.position = Vector3.Lerp(this.transform.position,Hedef.transform.position + mesafe, Time.deltaTime);
    }
}
