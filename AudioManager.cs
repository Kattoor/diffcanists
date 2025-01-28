
using System.Collections;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
  private float volumeSound = 0.5f;
  private float volumeMusic = 0.5f;
  [Header("Per Spellbook")]
  public AudioClip[] clipSelectSpell;
  public AudioClip[] clipChargeFamiliar;
  public AudioClip[] clipChargeSpell;
  public AudioClip[] clipHarmony;
  [Header("Random")]
  public AudioClip createThornBallTerrain;
  public AudioClip spellBounce;
  public AudioClip spellBounceBones;
  public AudioClip flashEnd;
  public AudioClip pop;
  public AudioClip waterExplosion;
  public AudioClip waterBounce;
  public AudioClip trollMedium;
  public AudioClip trollBig;
  public AudioClip mechArrowExplode;
  public AudioClip mapPing;
  public AudioClip emojiShow;
  public AudioClip coins;
  [Header("Movement")]
  public AudioClip footSteps;
  public AudioClip runSteps;
  public AudioClip jumpLong;
  public AudioClip jumpHigh;
  public AudioClip land;
  public AudioClip click;
  public AudioClip splash;
  public AudioClip spellSlash;
  public AudioClip mineCharge;
  public AudioClip pigCharge;
  public AudioClip moneySteps;
  public AudioClip moneyJump;
  public AudioClip watchtowerDestroyed;
  public AudioClip leapHit;
  public AudioClip stalkAppear;
  public AudioClip[] turnStart;
  public AudioClip turnEnd;
  public AudioClip turnEndCountdown;
  [Header("Music")]
  public AudioClip musicMainMenu;
  public AudioClip musicCredits;
  public AudioClip musicCharacterCreation;
  public AudioClip[] musicGame;
  public AudioClip[] additionalMusic;
  private AudioClip clipPausedMusic;
  private float pausedTime;
  [Header("Cached Audio Sources")]
  public AudioSource[] sources;
  public AudioSource[] sourcesNapalm;
  public AudioSource sourceMusic;
  public AudioSource sourceChargeSpell;
  public AudioSource sourceCastSpell;
  public AudioSource sourcePickupMusic;
  public AudioSource sourceTurnEnd;
  private int curIndex;
  private int curIndexNapalm;

  public static AudioManager instance { get; private set; }

  public static void PlayTurnStart()
  {
    AudioManager.instance.InstancePlay(AudioManager.instance.turnStart[Mathf.Clamp(PlayerPrefs.GetInt("prefturnstartsound", 0), 0, AudioManager.instance.turnStart.Length - 1)], PlayerPrefs.GetFloat("prefturnstartvolume", 0.5f));
  }

  public static void PlayFromSource(AudioClip clip, AudioSource source)
  {
    source.clip = clip;
    source.volume = AudioManager.instance.volumeSound;
    source.time = 0.0f;
    source.Play();
  }

  public static void PlayChargeSpell(int i)
  {
    AudioManager.instance.sourceChargeSpell.clip = AudioManager.instance.clipChargeSpell[i];
    AudioManager.instance.sourceChargeSpell.volume = AudioManager.instance.volumeSound;
    AudioManager.instance.sourceChargeSpell.time = 0.0f;
    AudioManager.instance.sourceChargeSpell.Play();
  }

  public static void StopChargeSpell()
  {
    if (!AudioManager.instance.sourceChargeSpell.isPlaying)
      return;
    AudioManager.instance.sourceChargeSpell.Stop();
  }

  public static void PlayNapalm(AudioClip clip)
  {
    if (Client.game == null || !Client.game.isClient || (Client.game.resyncing || !((Object) AudioManager.instance != (Object) null)))
      return;
    AudioManager.instance.InstancePlayNapalm(clip);
  }

  public static void Play(AudioClip clip)
  {
    if (Client.game == null || !Client.game.isClient || (Client.game.resyncing || !((Object) AudioManager.instance != (Object) null)))
      return;
    AudioManager.instance.InstancePlay(clip);
  }

  public static void PlayChess(AudioClip clip)
  {
    if (!((Object) ChessUI.Instance != (Object) null) || !ChessUI.Instance.useAudio)
      return;
    AudioManager.instance.InstancePlay(clip, 1f);
  }

  public static void ResumeMusic()
  {
    if (!((Object) AudioManager.instance != (Object) null))
      return;
    AudioManager.instance._PlayMusic(AudioManager.instance.clipPausedMusic, AudioManager.instance.pausedTime);
    AudioManager.instance.clipPausedMusic = (AudioClip) null;
  }

  public static void PlayMusic(AudioClip music)
  {
    if (!((Object) AudioManager.instance != (Object) null))
      return;
    AudioManager.instance.clipPausedMusic = AudioManager.instance.sourceMusic.clip;
    AudioManager.instance.pausedTime = AudioManager.instance.sourceMusic.time;
    AudioManager.instance._PlayMusic(music, 0.0f);
  }

  public static void PlayMusicMainMenu()
  {
    if (!((Object) AudioManager.instance != (Object) null))
      return;
    AudioManager.instance._PlayMusic(AudioManager.instance.musicMainMenu, 0.0f);
  }

  public static void PlayMusicCharacterCreation()
  {
    if (!((Object) AudioManager.instance != (Object) null))
      return;
    AudioManager.instance._PlayMusic(AudioManager.instance.musicCharacterCreation, 0.0f);
  }

  public static void PlayGameMusic(int i)
  {
    if (!((Object) AudioManager.instance != (Object) null) || i < 0 || i >= AudioManager.instance.musicGame.Length)
      return;
    AudioManager.instance._PlayMusic(AudioManager.instance.musicGame[i], 0.0f);
  }

  public void InstancePlay(AudioClip clip, float volume)
  {
    if ((Object) clip == (Object) null)
      return;
    this.sources[this.curIndex].clip = clip;
    this.sources[this.curIndex].time = 0.0f;
    this.sources[this.curIndex].volume = volume;
    this.sources[this.curIndex].Play();
    ++this.curIndex;
    if (this.curIndex < this.sources.Length)
      return;
    this.curIndex = 0;
  }

  private void InstancePlay(AudioClip clip)
  {
    if ((Object) clip == (Object) null)
      return;
    this.sources[this.curIndex].clip = clip;
    this.sources[this.curIndex].time = 0.0f;
    this.sources[this.curIndex].volume = this.volumeSound;
    this.sources[this.curIndex].Play();
    ++this.curIndex;
    if (this.curIndex < this.sources.Length)
      return;
    this.curIndex = 0;
  }

  private void InstancePlayNapalm(AudioClip clip)
  {
    if ((Object) clip == (Object) null)
      return;
    this.sourcesNapalm[this.curIndexNapalm].clip = clip;
    this.sourcesNapalm[this.curIndexNapalm].time = 0.0f;
    this.sourcesNapalm[this.curIndexNapalm].volume = this.volumeSound * 0.5f;
    this.sourcesNapalm[this.curIndexNapalm].Play();
    ++this.curIndexNapalm;
    if (this.curIndexNapalm < this.sourcesNapalm.Length)
      return;
    this.curIndexNapalm = 0;
  }

  private void _PlayMusic(AudioClip clip, float time = 0.0f)
  {
    if ((Object) clip == (Object) null || (Object) this.sourceMusic.clip == (Object) clip)
      return;
    this.sourceMusic.clip = clip;
    this.sourceMusic.time = time;
    this.sourceMusic.Play();
  }

  internal IEnumerator FadePickupMusic(bool stop)
  {
    float cur = this.sourcePickupMusic.volume;
    float volume = PlayerPrefs.GetFloat("prefvolmusic", 0.5f);
    if (stop)
    {
      while ((double) cur > 0.0)
      {
        cur -= Time.deltaTime;
        this.sourcePickupMusic.volume = cur;
        this.sourceMusic.volume = volume - cur;
        yield return (object) null;
      }
      this.sourceMusic.volume = volume;
      this.sourcePickupMusic.volume = 0.0f;
      this.sourcePickupMusic.Pause();
    }
    else
    {
      this.sourcePickupMusic.Play();
      while ((double) cur < (double) volume)
      {
        cur += Time.deltaTime;
        if ((double) cur >= (double) volume)
        {
          cur = volume;
          this.sourcePickupMusic.volume = cur;
          this.sourceMusic.volume = volume - cur;
          break;
        }
        this.sourceMusic.volume = 0.0f;
        this.sourcePickupMusic.volume = cur;
        yield return (object) null;
      }
    }
  }

  private void Awake()
  {
    AudioManager.instance = this;
    this.volumeSound = PlayerPrefs.GetFloat("prefvolsound", 0.5f);
    this.volumeMusic = PlayerPrefs.GetFloat("prefvolmusic", 0.5f);
    this.sourceMusic.volume = this.volumeMusic;
  }

  public static void UpdateVolumeSound(float f)
  {
    if (!((Object) AudioManager.instance != (Object) null))
      return;
    AudioManager.instance.volumeSound = f;
  }

  public static void UpdateVolumeMusic(float f)
  {
    if (!((Object) AudioManager.instance != (Object) null))
      return;
    AudioManager.instance.volumeMusic = f;
    AudioManager.instance.sourceMusic.volume = f;
  }

  private void OnDestroy()
  {
    AudioManager.instance = (AudioManager) null;
  }

  public static void Timer(float f)
  {
    if ((double) f >= (double) AudioManager.TurnTimer._lastTime || (double) f <= 0.0)
      return;
    AudioManager.TurnTimer._lastTime = Mathf.Floor(f - 0.1f);
    if ((double) AudioManager.TurnTimer._lastTime == 0.0 && (Object) AudioManager.instance.sourceTurnEnd.clip != (Object) AudioManager.instance.turnEnd)
      AudioManager.TurnTimer._lastTime = 0.4f;
    Debug.Log((object) ("Time: " + (object) f));
    AudioManager.instance.sourceTurnEnd.volume = PlayerPrefs.GetFloat("turnendsound", 1f);
    AudioManager.instance.sourceTurnEnd.clip = (double) f <= 0.5 ? AudioManager.instance.turnEnd : AudioManager.instance.turnEndCountdown;
    AudioManager.instance.sourceTurnEnd.Play();
  }

  public static class TurnTimer
  {
    public static float _lastTime = -1f;

    public static void NextTurn(ZGame g)
    {
      AudioManager.TurnTimer._lastTime = Mathf.Floor(Mathf.Clamp((float) (((double) g.PlayersMaxTurnTime - 1.0) / 2.0), 2f, 5f));
      AudioManager.instance.sourceTurnEnd.Stop();
    }
  }
}
