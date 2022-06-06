namespace DnDCombatHelperPC
{
	internal static class Program
	{
		[STAThread]
		static void Main()
		{
			ApplicationConfiguration.Initialize();
			MainView mainView = new MainView();
			Application.Run(mainView);
		}
	}
}