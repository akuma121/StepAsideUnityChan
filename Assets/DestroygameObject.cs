using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroygameObject : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "DestroyWellTag")
        {
            Destroy(this.gameObject);
        }
        
    }
}
