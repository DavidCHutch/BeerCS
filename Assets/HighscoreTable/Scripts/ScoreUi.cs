using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ScoreUi : MonoBehaviour
{
    public RowUi rowUi;
    public ScoreManager scoreManager;

    private void Start()
    {
        scoreManager.AddScore(new Score("Gert", 6, 5, 4, 3, 2, 3));
        scoreManager.AddScore(new Score("PerTheGodLikeEntityOfDestruction", 1, 2, 8, 10, 35, 52));

        var scores = scoreManager.GetHighScores().ToArray();
        for (int i = 0; i < scores.Length; i++)
        {
            var row = Instantiate(rowUi, transform).GetComponent<RowUi>();
            var totalBeers = scores[i].sips / 20;
            row.name.text = (i + 1) + ". " + scores[i].name;
            row.gotKnifed.text = scores[i].gotKnifed.ToString();
            row.deaths.text = scores[i].deaths.ToString();
            row.kills.text = scores[i].kills.ToString();
            row.knifed.text = scores[i].knifed.ToString();
            row.rounds.text = scores[i].rounds.ToString();
            row.teamKills.text = scores[i].teamKills.ToString();
            row.sips.text = scores[i].sips.ToString();
            row.totalBeers.text = totalBeers.ToString();
        }
    }
}
