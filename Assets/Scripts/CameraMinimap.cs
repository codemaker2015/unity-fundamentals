using UnityEngine;
using System.Collections;

public class CameraMinimap : MonoBehaviour
{
	public Transform target = null;
	public bool followTarget = true;
	public float cameraHeight = 18;

	void LateUpdate ()
	{
		if ( target )
		{
			if ( followTarget )
			{
				this.transform.position = new Vector3 ( target.position.x, cameraHeight, target.position.z );
			}
			else
			{
				this.transform.position = new Vector3 ( this.transform.position.x, cameraHeight, this.transform.position.z );
			}
		}
	}
}
