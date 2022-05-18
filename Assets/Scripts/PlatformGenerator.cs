using UnityEngine;

public class PlatformGenerator : MonoBehaviour
{
    [SerializeField] private GameObject _platformPrefab;
    [SerializeField] private Transform[] _createLocations;
    [SerializeField] private Material[] _materials;
    [SerializeField] private float _speed;

    private float _side;
    private float _timer;

    void Start()
    {
        _side = _platformPrefab.transform.lossyScale.x;
        var fixedFrames = _side / _speed;
        _timer = fixedFrames * Time.fixedDeltaTime;

        CreatePlatform();
    }

    private void CreatePlatform()
    {
        var howManyPlatform = Random.Range(1, 3);
        if (howManyPlatform == 1)
        {
            int indexLocation = Random.Range(0, 2);
            SetPlatformValues(Instantiate(_platformPrefab, _createLocations[indexLocation].position, Quaternion.identity));
        }
        else
        {
            for (int i = 0; i < _createLocations.Length; i++)
            {
                SetPlatformValues(Instantiate(_platformPrefab, _createLocations[i].position, Quaternion.identity));
            }
        }
        
        Invoke(nameof(CreatePlatform), _timer);
    }

    private void SetPlatformValues(GameObject platform)
    {
        if (platform.GetComponent<Platform>())
        {
            platform.GetComponent<Platform>().SetSpeed(_speed);
            platform.GetComponent<Platform>().SetMaterial(_materials[Random.Range(0, _materials.Length - 1)]);
        }
    }
}
