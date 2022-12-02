using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosBlackDetection : MonoBehaviour
{
    [SerializeField] private GameObject posBlack;
    [SerializeField] private GameObject negBlack;

    [SerializeField] public bool powerBlack2;

    // Start is called before the first frame update
    void Start()
    {
        powerBlack2 = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == posBlack || other.gameObject == negBlack)
        {
            Debug.Log("Good Connection 1");
            powerBlack2 = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == posBlack || other.gameObject == negBlack)
        {
            Debug.Log("Good Connection 1");
            powerBlack2 = false;
        }
    }
}
