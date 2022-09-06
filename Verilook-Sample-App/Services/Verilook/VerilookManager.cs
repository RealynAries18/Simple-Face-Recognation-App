using Neurotec.Biometrics;
using Neurotec.Biometrics.Client;
using Neurotec.Biometrics.Gui;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verilook_Sample_App.Model;

namespace Verilook_Sample_App.Services
{
    public class VerilookManager : IVerilookManager
    {
        private NBiometricClient _client { get; set; }
        private NFaceView _faceView { get; set; }

        private NBiometricCaptureOptions _captureOptions { get; set; }


        public VerilookManager(NBiometricClient client, NFaceView faceView, NBiometricCaptureOptions captureOptions)
        {
            _client = client;
            _faceView = faceView;
            _captureOptions = captureOptions;
        }

        public async Task<NSubject> EnrollAsync()
        {
            NSubject newFaceSubject = new NSubject();
            newFaceSubject.Faces.Add(new NFace() { CaptureOptions = _captureOptions });

            _faceView.Face = newFaceSubject.Faces.Last();

            NBiometricStatus status = await _client.CaptureAsync(newFaceSubject);
            if (status == NBiometricStatus.Ok)
            {
                return newFaceSubject;
            }

            return null;
        }

        public void Identify()
        {
            throw new NotImplementedException();
        }

        public void Save(FaceProfile faceProfile)
        {
            throw new NotImplementedException();
        }
    }
}
