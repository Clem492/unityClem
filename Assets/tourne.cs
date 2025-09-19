using Unity.VisualScripting;
using UnityEngine;

public class tourne : MonoBehaviour
{
    public Material mat;
    public Material color;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(Vector3.up);
        
    }
    private void OnMouseEnter()
    {
        gameObject.GetComponent<Renderer>().material = mat;
    }
    private void OnMouseExit()
    {
        gameObject.GetComponent<Renderer>().material = color;
    }
}
