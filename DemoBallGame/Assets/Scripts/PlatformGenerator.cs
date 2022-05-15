using UnityEngine;

public class PlatformGenerator : MonoBehaviour
{
    [SerializeField] private GameObject _platformPrefab;
    [SerializeField] private Transform[] _createLocations;
    [SerializeField] private float _speed = 1f;

    private Vector3 _position1;
    private Vector3 _position2;

    private float _side;
    private float _timer;
    private float _lostTime = 0;

    void Start()
    {
        _side = _platformPrefab.transform.lossyScale.x;
        _timer = _side / _speed;
        _position1 = transform.TransformDirection(_createLocations[0].position);
        _position2 = transform.TransformDirection(_createLocations[1].position);

        CreatePlatform(Random.Range(1, 3));
    }

    private void FixedUpdate()
    {

        if (_lostTime < _timer)
            _lostTime += Time.fixedDeltaTime;
        else
        {
            CreatePlatform(Random.Range(1, 3));
            _lostTime = 0;
        }
    }

    private void CreatePlatform(int howManyPlatform)
    {
        if (howManyPlatform == 1)
        {
            int indexLocation = Random.Range(0, 2);
            SetPlatformSpeed(Instantiate(_platformPrefab, _createLocations[0].position, Quaternion.identity));
        }
        else
        {
            for (int i = 0; i < _createLocations.Length; i++)
            {
                SetPlatformSpeed(Instantiate(_platformPrefab, _createLocations[i].position, Quaternion.identity));

            }
        }
    }

    private void SetPlatformSpeed(GameObject platform)
    {
        if (platform.GetComponent<Platform>())
            platform.GetComponent<Platform>().SetSpeed(_speed);
    }
}
