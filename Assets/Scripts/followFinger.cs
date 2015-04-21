using UnityEngine;
using System.Collections;

public class followFinger : MonoBehaviour {
	void Update () {
        if (Input.touchCount > 0) {
            // No queremos que reaccione al resto de pulsaciones
            if (Input.GetTouch(0).fingerId == 0) {
                if (Input.GetTouch(0).phase.Equals(TouchPhase.Stationary)) {
                    Vector3 pos = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
                    // Se dibuja lo más cerca de la camára posible
                    transform.position = new Vector3(pos.x, pos.y, Camera.main.transform.position.z + Camera.main.nearClipPlane);
                }
                else if (Input.GetTouch(0).phase.Equals(TouchPhase.Ended)) {
                    EventsManager.RaisePlantIsFreeEvent(gameObject);
                }
            }
        }
	}
}
