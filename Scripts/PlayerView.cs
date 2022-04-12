using UnityEngine;

public class PlayerView : MonoBehaviour
{
    [SerializeField] private float _sensivity;
    [SerializeField] private Transform _player;


    private void Update()
    {
        var mouseX = Input.GetAxis("Mouse X");
        
        _player.Rotate(0 , mouseX * Time.unscaledDeltaTime * _sensivity , 0);
    }

}
