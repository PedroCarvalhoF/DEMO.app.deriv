using System.Windows.Forms;

namespace DEMO.app.deriv
{
    public static class TextBoxExtension
    {
        public static void TextBoxPasswordChar(this TextBox textBox)
        {
            textBox.PasswordChar = textBox.PasswordChar == '*' ? '\0' : '*';
        }
    }
}
