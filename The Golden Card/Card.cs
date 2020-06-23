namespace The_Golden_Card
{
    public class Card //Huvudklass för våra kort
    {
        public string cardNumber { get; set; } //Egenskaper som kortet behöver
        public string cardType { get; set; }

        public Card(string readCardNumber, string readCardType)
        {
            cardNumber = readCardNumber;
            cardType = readCardType;
        }

        class Dunderkatt : Card
        {
            public Dunderkatt(string readCardNumber, string readCardType) : base (readCardNumber, readCardType)
            {
                readCardType = "Dunderkatt";
            }

            public override string ToString()
            {
                return base.ToString();
            }
        }
        class Eldtomat : Card
        {
            public Eldtomat(string readCardNumber, string readCardType) : base(readCardNumber, readCardType)
            {
                readCardType = "Eldtomat";
            }

            public override string ToString()
            {
                return base.ToString();
            }
        }
        class Kristallhäst : Card
        {
            public Kristallhäst(string readCardNumber, string readCardType) : base(readCardNumber, readCardType)
            {
                readCardType = "Kristallhäst";
            }

            public override string ToString()
            {
                return base.ToString();
            }
        }
        class Överpanda : Card
        {
            public Överpanda(string readCardNumber, string readCardType) : base(readCardNumber, readCardType)
            {
                readCardType = "Överpanda";
            }

            public override string ToString()
            {
                return base.ToString();
            }
        }
    }
}
