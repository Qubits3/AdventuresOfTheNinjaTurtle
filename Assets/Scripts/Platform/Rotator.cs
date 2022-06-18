using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float rotateSpeed = 2f;

    private void Update()
    {
        transform.Rotate(0, 0, -360 * rotateSpeed * Time.deltaTime);
    }
}