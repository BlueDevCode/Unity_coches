using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    //Propiedades
    
    [ Range (0,20), SerializeField] 
     private float speed = 10f;

     [Range(0,90), SerializeField,Tooltip ("Velocidad lineal máxima del coche") ]
    private float turnSpeed = 45f;

    private float horizontalInput, verticalInput;


    // Start is called before the first frame update
    void Start()

    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput= Input.GetAxis ("Vertical");

        this.transform.Translate(speed* Time.deltaTime*Vector3.forward* verticalInput);
        this.transform.Rotate(turnSpeed* Time.deltaTime*Vector3.up*horizontalInput);

    }
}
