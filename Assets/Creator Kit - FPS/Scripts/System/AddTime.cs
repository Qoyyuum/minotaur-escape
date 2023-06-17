using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class AddTime : MonoBehaviour
{
    public float addToTime;
    
    void Reset()
    {
        gameObject.layer = LayerMask.NameToLayer("PlayerCollisionOnly");
        GetComponent<Collider>().isTrigger = true;
    }

    void OnTriggerEnter(Collider other)
    {
        Controller c = other.GetComponent<Controller>();

        if (c != null)
        {
            GameSystem.Instance.AddTimer(addToTime);
            Destroy(gameObject);
        }
    }
}
