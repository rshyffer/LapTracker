namespace LapTracker
{
    class BarcodeCreator
    {
        private const string TemplateFile = "labelTemplate.docx";
        public static bool CreateBarcodeFile(string fileName, Runners runners)
        {
            var doc = Novacode.DocX.Load(TemplateFile);

            return true;
        }
    }
}
