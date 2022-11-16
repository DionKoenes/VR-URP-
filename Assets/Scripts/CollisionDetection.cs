using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    [SerializeField] private GameObject PictureSolution;
    [SerializeField] private GameObject PictureQuestion;
    [SerializeField] private GameObject Solution1;

    [SerializeField] private Renderer SolutionTable;
    [SerializeField] private Material Red;
    [SerializeField] private Material Green;

    private bool activated = false;

    private void Start()
    {

    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Object has entered");

        if (other.gameObject == Solution1 && !activated)
        {
            SolutionTable.material = Green;
            activated = true;
            PictureSolution.SetActive(true);
            PictureQuestion.SetActive(false);
        }
    }


    private void OnTriggerExit(Collider other)
    {
        Debug.Log("OnTriggerExit Event");

        if (other.gameObject == Solution1 && activated)
        {
            SolutionTable.material = Red;
            activated = false;
            PictureSolution.SetActive(false);
            PictureQuestion.SetActive(true);
        }
    }
}


