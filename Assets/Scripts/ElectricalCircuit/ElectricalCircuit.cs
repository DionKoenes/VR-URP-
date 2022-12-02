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

    [SerializeField] private NegBrownDetection negBrownDetect;
    [SerializeField] private PosBrownDetection posBrownDetect;
    [SerializeField] private NegBlackDetection negBlackDetect;
    [SerializeField] private PosBlackDetection posBlackDetect;
    [SerializeField] private NegBlueDetection negBlueDetect;
    [SerializeField] private PosBlueDetection posBlueDetect;

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
        if (negBrownDetect.powerBrown1 && posBrownDetect.powerBrown2 && negBlackDetect.powerBlack1 && posBlackDetect.powerBlack2 && negBlueDetect.powerBlue1 && posBlueDetect.powerBlue2)
        {
            power = true;
        }
        else
        {
            power = false;
        }
    }
}
