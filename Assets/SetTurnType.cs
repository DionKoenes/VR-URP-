using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SetTurnType : MonoBehaviour
{
    [SerializeField] private ActionBasedSnapTurnProvider snapTurn;
    [SerializeField] private ActionBasedContinuousTurnProvider continuousTurn;

    [SerializeField] private TeleportationProvider teleport;
    [SerializeField] private ActionBasedContinuousMoveProvider continuousMove;

    public void Start()
    {
        GameObject.Find("XR Origin");
        teleport = GetComponent<TeleportationProvider>();
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
            continuousMove.enabled = true;
        }
        else if (index == 1)
        {
            teleport.enabled = true;
            continuousTurn.enabled = false;
        }
    }
}
