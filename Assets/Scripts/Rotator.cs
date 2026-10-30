using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField]
    private Vector3 _rotationVector = new Vector3(15, 30, 45);
    void Update()
    {
        transform.Rotate(_rotationVector * Time.deltaTime);
    }
}
