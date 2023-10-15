using System.Collections;

public class DealSentence
{
    private bool isr = false;
    private bool isw = false;
    private bool isu = false;
    private ArrayList SentencesArray;

    private static void Main(string[] input)
    {
        DealSentence DealSentence = new DealSentence();
        DealSentence.ReadCommands(input);
        if (DealSentence.isr && !DealSentence.isw && !DealSentence.isu)
        {
            Outputs outputs = new Reverse();
            outputs.Print(DealSentence.SentencesArray);
        }
        if (DealSentence.isw && !DealSentence.isr && !DealSentence.isu)
        {
            Outputs outputs = new Seperate();
            outputs.Print(DealSentence.SentencesArray);
        }
        if (DealSentence.isu && !DealSentence.isr && !DealSentence.isw)
        {
            Outputs outputs = new Uppercase();
            outputs.Print(DealSentence.SentencesArray);
        }
        if (DealSentence.isr && DealSentence.isw && !DealSentence.isu)
        {
            Outputs outputs = new ReverseSeperate();
            outputs.Print(DealSentence.SentencesArray);
        }
        if (DealSentence.isr && DealSentence.isu && !DealSentence.isw)
        {
            Outputs outputs = new ReverseUppercase();
            outputs.Print(DealSentence.SentencesArray);
        }
        if (DealSentence.isw && DealSentence.isu && !DealSentence.isr)
        {
            Outputs outputs = new SeperateUppercase();
            outputs.Print(DealSentence.SentencesArray);
        }
        if (DealSentence.isr && DealSentence.isw && DealSentence.isu)
        {
            Outputs outputs = new ReverseSeperateUppercase();
            outputs.Print(DealSentence.SentencesArray);
        }
        if (!DealSentence.isr && !DealSentence.isw && !DealSentence.isu)
        {
            Outputs outputs = new Outputs();
            outputs.Print(DealSentence.SentencesArray);
        }
    }

    public ArrayList ReadCommands(String[] sentence)
    {
        SentencesArray = new ArrayList();
        foreach (string s in sentence)
        {
            switch (s)
            {
                case "-r":
                    isr = true;
                    break;

                case "-w":
                    isw = true;
                    break;

                case "-u":
                    isu = true;
                    break;

                default:
                    SentencesArray.Add(s);
                    break;
            }
        }
        return SentencesArray;
    }

    public class Outputs
    {
        public virtual void Print(ArrayList sentence)
        {
            foreach (String word in sentence)
            {
                Console.Write(word);
                Console.Write(" ");
            }
        }
    }

    public class Reverse : Outputs
    {
        public override void Print(ArrayList sentence)
        {
            ArrayList temp = new ArrayList();
            foreach (String word in sentence)
            {
                char[] charArray = word.ToCharArray();
                Array.Reverse(charArray);
                temp.Add(new string(charArray));
            }
            temp.Reverse();
            foreach (String word in temp)
            {
                Console.Write(word);
                Console.Write(" ");
            }
        }
    }

    public class Seperate : Outputs
    {
        public override void Print(ArrayList sentence)
        {
            foreach (String word in sentence)
            {
                Console.Write(word);
                Console.Write("\n");
            }
        }
    }

    public class Uppercase : Outputs
    {
        public override void Print(ArrayList sentence)
        {
            foreach (String word in sentence)
            {
                Console.Write(word.ToUpper());
                Console.Write(" ");
            }
        }
    }

    public class ReverseSeperate : Outputs
    {
        public override void Print(ArrayList sentence)
        {
            ArrayList temp = new ArrayList();
            foreach (String word in sentence)
            {
                char[] charArray = word.ToCharArray();
                Array.Reverse(charArray);
                temp.Add(new string(charArray));
            }
            temp.Reverse();
            foreach (String word in temp)
            {
                Console.Write(word);
                Console.Write("\n");
            }
        }
    }

    public class ReverseUppercase : Outputs
    {
        public override void Print(ArrayList sentence)
        {
            ArrayList temp = new ArrayList();
            foreach (String word in sentence)
            {
                char[] charArray = word.ToCharArray();
                Array.Reverse(charArray);
                temp.Add(new string(charArray));
            }
            temp.Reverse();
            foreach (String word in temp)
            {
                Console.Write(word.ToUpper());
                Console.Write(" ");
            }
        }
    }

    public class SeperateUppercase : Outputs
    {
        public override void Print(ArrayList sentence)
        {
            foreach (String word in sentence)
            {
                Console.Write(word.ToUpper());
                Console.Write("\n");
            }
        }
    }

    public class ReverseSeperateUppercase : Outputs
    {
        public override void Print(ArrayList sentence)
        {
            ArrayList temp = new ArrayList();
            foreach (String word in sentence)
            {
                char[] charArray = word.ToCharArray();
                Array.Reverse(charArray);
                temp.Add(new string(charArray));
            }
            temp.Reverse();
            foreach (String word in temp)
            {
                Console.Write(word.ToUpper());
                Console.Write("\n");
            }
        }
    }
}