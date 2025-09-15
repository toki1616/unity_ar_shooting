using UnityEngine;

public static class ScoreExtension
{
    public static float GetValueScore(this ScoreConst.ScoreEvent value)
    {
        switch(value)
        {
            case ScoreConst.ScoreEvent.Cube:
              return 1;
              
            case ScoreConst.ScoreEvent.Sphere:
              return 5;
              
            case ScoreConst.ScoreEvent.Cylinder:
              return 10;
              
            case ScoreConst.ScoreEvent.Capsule:
              return 100;
              
            default:
              return 0;
        }
    }
}