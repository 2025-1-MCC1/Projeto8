using UnityEngine;

public class PuzzleDeactivateAudio : MonoBehaviour
{
    public AudioSource puzzleDesativo; //audio de desativação do puzzle

    public void PuzzleAudio()
    {
        puzzleDesativo.Play();
    }
}
