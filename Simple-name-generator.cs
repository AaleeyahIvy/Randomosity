using System;
					
string[] Adjectives = {"Delightful","Joshy", "Cold", "Rad", "Tastical", "Gorgeous", "Fictional", "Alternative", "Dirty", "Social", "Buzy", "Goth", "Sus", "Trivial", "Lovely", "Adorable", "Adventurous",
"Aggressive", "Agreeable", "Alert", "Alive", "Amused", "Angry", "Annoying", "Anxious", "Bad", "Bold", "Furious", "Fiery", "Naughty", "Daunting", "Horrid", "Mischievous", "Strange", "Wickerd", "Talented", "Foreign", "Kind", "Haughty", "Delicate"};
string[] Animals = {"Kitten", "Dragon", "Bobcat", "Ferret", "Piglet", "Panda", "Snake", "Rabbit", "Tortoise", "Iguana", "Lion", "Tiger", "Blue Whale", "Robin", "Cat", "Boar", "Polar Bear", "BluJay", "Firefly", "Black Widow", "Octopus", "Squid", "Clown Fish"};
string[] Items = {"Eye", "Leg", "Neck", "Feet", "Arm", "Head", "Toe", "Tongue", "Finger", "Tooth", "Hair", "Lamp", "Wielder", "Swordsman", "Archer", "Warrior", "Doopleganger", "Book", "Keyboard", "Tree", "Knife", "Nail", "Shoelace", "Router", "Bottle", "Picture", "Pillow", "Leaf", "Pendant", "State", "Country", "City", "Utopia", "Page", "Query", "Cards"};

static Random rnd = new Random();

for(int adj = 0; adj < 1; adj++) //Looping through Adjectives array
{
	int number = rnd.Next(1 , Adjectives.Length);
	Console.WriteLine("..."+Adjectives[number]);
	
	for(int ani = 0; ani < 1; ani++) //Looping through Animal array
	{
		int number2 = rnd.Next(1, Animals.Length);
		Console.WriteLine("..." +Animals[number2]);
		
		for(int ite = 0; ite < 1; ite++) //Looping through Item array
		{
			int number3 = rnd.Next(1, Items.Length);
			Console.WriteLine("..."+Items[number3]);
			
			Console.WriteLine("Your random name is:" + " " + Adjectives[number] + " " + Animals[number2] + " " + Items[number3]);
		}			  
	}
}

///////PRESS RUN ATLEAST ONCE BOFORE COMMENTING NAME//////////////
