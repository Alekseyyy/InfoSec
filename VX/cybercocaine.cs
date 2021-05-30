/*
 * Cybercocaine Programme
 *  This'll make ur computer higher than an airplane ;-)
 * By Aleksey
 *  github.com/Alekseyyy
 *  twitter.com/EpsilonCalculus
 *
 * See this article for context: https://medium.com/@EpsilonCalculus/cybercocaine-ff27b2aaa80c
*/

using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace Cybercocaine {

	public class StonedPic : System.Windows.Forms.ContainerControl {

		public StonedPic() {
			//InitializeComponent();
			Cursor.Hide();
		}

		public void CreateTheExperience(string myImage) {
			Form the_experience = new Form();
			Image background = new Bitmap(myImage);

			the_experience.FormBorderStyle = FormBorderStyle.None;
			the_experience.StartPosition = FormStartPosition.CenterScreen;
			the_experience.WindowState = FormWindowState.Maximized;
			the_experience.BackgroundImage = background;

			the_experience.ShowDialog();
		}
	}

	class MainLogic {

		public static void Main(string[] args) {
			StonedPic sp = new StonedPic();
			sp.CreateTheExperience(@".\image.jpg");
		}
	}
}
