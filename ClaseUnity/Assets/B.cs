using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B : MonoBehaviour
{
    public float speed;
    private int privada;

    public GameObject otro;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hola mundo");
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float y = Input.GetAxis("Vertical") * Time.deltaTime * speed;

        transform.Translate(x, y, 0);

        if (Input.GetKeyDown(KeyCode.Space)){
            Instantiate(otro, transform.position, transform.rotation);
        }
    }
}
