using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{


    public static Player Instance;
    public float mouseSensitivity = 100f;
    private float rotationY = 0f;
    private float rotationX = 0f;
    public Transform playerCamera;
    public float verticalClamp = 90f;
    public bool referenacePopUpBool;
    Vector3 pos;
    public float speed;
    public GameObject move;
    public GameObject staticone;
    public GameObject popUp;
    public GameObject randomObj;
    public List<GameObject> positions;
    public GameObject target;
   public  GameObject disable;
   public  GameObject Settings;
    int posValue;
    public GameObject bullet;
    public int score = 0;
    public TextMeshProUGUI scoreText;
    private void Start()
    {
       
        InvokeRepeating("PopUpSpwan", 2, 3);
        Instance = this;
        
    }
    void Update()
    {
        scoreText.text = score.ToString();
        
        Mousecontroller();
        PlayerController();
        /*pos = transform.position;
        pos.x += Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        pos.z += Input.GetAxis("Vertical") * speed * Time.deltaTime;
        pos.x = Mathf.Clamp(pos.x, -1761.9f, 1849.39f);
        pos.z = Mathf.Clamp(pos.z, 2019.17f, 2064.29f);
       transform.position = pos;*/

    }
   public void Mousecontroller()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        // Rotate the player left and right
        transform.Rotate(Vector3.up * mouseX);

        // Rotate the camera up and down
        rotationY -= mouseY;
        rotationY = Mathf.Clamp(rotationY, -verticalClamp, verticalClamp);
        playerCamera.localRotation = Quaternion.Euler(rotationY, 0f, 0f);
    }
    public void PlayerController()
    {
        float inputX = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float inputZ = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        transform.Translate(inputX,0,inputZ);
    }
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag=="Wall")
        {
            speed = 0;
        }
        else
        {
            speed = 10;
        }
    }
    public void Move()
    {
        move.SetActive(true);
        staticone.SetActive(false);
        popUp.SetActive(false);
        referenacePopUpBool = false;
        settingsOff();
    }
     public void Staic()
    {
        move.SetActive(false);
        staticone.SetActive(true);
        popUp.SetActive(false);
        referenacePopUpBool = false;
        settingsOff();
    }
   
    public void Popup()
    {
        /* float randomX = Random.Range(1780, 1807);
         GameObject point=Instantiate(randomObj, new Vector3(randomX, 80.5f, 2009.77f), Quaternion.identity);
         point.transform.rotation = Quaternion.Euler(81.5630112f, 47.6207504f, 177.869049f);*/
        move.SetActive(false);
        staticone.SetActive(false);
        randomObj.SetActive(true);
        referenacePopUpBool = true;
        settingsOff();

    }
    public void PopUpSpwan()
    {
        if (referenacePopUpBool == true)
        {
            posValue = Random.Range(0, 9);
            disable = Instantiate(target, positions[posValue].transform.position, Quaternion.identity);
            disable.transform.rotation = Quaternion.Euler(81.5630112f, 47.6207504f, 177.869049f);
            Invoke("DisablePopUpOff", 2f);
        }
        
       
        InvokeRepeating("Disable", 3, 6);
        InvokeRepeating("Disable", 4, 9);
    }

    public void DisablePopUpOff()
    {
        disable.SetActive(false);
    }
    public void Disable()
    {
        
       // disable.SetActive(false);
      //  Destroy(disable);
    }
  /* public void Bullet()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            Instantiate(bullet,transform.position, Quaternion.identity);
        }
    }*/
    public void settingsOn()
    {
        Settings.SetActive(true);
        GunShoot_Mec.Instance.Source.mute = true;
    }
    public void settingsOff()
    {
        Settings.SetActive(false);
        GunShoot_Mec.Instance.Source.mute = false;
    }
}
