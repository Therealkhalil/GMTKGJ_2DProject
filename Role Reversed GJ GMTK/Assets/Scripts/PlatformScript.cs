using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformScript : MonoBehaviour
{
    [SerializeField] private float speed;
    public int PlatformNumber;
     public int Nextplat = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(PlatformNumber == Nextplat)
        {
        transform.Translate(new Vector2(0f,Input.GetAxis("Vertical") * speed) * Time.deltaTime);
            Debug.Log(Nextplat);
        }
        
    }
}
