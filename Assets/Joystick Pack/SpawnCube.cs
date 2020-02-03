using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCube : MonoBehaviour
    {
    public PrimitiveType dotType = PrimitiveType.Cube;
    public GameObject pbj;
    private void Awake()
    {
         pbj = GameObject.CreatePrimitive(dotType);
        pbj.transform.SetPositionAndRotation(Vector3.zero, new Quaternion());
        pbj.AddComponent<RotateObject>();
        RotateObject rt = pbj.GetComponent<RotateObject>();
        pbj.gameObject.transform.SetParent(this.transform);
       



        rt.RotateAmount.x = 10;
        rt.RotateAmount.y = 10;
        rt.RotateAmount.z = 10;
        pbj.transform.position = Vector3.zero;
    }

    private void Start()
    {
        pbj.transform.position = this.transform.position;
        pbj.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
    }
}
