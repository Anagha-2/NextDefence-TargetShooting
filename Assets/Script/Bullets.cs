using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject bulletPrefab; // Assign Bullet prefab in the Inspector
    public GameObject gunPoint; // Assign gun muzzle position in Inspector
    public float fireRate = 0.2f;
    public float bulletSpeed = 50f;

    private float nextFireTime = 0f;
    private void Start()
    {
        gunPoint = GameObject.Find("GunPoint");
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1") && Time.time >= nextFireTime)
        {
           // Shoot();
            nextFireTime = Time.time + fireRate;
        }

    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, gunPoint.transform. position, gunPoint.transform. rotation);
        Rigidbody rb = bullet.GetComponent<Rigidbody>();

      if (rb != null)
        {
            rb.velocity = gunPoint.transform.forward * bulletSpeed; // Moves bullet forward
        }

        Destroy(bullet, 3f); // Destroy bullet after 3 sec
    }
}
