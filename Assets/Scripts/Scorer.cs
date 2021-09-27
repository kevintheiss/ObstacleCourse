using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int numHits = 0;

    private void OnCollisionEnter(Collision collision)
    {
        numHits++;
        Debug.Log("You've hit the wall this many times: " + numHits);       
    }
}
