using UnityEngine;
using System.Collections;

public class LoadScene : MonoBehaviour
{
	public int loadSceneId = 0;

	void Update ()
	{
		if ( Input.GetKeyDown ( "s" ) )
		{
			Application.LoadLevel ( loadSceneId );
		}
	}
}
