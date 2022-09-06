using Neurotec.Biometrics;
using Neurotec.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verilook_Sample_App.Models
{
    public class FaceProfile
    {
        public string Id { get; set; }
        public bool Active { get; set; }
        public bool Admin  { get; set; }


        public NSubject FaceSubject { get; set; }
        public void SetFaceSubject(byte[] value) =>
            FaceSubject = NSubject.FromMemory(NBuffer.FromArray(value));

        public byte[] ConvertToInsertableFaceSubject() =>
            FaceSubject.GetTemplateBuffer().ToArray();
    }
}
