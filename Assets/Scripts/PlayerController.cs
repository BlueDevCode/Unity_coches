using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Claudia Cadec

    //Propiedades
    
    [ Range (0,20), SerializeField] 
     private float speed = 10f;

     [Range(0,20), SerializeField,Tooltip ("Velocidad lineal máxima del coche") ]
    private float turnSpeed = 10f;

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
        this.transform.Translate(turnSpeed* Time.deltaTime*Vector3.right*horizontalInput);

    }
}
