using UnityEngine;

public class PuzzleDeactivateAudio : MonoBehaviour
{
    public AudioSource puzzleDesativo; //audio de desativa��o do puzzle

    public void PuzzleAudio()
    {
        puzzleDesativo.Play();
    }
}
