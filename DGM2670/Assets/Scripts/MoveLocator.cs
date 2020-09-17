using UnityEngine;

public class MoveLocator : MonoBehaviour
{
    private Camera cam;
    public Transform pointObj;
    
    
    private void Start()
    {
        cam = Camera.main
    }

    private void OnMouseDown()
    {
        if (Physics.Raycast(cam.ScreenPointToRay()))
    }
}
