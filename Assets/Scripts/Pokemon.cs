using UnityEngine;

public class Pokemon : MonoBehaviour
{
    public SpriteRenderer sp;
    public float successRate = 70f;

    private void Awake()
    {
        sp = GetComponent<SpriteRenderer>();
    }
}
