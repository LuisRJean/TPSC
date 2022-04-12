public partial class Form1 : Form
{
    public  Form1()
    {
        InitializeComponent();
    }


    private void BTtnGetTopArtist_Click(object sender, EventArgs e)
    {
        string[] artis = SpotifyClassLibrary.SpotifyHelper.GetTopPlayedSpotifyCurrently();

        1stArtist.Items.AddRange(artis);


    }
}
