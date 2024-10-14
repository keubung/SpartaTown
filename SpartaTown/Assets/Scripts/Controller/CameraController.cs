using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    private float cameraSpeed;
    private CharacterStatsHandler characterStatsHandler;

    private void Update()
    {
        cameraSpeed = characterStatsHandler.CurrentStat.speed;
        Vector3 dir = player.transform.position - this.transform.position;
        Vector3 moveVector = new Vector3(dir.x * cameraSpeed * Time.deltaTime, dir.y * cameraSpeed * Time.deltaTime, 0.0f);
        this.transform.Translate(moveVector);
    }
}