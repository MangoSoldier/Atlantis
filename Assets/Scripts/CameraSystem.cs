using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSystem : MonoBehaviour
{

    public GameObject player;
    //public float xMin;
    //public float xMax;
    //public float yMin;
    //public float yMax;



    // Use this for initialization
    void Start()
    {
        // player = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
        this.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, -10);
    }

    // Update is called once per frame
    void LateUpdate()
    {
       // float x = Mathf.Clamp(player.transform.position.x, xMin, xMax);
        // float y = Mathf.Clamp(player.transform.position.y, yMin, yMax);
       // gameObject.transform.position = new Vector3(x, y, gameObject.transform.position.z);
    }
}
