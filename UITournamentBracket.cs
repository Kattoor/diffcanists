
using System;
using UnityEngine;

public class UITournamentBracket : MonoBehaviour
{
  [NonSerialized]
  public TournamentBracket tc = new TournamentBracket();
  public int activeRound;
  public int activeBracket;

  public static UITournamentBracket Instance { get; private set; }

  public TournamentBracket.Round _activeRound
  {
    get
    {
      return this.tc.rounds[this.activeRound];
    }
  }

  public TournamentBracket.Bracket _activeBracket
  {
    get
    {
      return this.tc.rounds[this.activeRound].bracket[this.activeBracket];
    }
  }

  private void Awake()
  {
    UITournamentBracket.Instance = this;
  }

  private void OnDestroy()
  {
    if (!((UnityEngine.Object) UITournamentBracket.Instance == (UnityEngine.Object) this))
      return;
    UITournamentBracket.Instance = (UITournamentBracket) null;
  }

  public void Start()
  {
    this.RefreshUI();
  }

  public void RefreshUI()
  {
    if (this.activeRound >= this.tc.rounds.Count)
      this.activeRound = this.tc.rounds.Count - 1;
    if (this.tc.rounds.Count == 0)
      return;
    if (this.activeBracket >= this.tc.rounds[this.activeRound].bracket.Count)
      this.activeBracket = this.tc.rounds[this.activeRound].bracket.Count - 1;
    int count = this.tc.rounds[this.activeRound].bracket.Count;
  }
}
