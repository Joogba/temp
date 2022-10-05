using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circleTransform : MonoBehaviour
{
    
    private enum Ord { x, y, z};
    [SerializeField]
    private Ord ord;

    public GameObject[] ordTransform;
    // Start is called before the first frame update
    void Start()
    {
        ordTransform[(int)Ord.x].transform.position = GetComponent<Transform>().position;
        ordTransform[(int)Ord.y].transform.position = GetComponent<Transform>().position;
        ordTransform[(int)Ord.z].transform.position = GetComponent<Transform>().position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
