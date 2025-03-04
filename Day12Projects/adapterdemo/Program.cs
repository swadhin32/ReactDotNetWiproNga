namespace adapterdemo;
public interface IMediaPlayer
{
    void Play(string audioType, string fileName);
}
public class AudioPlayer : IMediaPlayer
{
    private MediaAdapter _mediaAdapter;
  
    public void Play(string audioType, string fileName)
    {
        if (audioType.ToLower() == "mp3")
        {
            Console.WriteLine("Playing mp3 file: " + fileName);
        }
        else if (audioType.ToLower() == "vlc" || audioType.ToLower() == "mp4")
        {
            _mediaAdapter = new MediaAdapter();
            _mediaAdapter.Play(audioType, fileName);
        }
        else
        {
            Console.WriteLine($"Invalid media: {audioType} format not supported.");
        }
    }
}
public class VLCPlayer 
{

    public void PlayVLC(string fileName)
    {
        Console.WriteLine("Playing VLC file: " + fileName);
    }
}
// Class for playing MP4 files
public class MP4Player
{
    public void PlayMP4(string fileName)
    {
        Console.WriteLine("Playing MP4 file: " + fileName);
    }
}
public class MediaAdapter : IMediaPlayer
{
    private VLCPlayer _vlcPlayer;
    private MP4Player _mp4Player;



    public void Play(string audioType, string fileName)
    {
        if (audioType.ToLower() == "vlc")
        {
            _vlcPlayer = new VLCPlayer();
            _vlcPlayer?.PlayVLC(fileName);
        }
        else if (audioType.ToLower() == "mp4")
        {
            _mp4Player = new MP4Player();
            _mp4Player?.PlayMP4(fileName);
        }
    }
}




class Program
{
    static void Main(string[] args)
    {
        IMediaPlayer mediaPlayer = new AudioPlayer();
        // Playing various formats
        mediaPlayer.Play("mp3", "song.mp3");
        mediaPlayer.Play("mp4", "video.mp4");
        mediaPlayer.Play("vlc", "movie.vlc");
        mediaPlayer.Play("avi", "unsupported.avi");

        Console.ReadLine();
    }
}
