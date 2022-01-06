using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    private float moveSpeed=10f;
    public float HorizontalOffset = 1f;
    public float VerticalOffset = 1f;

    private float edgePosRight,edgePosLeft,edgePosTop,edgePosBtm;

    void Start()
    {
        edgePosBtm=Camerainfo.instance.CameratEdgeBtm+VerticalOffset;
        edgePosTop=Camerainfo.instance.CameratEdgeTop-VerticalOffset;
        edgePosLeft=Camerainfo.instance.CameratEdgeLeft+HorizontalOffset;
        edgePosRight=Camerainfo.instance.CameratEdgeRight-HorizontalOffset;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetForwards = new Vector3(Input.GetAxisRaw("Horizontal"),Input.GetAxisRaw("Vertical"),this.transform.position.z);
        transform.Translate(targetForwards*moveSpeed*Time.deltaTime);
        transform.position = new Vector3(Mathf.Clamp(transform.position.x,edgePosLeft,edgePosRight),Mathf.Clamp(transform.position.y,edgePosBtm,edgePosTop));
    }
}
