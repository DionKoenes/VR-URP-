using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NegBrownDetection : MonoBehaviour
{
    [SerializeField] private GameObject negBrown;
    [SerializeField] private GameObject posBrown;

    [SerializeField] public bool powerBrown1;

    // Start is called before the first frame update
    void Start()
    {
        powerBrown1 = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == negBrown || other.gameObject == posBrown)
        {
            Debug.Log("Good Connection 1");
            powerBrown1 = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == negBrown || other.gameObject == posBrown)
        {
            Debug.Log("Good Connection 1");
            powerBrown1 = false;
        }
    }
}
