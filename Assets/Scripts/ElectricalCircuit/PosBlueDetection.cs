using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosBlueDetection : MonoBehaviour
{
    [SerializeField] private GameObject posBlue;
    [SerializeField] private GameObject negBlue;

    [SerializeField] public bool powerBlue2;

    // Start is called before the first frame update
    void Start()
    {
        powerBlue2 = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == posBlue || other.gameObject == negBlue)
        {
            Debug.Log("Good Connection 1");
            powerBlue2 = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == posBlue || other.gameObject == negBlue)
        {
            Debug.Log("Good Connection 1");
            powerBlue2 = false;
        }
    }
}
