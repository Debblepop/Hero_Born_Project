using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public Vector3 myStartPosition = new Vector3(0, 0, 20);
    public Vector3 myEndPosition = new Vector3(0, 0, 44);
    public int speed = 3;
    public bool forward = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if (gameObject.transform.position.z >= myEndPosition.z)
		{
			forward = false;
		}
		
		if (gameObject.transform.position.z <= myStartPosition.z)
		{
			forward = true;
		}

		
		if (forward == true)
		{
			gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z + (Time.deltaTime * speed));
		}
		
		if (forward == false)
		{
			gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z - (Time.deltaTime * speed));
		}
	}
}
