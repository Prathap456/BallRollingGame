using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BallCollision : MonoBehaviour
{
    public Material[] wallMat;
    Renderer rend;
    public Text displayText;

    
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        displayText.text = "";

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Sphere")
        {
            displayText.text = "you hit the wall";
            rend.sharedMaterial = wallMat[1];

        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "Sphere")
        {
            displayText.text = "Keep rolling";
            rend.sharedMaterial = wallMat[0];

        }
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
