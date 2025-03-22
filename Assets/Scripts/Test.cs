using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public float xForce;
    public float yForce;
    public float zForce;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.gameObject.transform.position = new Vector3(
                other.gameObject.transform.position.x + xForce,
                other.gameObject.transform.position.y + yForce,
                other.gameObject.transform.position.z + zForce
                );

            Debug.Log("Hit");
        }
        
    }
}
