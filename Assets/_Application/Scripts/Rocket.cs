using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using FLFlight;

public class Rocket : MonoBehaviour {
    public  float speed;
    public GameObject explosion;

    void Update() {
        transform.Translate(0, 0, speed * Time.deltaTime * Time.timeScale);
    }

    void OnCollisionEnter(Collision collision) {
        var instance = Instantiate(explosion);
        instance.transform.position = transform.position;
        Destroy(gameObject);
    }
}
