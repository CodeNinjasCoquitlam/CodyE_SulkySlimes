using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collide : MonoBehaviour
{
    public GameObject pipe;
    public GameObject ball;

    public int sceneNumber;
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
            gameObject.SetActive(false);
            Invoke("LoadNextScene", 2f);

            Debug.Log("BeGone");
        }

    }
    private void LoadNextScene()
    {
        SceneManager.LoadScene(sceneNumber);
    }
}
