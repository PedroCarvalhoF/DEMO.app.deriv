using Newtonsoft.Json;
using System.Windows.Forms;

namespace DEMO.app.deriv.Ferramentas
{
    public static class FerramentaJson
    {
        public static void FormatarTextBoxJson(this TextBox textBox)
        {
            try
            {
                // Obtem o texto do TextBox
                string jsonText = textBox.Text;

                // Faz o parsing e formata o JSON
                var parsedJson = JsonConvert.DeserializeObject(jsonText);
                string formattedJson = JsonConvert.SerializeObject(parsedJson, Newtonsoft.Json.Formatting.Indented);

                // Define o texto formatado no TextBox
                textBox.Text = formattedJson;
            }
            catch (Newtonsoft.Json.JsonException ex)
            {
                MessageBox.Show($"Erro ao formatar JSON: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
