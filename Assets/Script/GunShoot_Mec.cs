using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunShoot_Mec : MonoBehaviour
{
    public static GunShoot_Mec Instance;
    public GameObject bullPre;
    public GameObject cube;
   public AudioSource Source;
    public AudioClip gun,hits;
    // Start is called before the first frame update
    void Start()
    {
        Instance=this;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("hishoot");
            ShootMode();
            Source.PlayOneShot(gun);
        }
        
    }

    public void ShootMode()
    {
        GameObject bullectNew = Instantiate(bullPre, cube.transform.position, transform.rotation);
        bullectNew.GetComponent<Rigidbody>().AddForce(transform.forward * 200f,ForceMode.Impulse);

    }
}
