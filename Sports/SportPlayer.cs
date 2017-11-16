namespace Sports
{
    public class SportPlayer
    {
        private static readonly string[] categoryList = new string[] { "amateur", "professional", "classic" };
        public static int wR;

        private readonly string name;

        private int[] results = new int[20];
        private int pB;
        private int resultIndex;
        private string category;

        public SportPlayer(string receivedName)
        {
            this.name = receivedName;
            this.category = categoryList[0];
            resultIndex = 0;         
        }

        public void AddNewResult(int currentResult)
        {
            if(resultIndex > 19) return;

            results[resultIndex] = currentResult;
            resultIndex++;

            if (currentResult > this.pB)
            {
                this.pB = currentResult;
            }

            if (currentResult > wR)
            {
                wR = currentResult;
            }

            if (this.pB < wR*0.3)
            {
                this.category = categoryList[0];
            }
            else
            {
                this.category = this.pB < wR * 0.75 ? categoryList[1] : categoryList[2];
            }
        }

        public int GetPersonalBestResult()
        {
            return this.pB;
        }

        public string PrintData()
        {
            var allData = "Name: " + this.name + " Results: ";
            for (var i=0; i < resultIndex; i++)
            {
                   allData = allData + results[i] + ", ";
            }
        
            allData = allData + " PB: " + this.pB;
            allData = allData + " Category: " + this.category;

            return allData;
        }
    }
}
