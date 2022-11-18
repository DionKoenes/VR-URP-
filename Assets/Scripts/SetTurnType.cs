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

/*    [SerializeField] private XRDirectInteractor directGrabLeft;
    [SerializeField] private XRDirectInteractor directGrabRight;
    [SerializeField] private XRRayInteractor rayGrabLeft;
    [SerializeField] private XRRayInteractor rayGrabRight;*/


    public void Start()
    {

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
            continuousMove.enabled = true;
            teleport.enabled = false;
            teleportRayActivate.enabled = false;
        }
        else if (index == 1)
        {
            continuousMove.enabled = false;
            teleport.enabled = true;
            teleportRayActivate.enabled = true;
        }
    }

    /*public void SetTypeFromIndexGrab(int index)
    {
        if (index == 0)
        {
            rayGrabLeft.enabled = true;
            rayGrabRight.enabled = true;
            directGrabLeft.enabled = false;
            directGrabRight.enabled = false;
        }
        else if (index == 1)
        {
            rayGrabLeft.enabled = false;
            rayGrabRight.enabled = false;
            directGrabLeft.enabled = true;
            directGrabRight.enabled = true;
        }
    }*/
}
