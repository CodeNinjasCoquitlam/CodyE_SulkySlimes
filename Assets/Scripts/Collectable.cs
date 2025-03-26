using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collectable : MonoBehaviour
{
    public float distanceToMove;

    private Vector3 startingPosition;
    private Vector3 endingPosition;

    public float speed = 0.1f;
    public float direction = -1f;

    [Header("Scene to Load")]
    public int sceneNumber;
    // Start is called before the first frame update
    void Start()
    {
        startingPosition = transform.position;
        endingPosition = new Vector3(
            startingPosition.x, 
            startingPosition.y + distanceToMove, 
            startingPosition.z
            );
    }

    // Update is called once per frame
    void Update()
    {
       if (transform.position.y > startingPosition.y)
       {
            direction = -1f;
       }
       if (transform.position.y < endingPosition.y)
       {
           direction = 1f;
       }

        Vector3 position = new Vector3(
            startingPosition.x, 
            transform.position.y + speed * direction * Time.deltaTime, 
            startingPosition.z
            );

        transform.position = position;
    }
    
}
