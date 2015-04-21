using UnityEngine;
using System.Collections;

public class EventsManager : MonoBehaviour {

    public delegate void GameObjectDelegate(GameObject obj);

    public static event GameObjectDelegate OnTouchEvent;
    public static void RaiseOnTouchEvent(GameObject obj) {
        if (OnTouchEvent != null) {
            OnTouchEvent(obj);
        }
    }

    public static event GameObjectDelegate PlantIsFreeEvent;
    public static void RaisePlantIsFreeEvent(GameObject plant) {
        if (PlantIsFreeEvent != null) {
            PlantIsFreeEvent(plant);
        }
    }

    //public static event GameObjectDelegate ImSelectedCellEvent;
    //public static void RaiseImSelectedCell(GameObject obj) {
    //    if (ImSelectedCellEvent != null) {
    //        ImSelectedCellEvent(obj);
    //    }
    //}
}
