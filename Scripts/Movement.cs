using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float _speed = 14;

    private void Update()
    {
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");

        var offset = new Vector3(horizontal, 0 , vertical) * Time.deltaTime * _speed;
        transform.Translate(offset);
    }
}
