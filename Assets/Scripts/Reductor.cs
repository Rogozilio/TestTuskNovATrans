using DefaultNamespace.Enums;
using UnityEngine;
using Zenject;

namespace DefaultNamespace
{
    public class Reductor : MonoBehaviour
    {
        [Inject] private UI _ui;
        [Inject] private CameraController _cameraController;

        public GameObject axis;
        public GameObject Cap1;
        public GameObject Cap2;
        public GameObject CrownGear;
        public GameObject Fasteners;
        public GameObject PlanetaryCarrier1;
        public GameObject PlanetaryCarrier2;
        public GameObject PlanetaryGears;
        public GameObject Sleeve;
        public GameObject SunGear;

        private Animator _animator;
        private bool _isBoom;

        private void Awake()
        {
            _animator = GetComponent<Animator>();
            _ui.SetActionClickReductor = () =>
            {
                EnableAllElements();
                _cameraController.EnableCamera(ElementType.Reductor);
                ToggleBlowUpOrCollect();
            };
            _ui.SetActionClickAxis = () =>
            {
                EnableOrDisableElements(ElementType.Axis);
                _cameraController.EnableCamera(ElementType.Axis);
            };
            _ui.SetActionClickCap1 = () =>
            {
                EnableOrDisableElements(ElementType.Cap1);
                _cameraController.EnableCamera(ElementType.Cap1);
            };
            _ui.SetActionClickCap2 = () =>
            {
                EnableOrDisableElements(ElementType.Cap2);
                _cameraController.EnableCamera(ElementType.Cap2);
            };
            _ui.SetActionClickCrownGear = () =>
            {
                EnableOrDisableElements(ElementType.CrownGear);
                _cameraController.EnableCamera(ElementType.CrownGear);
            };
            _ui.SetActionClickFasteners = () =>
            {
                EnableOrDisableElements(ElementType.Fasteners);
                _cameraController.EnableCamera(ElementType.Fasteners);
            };
            _ui.SetActionClickPlanetaryCarrier1 = () =>
            {
                EnableOrDisableElements(ElementType.PlanetaryCarrier1);
                _cameraController.EnableCamera(ElementType.PlanetaryCarrier1);
            };
            _ui.SetActionClickPlanetaryCarrier2 = () =>
            {
                EnableOrDisableElements(ElementType.PlanetaryCarrier2);
                _cameraController.EnableCamera(ElementType.PlanetaryCarrier2);
            };
            _ui.SetActionClickPlanetaryGears = () =>
            {
                EnableOrDisableElements(ElementType.PlanetaryGears);
                _cameraController.EnableCamera(ElementType.PlanetaryGears);
            };
            _ui.SetActionClickSleeve = () =>
            {
                EnableOrDisableElements(ElementType.Sleeve);
                _cameraController.EnableCamera(ElementType.Sleeve);
            };
            _ui.SetActionClickSunGear = () =>
            {
                EnableOrDisableElements(ElementType.SunGear);
                _cameraController.EnableCamera(ElementType.SunGear);
            };
        }

        private void ToggleBlowUpOrCollect()
        {
            _isBoom = !_isBoom;
            _animator.SetBool("isBoom", _isBoom);
        }

        private void DisableAllElements()
        {
            // axis.SetActive(false);
            // Cap1.SetActive(false);
            // Cap2.SetActive(false);
            // CrownGear.SetActive(false);
            // Fasteners.SetActive(false);
            // PlanetaryCarrier1.SetActive(false);
            // PlanetaryCarrier2.SetActive(false);
            // PlanetaryGears.SetActive(false);
            // Sleeve.SetActive(false);
            // SunGear.SetActive(false);
            axis.GetComponent<MeshRenderer>().enabled = false;
            Cap1.GetComponent<MeshRenderer>().enabled = false;
            Cap2.GetComponent<MeshRenderer>().enabled = false;
            CrownGear.GetComponent<MeshRenderer>().enabled = false;
            Fasteners.GetComponent<MeshRenderer>().enabled = false;
            PlanetaryCarrier1.GetComponent<MeshRenderer>().enabled = false;
            PlanetaryCarrier2.GetComponent<MeshRenderer>().enabled = false;
            PlanetaryGears.GetComponent<MeshRenderer>().enabled = false;
            Sleeve.GetComponent<MeshRenderer>().enabled = false;
            SunGear.GetComponent<MeshRenderer>().enabled = false;
        }
        
