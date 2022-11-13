using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
	public float moveSpeed = 5.0f;
	public float rotateSpeed = 60.0f;
	public bool canMoveSideways = false;

	void Update ()
	{
		Movement ();
	}

	void Movement ()
	{
		if ( Input.GetKey (KeyCode.UpArrow) )
		{
			Debug.Log ( "Key UpArrow Pressed." );
			
			this.transform.Translate ( new Vector3 ( 0, 0, moveSpeed * Time.deltaTime ) );
		}
		else if ( Input.GetKey (KeyCode.DownArrow) )
		{
			Debug.Log ( "Key DownArrow Pressed." );
			
			this.transform.Translate ( new Vector3 ( 0, 0, -moveSpeed * Time.deltaTime ) );
		}



		if ( Input.GetKey (KeyCode.LeftArrow) )
		{
			if ( canMoveSideways )
			{
				Debug.Log ( "Key LeftArrow Pressed." );
			
				this.transform.Translate ( new Vector3 ( -moveSpeed * Time.deltaTime, 0, 0 ) );
			}
			else
			{
				Debug.Log ( "Key LeftArrow Pressed: Rotate" );
				
				this.transform.Rotate ( new Vector3 ( 0, -rotateSpeed * Time.deltaTime, 0 ) );
			}
		}
		else if ( Input.GetKey ( KeyCode.RightArrow ) )
		{
			if ( canMoveSideways )
			{
				Debug.Log ( "Key RightArrow Pressed.");
			
				this.transform.Translate ( new Vector3 ( moveSpeed * Time.deltaTime, 0, 0 ) );
			}
			else
			{
				Debug.Log ( "Key RightArrow Pressed: Rotate" );
				
				this.transform.Rotate ( new Vector3 ( 0, rotateSpeed * Time.deltaTime, 0 ) );
			}
		}

		if ( Input.GetKey ( KeyCode.W ) )
		{
			Debug.Log ( "Key W Pressed." );
			
			this.transform.Translate ( new Vector3 ( 0, moveSpeed * Time.deltaTime, 0 ) );
		}
		else if ( Input.GetKey ( KeyCode.S ) )
		{
			Debug.Log ( "Key S Pressed." );
			
			this.transform.Translate ( new Vector3 ( 0, -moveSpeed * Time.deltaTime, 0 ) );
		}
	}
}








