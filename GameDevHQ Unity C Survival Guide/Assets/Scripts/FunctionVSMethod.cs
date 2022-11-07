using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunctionVSMethod : MonoBehaviour
{
    [SerializeField]
    private GameObject PlayerOBJ;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ChangeColor(PlayerOBJ, Color.blue);
            Debug.Log("Change Color");
        }
    }

    private void ChangeColor(GameObject obj, Color AssignColor)
    {
        obj.GetComponent<MeshRenderer>().material.color = AssignColor;
    }    
}
