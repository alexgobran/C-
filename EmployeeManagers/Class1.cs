using System;

public class Class1 {
    public Class1() {
        static void Main(string[] args) {

            // words is a string array that we'll sort alphabetically
            string[] words = {
    "the",
    "quick",
    "brown",
    "fox",
    "jumps"
};

            //string[] morewords = {
            //"over",
            //"the",
            //"lazy",
            //"dog"
        };

        IEnumerable<string> query = from word in _words
                                    orderby word.Length
                                    select word;

        // foreach(string str in query)
        {

            Console.Writeline(str);
        }
    }
}
     
        

        
        
        


