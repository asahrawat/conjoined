using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLine : MonoBehaviour
{

	private LineRenderer lineRenderer;


	public Transform origin;
	public Transform destination;
    // Start is called before the first frame update
    void Start()
    {
    	lineRenderer = GetComponent<LineRenderer>();
    	lineRenderer.SetPosition(0, origin.position);
    	lineRenderer.SetPosition(1, destination.position);
    	lineRenderer.SetWidth(.15f, .15f);
        
    }

    // Update is called once per frame
    void Update()
    {
        lineRenderer.SetPosition(0, origin.position);
        lineRenderer.SetPosition(1, destination.position);
    }
}
