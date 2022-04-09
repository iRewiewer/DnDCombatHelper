namespace DnDCombatHelperPC
{
	public partial class MainView : Form
	{
		private int code;

		public MainView()
		{
			InitializeComponent();
			Random rng = new Random();

			this.code = Convert.ToInt32(rng.Next(0, 9).ToString() +
										rng.Next(0, 9).ToString() +
										rng.Next(0, 9).ToString() +
										rng.Next(0, 9).ToString());

			// 4 random digits
			textBox1.Text = this.code.ToString();

			

			// maybe this?
			// https://stackoverflow.com/questions/36823404/server-client-application-with-net-and-xamarin
		}
	}
}
