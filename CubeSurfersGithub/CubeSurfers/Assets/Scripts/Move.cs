using UnityEngine;

public class Move : MonoBehaviour
{ 
    public float ileriGitmeHizi;   
    public float sagaSolaGitmeHizi;

    void Start()
    {
        
    }

    void Update()
    {
        float yatayeksen = Input.GetAxis("Horizontal") * sagaSolaGitmeHizi * Time.deltaTime;
        this.transform.Translate(yatayeksen ,0, ileriGitmeHizi * Time.deltaTime);
    }
}
