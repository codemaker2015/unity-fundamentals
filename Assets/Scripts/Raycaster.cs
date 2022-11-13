using UnityEngine;
using System.Collections;

public class Raycaster : MonoBehaviour
{
	public Camera camera;
	public GameObject obj;
	public Transform origin;
	public float rayLength = 2;
	private Ray ray;
	private RaycastHit hit;

	void Update ()
	{
		if ( Input.GetMouseButtonDown ( 0 ) )
		{
			//ray = camera.ScreenPointToRay ( Input.mousePosition );

			//if ( Physics.Raycast ( ray ) )
			//{
			//	Debug.Log ( "Hit something." );
			//}

			//if ( Physics.Raycast ( ray, out hit ) )
			//{
			//	if ( hit.collider )
			//	{
			//		Debug.Log ( "Hit object named: " + hit.collider.name );
			//
			//		Instantiate ( obj, hit.point, hit.transform.rotation ); 
			//	}
			//}

			/*
			RaycastHit [] hits = null;

			hits = Physics.RaycastAll (ray);

			if ( hits.Length > 0 )
			{
				for ( int i = 0; i < hits.Length; i++ )
				{				
					Debug.Log ( "Hit: " + hits[i].collider.name );
				}
			}
			*/

			RaycastHit [] hits = null;

			hits = Physics.RaycastAll ( origin.position, Vector3.forward, rayLength );

			if ( hits.Length > 0 )
			{
				for ( int i = 0; i < hits.Length; i++ )
				{
					if ( hits[i].collider )
					{
						Debug.Log ( "Hit: " + hits[i].collider.name );
					}
				}
			}

			Debug.DrawRay (origin.position, Vector3.forward * rayLength, Color.green, 3);
		}

		//Debug.DrawRay (origin.position, Vector3.forward * rayLength, Color.green, 3);
		//Debug.DrawLine (ray.origin, hit.point, Color.red);
	}
}
