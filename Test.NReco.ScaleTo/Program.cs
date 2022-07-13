namespace Test.NReco.ScaleTo
{
    using global::NReco.PdfRenderer;

    internal class Program
    {
        private static void Main(string[] args)
        {
            new PdfToImageConverter
            {
                ScaleTo = 2200
            }
            .GenerateImage(
                "sample.pdf",
                1,
                ImageFormat.Png,
                "sample.pdf.png");
        }
    }
}