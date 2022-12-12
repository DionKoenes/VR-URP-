using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    public Material lens;

    private Light _light;
    private AudioSource _audioSource;
    private bool lighton;

    void Start()
    {
        _light = GetComponentInChildren<Light>();
        _audioSource = GetComponent<AudioSource>();
        lighton = false;
    }
    public void ToggleLight()
    {
        if(!lighton)
        {
            _audioSource.Play();
            lens.EnableKeyword("_EMISSION");
            _light.enabled = true;
            lighton = true;
        }
        else if(lighton)
        {
            _audioSource.Play();
            lens.DisableKeyword("_EMISSION");
            _light.enabled = false;
            lighton = false;
        }
    }
}
