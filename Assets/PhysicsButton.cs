using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PhysicsButton : MonoBehaviour
{
    [SerializeField] private float threshold = 0.1f;
    [SerializeField] private float deadZone = 0.025f;
    
    [SerializeField] private AudioClip buttonSound;
    private AudioSource source;

    private bool isPressed;
    private Vector3 startPos;
    private ConfigurableJoint joint;

    private bool hasPlayed = false;

    [SerializeField] private GameObject spotLight;
    private bool lampIsOff = true;

    public UnityEvent onPressed, onReleased;

    // Start is called before the first frame update
    void Start()
    {
        source = gameObject.AddComponent<AudioSource>();
        startPos = transform.localPosition;
        joint = GetComponent<ConfigurableJoint>();
        spotLight = GameObject.Find("Spotlight").GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!isPressed && GetValue() + threshold >= 1)
            Pressed();
            ToggleLight();

        if (isPressed && GetValue() - threshold <= 0)
            Released();
    }

    private float GetValue()
    {
        var value = Vector3.Distance(startPos, transform.localPosition) / joint.linearLimit.limit;

        if (Mathf.Abs(value) < deadZone)
            value = 0;

        return Mathf.Clamp(value, -1f, 1f);
    }

    private void Pressed()
    {
        isPressed = true;
        onPressed.Invoke();
        Debug.Log("Pressed");
    }

    private void Released()
    {
        isPressed = false;
        onReleased.Invoke();
        Debug.Log("Released");
        hasPlayed = false;
    }

    private void ToggleLight()
    {
        if (!hasPlayed && isPressed && lampIsOff)
        {
            source.PlayOneShot(buttonSound);
            hasPlayed = true;
            spotLight.SetActive(true);
            lampIsOff = false;
        }
        else if (!hasPlayed && isPressed && !lampIsOff)
        {
            source.PlayOneShot(buttonSound);
            hasPlayed = true;
            spotLight.SetActive(false);
            lampIsOff = true;
        }
    }
}
