using System;
using System.Collections.Generic;
using System.Linq;


namespace BeeBee
{
    class Program
    {
        static void Main(string[] args)
        {
            //menu for cree beehive 
            display(" Hi dear beekeeper, \n you want expend your Beeframe and you have all ready 2 BeeHive maybe will be a good idea to pruchase some more  ? \n Press 1 for yes \n press 2 for no");
            int Choosenum, DayChoose;
            // string Creationbeehive , BeehiveNumbre1;  //    It is for the Creation of beehive  ad creat new name eacht time 
            //string CreationBeeListName, listbeehiveNum1; //    It is for the creation of the list to going in new Beehive eacht time 


            // List<Beehive> beehivesList = new List<Beehive>();   // c est la liste de ruche
            // List<Bee> beeListNUm55 = new List<Bee>();           // c est la liste des abeille 


            // List<Bee> ListBeehive1 = new List<Bee>();   //list<Bee>  = list of bee
            // Beehive BeeHome1 = new Beehive(20, ListBeehive1);       //  BeehomeNUm = new beehive



            string inputYesNo = Console.ReadLine();   //    no lettre
        startagain: System.Console.WriteLine("");
            if (int.TryParse(inputYesNo, out Choosenum))
            {
                switch (Choosenum)
                {
                    case 1:
                        //choose how many beehive you want a build 
                        System.Console.WriteLine(" sorry for this robotic voice but he was a simple question anyway");
                        System.Console.WriteLine(" How many beehive you need? Lucky you are we do some promotion eacht beehive come with the Queen ");
                        int numbreNeeded = int.Parse(Console.ReadLine());
                        System.Console.WriteLine("choose the limitation of your bee capacity for yours new  beehive ");
                        int CapacityMax = int.Parse(System.Console.ReadLine());




                        for (int i = 0; i <= numbreNeeded; i++)
                        {

                            // //so beehome.add

                            // beehivesList.Add(new Beehive(40, beeListNUm55));
                            // // beehivesList[i].Add(beeListNUm55.Add(new Bee("James", 2.2f)));
                            // beehivesList[i].AddBee(new Bee("James", 2.2f));
                            // // System.Console.WriteLine(beehivesList[0].AddBee(new Bee("allex" , 5.5)));
                            // System.Console.WriteLine(beehivesList[0]);



                            //creat new list for the new beehive
                            // CreationBeeList= "listbeehiveNum1 ";    
                            // listbeehiveNum1 = CreationBeeList.Insert(14, $"{i}");

                            // List<Bee> passtolocal = new List<Bee>(); 
                            //creat new name for the new beehive

                            //CreationBeeListName = "BeehiveNum ";    
                            // BeehiveNumbre1 = Creationbeehive.Insert(11, $"{i}");
                            // BeehiveNumbre1 = new Beehive(CapacityMax,   beehivesList  );  //new beehive

                        }
                        break;

                    case 2:
                        display("OK, maybe you shoul check your beeframe");
                        break;

                    default:
                        display("I know you have a lots a key on your kaybord but only the Key1 or the Key 2 will make you going somewhere. \n try angain");
                        System.Console.WriteLine("try angain");
                        inputYesNo = Console.ReadLine();
                        goto startagain;
                }
            }
            else if (Choosenum < 2)     // check if good numbre
            {
                display("DO What I say Human, not undrestand any carater \n start again or EXTREMINET");
                inputYesNo = Console.ReadLine();
                goto startagain;
            }

            display("Choose along you want a wait for collection all you honey in your beeframe ");
            DayChoose = int.Parse(System.Console.ReadLine());

            List<Bee> ListBeeHive2 = new List<Bee>();
            List<Bee> ListBeeHive1 = new List<Bee>();
            Beehive BeeHome1 = new Beehive(20, ListBeeHive1);
            Beehive BeeHome2 = new Beehive(20, ListBeeHive2);

            //Bee List 1 /Beehive1
            ListBeeHive1.Add(new Bee("John", 3.2f));
            ListBeeHive1.Add(new Bee("Paul", 2.7f));
            ListBeeHive1.Add(new Bee("George", 1.1f));
            ListBeeHive1.Add(new Bee("Ringo", 2.0f));
            //Bee List 2 /Beehive2
            ListBeeHive2.Add(new Bee("Kurt", 2.3f));
            ListBeeHive2.Add(new Bee("Dave", 7.4f));
            ListBeeHive2.Add(new Bee("Krist", 1.5f));

            float sumBeehive1 = 0;      // total side bees in beehive1
            float sumBeehive2 = 0;      // total side bees in beehive2
            for (int i = 0; i < ListBeeHive1.Count; i++) //Loop for know all the totalSide of all Bees
            {
                sumBeehive1 = ListBeeHive1[i].BeeSize + sumBeehive1;     //add each beeside Beehive1
            }
            for (int i = 0; i < ListBeeHive2.Count; i++)    //Loop for know all the totalSide of all Bees
            {
                sumBeehive2 = ListBeeHive2[i].BeeSize + sumBeehive2;    //add each beeside Beehive2
            }

            float totalOfHoneyBeehive1 = BeeHome1.AmountHoneyCollected(DayChoose, sumBeehive1);     //day * totalsyde * 2  in beehive1
            float totalOfHoneyBeehive2 = BeeHome2.AmountHoneyCollected(DayChoose, sumBeehive2);     //day * totalsyde * 2  in beehive2

            System.Console.WriteLine($"Total collect on beehive1 {totalOfHoneyBeehive1} \nTotal collect on beehive2 {totalOfHoneyBeehive2}");

            
             
    
     
        }






        static void display(string MYTEXT)  //to be readable on console 
        {
            System.Console.WriteLine("                                                                                             ");
            System.Console.WriteLine("   --------------------------------------------------------------------------------   ");
            System.Console.WriteLine("                        " + MYTEXT);
            System.Console.WriteLine("   --------------------------------------------------------------------------------   ");
            System.Console.WriteLine("                                                                                             ");
        }
    }
}

