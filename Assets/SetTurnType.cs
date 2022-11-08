using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SetTurnType : MonoBehaviour
{
    [SerializeField] private ActionBasedSnapTurnProvider snapTurn;
    [SerializeField] private ActionBasedContinuousTurnProvider continuousTurn;

    [SerializeField] private TeleportationProvider teleport;
    [SerializeField] private ActivateTeleportationRay teleportRayActivate;
    [SerializeField] private ActionBasedContinuousMoveProvider continuousMove;

    public void Start()
    {
        snapTurn = GameObject.Find("Locomotion System").GetComponent<ActionBasedSnapTurnProvider>();
        continuousTurn = GameObject.Find("Locomotion System").GetComponent<ActionBasedContinuousTurnProvider>();

        teleport = GameObject.Find("Locomotion System").GetComponent<TeleportationProvider>();
        teleportRayActivate = GameObject.Find("Locomotion System").GetComponent<ActivateTeleportationRay>();
        continuousMove = GameObject.Find("Locomotion System").GetComponent<ActionBasedContinuousMoveProvider>();
    }

    public void SetTypeFromIndexTurn(int index)
    {
        if(index == 0)
        {
            snapTurn.enabled = false;
            continuousTurn.enabled = true;
        }
        else if(index == 1)
        {
            snapTurn.enabled = true;
            continuousTurn.enabled = false;
        }
    }

    public void SetTypeFromIndexMove(int index)
    {
        if (index == 0)
        {
            teleport.enabled = false;
            teleportRayActivate.enabled = false;
            continuousMove.enabled = true;
        }
        else if (index == 1)
        {
            continuousMove.enabled = false;
            teleport.enabled = true;
            teleportRayActivate.enabled = true;
        }
    }
}
