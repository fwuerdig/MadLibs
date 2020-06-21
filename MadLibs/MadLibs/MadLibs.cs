using System;

namespace MadLibs
{
    class MadLibs
    {
        String story;
        String name;
        String adjective1;
        String adjective2;
        String noun1;
        String noun2;
        String noun3;
        String adverb;
        String randomNums;
        Random rand = new Random();

        public String getStory()
        {
            return story;
        }

        public String getName()
        {
            return name;
        }

        public String getAdjective1()
        {
            return adjective1;
        }

        public String getAdjective2()
        {
            return adjective2;
        }

        public String getNoun1()
        {
            return noun1;
        }

        public String getNoun2()
        {
            return noun2;
        }

        public String getNoun3()
        {
            return noun3;
        }

        public String getAdverb()
        {
            return adverb;
        }

        public String getRandomNums()
        {
            return randomNums;
        }

        public void setStory(String newStory)
        {
            this.story = newStory;
        }

        public void setName(String newName)
        {
            this.name = newName;
        }
        public void setAdjective1(string newAdj1)
        {
            this.adjective1 = newAdj1;
        }

        public void setAdjective2(string newAdj2)
        {
            this.adjective2 = newAdj2;
        }

        public void setNoun1(string newNoun1)
        {
            this.noun1 = newNoun1;
        }

        public void setNoun2(string newNoun2)
        {
            this.noun2 = newNoun2;
        }

        public void setNoun3(string newNoun3)
        {
            this.noun3 = newNoun3;
        }

        public void setAdverb(string newAdverb)
        {
            this.adverb = newAdverb;
        }

        public void setRandomNums()
        {
            int num = Math.Abs(rand.Next()) % 100;
            int index = 0;
            int[] numberHolder = new int[3];
            while (index < numberHolder.Length)
            {
                numberHolder[index] = num + index;
                index++;
            }
            randomNums = "not " + numberHolder[0] + ", not " + numberHolder[1] + ", but " + numberHolder[2];
        }

        public void printInstructions()
        {
            Console.WriteLine("Welcome to the MadLibs game. If you type in words, we´ll give you a story. " +
                "Start by typing a name.");
        }

        public void enterName()
        {
            Console.WriteLine("Insert your name: ");
            setName(Console.ReadLine());
        }

        public void enterNoun1()
        {
            Console.WriteLine("Give me a noun!");
            setNoun1(Console.ReadLine());
        }

        public void enterNoun2()
        {
            Console.WriteLine("Give me another noun!");
            setNoun2(Console.ReadLine());
        }

        public void enterNoun3()
        {
            Console.WriteLine("Give me the last noun!");
            setNoun3(Console.ReadLine());
        }

        public void enterAdjective1()
        {
            Console.WriteLine("Give me an adjective!");
            setAdjective1(Console.ReadLine());
        }

        public void enterAdjective2()
        {
            Console.WriteLine("I need another adjective!");
            setAdjective2(Console.ReadLine());
        }

        public void enterAdverb()
        {
            Console.WriteLine("Give me an adverb!");
            setAdverb(Console.ReadLine());
        }

        public void putTheStoryTogether()
        {
            string story;
            int num = Math.Abs(rand.Next()) % 2;
            if (num == 0)
            {
                story = "Jesse and her best friend " + getName() + " went to Disney "
               + "World today! They saw a " + getNoun1() + " in a show at Magic "
               + "Kingdom and ate a " + getAdjective1() + " feast for dinner. The "
               + "next day I ran " + getAdverb() + " to meet Mickey Mouse in his "
               + getNoun2() + " and then that night I gazed at the " + getRandomNums()
               + " " + getAdjective2() + " fireworks shooting from the " + getNoun3() + ".";
            }
            else
            {
                story = "Amanda and her frenemy " + getName() + " went to the zoo last "
                   + "summer. They saw a huge " + getNoun1() + " and a tiny little "
                   + getNoun2() + ". That night, they decided to climb " + getAdverb()
                   + " into the " + getNoun3() + " to get a closer look. The zoo "
                   + "was " + getAdjective1() + " at night, but they didn´t care... "
                   + "until " + getRandomNums() + " " + getAdjective2() + " apes "
                   + "yelled in their faces, making Amanda and " + getName() + " sprint "
                   + "all the way back home.";
            }
            setStory(story);
        }

        public void play()
        {
            enterName();
            enterNoun1();            
            enterAdjective1();
            enterAdjective2();
            enterNoun2();
            enterAdverb();
            enterNoun3();
            setRandomNums();
            putTheStoryTogether();
            Console.WriteLine(getStory());
        }
        static void Main(string[] args)
        {
            MadLibs game = new MadLibs();
            game.printInstructions();
            game.play();
        }
    }
}
