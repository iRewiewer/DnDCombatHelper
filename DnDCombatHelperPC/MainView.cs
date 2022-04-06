namespace DnDCombatHelperPC
{
	public partial class MainView : Form
	{
		public MainView()
		{
			InitializeComponent();
			Random rng = new Random();

			// 4 random digits
			textBox1.Text = rng.Next(0, 9).ToString() +
							rng.Next(0, 9).ToString() +
							rng.Next(0, 9).ToString() +
							rng.Next(0, 9).ToString();

			// maybe this?
			// https://stackoverflow.com/questions/36823404/server-client-application-with-net-and-xamarin
		}
	}
}
