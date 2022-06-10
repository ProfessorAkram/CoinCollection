using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{

    [Header("Score")]
    [SerializeField] private int score;
    public string scoreLable;

    [Header("Movement")]
    public int moveSpeed;
    public int runSpeed;    
    public int jumpSpeed;
    [Space(10)]
    public float xRotation;
    public float yRotation;
   



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
