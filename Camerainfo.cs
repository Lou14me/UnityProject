using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camerainfo : MonoBehaviour
{
    private Camera camera;
    public static Camerainfo instance;
    public float CameraHeight,CameraWidth;
    public float CameratEdgeTop,CameratEdgeBtm,CameratEdgeRight,CameratEdgeLeft;
    // Start is called before the first frame update
    private void Awake() {
        camera = Camera.main;
        instance=this;
        CameraHeight = camera.orthographicSize;
        CameraWidth = CameraHeight*camera.aspect;

        CameratEdgeTop=camera.transform.position.y+CameraHeight;
        CameratEdgeBtm=camera.transform.position.y-CameraHeight;
        CameratEdgeRight=camera.transform.position.x+CameraWidth;
        CameratEdgeLeft=camera.transform.position.x-CameraWidth;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
