using UnityEngine;

public class CameraBounds : MonoBehaviour
{
    public float minX, maxX, minY, maxY;

    void LateUpdate()
    {
        // Отримання поточних координат камери
        Vector3 clampedPosition = transform.position;

        // Обмеження координат
        clampedPosition.x = Mathf.Clamp(clampedPosition.x, minX, maxX);
        clampedPosition.y = Mathf.Clamp(clampedPosition.y, minY, maxY);

        // Встановлення нових координат для камери
        transform.position = clampedPosition;
    }
}
