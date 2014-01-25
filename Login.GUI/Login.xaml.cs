using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

using LArchitecture.GUI.LArchitectureControls;
using LacertusStartup;
using LacertusMain;


namespace LacertusLoginGUI
{
	/// <summary>
	/// Interaction logic for Login.xaml
	/// </summary>
	public partial class Login : LWindow
	{
		public Login()
		{
			InitializeComponent();
		}

		private void Login_Load(object sender, RoutedEventArgs e)
		{
			ErrorMessageLabel.Content = "";
		}

		private void LoginButton_Click(object sender, RoutedEventArgs e)
		{
			if (UsernameInputTextBox.Text != "" && PasswordInputTextBox.Text != "")
			{
				string usernameEntry = UsernameInputTextBox.Text;
				string passwordEntry = PasswordInputTextBox.Text;

				var VerifyLogin = new VerifyLogin();
				bool loginSucess = VerifyLogin.LoginFunction(usernameEntry, passwordEntry);

				if (loginSucess)
				{
					var window = new MainWindow();
					window.Show();
					this.Close();
				}
				else
				{
					ErrorMessageLabel.Content = "Invalid Username/Password combination.";
				}
			}
			else
			{
				ErrorMessageLabel.Content = "Please enter a username and password.";
			}
		}

		private void RegisterButton_Click(object sender, RoutedEventArgs e)
		{
			if (UsernameInputTextBox.Text != "" && PasswordInputTextBox.Text != "")
			{
				string usernameEntry = UsernameInputTextBox.Text;
				string passwordEntry = PasswordInputTextBox.Text;
			}
			else
			{
				ErrorMessageLabel.Content = "Please enter a username and password.";
			}
		}
		
		
	}
}
