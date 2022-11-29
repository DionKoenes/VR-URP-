using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectricalCircuit : MonoBehaviour
{
    [SerializeField] private GameObject Battery;
    [SerializeField] private GameObject Switch;
    [SerializeField] private GameObject Lamp;

    
    [SerializeField] private Collider switchMin;

    


    // Start is called before the first frame update
    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider switchMin)
    {
        if (switchMin.CompareTag("BrownAnchor"))
        {
            Debug.Log("connected");
        }
        if (switchMin.CompareTag("BrownAnchor"))
        {
            Debug.Log("connected");
        }
    }

    /* volt op batterij, wanneer anchorbrown in contact komt met batterijplus zet kabel volt op 5 bijv. 
    Wanneer deze andere achor in contact komt met knop negatief. 
    Dan pas kan de knop de andere lamp aan doen wanneer deze ook aan de lamp zit met een zwarte kabel*/
}
