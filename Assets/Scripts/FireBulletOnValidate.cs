using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class FireBulletOnValidate : MonoBehaviour
{
    public GameObject bullet;
    public Transform spawnPointBullet;
    public float fireSpeedBullet = 0;

    public GameObject casing;
    public Transform spawnPointCasing;
    public float fireSpeedCasing = 0;

    // Start is called before the first frame update
    void Start()
    {
        XRGrabInteractable grabbable = GetComponent<XRGrabInteractable>();
        grabbable.activated.AddListener(FireBullet);
        grabbable.activated.AddListener(FireCasing);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void FireBullet(ActivateEventArgs arg)
    {
        GameObject spawnBullet = Instantiate(bullet);
        spawnBullet.transform.position = spawnPointBullet.position;
        spawnBullet.GetComponent<Rigidbody>().velocity = spawnPointBullet.forward * fireSpeedBullet;
        Destroy(spawnBullet, 5);
    }
    public void FireCasing(ActivateEventArgs arg)
    {
        GameObject spawnCasing = Instantiate(casing);
        spawnCasing.transform.position = spawnPointCasing.position;
        spawnCasing.GetComponent<Rigidbody>().velocity = spawnPointCasing.right * fireSpeedCasing;
        Destroy(spawnCasing, 5);
    }
}
