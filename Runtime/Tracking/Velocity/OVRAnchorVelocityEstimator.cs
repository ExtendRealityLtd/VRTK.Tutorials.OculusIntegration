namespace OculusIntegrationForVRTK.Tracking.Velocity
{
    using UnityEngine;
    using Zinnia.Tracking.Velocity;

    public class OVRAnchorVelocityEstimator : VelocityTracker
    {
        [Tooltip("The GameObject anchor from the OVRCameraRig to track velocity for.")]
        public GameObject trackedGameObject;

        protected override Vector3 DoGetAngularVelocity()
        {
            throw new System.NotImplementedException();
        }

        protected override Vector3 DoGetVelocity()
        {
            switch (trackedGameObject.name)
            {
                case "CenterEyeAnchor":
                    return OVRManager.isHmdPresent ? OVRPlugin.GetNodeVelocity(OVRPlugin.Node.EyeCenter, OVRPlugin.Step.Render).FromFlippedZVector3f() : Vector3.zero;
                case "LeftHandAnchor":
                    return Vector3.zero;
                case "RightHandAnchor":
                    return Vector3.zero;
            }
            return Vector3.zero;
        }
    }
}