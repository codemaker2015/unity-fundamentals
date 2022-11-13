using UnityEngine;
using System.Collections;

public class CameraTriggers : MonoBehaviour
{
	public Cameras cameras;
	public Cameras.CameraState cameraState;

	void OnTriggerEnter ( Collider other )
	{
		if ( other.name == "player" )
		{
			cameras.cameraState = cameraState;
		}
	}
}
