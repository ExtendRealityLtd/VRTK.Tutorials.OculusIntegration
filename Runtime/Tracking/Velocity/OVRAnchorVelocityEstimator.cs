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
            throw new System.NotImplementedException();
        }
    }
}