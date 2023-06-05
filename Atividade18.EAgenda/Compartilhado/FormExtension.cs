namespace Atividade18.EAgenda.Compartilhado
{
    public static class FormExtension
    {
        public static void ConfigurarDialog(this Form form)
        {
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.MaximizeBox = false;
            form.MinimizeBox = false;
            form.ShowIcon = false;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowInTaskbar = false;
            form.Size = new Size(725, 500);
        }
    }
}
