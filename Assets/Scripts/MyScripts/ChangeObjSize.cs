using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeObjSize : MonoBehaviour
{
    public float shrinkFactor;
    private bool needToChangeSize = true;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball") && needToChangeSize)
        {
            collision.gameObject.transform.localScale *= shrinkFactor;
            needToChangeSize = false;
        }
    }
}

