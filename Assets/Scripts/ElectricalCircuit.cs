using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ElectricalCircuit : MonoBehaviour
{
    [SerializeField] private GameObject BrownAnchor1;
    [SerializeField] private GameObject BrownAnchor2;

    [SerializeField] private Collider switchNegCol;
    
    [SerializeField] public bool power;

    // Start is called before the first frame update
    void Start()
    {
        power = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("BrownAnchor"))
        {
            Debug.Log("Good Connection");
            power = true;
        }
        else if (other.CompareTag("BlueAnchor"))
        {
            Debug.Log("Bad Connection");
        }
        else if (other.CompareTag("BlackAnchor"))
        {
            Debug.Log("Bad Connection");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("BrownAnchor"))
        {
            power = false;
        }
    }
}
