using UnityEngine;
using UnityEngine.Tilemaps;

public class PlayerRenderer : MonoBehaviour
{
    private SpriteRenderer _renderer;
    private void Awake()
    {
        _renderer = GetComponent<SpriteRenderer>();
    }
    private void Update()
    {
        Flip();
    }

    private void Flip()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        _renderer.flipX = mousePos.x < transform.position.x;
    }
}
