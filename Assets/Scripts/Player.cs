using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 1.0f;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private GameObject _plantPrefab;
    [SerializeField] private int _numSeeds = 5; 
    [SerializeField] private PlantCountUI _plantCountUI;

    private int _numSeedsLeft;
    private int _numSeedsPlanted;

    private void Start ()
    {
        _numSeedsLeft = _numSeeds;
        _numSeedsPlanted = 0;
        _plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);
    }

    private void Update()
    {
        // Handle movement
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");
        // Move the player
        Vector3 movement = new Vector3(moveX, moveY, 0).normalized * _speed * Time.deltaTime;
        _playerTransform.position += movement;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlantSeed();
        }
    }

    public void PlantSeed ()
    {
        if (_numSeedsLeft > 0)
        {
            // Instantiate the plant prefab at the player's position
            Instantiate(_plantPrefab, _playerTransform.position, Quaternion.identity);

            // Update seed counts
            _numSeedsLeft--;
            _numSeedsPlanted++;

            // Update the UI
            _plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);
        }
        else
        {
            Debug.Log("No seeds left to plant!");
        }
    }
}
