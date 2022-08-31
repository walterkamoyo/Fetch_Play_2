using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float horizontalInput;
    public float speed = 40.0f;
    public float xRange = 10;
    public GameObject projectilePrefab;
    // Start is called before the first frame update
    void Start()
    {
       
        
    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.x < -xRange) {
            transform.position = new Vector3(-xRange,transform.position.y,transform.position.z);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        horizontalInput = Input.GetAxisRaw("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        if (Input.GetKeyDown(KeyCode.Space)) { 
            //Launch Projectile
            Instantiate(projectilePrefab,transform.position,transform.rotation);

        }
    }
}
