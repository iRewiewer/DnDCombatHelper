using System.Net;
using System.Net.Sockets;

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

			IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
			IPAddress ipAddress = ipHostInfo.AddressList[0];
			IPEndPoint localEndPoint = new IPEndPoint(ipAddress, 25565);

			Console.WriteLine(ipAddress.ToString());

			// Create a TCP/IP socket.
			Socket listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
			
			// maybe this?
			// https://stackoverflow.com/questions/36823404/server-client-application-with-net-and-xamarin
		}
	}
}
