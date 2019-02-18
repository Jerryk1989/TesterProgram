using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class StepRecording
    {
        public String fileName, pathToSaveFileTo;

        public StepRecording()
        {

        }

        public StepRecording(String fileName, String pathToSaveFileTo)
        {
            this.fileName = fileName;
            this.pathToSaveFileTo = pathToSaveFileTo;
        }

        public void startRecording()
        {
            Console.WriteLine(this.fileName);
        }

        public void createRecordingFile(String fileName)
        {

        }
    }
}
