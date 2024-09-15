using UnityEngine;

public class CamraFollow : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private float speed = 0.125f;
    private Vector3 offset;

    private void Start()
    {
        offset = transform.position - player.position;
    }

    private void LateUpdate()
    {
        if (player != null)
        {
            Vector3 targetPos = player.position + offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, targetPos, speed);
            transform.position = smoothedPosition;
        }

       
    }
}
