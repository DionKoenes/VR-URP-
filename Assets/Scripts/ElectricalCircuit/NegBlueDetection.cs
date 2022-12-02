using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NegBlueDetection : MonoBehaviour
{
    [SerializeField] private GameObject negBlue;
    [SerializeField] private GameObject posBlue;

    [SerializeField] public bool powerBlue1;

    // Start is called before the first frame update
    void Start()
    {
        powerBlue1 = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == negBlue || other.gameObject == posBlue)
        {
            Debug.Log("Good Connection 1");
            powerBlue1 = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == negBlue || other.gameObject == posBlue)
        {
            Debug.Log("Good Connection 1");
            powerBlue1 = false;
        }
    }
}
