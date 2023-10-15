using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawingScript : MonoBehaviour
{
    public DrawingArea drawingArea;
    public GameObject linePrefab;

    private GameObject currentLine;
    private LineRenderer lineRenderer;
    private EdgeCollider2D edgeCollider;

    private void Update()
    {
        if (drawingArea.canDraw && Input.GetMouseButtonDown(0))
        {
            CreateLine();
        }

        if (drawingArea.canDraw && Input.GetMouseButton(0))
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (Vector2.Distance(mousePos, lineRenderer.GetPosition(lineRenderer.positionCount - 1)) > 0.1f)
            {
                UpdateLine(mousePos);
            }
        }
    }

    void CreateLine()
    {
        currentLine = Instantiate(linePrefab, Vector3.zero, Quaternion.identity);
        lineRenderer = currentLine.GetComponent<LineRenderer>();
        edgeCollider = currentLine.GetComponent<EdgeCollider2D>();
        lineRenderer.SetPosition(0, Camera.main.ScreenToWorldPoint(Input.mousePosition));
        lineRenderer.SetPosition(1, Camera.main.ScreenToWorldPoint(Input.mousePosition));
    }

    void UpdateLine(Vector2 newPoint)
    {
        lineRenderer.positionCount++;
        lineRenderer.SetPosition(lineRenderer.positionCount - 1, newPoint);
        
        Vector3[] positions = new Vector3[lineRenderer.positionCount];
        lineRenderer.GetPositions(positions);
        
        Vector2[] points = new Vector2[positions.Length];
        for (int i = 0; i < positions.Length; i++)
        {
            points[i] = new Vector2(positions[i].x, positions[i].y);
        }
        
        edgeCollider.points = points;
    }

}
