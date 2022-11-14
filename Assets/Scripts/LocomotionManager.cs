using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class LocomotionManager : MonoBehaviour
{
    [SerializeField] private GameObject leftRayTeleport;
    [SerializeField] private GameObject rightRayTeleport;

    [SerializeField] private TeleportationProvider teleportationProvider;
    [SerializeField] private ContinuousMoveProviderBase continuousMoveProvider;

    // Start is called before the first frame update
    void Start()
    {
        teleportationProvider = GetComponent<TeleportationProvider>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
