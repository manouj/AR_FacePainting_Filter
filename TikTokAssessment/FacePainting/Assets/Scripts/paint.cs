using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paint : MonoBehaviour
{


    public Camera cam;
    public int PixelsSize = 10;

    void Start()
    {
        cam = GetComponent<Camera>();
    }

    void Update()
    {
        if (!Input.GetMouseButton(0))
            return;

        RaycastHit hit;
        if (!Physics.Raycast(cam.ScreenPointToRay(Input.mousePosition), out hit))
            return;

        Renderer rend = hit.transform.GetComponent<Renderer>();
        MeshCollider meshCollider = hit.collider as MeshCollider;

        if (rend == null || rend.sharedMaterial == null || rend.sharedMaterial.mainTexture == null || meshCollider == null)
            return;

        Texture2D tex = rend.material.mainTexture as Texture2D;
        Vector2 pixelUV = hit.textureCoord;
        pixelUV.x *= tex.width;
        pixelUV.y *= tex.height;


        var colors = new Color[PixelsSize * PixelsSize];
        // set brush to black
        for (var i = 0; i < PixelsSize * PixelsSize; i++)
        {
            colors[i] = Color.red;
        }


        tex.SetPixels((int)pixelUV.x, (int)pixelUV.y, PixelsSize, PixelsSize, colors);


        //tex.SetPixel((int)pixelUV.x, (int)pixelUV.y, Color.black);
        tex.Apply();
    }
}