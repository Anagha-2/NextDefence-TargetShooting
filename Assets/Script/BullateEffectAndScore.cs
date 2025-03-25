using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BullateEffectAndScore : MonoBehaviour
{
    public float rayDistance = 10f; // The distance the ray will travel
    public GameObject effect;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;

        // Perform the raycast
        if (Physics.Raycast(ray, out hit, rayDistance))
        {
            if(hit.collider.tag=="Wall")
            {
                Player.Instance.score++;
                Instantiate(effect, hit.collider.transform.position,Quaternion.identity);
                Debug.Log("hi");
                GunShoot_Mec.Instance.Source.PlayOneShot(GunShoot_Mec.Instance.hits);
            }
        }
        else
        {
            Debug.DrawLine(ray.origin, ray.origin + ray.direction * rayDistance, Color.green);  // Visualize the miss
        }
    }

}
