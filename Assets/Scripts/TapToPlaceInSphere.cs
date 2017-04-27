using UnityEngine;
using HoloToolkit.Unity.InputModule;

public class TapToPlaceInSphere : MonoBehaviour, IInputClickHandler
{
    public float distanceFromUser = 2f;

    bool isBeingPlaced = false;

    private void Update()
    {
        if (isBeingPlaced)
        {
            Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);
            transform.position = ray.GetPoint(distanceFromUser);
        }
    }

    public void OnInputClicked(InputClickedEventData eventData)
    {
        isBeingPlaced = !isBeingPlaced;
    }
}