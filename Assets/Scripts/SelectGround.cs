using UnityEngine;
using System.Collections;

public class SelectGround : MonoBehaviour {
    private bool m_ImSelected = false;

    void OnEnable() {
        EventsManager.OnTouchEvent += this.OnTouchEvent;
        EventsManager.PlantIsFreeEvent += this.PlantIsFreeEvent;
    }
    void OnDisable() {
        EventsManager.OnTouchEvent -= this.OnTouchEvent;
        EventsManager.PlantIsFreeEvent -= this.PlantIsFreeEvent;
    }

    void OnTouchEvent(GameObject obj) {
        if (obj == gameObject) {
            m_ImSelected = true;
        }
        else {
            m_ImSelected = false;
        }
    }

    void PlantIsFreeEvent(GameObject plant) {
        if (m_ImSelected) {
            Destroy(plant);
        }
    }
}
