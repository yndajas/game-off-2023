using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject block;
    public float maxX;
    public Transform spawnPoint;
    public float spawnRate;
    private bool _gameStarted;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI tapToStartText;
    private int _score = 0;

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && !_gameStarted)
        {
            _gameStarted = true;
            StartSpawning();
            tapToStartText.enabled = false;
        }
    }

    private void StartSpawning()
    {
        InvokeRepeating(nameof(SpawnBlock), 0.5f, spawnRate);
    }

    private void SpawnBlock()
    {
        Vector3 spawnPosition = spawnPoint.position;
        spawnPosition.x = Random.Range(-maxX, maxX);

        Instantiate(block, spawnPosition, Quaternion.identity);

        _score++;
        scoreText.text = _score.ToString();
    }
}
