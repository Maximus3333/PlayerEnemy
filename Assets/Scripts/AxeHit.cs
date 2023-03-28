using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeHit : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Enemy")
            Destroy(other.gameObject);
    }
}
