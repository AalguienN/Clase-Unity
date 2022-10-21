using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A : MonoBehaviour
{
    //2: Alcance de las variables
    //2.1 - Ver que aparece en el inspector
    public float speed;

    //2.2 - Ver que no aparece en el inspector
    private int privada; //Borrable

    //5.2 Añadir una referencia a prefab
    public GameObject otro;
    void Start()
    {
        //1 Hacer un hola mundo
        Debug.Log("HolaMundo"); //Borrable
    }

    void Update()
    {
        //3 - Inputs básicos: Las AXIS
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        //4.1 - Darse cuenta de que va demasiado rápido
        transform.Translate(new Vector3(x, y, 0)); //Comentar 
        //4.2 - Añadimos Time.deltaTime
        transform.Translate(new Vector3(x,y,0) * Time.deltaTime);

        //5 Otros Inputs
        if (Input.GetKeyDown(KeyCode.Space)) { 
            //5.2
            Debug.Log("Espacio pulsado");
            //5.3
            Instantiate(otro);
            
        }
    }

    
}
