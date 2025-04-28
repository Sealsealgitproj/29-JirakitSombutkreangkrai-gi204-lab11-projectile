using UnityEngine;
public class Projectile2D : MonoBehaviour
{
    [SerializeField] Transform shootPoint;
    [SerializeField] GameObject target;
    [SerializeField] Rigidbody2D bulletPrefab;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Debug.DrawRay(ray.origin, ray.direction * 5f, Color.blue, 5f);
            RaycastHit2D hit = Physics2D.GetRayIntersection(ray, Mathf.Infinity);
            if (hit.collider != null)
            {
                target.transform.position = new Vector2(hit.point.x, hit.point.y);
                Debug.Log("hit " + hit.collider.name);
            }
        }
    }
}