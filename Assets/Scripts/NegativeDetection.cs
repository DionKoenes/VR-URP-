using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NegativeDetection : MonoBehaviour
{
    [SerializeField] private GameObject negBrown;


    [SerializeField] public bool power1;

    // Start is called before the first frame update
    void Start()
    {
        power1 = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == negBrown)
        {
            Debug.Log("Good Connection 1");
            power1 = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == negBrown)
        {
            Debug.Log("Good Connection 1");
            power1 = false;
        }
    }
}
