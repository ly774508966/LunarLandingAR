using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    Rigidbody _rigidbody;
    public Vector3 vector = new Vector3(0,2000f,0);
    public Vector3 vector2 = new Vector3(2000f, 0, 0);
    public Vector3 vector3 = new Vector3(-2000f, 0, 0);

    // Use this for initialization
    void Start ()
    {
        _rigidbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(Input.GetAxis("Vertical")>0)
        {
            _rigidbody.AddForce(vector * Time.deltaTime);
        }
        if (Input.GetAxis("Horizontal") > 0)
        {
            _rigidbody.AddForce(vector3 * Time.deltaTime);
        }
        if (Input.GetAxis("Horizontal") < 0)
        {
            _rigidbody.AddForce(vector2 * Time.deltaTime);
        }
        // zorgen dat het per seconde gaat idpv per frame

    }
}
