using UnityEngine;
using System.Collections;

public class lineRenderer : MonoBehaviour
{
    private LineRenderer line;
    private float count;
    private float dist;
    public float zValue;
    public Vector3 tempValue;
    public Transform origin;
    public Transform destination;
    public float lineWidth = 0.1f;

    public float drawSpeed = 1f;

    private void Start()
    {
        line = GetComponent<LineRenderer>();

    }

    public void Update()
    {
        
        if (origin!=null && destination!= null)
        { 
        dist = Vector3.Distance(origin.position, destination.position);
            line.SetPosition(0, origin.position);
            //line.startWidth = lineWidth;
            if (count < dist)
        {
            count += 0.1f / drawSpeed;
            float x = Mathf.Lerp(0, dist, count);

                Vector3 pointA = origin.position;
                Vector3 pointB = destination.position;
                Vector3 pointAlongLine = x * Vector3.Normalize(pointB - pointA) + pointA;
                tempValue = pointAlongLine;
                zValue = pointAlongLine.z;
                if (pointAlongLine.x==0|| pointAlongLine.y == 0 )
                {
                    pointAlongLine = new Vector3(0f,0f,0f);
                }

                if (pointAlongLine.z == 0)
                {
                    line.SetPosition(1, pointAlongLine);
                }
                line.numCapVertices = 6;
        }
        }
       
        if(origin == destination || tempValue.x<1f|| tempValue.z != 0f)
        {
            this.gameObject.SetActive(false);
        }
      
       
    }
}
