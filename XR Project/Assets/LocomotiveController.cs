using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class LocomotiveController : MonoBehaviour
{
    public XRController leftTeleportRay;
    public XRController rightTeleportRay;
    public InputHelpers.Button teleportActivateButton;
    public float activationThreshold = 0.1f;

    public XRRayInteractor LeftInteractorRay;
    public XRRayInteractor RightInteractorRay;
    public bool enableLeftTeleport { get; set; } = true;
    public bool enableRightTeleport { get; set; } = true;

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = new Vector3();
        Vector3 norm = new Vector3();

        int index = 0;
        bool validtarget = false;
        if(leftTeleportRay)
        {
            bool isLeftInteractorRayHovering = LeftInteractorRay.TryGetHitInfo(ref pos, ref norm, ref index, ref validtarget);
            leftTeleportRay.gameObject.SetActive(enableLeftTeleport && CheckIfActivated(leftTeleportRay)&& !isLeftInteractorRayHovering);
        }
        
        if (rightTeleportRay)
        {
            bool isRightInteractorRayHovering = RightInteractorRay.TryGetHitInfo(ref pos, ref norm, ref index, ref validtarget);
            rightTeleportRay.gameObject.SetActive(enableRightTeleport && CheckIfActivated(rightTeleportRay) && !isRightInteractorRayHovering);
        }
    }

    public bool CheckIfActivated(XRController controller)
    {
        InputHelpers.IsPressed(controller.inputDevice, teleportActivateButton, out bool isActivated, activationThreshold);
        return isActivated;
    }
}
