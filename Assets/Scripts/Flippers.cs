//using UnityEditor.UI;
using UnityEngine;

public class Flippers : MonoBehaviour
{
    private Rigidbody2D rb;
    private KeyCode hotkey;
    public float force = 180f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        if (this.name == "FlipperLeft")
        {
            hotkey = KeyCode.A;
        }
        else if (this.name == "FlipperRight")
        {
            hotkey = KeyCode.D;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (this.name == "FlipperLeft")
        {
            if (Input.GetKey(hotkey))
            {
                rb.AddTorque(force);
                //this.transform.Rotate(Vector3.forward, Time.deltaTime * force, Space.World);
            }
            else
            {
                rb.AddTorque(-force);
                //this.transform.Rotate(Vector3.forward, Time.deltaTime * -force, Space.World);
                //Debug.Log(this.transform.localEulerAngles.z);

            }
        }
        else if (this.name == "FlipperRight")
        {
            if (Input.GetKey(hotkey))
            {
                rb.AddTorque(-force);
            }
            else
            {
                rb.AddTorque(force);
            }
        }
    }
}
