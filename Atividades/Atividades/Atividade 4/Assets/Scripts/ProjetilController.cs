using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class ProjetilController : NetworkBehaviour
{
    float moveSpeed = 20f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 1);
    }

    // Update is called once per frame
    void Update()
    {
        void Update()
        {
            transform.Translate(0, 0, Time.deltaTime * 20f);
        }
    }

    [ServerCallback]
    private void OnTriggerEnter(Collider other)
    {
        NetworkServer.Destroy(gameObject);
        NetworkServer.Destroy(other.gameObject);
    }
}
