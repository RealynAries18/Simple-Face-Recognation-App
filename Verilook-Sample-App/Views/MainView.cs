using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Verilook_Sample_App.Controllers;
using Verilook_Sample_App.Services;
using Verilook_Sample_App.Services.Face_Profile;

namespace Verilook_Sample_App
{
    public partial class MainView : Form
    {
        FaceProfileController _controller;
        VerilookManagerFactory _factory;
        public MainView()
        {
            InitializeComponent();

            _factory = new VerilookManagerFactory(MainFaceView);
            _controller = new FaceProfileController(new FaceProfileProvider(), new FaceProfileManager(), _factory.CreateManager());
        }

        private void EnrollButton_Click(object sender, EventArgs e)
        {
            _controller.EnrollUser("testid");
        }
    }
}
