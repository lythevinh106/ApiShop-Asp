namespace Presentation.View.MailLayout
{
    public class MailLayoutHelper
    {

        public static string GetMailLayoutRegister(string linkVerify)
        {
            var contentsPath = Directory.GetCurrentDirectory() + $"/View/MailLayout/MailLayout1.html";


            string fileContent = ReadAllTextMethod(contentsPath);

            fileContent = fileContent.Replace("{{@linkRegister}}", linkVerify);

            return fileContent;

        }

        private static string ReadAllTextMethod(string contentsPath)
        {
            if (System.IO.File.Exists(contentsPath))
            {
                string fileContent = System.IO.File.ReadAllText(contentsPath);
                return fileContent;
            }

            throw new FileNotFoundException("html file not exist");



        }
    }
}
