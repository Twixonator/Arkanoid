using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ball : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D obj)
    {
       if (obj.gameObject.CompareTag("Block"))
        {
            Destroy(obj.gameObject);
        }
    }
}
