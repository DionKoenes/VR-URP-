using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositiveDetection : MonoBehaviour
{
    [SerializeField] private GameObject posBrown;


    [SerializeField] public bool power2;

    // Start is called before the first frame update
    void Start()
    {
        power2 = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == posBrown)
        {
            Debug.Log("Good Connection 1");
            power2 = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == posBrown)
        {
            Debug.Log("Good Connection 1");
            power2 = false;
        }
    }
}
