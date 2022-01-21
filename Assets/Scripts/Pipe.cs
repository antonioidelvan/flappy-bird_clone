using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    [SerializeField]
    float velocidade;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 4);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.right * velocidade * Time.deltaTime;
    }
}
