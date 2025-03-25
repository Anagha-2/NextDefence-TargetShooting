using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Crosshair : MonoBehaviour
{
    public static Crosshair instance;
    RaycastHit hit;
    public int range=20;
    public TextMeshProUGUI scoreText;
    public int score;
    public GameObject[] gameObjectsMove;
    public GameObject[] gameObjectsStatic;
    public GameObject bullet;
    public Transform gunPOint;
    public float force;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {


        /*if(Input.GetKey(KeyCode.Space))
        {
           GameObject bull= Instantiate(bullet, gunPOint.position, Quaternion.identity);
            bull.transform.rotation=Quaternion.Euler(0, -157.459f,0);
            bull.transform.Translate(Vector3.forward * 50 * Time.deltaTime);
        }*/

       /* if (Physics.Raycast(transform.position, transform.forward, out hit, range))
        {
            if (hit.collider.tag == "TargetStatic" & Input.GetMouseButton(1))
            {
                score++;
                hit.collider.gameObject.SetActive(false);
                Invoke("OffFuntion", 6);
                scoreText.text = score.ToString();
            }
            if (hit.collider.tag == "TargetMove" & Input.GetMouseButton(1))
            {
                score++;
                hit.collider.gameObject.SetActive(false);

                Invoke("OffFuntion", 6);
                scoreText.text = score.ToString();
            }
            if (hit.collider.tag == "TargetPopUp" & Input.GetMouseButton(1))
            {
                score++;
                Destroy(hit.collider.gameObject);
                scoreText.text = score.ToString();
            }
            Debug.DrawRay(transform.position, transform.forward * hit.distance, Color.green);
        }
        else
        {
            Debug.DrawRay(transform.position, transform.forward * range, Color.red);
        }*/
        
    }
   /* public void OffFuntion()
    {
        int x=0;
        while(x<7)
        {
            gameObjectsMove[x].SetActive(true);
            x++;
        } 
        int y=0;
        while(y<12)
        {
            gameObjectsStatic[x].SetActive(true);
            y++;
        }
    }*/
}
