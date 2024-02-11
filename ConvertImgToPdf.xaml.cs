using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ConvertImgToPdfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            QuestPDF.Settings.License = LicenseType.Community;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string imgPath = imgInsert.Text;
            string pdfPath = pdfInsert.Text;

            try
            {
                Document.Create(container =>
                {
                    container.Page(page =>
                    {
                        page.Size(PageSizes.A4);
                        page.Margin(2, Unit.Centimetre);
                        page.PageColor(QuestPDF.Helpers.Colors.White);

                        page.Content()
                            .Column(column =>
                            {
                                column
                                    .Item()
                                    .Image(imgPath, ImageScaling.FitArea);
                            });
                    });


                })
                    .GeneratePdf(pdfPath);

                MessageBox.Show($"Arquivo gerado no seguinte caminho: {pdfPath}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Mensagem de erro: {ex.Message}", "Error");
            }
        }

    }
}