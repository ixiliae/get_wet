using UnityEngine;
using System.Collections;

public class MouseAimCamera : MonoBehaviour
{
    public GameObject target;
    public float rotateSpeed = 5;
    Vector3 offset;
	PlayerHealth p;

    void Start()
    {
        offset = target.transform.position - transform.position;
		p = gameObject.GetComponentInParent<PlayerHealth>();
    }

    void LateUpdate()
    {
		if (p.isDead == false) {
			float horizontal = Input.GetAxis ("Mouse X") * rotateSpeed;
			float vertical = Input.GetAxis ("Mouse Y") * rotateSpeed;
			target.transform.Rotate (vertical, horizontal, 0); 

			float desiredAngle = target.transform.eulerAngles.y;
			float desiredAnglez = target.transform.eulerAngles.x;
			Quaternion rotation = Quaternion.Euler (desiredAnglez, desiredAngle, 0);
			transform.position = target.transform.position - (rotation * offset);

			transform.LookAt (target.transform);
		}
    }
}