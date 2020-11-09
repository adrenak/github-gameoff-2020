using UnityEngine;

namespace FLFlight.UI {
    public class BoresightCrosshair : MonoBehaviour {
        public Transform ship;
        public float boresightDistance = 1000f;

        void Update() {
            if (ship != null) {
                Vector2 active = new Vector2(Screen.width, Screen.height);
                Vector2 target = new Vector2(Camera.main.targetTexture.width, Camera.main.targetTexture.height);
                Vector3 boresightPos = (ship.transform.forward * boresightDistance) + ship.transform.position;
                Vector3 screenPos = Camera.main.WorldToScreenPoint(boresightPos);
                var nPos = new Vector2(
                    screenPos.x / target.x,
                    screenPos.y / target.y
                );

                screenPos.z = 0f;

                transform.position = new Vector3(
                    nPos.x * active.x,
                    nPos.y * active.y,
                    0
                );
            }
        }
    }
}
