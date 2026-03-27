using UnityEngine;

public class HealItem : MonoBehaviour
{
    [SerializeField] private ParticleSystem healItem;
    [SerializeField] private Camera mainCamera;
    
    void Update()
    {
        CollectItem();
    }

    void CollectItem()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            RaycastHit hit;

            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 280))
            {
                Destroy(hit.collider.gameObject);
                healItem.Play();
            }
        }
    }
}
