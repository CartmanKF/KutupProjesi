using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class kutupayisisoru : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D coll)
    {
        Debug.Log("içine girdi");
        PlayerMovement pm = coll.gameObject.GetComponent<PlayerMovement>();
        if(pm !=null)
        {
            pm.Durdur();
        }
    }
}
