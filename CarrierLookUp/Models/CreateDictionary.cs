namespace CarrierLookUp.Models
{
    public class CreateDictionary
    {
        //Used for creating to store the dicrionary info
        public Dictionary<string, string> DictNum;
        public CreateDictionary(Dictionary<string, string> dictNum, 
            string sFile = "C:\\Users\\DeviceParticle\\Saved Games\\C# application\\CarrierLookup\\CarrierLookUp\\CarrierLookUp\\bin\\Debug\\net7.0\\Carrier_Dictionary.txt")
        {
          DictNum = AddEntries(dictNum, sFile);
        }

        private static Dictionary<string, string> AddEntries(Dictionary<string, string> dictNum, string sFile)
        {
            StreamReader f = new StreamReader(sFile);
            while (!f.EndOfStream)
            {
                string s = f.ReadLine() + "\t";
                string key = s.Split('\t')[0];
                string value = s.Split('\t')[1];
                dictNum.Add(key, value);
            }
            f.Close();
            return dictNum;
        } //AddEntries
    }
}
