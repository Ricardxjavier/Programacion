using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TraductorWinForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonTranslate_Click(object sender, EventArgs e)
        {
            string inputText = textBoxInput.Text.Trim();
            if (string.IsNullOrWhiteSpace(inputText))
            {
                MessageBox.Show("Por favor, introduce texto para traducir.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Traducciones simuladas
            Dictionary<string, string> translations = new Dictionary<string, string>
            {
                { "Inglés", TranslateToEnglish(inputText) },
                { "Francés", TranslateToFrench(inputText) }
            };

            // Ordenar resultados (Método Mosler: Por longitud de texto, luego alfabéticamente)
            var sortedTranslations = translations.OrderBy(t => t.Value.Length).ThenBy(t => t.Key);

            // Mostrar resultados en el DataGridView
            dataGridViewTranslations.Rows.Clear();
            foreach (var translation in sortedTranslations)
            {
                dataGridViewTranslations.Rows.Add(translation.Key, translation.Value);
            }
        }

        private string TranslateToEnglish(string text)
        {
            // Simulación de traducción
            return text switch
            {
                "hola" => "hello",
                "mundo" => "world",
                _ => $"[EN] {text}"
            };
        }

        private string TranslateToFrench(string text)
        {
            // Simulación de traducción
            return text switch
            {
                "hola" => "bonjour",
                "mundo" => "monde",
                _ => $"[FR] {text}"
            };
        }
    }
}
