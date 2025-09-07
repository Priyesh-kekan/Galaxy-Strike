using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    [SerializeField] private float controllSpeed = 10f;

    Vector2 movement;

    private void Update()
    {
        float xOffset = movement.x * controllSpeed * Time.deltaTime;
        float yOffset = movement.y * controllSpeed * Time.deltaTime;
        transform.localPosition = new Vector3(transform.localPosition.x + xOffset, transform.localPosition.y + yOffset, 0f);
    }

    private void onMove(InputValue value)
    {
        Debug.Log(value.Get<Vector2>());
        movement = value.Get<Vector2>();
    }
}
