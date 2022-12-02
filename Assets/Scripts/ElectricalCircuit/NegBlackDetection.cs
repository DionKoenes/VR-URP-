using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NegBlackDetection : MonoBehaviour
{
    [SerializeField] private GameObject negBlack;
    [SerializeField] private GameObject posBlack;

    [SerializeField] public bool powerBlack1;

    // Start is called before the first frame update
    void Start()
    {
        powerBlack1 = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == negBlack || other.gameObject == posBlack)
        {
            Debug.Log("Good Connection 1");
            powerBlack1 = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == negBlack || other.gameObject == posBlack)
        {
            Debug.Log("Good Connection 1");
            powerBlack1 = false;
        }
    }
}
