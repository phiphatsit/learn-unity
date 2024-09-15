using UnityEngine;

public class CamraFollow : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private float speed = 5f;
    private Vector3 offset;

    private void Start()
    {
        offset = transform.position - player.position;
    }

    private void LateUpdate()
    {
        Vector3 targetPos = player.position + offset;
        transform.position = Vector3.Lerp(transform.position, targetPos, Time.fixedDeltaTime * speed);
    }
}
