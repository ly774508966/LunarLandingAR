using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    Rigidbody _rigidbody;
    public Vector3 vector = new Vector3(0,2000f,0);

	// Use this for initialization
	void Start ()
    {
        _rigidbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(Input.GetAxis("Vertical")>.1f)
        {
            _rigidbody.AddForce(vector * Time.deltaTime);
        }
        // zorgen dat het per seconde gaat idpv per frame
        
	}
}
