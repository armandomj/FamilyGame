using System.Collections;
using UnityEngine;

public class InputManager : MonoBehaviour {
    private bool m_OnButton = false;
	void Update () {
        if (Input.touchCount > 0) {
            // Intentamos que sea monotactil
            if (Input.GetTouch(0).fingerId == 0) {//&& (Input.GetTouch(0).phase.Equals(TouchPhase.Began))){
                // No ignora la interfaz
                //if (!UnityEngine.EventSystems.EventSystem.current.IsPointerOverGameObject(Input.GetTouch(0).fingerId)) {
                if (!m_OnButton) {
                    Vector2 pos = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
                    RaycastHit2D hit = Physics2D.Raycast(pos, Vector2.zero);
                    if (hit) {
                        EventsManager.RaiseOnTouchEvent(hit.transform.gameObject);
                    }
                    else {
                        EventsManager.RaiseOnTouchEvent(null);
                    }
                }
                else {
                    // Si el rayo colisiona con un elemento UI consideramos que no choca con nada
                    EventsManager.RaiseOnTouchEvent(null);
                }
		    }
        }
	}

    public void SetOnButton() {
        m_OnButton = true;
    }

    public void ReleaseOnButton() {
        m_OnButton = false;
    }
}
