using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallControllerLeft : MonoBehaviour
{
    public float wallSpeed = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.right * Time.deltaTime * -wallSpeed;

        Destroy(gameObject, 10f);
    }
}
