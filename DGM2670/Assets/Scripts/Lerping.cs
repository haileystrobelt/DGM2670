using UnityEngine;

public class Lerping : MonoBehaviour
{
    public Vector3 vOne, vTwo;

    private float speed = 2f;
    
    
    void Start()
    {
        
    }

    void Update()
    {
        var direction = Vector3.Lerp(vOne, vTwo, 1);
        transform.position = direction;
    }
}
