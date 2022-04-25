using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Custom_Exception.Utilities
{
    public class ExceptionRepository : ApplicationException
    {
        public string Text { get; set; }
        public virtual void WriteExceptionToFile()
        {
            string folderPath = Application.StartupPath + @"\log.txt";
            DateTime exceptionDate = DateTime.Now;
            string exceptionMessage = this.Message;
            string userText = this.Text;
            string createdBy = Environment.MachineName;

            StreamWriter streamWriter = new StreamWriter(folderPath, append: true, encoding: Encoding.UTF8);

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(userText);
            stringBuilder.Append("|");
            stringBuilder.Append(exceptionMessage);
            stringBuilder.Append("|");
            stringBuilder.Append(exceptionDate);
            stringBuilder.Append("|");
            stringBuilder.Append(createdBy);

            streamWriter.WriteLine(stringBuilder);
            streamWriter.Close();
        }
    }
}
