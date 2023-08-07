using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Looping : MonoBehaviour
{
    public float backgroundSpeed;
    public Renderer backgroundRender;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        backgroundRender.material.mainTextureOffset += new Vector2(backgroundSpeed * Time.deltaTime, 0f);
    }
}
