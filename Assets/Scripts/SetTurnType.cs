using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.XR.Interaction.Toolkit;

public class SetTurnType : MonoBehaviour
{
    [SerializeField] private ActionBasedSnapTurnProvider snapTurn;
    [SerializeField] private ActionBasedContinuousTurnProvider continuousTurn;

    [SerializeField] private TeleportationProvider teleport;
    [SerializeField] private ActivateTeleportationRay teleportRayActivate;
    [SerializeField] private ActionBasedContinuousMoveProvider continuousMove;


    [SerializeField] private Material dayMat;
    [SerializeField] private Material nightMat;
    [SerializeField] private Light sunmoon;

    public void Start()
    {
        
    }

    public void SetTypeFromIndexTurn(int index)
    {
        if (index == 0)
        {
            snapTurn.enabled = false;
            continuousTurn.enabled = true;
        }
        else if (index == 1)
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
    public void SetTypeFromIndexTime(int index)
    {
        if (index == 0)
        {
            RenderSettings.skybox = dayMat;
            sunmoon.color = Color.white;
        }
        else if (index == 1)
        {
            RenderSettings.skybox = nightMat;
            sunmoon.color = Color.cyan;
        }
    }
}