        private void EnableAllElements()
        {
            // axis.SetActive(true);
            // Cap1.SetActive(true);
            // Cap2.SetActive(true);
            // CrownGear.SetActive(true);
            // Fasteners.SetActive(true);
            // PlanetaryCarrier1.SetActive(true);
            // PlanetaryCarrier2.SetActive(true);
            // PlanetaryGears.SetActive(true);
            // Sleeve.SetActive(true);
            // SunGear.SetActive(true);
            axis.GetComponent<MeshRenderer>().enabled = true;
            Cap1.GetComponent<MeshRenderer>().enabled = true;
            Cap2.GetComponent<MeshRenderer>().enabled = true;
            CrownGear.GetComponent<MeshRenderer>().enabled = true;
            Fasteners.GetComponent<MeshRenderer>().enabled = true;
            PlanetaryCarrier1.GetComponent<MeshRenderer>().enabled = true;
            PlanetaryCarrier2.GetComponent<MeshRenderer>().enabled = true;
            PlanetaryGears.GetComponent<MeshRenderer>().enabled = true;
            Sleeve.GetComponent<MeshRenderer>().enabled = true;
            SunGear.GetComponent<MeshRenderer>().enabled = true;
        }

        private void EnableElement(ElementType cameraType)
        {
            switch (cameraType)
            {
                // case ElementType.Reductor: axis.SetActive(true);break;
                // case ElementType.Axis: axis.SetActive(true); break;
                // case ElementType.Cap1: Cap1.SetActive(true); break;
                // case ElementType.Cap2: Cap2.SetActive(true);break;
                // case ElementType.CrownGear: CrownGear.SetActive(true); break;
                // case ElementType.Fasteners: Fasteners.SetActive(true); break;
                // case ElementType.PlanetaryCarrier1: PlanetaryCarrier1.SetActive(true); break;
                // case ElementType.PlanetaryCarrier2: PlanetaryCarrier2.SetActive(true); break;
                // case ElementType.PlanetaryGears: PlanetaryGears.SetActive(true); break;
                // case ElementType.Sleeve: Sleeve.SetActive(true); break;
                // case ElementType.SunGear: SunGear.SetActive(true); break;
                case ElementType.Reductor: axis.GetComponent<MeshRenderer>().enabled = true;break;
                case ElementType.Axis: axis.GetComponent<MeshRenderer>().enabled = true; break;
                case ElementType.Cap1: Cap1.GetComponent<MeshRenderer>().enabled = true; break;
                case ElementType.Cap2: Cap2.GetComponent<MeshRenderer>().enabled = true;break;
                case ElementType.CrownGear: CrownGear.GetComponent<MeshRenderer>().enabled = true; break;
                case ElementType.Fasteners: Fasteners.GetComponent<MeshRenderer>().enabled = true; break;
                case ElementType.PlanetaryCarrier1: PlanetaryCarrier1.GetComponent<MeshRenderer>().enabled = true; break;
                case ElementType.PlanetaryCarrier2: PlanetaryCarrier2.GetComponent<MeshRenderer>().enabled = true; break;
                case ElementType.PlanetaryGears: PlanetaryGears.GetComponent<MeshRenderer>().enabled = true; break;
                case ElementType.Sleeve: Sleeve.GetComponent<MeshRenderer>().enabled = true; break;
                case ElementType.SunGear: SunGear.GetComponent<MeshRenderer>().enabled = true; break;
            }
        }

        private void EnableOrDisableElements(ElementType elementType)
        {
            if (_cameraController.ActiveCameraType == elementType)
            {
                EnableAllElements();
            }
            else
            {
                DisableAllElements();
                EnableElement(elementType);
            }
        }
    }
}