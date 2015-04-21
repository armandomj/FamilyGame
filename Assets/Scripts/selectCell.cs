using UnityEngine;
using System.Collections;

public class selectCell : MonoBehaviour {
    private bool m_ImSelected = false;
    private bool m_IHavePlant = false;

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
        if (m_ImSelected && !m_IHavePlant) {
            plant.transform.position = transform.position;
            plant.GetComponent<followFinger>().enabled = false;
            m_IHavePlant = true;
        }
        else if (m_ImSelected && m_IHavePlant) {
            Destroy(plant);
        }
    }
}
