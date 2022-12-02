using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosBrownDetection : MonoBehaviour
{
    [SerializeField] private GameObject posBrown;
    [SerializeField] private GameObject negBrown;

    [SerializeField] public bool powerBrown2;

    // Start is called before the first frame update
    void Start()
    {
        powerBrown2 = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == posBrown || other.gameObject == negBrown)
        {
            Debug.Log("Good Connection 1");
            powerBrown2 = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == posBrown || other.gameObject == negBrown)
        {
            Debug.Log("Good Connection 1");
            powerBrown2 = false;
        }
    }
}
