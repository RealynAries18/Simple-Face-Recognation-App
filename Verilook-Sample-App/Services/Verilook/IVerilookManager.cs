using Neurotec.Biometrics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verilook_Sample_App.Models;

namespace Verilook_Sample_App.Services
{
    public interface IVerilookManager
    {
        Task<NSubject> EnrollAsync();

        void Identify();

        void Save(FaceProfile faceProfile);
    }
}
