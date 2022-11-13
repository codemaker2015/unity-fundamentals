using UnityEngine;
using System.Collections;

public class RuntimeCreation : MonoBehaviour
{
	public PrimitiveType primitiveType = PrimitiveType.Cube;
	Mesh mesh;
	GameObject myGameObject;

	void Update ()
	{
		if ( Input.GetKeyDown ( "a" ) )
		{
			CreatePrimitiveCube();
		}

		if ( Input.GetKeyDown ( "s" ) )
		{
			CreateTriangle ();
		}

		if ( Input.GetKeyDown ( "d" ) )
		{
			CreateFromResources ();
		}

		UpdateMeshVertices (myGameObject);

	}
	
	void CreatePrimitiveCube ()
	{
		GameObject obj = GameObject.CreatePrimitive (primitiveType);
		obj.AddComponent<Rigidbody> ();
	}

	void CreateTriangle ()
	{
		GameObject obj = new GameObject ();
		obj.name = "Runtime created gameObject";

		MeshFilter meshFilter = obj.AddComponent<MeshFilter> ();
		Mesh mesh = meshFilter.mesh;

		mesh.Clear ();
		mesh.vertices = new Vector3[]{ new Vector3(0,0,0),new Vector3(0,1,0),new Vector3(1,1,0)};
		mesh.uv = new Vector2[] { new Vector2(0,0),new Vector2(0,1),new Vector2(1,1) };
		mesh.triangles = new int[] {0,1,2};
		mesh.RecalculateNormals ();
		mesh.RecalculateBounds ();

		MeshRenderer meshRenderer = obj.AddComponent<MeshRenderer> ();
		Material material = new Material (Shader.Find ("Diffuse"));
		material.color = Color.blue;

		meshRenderer.material = material;

		MeshCollider meshCollider = obj.AddComponent<MeshCollider> ();

		obj.layer = 0;
		obj.tag = "Player";

		myGameObject = obj;
	}

	void UpdateMeshVertices ( GameObject obj )
	{
		if ( !obj ) return;

		Mesh mesh = obj.GetComponent<MeshFilter> ().mesh;
		Vector3[] vertices = mesh.vertices;
		Vector3[] normals = mesh.normals;

		int i = 0;

		while ( i<vertices.Length )
		{
			vertices[i]+= normals[i] * Mathf.Sin (Time.time );
			i++;
		}

		mesh.vertices = vertices;
		mesh.RecalculateNormals ();
		mesh.RecalculateBounds ();
	}

	void CreateFromResources ()
	{
		GameObject obj = Resources.Load ("Cube") as GameObject;

		Instantiate (obj);
	}
}















