namespace CarrierLookUp.Models
{
    //Used to check if the number exists on the Dictionary
    public class NumberChecker
    {
        private  Dictionary<string, string> dicNum = new Dictionary<string, string>();
        private  CreateDictionary Dict;
        private string number;
        public string Carrier = "";
        public string NotFound = "No S.A carrier found.";


        public NumberChecker(UserInput userInput)
        {
            Dict  = new CreateDictionary(dicNum);
            CutNumber(userInput.CNumber);
        }

        //Write a method that will cut the number to search for the carrier
        private void CutNumber(string sNum)
        {
            number = sNum;
            for (int i= 4; i >= 3; i--)
            {
                number = number.Substring(0,i);
                Carrier = AsDotnetDictionary(number);
                if (Carrier != NotFound)
                    return;
            }
        }

        //Create structure
        private string  AsDotnetDictionary(string sNumber)
        {            
            dicNum = Dict.DictNum;

            //Find entry
            string sKey = sNumber;
            dicNum.TryGetValue(sKey, out string sValue);

            //Output
            return sValue ?? NotFound;
        } //ImplementAsDictionary

    }
}
