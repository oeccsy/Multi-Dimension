using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointController : MonoBehaviour 
{
	private void Start ()
	{
		MeshFilterArrControl();
	}

	private void MeshFilterControl()
	{
		MeshFilter meshFilter = GetComponent<MeshFilter>();
		meshFilter.mesh.SetIndices(meshFilter.mesh.GetIndices(0),MeshTopology.Points,0);
        
		ScreenCapture.CaptureScreenshot("Capture.png");
	}

	private void MeshFilterArrControl()
	{
		MeshFilter[] meshFilterArr = GetComponentsInChildren<MeshFilter>();
		
		foreach (var meshFilter in meshFilterArr)
		{
			meshFilter.mesh.SetIndices(meshFilter.mesh.GetIndices(0), MeshTopology.Points, 0);
		}
		
		//ScreenCapture.CaptureScreenshot("Capture.png");
	}

}