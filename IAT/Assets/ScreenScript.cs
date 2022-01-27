using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenScript : MonoBehaviour
{
    public Texture m_MainTexture;
    // Start is called before the first frame update
    void Start()
    {
        GameObject screen = GameObject.Find("Screen");
        Renderer renderer = screen.GetComponent<Renderer>();
        renderer.material.SetTexture("_MainTex", m_MainTexture);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}