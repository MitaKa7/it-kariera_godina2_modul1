using Tesseract;

try
{
    string imageName = "test.png";
    using (var engine = new TesseractEngine(@"./tessdata", "eng", EngineMode.Default))
    {
        using (var img = Pix.LoadFromFile(imageName))
        {
            using (var page = engine.Process(img))
            {
                string text = page.GetText();
                Console.WriteLine(text);
            }
        }
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}