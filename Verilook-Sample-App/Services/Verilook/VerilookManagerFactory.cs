using Neurotec.Biometrics;
using Neurotec.Biometrics.Client;
using Neurotec.Biometrics.Gui;
using Neurotec.Licensing;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Verilook_Sample_App.Shared.Prompts;

namespace Verilook_Sample_App.Services
{
    public class VerilookManagerFactory
    {
        private bool _licenseSetupSuccessfully { get; set; }

        private NFaceView _faceView { get; set; }
        public VerilookManagerFactory(NFaceView faceView)
        {
            _faceView = faceView;
        }

        public VerilookManager CreateManager(NBiometricCaptureOptions captureOptions = NBiometricCaptureOptions.Stream)
        {
            LicenseSetup();

            NBiometricClient client = new NBiometricClient()
            {
                BiometricTypes = NBiometricType.Face,
                UseDeviceManager = true,
            };


            return new VerilookManager(client, _faceView, captureOptions);
        }


        private void LicenseSetup()
        {
            if (!_licenseSetupSuccessfully)
            {
                _licenseSetupSuccessfully = true;

                _licenseSetupSuccessfully = AddLicenseFiles();

                string[] requiredComponents = new string[]
                {
                    "Biometrics.FaceExtraction",
                    "Biometrics.FaceMatching",
                    "Biometrics.FaceDetection",
                    "Devices.Cameras"
                };

                string server = "/local";
                string port = "5000";
                foreach (string component in requiredComponents)
                    if (NLicense.ObtainComponents(server, port, component))
                    {
                        ShowError($"{component} Component License is not activated", "License setup failed");
                        _licenseSetupSuccessfully = false;
                    }
            }
        }

        private bool AddLicenseFiles()
        {
            string licenseDirectory = $@"{Application.StartupPath}\Activation\Licenses";
            if (Directory.Exists(licenseDirectory))
            {
                string[] licenseFiles = Directory.GetFiles(licenseDirectory, "*.lic");
                if (licenseFiles.Any())
                {
                    foreach (string licenseFile in licenseFiles)
                        NLicense.Add(licenseFile);
                    return true;
                }
                else
                    ShowError("No License file was found.", "License setup failed");
            }
            else
                ShowError("License Directory was not found.", "License setup failed");
            return false;
        }

    }
}
