using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PindahLayar : MonoBehaviour
{
     public void LevelSelanjutnya()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void KeMenuLagi()
    {
        SceneManager.LoadScene(0);
    }

    public void Level1Belajar()
    {
        SceneManager.LoadScene(1);
    }

    public void Replay1_1()
    {
        SceneManager.LoadScene(1);
    }

    public void Level2Belajar()
    {
        SceneManager.LoadScene(2);
    }

    public void Replay2_1()
    {
        SceneManager.LoadScene(2);
    }

    public void Level3Belajar()
    {
        SceneManager.LoadScene(3);
    }

    public void Replay3_1()
    {
        SceneManager.LoadScene(3);
    }

    public void Level4Belajar()
    {
        SceneManager.LoadScene(4);
    }

    public void Replay4_1()
    {
        SceneManager.LoadScene(4);
    }

    public void Level5Belajar()
    {
        SceneManager.LoadScene(5);
    }

    public void Replay5_1()
    {
        SceneManager.LoadScene(5);
    }

    public void Level1Juara()
    {
        SceneManager.LoadScene(6);
    }

    public void Replay1_2()
    {
        SceneManager.LoadScene(6);
    }

    public void Level2Juara()
    {
        SceneManager.LoadScene(7);
    }

    public void Replay2_2()
    {
        SceneManager.LoadScene(7);
    }

    public void Level3Juara()
    {
        SceneManager.LoadScene(8);
    }

    public void Replay3_2()
    {
        SceneManager.LoadScene(8);
    }

    public void Level4Juara()
    {
        SceneManager.LoadScene(9);
    }

    public void Replay4_2()
    {
        SceneManager.LoadScene(9);
    }
    
    public void Level5Juara()
    {
        SceneManager.LoadScene(10);
    }

    public void Replay5_2()
    {
        SceneManager.LoadScene(10);
    }
    
}
