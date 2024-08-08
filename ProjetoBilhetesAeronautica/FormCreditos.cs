using System.Diagnostics;

namespace ProjetoBilhetesAeronautica
{
    public partial class FormCreditos : Form
    {
        FormPrincipal _principal;
        FormColaborador _colaborador;

        public FormCreditos(Form form, int caso)
        {
            InitializeComponent();
            // Verificar qual o form que foi passado
            switch (caso)
            {
                case 0:
                    _principal = (FormPrincipal)form;
                    break;
                case 1:
                    _colaborador = (FormColaborador)form;
                    break;
            }

            linkLabel1.Links.Add(7, 21, "https://www.linkedin.com/in/nuno-salgueiro-9b3a7810b/");
        }

        private void FormCreditos_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_principal != null)
            {
                _principal.Enabled = true;
            }

            if (_colaborador != null)
            {
                _colaborador.Enabled = true;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Link.LinkData.ToString()) { UseShellExecute = true });
        }
    }
}
