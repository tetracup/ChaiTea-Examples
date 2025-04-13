using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class HapticCylinder : HapticPrimitiveShape
{
    protected override void Awake()
    {
        double height = this.transform.localScale.y*2;
        double radius = this.transform.localScale.x / 2;
        obj = new ChaiTea.ShapeCylinder(radius, height);
        base.Awake();

        //Chai3D cylinder position is at bottom
        //Unity cylinder position at middle
        //Apply the offset according to its transform up vector to account for rotations
         Vector3 offset = -this.transform.up * this.transform.localScale.y; 
        obj.SetLocalPosition(this.transform.localPosition + offset);
    }

    protected override void Start()
    {
        base.Start();
    }
}
