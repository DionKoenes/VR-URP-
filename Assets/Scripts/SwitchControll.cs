using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchControll : MonoBehaviour
{
    //Sound
    private AudioSource source;
    [SerializeField] private AudioClip switchSound;

    private bool on = false;
    [SerializeField] private bool switchHit = false;

    private float switchRotation = 180;
    [SerializeField] private GameObject switchBase;

    [SerializeField] private GameObject spotLight;

    [SerializeField] private ElectricalCircuit electricalCircuit;

    void Start()
    {
        source = gameObject.AddComponent<AudioSource>();
        //turn off spotlight
        spotLight.SetActive(false);
    }

    void Update()
    {
        if (switchHit && electricalCircuit.power == true)
        {
            //PlaySound
            source.PlayOneShot(switchSound);
            switchHit = false;
            //if on is true, make on false. And if on is false, make on true.
            on = !on;

            if (on == true)
            {
                spotLight.SetActive(true);
                transform.rotation = Quaternion.Euler(transform.eulerAngles.x + switchRotation, transform.eulerAngles.y, transform.eulerAngles.z);
            }
            else
            {
                spotLight.SetActive(false);
                transform.rotation = Quaternion.Euler(transform.eulerAngles.x - switchRotation, transform.eulerAngles.y, transform.eulerAngles.z);
            }
        }
        else if (switchHit == true)
        {
            //PlaySound
            source.PlayOneShot(switchSound);
            switchHit = false;
            //if on is true, make on false. And if on is false, make on true.
            on = !on;

            if (on == true)
            {
                transform.rotation = Quaternion.Euler(transform.eulerAngles.x + switchRotation, transform.eulerAngles.y, transform.eulerAngles.z);
            }
            else
            {
                transform.rotation = Quaternion.Euler(transform.eulerAngles.x - switchRotation, transform.eulerAngles.y, transform.eulerAngles.z);
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Left Hand") || other.CompareTag("Right Hand"))
        {
            switchHit = true;
        }
    }
}

