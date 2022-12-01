using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ElectricalCircuit : MonoBehaviour
{
    [SerializeField] private GameObject BrownAnchor1;
    [SerializeField] private GameObject BrownAnchor2;

/*    [SerializeField] private Collider switchNegCol;
    [SerializeField] private Collider batteryPositiveCol;*/
    
    [SerializeField] public bool power;

    [SerializeField] private NegativeDetection negDetect;
    [SerializeField] private PositiveDetection posDetect;

    // Start is called before the first frame update
    void Start()
    {
        power = false;
    }

    // Update is called once per frame
    void Update()
    {
        Power();
    }

    private void Power()
    {
        if (negDetect.power1 && posDetect.power2)
        {
            power = true;
        }
        else
        {
            power = false;
        }
    }
}
