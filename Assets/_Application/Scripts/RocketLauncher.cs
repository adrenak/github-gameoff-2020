using UnityEngine;

public class RocketLauncher : MonoBehaviour {
    [SerializeField] GameObject rocket;
    [SerializeField] Transform muzzle;

    private void Update() {
        if (Input.GetMouseButtonDown(1))
            Fire();
    }

    void Fire(){
        var instance = Instantiate(rocket);
        instance.transform.position = muzzle.position;
        instance.transform.rotation = muzzle.rotation;
    }
}
