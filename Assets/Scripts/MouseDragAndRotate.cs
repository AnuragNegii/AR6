using UnityEngine;

public class MouseDragAndRotate : MonoBehaviour {
        [SerializeField] private float rotationSpeed = 0.2f;


        private void OnMouseDrag() {
            float xAxisRotation = Input.GetAxis("Mouse X") * rotationSpeed;

            transform.Rotate(Vector3.down, xAxisRotation);
        }
}