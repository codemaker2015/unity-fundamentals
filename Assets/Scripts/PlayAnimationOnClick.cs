using UnityEngine;
using System.Collections;

public class PlayAnimationOnClick : MonoBehaviour
{
	private Animator animator;

	void Awake ()
	{
		animator = GetComponent<Animator> ();
	}

	void Update ()
	{
		if ( Input.GetKeyDown ( KeyCode.A ) )
		{
			animator.Play ( "cubeMove" );
		}
	}


}
