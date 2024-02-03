using System;
using Cinemachine;
using DefaultNamespace.Enums;
using UnityEngine;

namespace DefaultNamespace
{
    public class CameraController : MonoBehaviour
    {
        public CinemachineVirtualCamera cameraReductor;
        public CinemachineVirtualCamera cameraAxis;
        public CinemachineVirtualCamera cameraCap1;
        public CinemachineVirtualCamera cameraCap2;
        public CinemachineVirtualCamera cameraCrownGear;
        public CinemachineVirtualCamera cameraFasteners;
        public CinemachineVirtualCamera cameraPlanetaryCarrier1;
        public CinemachineVirtualCamera cameraPlanetaryCarrier2;
        public CinemachineVirtualCamera cameraPlanetaryGears;
        public CinemachineVirtualCamera cameraSleeve;
        public CinemachineVirtualCamera cameraSunGear;

        private CinemachineVirtualCamera _activeCamera;
        private ElementType _activeCameraType;

        private CinemachineVirtualCamera SetActiveCamera
        {
            set
            {
                _activeCamera.Priority = 10;
                _activeCamera = _activeCamera == value ? cameraReductor : value;
                _activeCamera.Priority = 20;
            }
        }

        public ElementType ActiveCameraType
        {
            get => _activeCameraType;
            private set => _activeCameraType = _activeCameraType == value ? ElementType.Reductor : value;
        }

        private void Awake()
        {
            _activeCamera = cameraReductor;
            _activeCameraType = ElementType.Reductor;
        }

        public void EnableCamera(ElementType cameraType)
        {
            ActiveCameraType = cameraType;
            switch (cameraType)
            {
                case ElementType.Reductor: SetActiveCamera = cameraReductor; break;
                case ElementType.Axis: SetActiveCamera = cameraAxis; break;
                case ElementType.Cap1: SetActiveCamera = cameraCap1; break;
                case ElementType.Cap2: SetActiveCamera = cameraCap2; break;
                case ElementType.CrownGear: SetActiveCamera = cameraCrownGear; break;
                case ElementType.Fasteners: SetActiveCamera = cameraFasteners; break;
                case ElementType.PlanetaryCarrier1: SetActiveCamera = cameraPlanetaryCarrier1; break;
                case ElementType.PlanetaryCarrier2: SetActiveCamera = cameraPlanetaryCarrier2; break;
                case ElementType.PlanetaryGears: SetActiveCamera = cameraPlanetaryGears; break;
                case ElementType.Sleeve: SetActiveCamera = cameraSleeve; break;
                case ElementType.SunGear: SetActiveCamera = cameraSunGear; break;
            }
        }
    }
}