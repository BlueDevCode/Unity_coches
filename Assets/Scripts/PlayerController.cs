using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    //Propiedades
    
    [ Range (0,20), [SerializeField] private ] private float speed = 5f;


    // Start is called before the first frame update
    void Start()

    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(speed* Time.deltaTime*Vector3.forward);
    }
}
